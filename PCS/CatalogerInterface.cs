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
    public partial class CatalogerInterface : Form
    {
        DataCataloger dataCataloger;
        public CatalogerInterface(DataCataloger dc)
        {
            dataCataloger = dc;
            InitializeComponent();
        }

        private void buttonMenuPrisoner_Click(object sender, EventArgs e)
        {
            panelPrisoner.Show();
            panelPrison.Hide();
            panelOffense.Hide();
            panelAccount.Hide();
        }

        private void buttonMenuPrison_Click(object sender, EventArgs e)
        {
            panelPrisoner.Hide();
            panelPrison.Show();
            panelOffense.Hide();
            panelAccount.Hide();
        }

        private void buttonMenuOffense_Click(object sender, EventArgs e)
        {
            panelPrisoner.Hide();
            panelPrison.Hide();
            panelOffense.Show();
            panelAccount.Hide();
        }

        private void buttonMenuAccount_Click(object sender, EventArgs e)
        {
            panelPrisoner.Hide();
            panelPrison.Hide();
            panelOffense.Hide();
            panelAccount.Show();
        }

    }
}
