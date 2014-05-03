using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginInterface : Form
    {
        public LoginInterface()
        {
            InitializeComponent();
            comboBoxUserType.SelectedIndex = 0;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginHandler.IsValidUser(textBoxUsername.Text, textBoxPassword.Text, comboBoxUserType.Text))
            {
                if (comboBoxUserType.Text.Equals("Cataloger"))
                {
                    Cataloger.CatalogerInterface catalogerInterface = new Cataloger.CatalogerInterface(textBoxUsername.Text);
                    //this.Hide();
                    //this.Owner = catalogerInterface;
                    //catalogerInterface.FormClosing += SubFormClosing;
                    catalogerInterface.Show();
                }
                else if (comboBoxUserType.Text.Equals("Database Administrator"))
                {
                    Dba.DbaInterface dbaInterface = new Dba.DbaInterface(textBoxUsername.Text);
                    this.Hide();
                    this.Owner = dbaInterface;
                    dbaInterface.FormClosing += SubFormClosing;
                    dbaInterface.Show();
                }
                else
                {
                    throw new Exception("Incorrect User Type selected.");
                }
            }
        }

        void SubFormClosing(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("closing!");
            this.Show();
        }
    }
}
