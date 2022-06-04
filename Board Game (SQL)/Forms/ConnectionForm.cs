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
        private TcpListener listener;

        public ConnectionForm()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());          //Own IP

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    YourIPTextBox.Text = Text = address.ToString();
                }
            }
        }


        private void StartServerButton_Click(object sender, EventArgs e)            //Start Server
        {
            if (!YourPortTextBox.Text.Equals(""))
            {
                ConnectionLabel.Visible = true;

                listener = new TcpListener(IPAddress.Any, int.Parse(YourPortTextBox.Text));
                listener.Start();
                client = listener.AcceptTcpClient();

       
                MultiplayerForm multiplayerForm = new MultiplayerForm(listener, client) { Owner = this };
                multiplayerForm.Show();
                this.Owner.Hide();
                this.Hide();
            }
        }

        private void ConnectToServerButton_Click(object sender, EventArgs e)        //Connect to server
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IPTextBox.Text), int.Parse(PortTextBox.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    MessageBox.Show("Connected to Server");

                    MultiplayerForm multiplayerForm = new MultiplayerForm(client) { Owner = this };
                    multiplayerForm.Show();
                    this.Owner.Hide();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void YourPortTextBox_TextChanged(object sender, EventArgs e)        //Port only digits
        {
            PortTextBox.Text = string.Concat(PortTextBox.Text.Where(char.IsDigit));
        }        
        private void CancelButton_Click(object sender, EventArgs e)                 //Cancel
        {
            this.Owner.Enabled = true;
            this.Owner.Show();
            this.Close();
        }
    }
}
