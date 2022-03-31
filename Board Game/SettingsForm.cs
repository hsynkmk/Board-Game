using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void difficultyCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //one selection
            //
            int index = difficultyCheckedListBox.SelectedIndex;
            int count = difficultyCheckedListBox.Items.Count;
            for(int i = 0; i < count; i++)
                if(index!=i)
                    difficultyCheckedListBox.SetItemChecked(i, false);

            if (difficultyCheckedListBox.SelectedIndex == 3)
            {
                widthTextbox.Visible = true;
                heightTextbox.Visible = true;
            }
            if (difficultyCheckedListBox.SelectedIndex != 3)
            {
                widthTextbox.Visible = false;
                heightTextbox.Visible = false;
            }

        }

        private void settingsExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm().Show();
        }
    }
}
