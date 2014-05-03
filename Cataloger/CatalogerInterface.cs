using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cataloger
{
    public partial class CatalogerInterface : Form
    {
        Cataloger cataloger;
        List<Prison> prisons;
        public CatalogerInterface(String uName)
        {
            cataloger = new Cataloger(uName);
            InitializeComponent();
            InitializeAdditional();
            panelPrisoner.Visible = true;
        }

        void InitializeAdditional()
        {
            this.panelPrisoner.VisibleChanged += new System.EventHandler(this.panelPrisoner_VisibleChanged);
            this.panelPrison.VisibleChanged += new System.EventHandler(this.panelPrison_VisibleChanged);
            this.panelOffense.VisibleChanged += new System.EventHandler(this.panelOffense_VisibleChanged);
            this.panelAccount.VisibleChanged += new System.EventHandler(this.panelAccount_VisibleChanged);
        }

        void RefreshData()
        {
            prisons = Prison.GenerateAll();
        }

        #region Menu Button Click Events
        private void buttonMenuPrisoner_Click(object sender, EventArgs e)
        {
            if (!panelPrisoner.Visible)
            {
                panelPrisoner.Visible = true;
            }
            panelPrison.Visible = false;
            panelOffense.Visible = false;
            panelAccount.Visible = false;
        }

        private void buttonMenuPrison_Click(object sender, EventArgs e)
        {
            if (!panelPrison.Visible)
            {
                panelPrison.Visible = true;
            }
            panelPrisoner.Visible = false;
            panelOffense.Visible = false;
            panelAccount.Visible = false;
        }

        private void buttonMenuOffense_Click(object sender, EventArgs e)
        {
            if (!panelOffense.Visible)
            {
                panelOffense.Visible = true;
            }
            panelPrisoner.Visible = false;
            panelPrison.Visible = false;
            panelAccount.Visible = false;
        }

        private void buttonMenuAccount_Click(object sender, EventArgs e)
        {
            if (!panelAccount.Visible)
            {
                panelAccount.Visible = true;
            }
            panelPrisoner.Visible = false;
            panelPrison.Visible = false;
            panelOffense.Visible = false;
        }
        #endregion

        #region Prisoner
        void panelPrisoner_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisoner.Visible)
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine("panelPrisoner visible");
            RefreshData();
        }


        #endregion

        #region Prison
        void panelPrison_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrison.Visible)
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine("panelPrison visible");
        }
        #endregion

        #region Offense
        void panelOffense_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelOffense.Visible)
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine("panelOffense visible");
        }
        #endregion

        #region Account
        void panelAccount_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelAccount.Visible)
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine("panelAccount visible");
        }
        #endregion
        
        private void comboBoxPrisonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPrisonType.SelectedIndex != 0)
            {
                labelPrisonAddLocation.Hide();
                textBoxPrisonAddLocation.Hide();
            }
            else
            {
                labelPrisonAddLocation.Show();
                textBoxPrisonAddLocation.Show();
            }
        }
    }
}
