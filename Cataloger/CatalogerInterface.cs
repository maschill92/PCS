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
        List<Prisoner> prisoners;
        public CatalogerInterface(String uName)
        {
            cataloger = new Cataloger(uName);
            prisons = new List<Prison>();
            prisoners = new List<Prisoner>();
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
            this.comboBoxPrisonType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrisonType_SelectedIndexChanged);
            this.listViewPrisonerSearch.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(this.listViewPrisonerSearch_ItemSelectionChanged);
            this.tabControlPrisoner.TabIndexChanged += new System.EventHandler(this.tabControlPrisoner_TabIndexChanged);
            this.comboBoxPrisonerAddPrison.SelectedValueChanged += new System.EventHandler(this.comboBoxPrisonerAddPrison_SelectedValueChanged);
            this.comboBoxPrisonerAddBlock.SelectedValueChanged += new System.EventHandler(this.comboBoxPrisonerAddBlock_SelectedValueChanged);

            comboBoxPrisonerAddPrison.DisplayMember = "name";
            comboBoxPrisonerAddPrison.ValueMember = "id";
            comboBoxPrisonerAddBlock.DisplayMember = "name";
            comboBoxPrisonerAddBlock.ValueMember = "id";
            comboBoxPrisonerAddCell.DisplayMember = "name";
            comboBoxPrisonerAddCell.ValueMember = "id";
        }

        void RefreshData()
        {
            prisons = Prison.GenerateAll();
            comboBoxPrisonerAddPrison.DataSource = prisons;
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
            PopulatePrisonerListView();
        }

        void PopulatePrisonerListView()
        {
            String id = textBoxPrisonerId.Text.ToLower();
            String fName = textBoxPrisonerFname.Text.ToLower();
            String lName = textBoxPrisonerLname.Text.ToLower();
            String pName = textBoxPrisonerPrisonName.Text.ToLower();
            String bName = textBoxPrisonerBlockName.Text.ToLower();
            String cName = textBoxPrisonerCellName.Text.ToLower();
            prisoners.Clear();
            listViewPrisonerSearch.Items.Clear();
            foreach (Prison p in prisons)
            {
                if (!p.name.ToLower().Contains(pName)) continue;
                foreach (CellBlock b in p.blocks)
                {
                    if (!b.name.ToLower().Contains(bName)) continue;
                    foreach (Cell c in b.cells)
                    {
                        if (!c.name.ToLower().Contains(cName)) continue;
                        foreach (Prisoner pr in c.prisoners)
                        {
                            if (pr.id.ToString().Contains(id) && pr.fName.ToLower().Contains(fName) && pr.lName.ToLower().Contains(lName))
                            {
                                prisoners.Add(pr);
                                ListViewItem item = new ListViewItem(pr.id.ToString());
                                item.SubItems.Add(pr.fName);
                                item.SubItems.Add(pr.lName);
                                item.SubItems.Add(p.name);
                                item.SubItems.Add(b.name);
                                item.SubItems.Add(c.name);
                                listViewPrisonerSearch.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        void listViewPrisonerSearch_ItemSelectionChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("listViewPrisonerSearch_ItemSelectionChanged");
            System.Diagnostics.Debug.WriteLine(listViewPrisonerSearch.SelectedItems.Count.ToString());
            if (listViewPrisonerSearch.SelectedItems.Count == 0)
            {
                buttonPrisonerNew.Text = "New";
                buttonPrisonerAddAdd.Text = "Add";
            }
            else
            {
                buttonPrisonerNew.Text = "Edit";
                buttonPrisonerAddAdd.Text = "Save";
            }
        }

        void tabControlPrisoner_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrisoner.SelectedTab == tabPrisonerSearch)
            {
                listViewPrisonerSearch.SelectedItems.Clear();
                buttonPrisonerNew.Text = "New";
                buttonPrisonerAddAdd.Text = "Add";
            }
        }

        private void buttonPrisonerSearch_Click(object sender, EventArgs e)
        {
            PopulatePrisonerListView();
        }

        private void buttonPrisonerNew_Click(object sender, EventArgs e)
        {
            if (buttonPrisonerNew.Text.Equals("New"))
            {
                textBoxPrisonerAddFname.Text = String.Empty;
                textBoxPrisonerAddLname.Text = String.Empty;
                datePickerAddPrisonerDob.Text = String.Empty;
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                comboBoxPrisonerAddCell.DataSource = null;
                comboBoxPrisonerAddBlock.DataSource = null;
            }
            else
            {
                int prisonerId = Convert.ToInt32(listViewPrisonerSearch.SelectedItems[0].Text);
                foreach (Prisoner p in prisoners)
                {
                    if (p.id == prisonerId)
                    {
                        textBoxPrisonerAddFname.Text = p.fName;
                        textBoxPrisonerAddLname.Text = p.lName;
                        datePickerAddPrisonerDob.Text = p.dateOfBirth;
                        if (p.sex.Equals("M"))
                        {
                            radioButtonAccountMale.Checked = true;
                        }
                        else
                        {
                            radioButtonAccountFemale.Checked = true;
                        }

                        comboBoxPrisonerAddBlock.DataSource = p.cell.block.prison.blocks;
                        comboBoxPrisonerAddBlock.SelectedValue = p.cell.block.id;
                        comboBoxPrisonerAddCell.DataSource = p.cell.block.cells;
                        comboBoxPrisonerAddCell.SelectedValue = p.cell.id;
                        break;
                    }
                }
            }
            tabControlPrisoner.SelectedTab = tabPrisonerAddEdit;
            comboBoxPrisonerAddBlock.DisplayMember = "name";
            comboBoxPrisonerAddBlock.ValueMember = "id";
            comboBoxPrisonerAddCell.DisplayMember = "name";
            comboBoxPrisonerAddCell.ValueMember = "id";
        }

        void comboBoxPrisonerAddPrison_SelectedValueChanged(object sender, EventArgs e)
        {
            Prison p = (Prison)comboBoxPrisonerAddPrison.SelectedItem;
            if (p == null) return;
            comboBoxPrisonerAddBlock.DataSource = p.blocks;
        }
        void comboBoxPrisonerAddBlock_SelectedValueChanged(object sender, EventArgs e)
        {
            CellBlock cb = (CellBlock)comboBoxPrisonerAddBlock.SelectedItem;
            if (cb == null) return;
            comboBoxPrisonerAddCell.DataSource = cb.cells;
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

    }
}
