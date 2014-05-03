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
                TextBoxCatalogerUsername.Enabled = false;
            }
        }

        private void ButtonCatalogerNew_Click(object sender, EventArgs e)
        {
            ListBoxCataloger.SelectedIndex = -1;
        }

        private void ButtonCatalogerReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCatalogerDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCatalogerSave_Click(object sender, EventArgs e)
        {

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
    }
}
