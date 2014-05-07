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
    /// <summary>
    /// This class is associated with the Login Module and handles all interface interactions
    /// It contains various textboxes that a user must enter information to authenticate further into the system.
    /// Authenitication 
    /// </sumary>
    public partial class LoginInterface : Form
    {
        /// <summary>
        /// The constructor method of the interface, which initalizes the components needed for the system.
        /// Also sets the default index for the "User Type" combobox to Cataloger.
        /// </summary>
        public LoginInterface()
        {
            InitializeComponent();
            comboBoxUserType.SelectedIndex = 0;
        }

        /// <summary>
        /// This method handles the event when the Login button is clicked.
        /// After the event is activated, the method uses the LoginHandler class to determine if the login information is correctly 
        /// entered for the respective user type. It then loads the respective module and passes the username.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginHandler.IsValidUser(textBoxUsername.Text, textBoxPassword.Text, comboBoxUserType.Text))
            {
                if (comboBoxUserType.Text.Equals("Cataloger"))
                {
                    Cataloger.CatalogerInterface catalogerInterface = new Cataloger.CatalogerInterface(textBoxUsername.Text);
                    this.Hide();
                    this.Owner = catalogerInterface;
                    catalogerInterface.FormClosing += SubFormClosing;
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
            else
            {
                MessageBox.Show("Login information is incorrect.");
            }
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        /// <summary>
        /// This method handles the event when another module (Cataloger, DBA) is closed through a logout button. Once this event is encountered
        /// it reloads the Login Module and displays the Login Interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SubFormClosing(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("closing!");
            this.Show();
        }
    }
}
