﻿using System;
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
            this.treeViewPrison.AfterSelect += new TreeViewEventHandler(this.treeViewPrison_AfterSelect);
            this.panelPrisonPrisonDetails.VisibleChanged += new System.EventHandler(this.panelPrisonPrisonDetails_VisibleChanged);
            this.panelPrisonCellBlockDetails.VisibleChanged += new System.EventHandler(this.panelPrisonCellBlockDetails_VisibleChanged);
            this.panelPrisonCellDetails.VisibleChanged += new System.EventHandler(this.panelPrisonCellDetails_VisibleChanged);

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

        void ResetPrisonerSearch()
        {
            RefreshData();
            textBoxPrisonerId.Text = String.Empty;
            textBoxPrisonerFname.Text = String.Empty;
            textBoxPrisonerLname.Text = String.Empty;
            textBoxPrisonerPrisonName.Text = String.Empty;
            textBoxPrisonerBlockName.Text = String.Empty;
            textBoxPrisonerCellName.Text = String.Empty;
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
                radioButtonPrisonerAddMale.Checked = false;
                radioButtonPrisonerAddFemale.Checked = false;
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
                            radioButtonPrisonerAddMale.Checked = true;
                        }
                        else
                        {
                            radioButtonPrisonerAddFemale.Checked = true;
                        }
                        comboBoxPrisonerAddPrison.SelectedValue = p.cell.block.prison.id;
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
            comboBoxPrisonerAddBlock.DisplayMember = "name";
            comboBoxPrisonerAddBlock.ValueMember = "id";
        }
        void comboBoxPrisonerAddBlock_SelectedValueChanged(object sender, EventArgs e)
        {
            CellBlock cb = (CellBlock)comboBoxPrisonerAddBlock.SelectedItem;
            if (cb == null) return;
            comboBoxPrisonerAddCell.DataSource = cb.cells;
            comboBoxPrisonerAddCell.DisplayMember = "name";
            comboBoxPrisonerAddCell.ValueMember = "id";
        }

        private void buttonPrisonerAddAdd_Click(object sender, EventArgs e)
        {
            if (listViewPrisonerSearch.SelectedItems.Count == 0)
            {
                //if (textBoxPrisonerFname.Text.Length == 0 || textBoxPrisonerLname.Text.Length == 0 || (!radioButtonPrisonerAddMale.Checked && !radioButtonPrisonerAddFemale.Checked)
                //    || comboBoxPrisonerAddPrison.SelectedItem == null || comboBoxPrisonerAddBlock.SelectedItem == null || comboBoxPrisonerAddCell.SelectedItem == null)
                //{
                //    MessageBox.Show("All fields are required.");
                //    return;
                //}
                Prisoner.Add(textBoxPrisonerAddFname.Text, textBoxPrisonerAddLname.Text, datePickerAddPrisonerDob.Value.Date.ToString("yyyy-MM-dd"), (radioButtonPrisonerAddMale.Checked) ? "M":"F", Convert.ToInt32(comboBoxPrisonerAddCell.SelectedValue));
                tabControlPrisoner.SelectedTab = tabPrisonerSearch;
            }
            else if (listViewPrisonerSearch.SelectedItems.Count == 1)
            {
                int prisonerId = Convert.ToInt32(listViewPrisonerSearch.SelectedItems[0].Text);
                Prisoner.Update(prisonerId, textBoxPrisonerAddFname.Text, textBoxPrisonerAddLname.Text, datePickerAddPrisonerDob.Value.Date.ToString("yyyy-MM-dd"), (radioButtonPrisonerAddMale.Checked) ? "M" : "F", Convert.ToInt32(comboBoxPrisonerAddCell.SelectedValue));
                tabControlPrisoner.SelectedTab = tabPrisonerSearch;
            }
            else throw new Exception("How'd you do that?!");
            RefreshData();
            PopulatePrisonerListView();

        }

        private void buttonPrisonerAddReset_Click(object sender, EventArgs e)
        {
            if (listViewPrisonerSearch.SelectedItems.Count == 0)
            {
                textBoxPrisonerAddFname.Text = String.Empty;
                textBoxPrisonerAddLname.Text = String.Empty;
                datePickerAddPrisonerDob.Text = String.Empty;
                radioButtonPrisonerAddMale.Checked = false;
                radioButtonPrisonerAddFemale.Checked = false;
                comboBoxPrisonerAddCell.DataSource = null;
                comboBoxPrisonerAddBlock.DataSource = null;
            }
            else if (listViewPrisonerSearch.SelectedItems.Count == 1)
            {
                int prisonerId = Convert.ToInt32(listViewPrisonerSearch.SelectedItems[0].Text);
                foreach(Prisoner p in prisoners)
                {
                    if (p.id == prisonerId)
                    {
                        textBoxPrisonerAddFname.Text = p.fName;
                        textBoxPrisonerAddLname.Text = p.lName;
                        datePickerAddPrisonerDob.Text = p.dateOfBirth;
                        if (p.sex.Equals("M"))
                        {
                            radioButtonPrisonerAddMale.Checked = true;
                        }
                        else
                        {
                            radioButtonPrisonerAddFemale.Checked = true;
                        }
                        comboBoxPrisonerAddPrison.SelectedValue = p.cell.block.prison.id;
                        comboBoxPrisonerAddBlock.DataSource = p.cell.block.prison.blocks;
                        comboBoxPrisonerAddBlock.SelectedValue = p.cell.block.id;
                        comboBoxPrisonerAddCell.DataSource = p.cell.block.cells;
                        comboBoxPrisonerAddCell.SelectedValue = p.cell.id;
                        break;
                    }
                }
            }
            else throw new Exception("How'd you do that?!");
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
            RefreshData();
            PopulatePrisonTreeView();
        }

        void PopulatePrisonTreeView()
        {
            treeViewPrison.BeginUpdate();
            treeViewPrison.Nodes.Clear();
            TreeNode root = new TreeNode("Prisons");
            root.Name = "root";
            treeViewPrison.Nodes.Add(root);
            foreach (Prison p in prisons)
            {
                TreeNode prisonNode = new TreeNode(p.name);
                prisonNode.Name = p.id.ToString();
                root.Nodes.Add(prisonNode);
                foreach (CellBlock b in p.blocks)
                {
                    TreeNode blockNode = new TreeNode(b.name);
                    blockNode.Name = b.id.ToString();
                    prisonNode.Nodes.Add(blockNode);
                    foreach (Cell c in b.cells)
                    {
                        TreeNode cellNode = new TreeNode(c.name);
                        cellNode.Name = c.id.ToString();
                        blockNode.Nodes.Add(cellNode);
                    }
                }
            }
            treeViewPrison.EndUpdate();
            treeViewPrison.ExpandAll();
        }

        void treeViewPrison_AfterSelect(object sender, EventArgs e)
        {
            TreeNode node = treeViewPrison.SelectedNode;
            if (node.Level == 0) return;
            int itemId = Convert.ToInt32(node.Name);
            if(node.Level == 1)
            {
                PopulatePrisonDataPanel(FindPrison(itemId));
                panelPrisonPrisonDetails.Visible = true;
            }
            else if (node.Level == 2)
            {
                PopulateBlockDataPanel(FindCellBlock(itemId));
                panelPrisonCellBlockDetails.Visible = true;
            }
            else if (node.Level == 3)
            {
                PopulateCellDataPanel(FindCell(itemId));
                panelPrisonCellDetails.Visible = true;
            }
            
        }

        void PopulateCellDataPanel(Cell cell)
        {
            textBoxCellDescription.Text = cell.description;
            textBoxCellName.Text = cell.name;
        }

        void PopulateBlockDataPanel(CellBlock block)
        {
            textBoxCellBlockName.Text = block.name;
            textBoxCellBlockDetails.Text = block.description;
        }

        void PopulatePrisonDataPanel(Prison prison)
        {
            textBoxPrisonName.Text = prison.name;
            textBoxPrisonLocation.Text = prison.location;
            textBoxPrisonDescription.Text = prison.description;
        }

        Prison FindPrison(int id)
        {
            Prison prison = new Prison(-1, String.Empty, String.Empty, String.Empty);
            foreach (Prison p in prisons)
            {
                if (p.id == id)
                {
                    prison = p;
                    break;
                }
            }
            if (prison.id == -1) return null;
            return prison;
        }

        CellBlock FindCellBlock(int id)
        {
            CellBlock block = new CellBlock(-1, String.Empty, String.Empty, null);
            foreach (Prison p in prisons)
            {
                foreach (CellBlock b in p.blocks)
                {
                    if (b.id == id)
                    {
                        block = b;
                        break;
                    }
                }
            }
            if (block.id == -1) return null;
            return block;
        }

        Cell FindCell(int id)
        {
            Cell cell = new Cell(-1, String.Empty, String.Empty, null);
            foreach (Prison p in prisons)
            {
                foreach (CellBlock b in p.blocks)
                {
                    foreach (Cell c in b.cells)
                    {
                        if (c.id == id)
                        {
                            cell = c;
                            break;
                        }
                    }
                }
            }
            if (cell.id == -1) return null;
            return cell;
        }

        void panelPrisonPrisonDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisonPrisonDetails.Visible) return;
            panelPrisonCellBlockDetails.Visible = false;
            panelPrisonCellDetails.Visible = false;
        }

        void panelPrisonCellBlockDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisonCellBlockDetails.Visible) return;
            panelPrisonPrisonDetails.Visible = false;
            panelPrisonCellDetails.Visible = false;
        }

        void panelPrisonCellDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisonCellDetails.Visible) return;
            panelPrisonPrisonDetails.Visible = false;
            panelPrisonCellBlockDetails.Visible = false;
        }

        private void buttonSavePrison_Click(object sender, EventArgs e)
        {
            Prison prison = FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            prison.Update(textBoxPrisonName.Text, textBoxPrisonLocation.Text, textBoxPrisonDescription.Text);
            PopulatePrisonTreeView();
        }

        private void buttonResetPrison_Click(object sender, EventArgs e)
        {
            PopulatePrisonDataPanel(FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name)));
        }

        private void buttonDeletePrison_Click(object sender, EventArgs e)
        {
            Prison prison = FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            prison.Delete();
            PopulatePrisonTreeView();
        }

        private void buttonSaveCellBlock_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetCellBlock_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCellBlock_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveCell_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetCell_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCell_Click(object sender, EventArgs e)
        {

        }

        void comboBoxPrisonType_SelectedIndexChanged(object sender, EventArgs e)
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

            TextBoxAccountFName.Text = cataloger.fName;
            TextBoxAccountLName.Text = cataloger.lName;
            TextBoxAccountPassword.Text = "";
            TextBoxAccountEmail.Text = cataloger.email;
            DateTimePickerAccountDOB.Text = cataloger.dateOfBirth;
            if (cataloger.sex.Equals("M"))
            {
                RadioButtonAccountSexMale.Checked = true;
            }
            else
            {
                RadioButtonAccountSexFemale.Checked = true;
            }
        }

        void ButtonAccountReset_Click(object sender, EventArgs e)
        {
            TextBoxAccountFName.Text = cataloger.fName;
            TextBoxAccountLName.Text = cataloger.lName;
            TextBoxAccountPassword.Text = "";
            TextBoxAccountEmail.Text = cataloger.email;
            DateTimePickerAccountDOB.Text = cataloger.dateOfBirth;
            if (cataloger.sex.Equals("M"))
            {
                RadioButtonAccountSexMale.Checked = true;
            }
            else
            {
                RadioButtonAccountSexFemale.Checked = true;
            }
        }

        void ButtonAccountSave_Click(object sender, EventArgs e)
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
                    if (!cataloger.Update(p, f, l, em, s, d))
                    {
                        MessageBox.Show("User account could not be updated.");
                    }
                    else
                    {
                        TextBoxAccountPassword.Text = "";
                        cataloger = new Cataloger(cataloger.username);
                    }
                }
            }
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
        #endregion
    }
}
