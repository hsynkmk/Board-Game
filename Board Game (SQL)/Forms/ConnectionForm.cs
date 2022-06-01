using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Board_Game__SQL_
{
    public partial class ConnectionForm : Form
    {
        private TcpClient client;
        TcpListener listener;

        public ConnectionForm()
        { 
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    YourIPTextBox.Text = Text = address.ToString();
                }
            }
        }


        private void StartServerButton_Click(object sender, EventArgs e)
        {
    
            listener = new TcpListener(IPAddress.Any, int.Parse(YourPortTextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();

            MultiplayerForm multiplayerForm = new MultiplayerForm(listener, client);
            multiplayerForm.Show();
            this.Close();
        }
        
        private void ConnectToServerButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IPTextBox.Text), int.Parse(PortTextBox.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    MessageBox.Show("Connected to Server");

                    MultiplayerForm multiplayerForm = new MultiplayerForm(listener, client);
                    multiplayerForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            this.Owner.Enabled = true;
            this.Close();
        }
    }
}
