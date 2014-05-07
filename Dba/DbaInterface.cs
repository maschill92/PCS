using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dba
{
    /// <summary>
    /// The logic of the DBA interface, houses all of the event-driven commands of the system
    /// </summary>
    public partial class DbaInterface : Form
    {

        private List<Cataloger> catalogers;
        private List<Dba> dbas;
        public DbaUser dbaUser;

        /// <summary>
        /// Constructor method for the DBA Interface. Creates a new instance of the DBA user.
        /// </summary>
        /// <param name="uName"></param> the username of the DBA user (passed from Login)
        public DbaInterface(String uName)
        {
            InitializeComponent();
            InitializeAdditional();
            dbaUser = new DbaUser(uName);
            PanelCataloger.Visible = true;
        }

        /// <summary>
        /// Method that is used to initialize the callbacks that will be sued throughout the class.
        /// </summary>
        private void InitializeAdditional()
        {
            this.PanelCataloger.VisibleChanged += new System.EventHandler(this.PanelCataloger_VisibleChanged);
            this.ListBoxCataloger.SelectedIndexChanged += new System.EventHandler(this.ListBoxCataloger_SelectedIndexChanged);
            this.ListBoxDBA.SelectedIndexChanged += new System.EventHandler(ListBoxDBA_SelectedIndexChanged);
            this.PanelDBA.VisibleChanged += new System.EventHandler(this.PanelDBA_VisibleChanged);
            this.PanelAccount.VisibleChanged += new System.EventHandler(this.PanelAccount_VisibleChanged);
        }

        /// <summary>
        /// Callback for when the "Cataloger" button is clicked in the menu. It makes the Cataloger panel visible and
        /// the other panels not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Cataloger
        private void ButtonMenuCataloger_Click(object sender, EventArgs e)
        {
            PanelCataloger.Visible = true;
            PanelDBA.Visible = false;
            PanelAccount.Visible = false;
        }

        /// <summary>
        /// Callback for when the Cataloger panel is made visible after clicking the "Cataloger" menu button. This method
        /// repopulates the Cataloger List and adds the data to the Cataloger listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelCataloger_VisibleChanged(object sender, EventArgs e)
        {
            catalogers = Cataloger.Generate();
            ListBoxCataloger.DataSource = catalogers;
            ListBoxCataloger.DisplayMember = "fullName";
        }

        /// <summary>
        /// Callback that occurs when a new item is selected in the Cataloger Listbox. Upon change, it populates the
        /// data fields with the respective Cataloger's information. If it nothing is selected, it enters the "New" state
        /// and allows the user to add a new Cataloger to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCataloger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxCataloger.SelectedIndex > -1)
            {
                Cataloger c = catalogers.ElementAt(ListBoxCataloger.SelectedIndex);
                TextBoxCatalogerFName.Text = c.fName;
                TextBoxCatalogerLName.Text = c.lName;
                TextBoxCatalogerUsername.Text = c.username;
                TextBoxCatalogerPassword.Text = c.password;
                TextBoxCatalogerEmail.Text = c.email;
                DateTimePickerCatalogerDOB.Text = c.dateOfBirth;
                if (c.sex.Equals("M"))
                {
                    RadioButtonCatalogerSexMale.Checked = true;
                }
                else
                {
                    RadioButtonCatalogerSexFemale.Checked = true;
                }
                ButtonCatalogerSave.Text = "Save";
                ButtonCatalogerDelete.Enabled = true;
                TextBoxCatalogerUsername.Enabled = false;
            }
            else
            {
                TextBoxCatalogerFName.Text = "";
                TextBoxCatalogerLName.Text = "";
                TextBoxCatalogerUsername.Text = "";
                TextBoxCatalogerPassword.Text = "";
                TextBoxCatalogerEmail.Text = "";
                DateTimePickerCatalogerDOB.Text = "";
                RadioButtonCatalogerSexMale.Checked = false;
                RadioButtonCatalogerSexFemale.Checked = false;
                ButtonCatalogerSave.Text = "Add";
                ButtonCatalogerDelete.Enabled = true;
                TextBoxCatalogerUsername.Enabled = true;
            }
        }

        /// <summary>
        /// Callback for when the "New" button is clicked in the Cataloger panel. The button changes the selected index of
        /// the listbox to -1 which triggers the "New" state in the Cataloger sytem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCatalogerNew_Click(object sender, EventArgs e)
        {
            ListBoxCataloger.SelectedIndex = -1;
        }

        /// <summary>
        /// Callback for when the "Reset" button is clicked in the Cataloger panel. This method reverts the information
        /// in the data fields to their original state. The original state varies based off of whether the user has
        /// anything currently selected. If they do, it repopulates the fields with that Cataloger's original information.
        /// If they do not, it empties all of the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCatalogerReset_Click(object sender, EventArgs e)
        {
            if (ListBoxCataloger.SelectedIndex < 0)
            {
                TextBoxCatalogerFName.Text = "";
                TextBoxCatalogerLName.Text = "";
                TextBoxCatalogerUsername.Text = "";
                TextBoxCatalogerPassword.Text = "";
                TextBoxCatalogerEmail.Text = "";
                DateTimePickerCatalogerDOB.Text = "";
                RadioButtonCatalogerSexMale.Checked = false;
                RadioButtonCatalogerSexFemale.Checked = false;
            }
            else
            {
                Cataloger c = catalogers.ElementAt(ListBoxCataloger.SelectedIndex);
                TextBoxCatalogerFName.Text = c.fName;
                TextBoxCatalogerLName.Text = c.lName;
                TextBoxCatalogerUsername.Text = c.username;
                TextBoxCatalogerPassword.Text = c.password;
                TextBoxCatalogerEmail.Text = c.email;
                DateTimePickerCatalogerDOB.Text = c.dateOfBirth;
                if (c.sex.Equals("M"))
                {
                    RadioButtonCatalogerSexMale.Checked = true;
                }
                else
                {
                    RadioButtonCatalogerSexFemale.Checked = true;
                }
            }
        }

        /// <summary>
        /// Callback for when the "Delete" button is clicked in the Cataloger panel. This method is used to trigger the
        /// deletion of the Cataloger in the system. If no item is selected, nothing happens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCatalogerDelete_Click(object sender, EventArgs e)
        {
            catalogers.ElementAt(ListBoxCataloger.SelectedIndex).Delete();
            catalogers = Cataloger.Generate();
            ListBoxCataloger.DataSource = catalogers;
            ListBoxCataloger.DisplayMember = "fullName";
        }

        /// <summary>
        /// Callback for when the "Save" or "Add" button is clicked in the Cataloger panel. The button has the text "Save"
        /// when updating an already existing Cataloger and the text "Add" when creating a new Cataloger to the system.
        /// This is determined by checking to see if an element is selected before proceding with the operation. If any
        /// of the fields are left empty an error message is displayed for the user. The password must also meet the
        /// specified password requirements. If the operation was uncessful, another error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCatalogerSave_Click(object sender, EventArgs e)
        {
            if (TextBoxCatalogerFName.Text.Equals("") || TextBoxCatalogerLName.Text.Equals("") || TextBoxCatalogerUsername.Text.Equals("") || 
                TextBoxCatalogerPassword.Text.Equals("") || TextBoxCatalogerEmail.Text.Equals("") ||
                (RadioButtonCatalogerSexMale.Checked == false && RadioButtonCatalogerSexFemale.Checked == false))
            {
                MessageBox.Show("Please fill in all of the fields.");
            }
            else
            {
                if (!PasswordMeetsRequirements(TextBoxCatalogerPassword.Text))
                {
                    MessageBox.Show("Entered passwords do not meet the minimum requirements.\n1 upper case letter, 1 lower case letter, 1 digit, and length of at least 8.");
                }
                else
                {
                    string p = TextBoxCatalogerPassword.Text;
                    string f = TextBoxCatalogerFName.Text;
                    string l = TextBoxCatalogerLName.Text;
                    string em = TextBoxCatalogerEmail.Text;
                    string d = DateTimePickerCatalogerDOB.Value.Date.ToString("yyyy-MM-dd");
                    string s = "";
                    if (RadioButtonCatalogerSexMale.Checked == true)
                    {
                        s = "M";
                    }
                    else
                    {
                        s = "F";
                    }
                    if (ListBoxCataloger.SelectedIndex < 0)
                    {
                        string u = TextBoxCatalogerUsername.Text;
                        Cataloger c = new Cataloger(u, p, f, l, em, s, d);
                        if (!c.Add())
                        {
                            MessageBox.Show("Data Cataloger could not be added.");
                        }
                        else
                        {
                            catalogers = Cataloger.Generate();
                            ListBoxCataloger.DataSource = catalogers;
                            ListBoxCataloger.DisplayMember = "fullName";
                        }
                    }
                    else
                    {
                        Cataloger c = catalogers.ElementAt(ListBoxCataloger.SelectedIndex);
                        if (!c.Update(p, f, l, em, s, d))
                        {
                            MessageBox.Show("Data Cataloger could not be updated.");
                        }
                        else
                        {
                            catalogers = Cataloger.Generate();
                            ListBoxCataloger.DataSource = catalogers;
                            ListBoxCataloger.DisplayMember = "fullName";
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Callback for when the "DBA" button is clicked in the menu. It makes the DBA panel visible and
        /// the other panels not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region DBA
        private void ButtonMenuDBA_Click(object sender, EventArgs e)
        {
            PanelCataloger.Visible = false;
            PanelDBA.Visible = true;
            PanelAccount.Visible = false;
        }

        /// <summary>
        /// Callback for when the DBA panel is made visible after clicking the "DBA" menu button. This method
        /// repopulates the DBA List and adds the data to the DBA listbox. Only the DBA user is excluded from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelDBA_VisibleChanged(object sender, EventArgs e)
        {
            dbas = Dba.Generate(dbaUser);
            ListBoxDBA.DataSource = dbas;
            ListBoxDBA.DisplayMember = "fullName";
        }

        /// <summary>
        /// Callback that occurs when a new item is selected in the DBA Listbox. Upon change, it populates the
        /// data fields with the respective DBA's information. If it nothing is selected, it enters the "New" state
        /// and allows the user to add a new DBA to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxDBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxDBA.SelectedIndex > -1)
            {
                Dba d = dbas.ElementAt(ListBoxDBA.SelectedIndex);
                TextBoxDBAFName.Text = d.fName;
                TextBoxDBALName.Text = d.lName;
                TextBoxDBAUsername.Text = d.username;
                TextBoxDBAPassword.Text = d.password;
                TextBoxDBAEmail.Text = d.email;
                DateTimePickerDBADOB.Text = d.dateOfBirth;
                if (d.sex.Equals("M"))
                {
                    RadioButtonDBASexMale.Checked = true;
                }
                else
                {
                    RadioButtonDBASexFemale.Checked = true;
                }
                ButtonDBASave.Text = "Save";
                ButtonDBADelete.Enabled = true;
                TextBoxDBAUsername.Enabled = false;
            }
            else
            {
                TextBoxDBAFName.Text = "";
                TextBoxDBALName.Text = "";
                TextBoxDBAUsername.Text = "";
                TextBoxDBAPassword.Text = "";
                TextBoxDBAEmail.Text = "";
                DateTimePickerDBADOB.Text = "";
                RadioButtonDBASexMale.Checked = false;
                RadioButtonDBASexFemale.Checked = false;
                ButtonDBASave.Text = "Add";
                ButtonDBADelete.Enabled = true;
                TextBoxDBAUsername.Enabled = true;
            }
        }

        /// <summary>
        /// Callback for when the "New" button is clicked in the DBA panel. The button changes the selected index of
        /// the listbox to -1 which triggers the "New" state in the DBA sytem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDBANew_Click(object sender, EventArgs e)
        {
            ListBoxDBA.SelectedIndex = -1;
        }

        /// <summary>
        /// Callback for when the "Reset" button is clicked in the DBA panel. This method reverts the information
        /// in the data fields to their original state. The original state varies based off of whether the user has
        /// anything currently selected. If they do, it repopulates the fields with that DBA's original information.
        /// If they do not, it empties all of the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDBAReset_Click(object sender, EventArgs e)
        {
            if (ListBoxDBA.SelectedIndex < 0)
            {
                TextBoxDBAFName.Text = "";
                TextBoxDBALName.Text = "";
                TextBoxDBAUsername.Text = "";
                TextBoxDBAPassword.Text = "";
                TextBoxDBAEmail.Text = "";
                DateTimePickerDBADOB.Text = "";
                RadioButtonDBASexMale.Checked = false;
                RadioButtonDBASexFemale.Checked = false;
            }
            else
            {
                Dba d = dbas.ElementAt(ListBoxDBA.SelectedIndex);
                TextBoxDBAFName.Text = d.fName;
                TextBoxDBALName.Text = d.lName;
                TextBoxDBAUsername.Text = d.username;
                TextBoxDBAPassword.Text = d.password;
                TextBoxDBAEmail.Text = d.email;
                DateTimePickerDBADOB.Text = d.dateOfBirth;
                if (d.sex.Equals("M"))
                {
                    RadioButtonDBASexMale.Checked = true;
                }
                else
                {
                    RadioButtonDBASexFemale.Checked = true;
                }
            }
        }

        /// <summary>
        /// Callback for when the "Delete" button is clicked in the DBA panel. This method is used to trigger the
        /// deletion of the DBA in the system. If no item is selected, nothing happens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDBADelete_Click(object sender, EventArgs e)
        {
            dbas.ElementAt(ListBoxDBA.SelectedIndex).Delete();
            dbas = Dba.Generate(dbaUser);
            ListBoxDBA.DataSource = dbas;
            ListBoxDBA.DisplayMember = "fullName";
        }

        /// <summary>
        /// Callback for when the "Save" or "Add" button is clicked in the DBA panel. The button has the text "Save"
        /// when updating an already existing DBA and the text "Add" when creating a new DBA to the system.
        /// This is determined by checking to see if an element is selected before proceding with the operation. If any
        /// of the fields are left empty an error message is displayed for the user. The password must also meet the
        /// specified password requirements. If the operation was uncessful, another error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDBASave_Click(object sender, EventArgs e)
        {
            if (TextBoxDBAFName.Text.Equals("") || TextBoxDBALName.Text.Equals("") || TextBoxDBAUsername.Text.Equals("") ||
                TextBoxDBAPassword.Text.Equals("") || TextBoxDBAEmail.Text.Equals("") ||
                (RadioButtonDBASexMale.Checked == false && RadioButtonDBASexFemale.Checked == false))
            {
                MessageBox.Show("Please fill in all of the fields.");
            }
            else
            {
                if (!PasswordMeetsRequirements(TextBoxDBAPassword.Text))
                {
                    MessageBox.Show("Entered passwords do not meet the minimum requirements.\n1 upper case letter, 1 lower case letter, 1 digit, and length of at least 8.");
                }
                else
                {
                    string p = TextBoxDBAPassword.Text;
                    string f = TextBoxDBAFName.Text;
                    string l = TextBoxDBALName.Text;
                    string em = TextBoxDBAEmail.Text;
                    string d = DateTimePickerDBADOB.Value.Date.ToString("yyyy-MM-dd");
                    string s = "";
                    if (RadioButtonDBASexMale.Checked == true)
                    {
                        s = "M";
                    }
                    else
                    {
                        s = "F";
                    }
                    if (ListBoxDBA.SelectedIndex < 0)
                    {
                        string u = TextBoxDBAUsername.Text;
                        Dba c = new Dba(u, p, f, l, em, s, d);
                        if (!c.Add())
                        {
                            MessageBox.Show("Database Adminsitrator could not be added.");
                        }
                        else
                        {
                            dbas = Dba.Generate(dbaUser);
                            ListBoxDBA.DataSource = dbas;
                            ListBoxDBA.DisplayMember = "fullName";
                        }
                    }
                    else
                    {
                        Dba c = dbas.ElementAt(ListBoxDBA.SelectedIndex);
                        if (!c.Update(p, f, l, em, s, d))
                        {
                            MessageBox.Show("Database Administrator could not be updated.");
                        }
                        else
                        {
                            dbas = Dba.Generate(dbaUser);
                            ListBoxDBA.DataSource = dbas;
                            ListBoxDBA.DisplayMember = "fullName";
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Callback for when the "My Account" button is clicked in the menu. It makes the Account panel visible and
        /// the other panels not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Account
        private void ButtonMenuAccount_Click(object sender, EventArgs e)
        {
            PanelCataloger.Visible = false;
            PanelDBA.Visible = false;
            PanelAccount.Visible = true;
        }

        /// <summary>
        /// Callback for when the Account panel is made visible after clicking the "Account" menu button. This method
        /// populates the textfields with the DBA user's information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelAccount_VisibleChanged(object sender, EventArgs e)
        {
            TextBoxAccountFName.Text = dbaUser.fName;
            TextBoxAccountLName.Text = dbaUser.lName;
            TextBoxAccountPassword.Text = "";
            TextBoxAccountConfirmPassword.Text = "";
            TextBoxAccountEmail.Text = dbaUser.email;
            DateTimePickerAccountDOB.Text = dbaUser.dateOfBirth;
            if (dbaUser.sex.Equals("M"))
            {
                RadioButtonAccountSexMale.Checked = true;
            }
            else
            {
                RadioButtonAccountSexFemale.Checked = true;
            }
        }

        /// <summary>
        /// Callback for when the "Reset" button is clicked in the Account panel. This method reverts the information
        /// in the data fields to their original state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAccountReset_Click(object sender, EventArgs e)
        {
            TextBoxAccountFName.Text = dbaUser.fName;
            TextBoxAccountLName.Text = dbaUser.lName;
            TextBoxAccountPassword.Text = "";
            TextBoxAccountConfirmPassword.Text = "";
            TextBoxAccountEmail.Text = dbaUser.email;
            DateTimePickerAccountDOB.Text = dbaUser.dateOfBirth;
            if (dbaUser.sex.Equals("M"))
            {
                RadioButtonAccountSexMale.Checked = true;
            }
            else
            {
                RadioButtonAccountSexFemale.Checked = true;
            }
        }

        /// <summary>
        /// Callback for when the "Save" button is clicked in the Account panel that updates the user's information in the database.
        /// If any of the fields are left empty an error message is displayed for the user. The password must also meet
        /// the specified password requirements. If the operation was uncessful, another error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAccountSave_Click(object sender, EventArgs e)
        {
            if (TextBoxAccountFName.Text.Equals("") || TextBoxAccountLName.Text.Equals("") ||
    TextBoxAccountPassword.Text.Equals("") || TextBoxAccountEmail.Text.Equals(""))
            {
                MessageBox.Show("Please fill in all of the fields.");
            }
            else
            {
                if (!PasswordMeetsRequirements(TextBoxAccountPassword.Text))
                {
                    MessageBox.Show("Entered passwords do not meet the minimum requirements.\n1 upper case letter, 1 lower case letter, 1 digit, and length of at least 8.");
                }
                else if (!TextBoxAccountPassword.Text.Equals(TextBoxAccountConfirmPassword.Text))
                {
                    TextBoxAccountPassword.Text = "";
                    TextBoxAccountConfirmPassword.Text = "";
                    MessageBox.Show("Passwords do not much.");

                }
                else
                {
                    string f = TextBoxAccountFName.Text;
                    string l = TextBoxAccountLName.Text;
                    string p = TextBoxAccountPassword.Text;
                    string em = TextBoxAccountEmail.Text;
                    string d = DateTimePickerAccountDOB.Value.Date.ToString("yyyy-MM-dd");
                    string s = "";
                    if (RadioButtonAccountSexMale.Checked == true)
                    {
                        s = "M";
                    }
                    else
                    {
                        s = "F";
                    }
                    if (!dbaUser.Update(p, f, l, em, s, d))
                    {
                        MessageBox.Show("User account could not be updated.");
                    }
                    else
                    {
                        TextBoxAccountPassword.Text = "";
                        TextBoxAccountConfirmPassword.Text = "";
                        dbaUser = new DbaUser(dbaUser.username);
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Callback for when the "Logout" menu button is clicked. This button ends the DBA user's session with the
        /// system and returns to the Login screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMenuLogout_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(this.OwnedForms.ElementAt(0));
            this.Close();
        }

        /// <summary>
        /// Method that is used to determine if the password is valid with the system's restrictions. The password must
        /// contain atleast 1 lower case letter, 1 upper case letter, and 1 number. It also must be longer than 8
        /// characters. 
        /// </summary>
        /// <param name="pWord"></param> the password that needs to be tested for validity
        /// <returns></returns> returns 'true' if the password meets the requiremetns and 'false' otherwise
        private bool PasswordMeetsRequirements(String pWord)
        {
            bool upper = false;
            bool lower = false;
            bool digit = false;
            if (pWord.Length >= 8)
            {
                for (int i = 0; i < pWord.Length; i++)
                {
                    if (Char.IsUpper(pWord[i])) upper = true;
                    else if (Char.IsLower(pWord[i])) lower = true;
                    else if (Char.IsDigit(pWord[i])) digit = true;
                }
            }
            return upper && lower && digit;
        }
    }
}
