using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS
{
    public partial class Login : Form
    {
        CatalogerInterface catInterface;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_click(object sender, EventArgs e)
        {
            if (MySqlManager.Instance.AuthenticateDataCataloger(usernameBox.Text, passwordBox.Text))
            {
                prompt.Text = "";
                catInterface = new CatalogerInterface(MySqlManager.Instance.GetDataCataloger(usernameBox.Text), this);
                catInterface.Show();

                this.Hide();
            }
            else
            {
                prompt.Text = "Invalid credentials";
            }
        }
        private void catInterface_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
