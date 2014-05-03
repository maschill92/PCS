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
    public partial class DbaInterface : Form
    {

        private List<Cataloger> catalogers;
        private List<Dba> dbas;
        public DbaUser dbaUser;

        public DbaInterface(String uName)
        {
            InitializeComponent();
            InitializeAdditional();
            dbaUser = new DbaUser(uName);
            PanelCataloger.Visible = true;
        }

        private void InitializeAdditional()
        {
            this.PanelCataloger.VisibleChanged += new System.EventHandler(this.PanelCataloger_VisibleChanged);
            this.ListBoxCataloger.SelectedIndexChanged += new System.EventHandler(this.ListBoxCataloger_SelectedIndexChanged);
            this.PanelDBA.VisibleChanged += new System.EventHandler(this.PanelDBA_VisibleChanged);
            this.PanelAccount.VisibleChanged += new System.EventHandler(this.PanelAccount_VisibleChanged);
        }

        private void ButtonMenuCataloger_Click(object sender, EventArgs e)
        {
            PanelCataloger.Visible = true;
            PanelDBA.Visible = false;
            PanelAccount.Visible = false;
        }

        private void PopulateCatalogerList()
        {
            catalogers = Cataloger.Generate();
        }

        private void PanelCataloger_VisibleChanged(object sender, EventArgs e)
        {
            PopulateCatalogerList();
            ListBoxCataloger.DataSource = catalogers;
            ListBoxCataloger.DisplayMember = "fullName";
        }

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

        private void ButtonCatalogerNew_Click(object sender, EventArgs e)
        {
            ListBoxCataloger.SelectedIndex = -1;

        }

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

        private void ButtonCatalogerDelete_Click(object sender, EventArgs e)
        {
            catalogers.ElementAt(ListBoxCataloger.SelectedIndex).Delete();
            PopulateCatalogerList();
            ListBoxCataloger.DataSource = catalogers;
            ListBoxCataloger.DisplayMember = "fullName";
        }

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
                    MessageBox.Show("Entered passwords do not meet the minimum requirements.\n1 upper case letter, 1 lower case letter, 1 digit, and legth of at least 8.");
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
                            PopulateCatalogerList();
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
                            PopulateCatalogerList();
                            ListBoxCataloger.DataSource = catalogers;
                            ListBoxCataloger.DisplayMember = "fullName";
                        }
                    }
                }
            }
        }

        private void ButtonMenuDBA_Click(object sender, EventArgs e)
        {
            PanelCataloger.Visible = false;
            PanelDBA.Visible = true;
            PanelAccount.Visible = false;
        }

        private void PopulateDBAList()
        {
            dbas = Dba.Generate();
        }

        private void PanelDBA_VisibleChanged(object sender, EventArgs e)
        {
            PopulateDBAList();
            ListBoxDBA.DataSource = dbas;
            ListBoxDBA.DisplayMember = "fullName";
        }

        private void ButtonMenuAccount_Click(object sender, EventArgs e)
        {
            PanelCataloger.Visible = false;
            PanelDBA.Visible = false;
            PanelAccount.Visible = true;
        }

        private void PanelAccount_VisibleChanged(object sender, EventArgs e)
        {
            //
        }

        private void ButtonMenuLogout_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(this.OwnedForms.ElementAt(0));
            this.Close();
        }

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
