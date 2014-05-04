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
            this.treeViewPrison.AfterSelect += new TreeViewEventHandler(this.treeViewPrison_AfterSelect);
            this.panelPrisonPrisonDetails.VisibleChanged += new System.EventHandler(this.panelPrisonPrisonDetails_VisibleChanged);
            this.panelPrisonCellBlockDetails.VisibleChanged += new System.EventHandler(this.panelPrisonCellBlockDetails_VisibleChanged);
            this.panelPrisonCellDetails.VisibleChanged += new System.EventHandler(this.panelPrisonCellDetails_VisibleChanged);
            this.comboBoxPrisonAddPrison.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrisonAddPrison_SelectedIndexChanged);
            this.listViewOffenses.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(this.listViewOffenses_ItemSelectionChanged);

            comboBoxPrisonerAddPrison.DisplayMember = "name";
            comboBoxPrisonerAddPrison.ValueMember = "id";
            comboBoxPrisonerAddBlock.DisplayMember = "name";
            comboBoxPrisonerAddBlock.ValueMember = "id";
            comboBoxPrisonerAddCell.DisplayMember = "name";
            comboBoxPrisonerAddCell.ValueMember = "id";
            listBoxOffenseEditPrisoners.DisplayMember = "ListBoxDisplay";
            listBoxOffenseEditPrisoners.ValueMember = "id";
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

        private void buttonMenuLogout_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(this.OwnedForms.ElementAt(0));
            this.Close();
        }
        #endregion

        #region Helpers
        void RefreshData()
        {
            prisoners.Clear();
            prisons = Prison.GenerateAll();
            foreach (Prison p in prisons)
            {
                foreach (CellBlock b in p.blocks)
                {
                    foreach (Cell c in b.cells)
                    {
                        foreach (Prisoner pr in c.prisoners)
                        {
                            prisoners.Add(pr);
                        }
                    }
                }
            }
            comboBoxPrisonerAddPrison.DataSource = prisons;
            listBoxOffenseEditPrisoners.DataSource = prisoners;
            listBoxOffenseEditPrisoners.DisplayMember = "ListBoxDisplay";
            listBoxOffenseEditPrisoners.ValueMember = "id";
        }

        Prison FindPrison(int id)
        {
            foreach (Prison p in prisons)
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            return null;
        }

        CellBlock FindCellBlock(int id)
        {
            foreach (Prison p in prisons)
            {
                foreach (CellBlock b in p.blocks)
                {
                    if (b.id == id)
                    {
                        return b;
                    }
                }
            }
            return null;
        }

        Cell FindCell(int id)
        {
            foreach (Prison p in prisons)
            {
                foreach (CellBlock b in p.blocks)
                {
                    foreach (Cell c in b.cells)
                    {
                        if (c.id == id)
                        {
                            return c;
                        }
                    }
                }
            }
            return null;
        }
        Offense FindOffense(int id)
        {
            foreach(Prisoner p in prisoners)
            {
                foreach(Offense o in p.offenses)
                {
                    if (o.id == id) return o;
                }
            }
            return null;
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

        private void buttonPrisonerDelete_Click(object sender, EventArgs e)
        {
            Prisoner.Delete(Convert.ToInt32(listViewPrisonerSearch.SelectedItems[0].Text));
            RefreshData();
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
            textBoxCellBlockDescription.Text = block.description;
        }

        void PopulatePrisonDataPanel(Prison prison)
        {
            textBoxPrisonName.Text = prison.name;
            textBoxPrisonLocation.Text = prison.location;
            textBoxPrisonDescription.Text = prison.description;
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
            if (treeViewPrison.SelectedNode == null) return;
            Prison prison = FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (prison == null) return;
            prison.Update(textBoxPrisonName.Text, textBoxPrisonLocation.Text, textBoxPrisonDescription.Text);
            RefreshData();
            PopulatePrisonTreeView();
            panelPrisonPrisonDetails.Visible = false;
        }

        private void buttonResetPrison_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Prison prison = FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (prison == null) return;
            PopulatePrisonDataPanel(prison);
        }

        private void buttonDeletePrison_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Prison prison = FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (prison == null) return;
            if (prison.blocks.Count > 0)
            {
                MessageBox.Show("There can't be cell blocks in a prison if you wish to delete a prison.");
                return;
            }
            prison.Delete();
            RefreshData();
            PopulatePrisonTreeView();
        }

        private void buttonSaveCellBlock_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            CellBlock block = FindCellBlock(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (block == null) return;
            block.Update(textBoxCellBlockName.Text, textBoxCellBlockDescription.Text);
            RefreshData();
            PopulatePrisonTreeView();
            panelPrisonCellBlockDetails.Visible = false;
        }

        private void buttonResetCellBlock_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            CellBlock block = FindCellBlock(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (block == null) return;
            PopulateBlockDataPanel(block);
        }

        private void buttonDeleteCellBlock_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            CellBlock block = FindCellBlock(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (block == null) return;
            if (block.cells.Count > 0)
            {
                MessageBox.Show("There can't be cells in a cell block if you wish to delete a prison.");
                return;
            }
            block.Delete();
            RefreshData();
            PopulatePrisonTreeView();
        }

        private void buttonSaveCell_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Cell cell = FindCell(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (cell == null) return;
            cell.Update(textBoxCellName.Text, textBoxCellDescription.Text);
            RefreshData();
            PopulatePrisonTreeView();
            panelPrisonCellDetails.Visible = false;
        }

        private void buttonResetCell_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Cell cell = FindCell(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (cell == null) return;
            PopulateCellDataPanel(cell);
        }

        private void buttonDeleteCell_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Cell cell = FindCell(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (cell == null) return;
            if (cell.prisoners.Count > 0)
            {
                MessageBox.Show("There can't be prisoners in a cell if you wish to delete a prison.");
                return;
            }
            cell.Delete();
            RefreshData();
            PopulatePrisonTreeView();
        }

        void comboBoxPrisonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxPrisonType.SelectedIndex)
            {
                case (0):
                    labelPrisonAddLocation.Show();
                    textBoxPrisonAddLocation.Show();
                    labelPrisonAddPrison.Hide();
                    comboBoxPrisonAddPrison.Hide();
                    labelPrisonAddCellBlock.Hide();
                    comboBoxPrisonAddCellBlock.Hide();
                    break;
                case (1):
                    labelPrisonAddLocation.Hide();
                    textBoxPrisonAddLocation.Hide();
                    labelPrisonAddPrison.Show();
                    comboBoxPrisonAddPrison.Show();
                    labelPrisonAddCellBlock.Hide();
                    comboBoxPrisonAddCellBlock.Hide();

                    comboBoxPrisonAddPrison.DataSource = prisons;
                    comboBoxPrisonAddPrison.DisplayMember = "name";
                    comboBoxPrisonAddPrison.ValueMember = "id";

                    break;
                case (2):
                    labelPrisonAddLocation.Hide();
                    textBoxPrisonAddLocation.Hide();
                    labelPrisonAddPrison.Show();
                    comboBoxPrisonAddPrison.Show();
                    labelPrisonAddCellBlock.Show();
                    comboBoxPrisonAddCellBlock.Show();
                    
                    comboBoxPrisonAddPrison.DataSource = prisons;
                    comboBoxPrisonAddPrison.DisplayMember = "name";
                    comboBoxPrisonAddPrison.ValueMember = "id";
                    break;
                default:
                    break;


            }
        }

        void comboBoxPrisonAddPrison_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPrisonAddCellBlock.DataSource = ((Prison)comboBoxPrisonAddPrison.SelectedItem).blocks;
            comboBoxPrisonAddCellBlock.DisplayMember = "name";
            comboBoxPrisonAddCellBlock.ValueMember = "id";
        }

        private void buttonPrisonAddAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPrisonType.SelectedIndex == 0 && textBoxPrisonAddLocation.Text.Length == 0)
            {
                MessageBox.Show("Name and Location fields are required.");
                return;
            }
            if (comboBoxPrisonType.SelectedIndex == 1 && (textBoxPrisonAddName.Text.Length == 0 || comboBoxPrisonAddPrison.SelectedItem == null))
            {
                MessageBox.Show("Name and Prison fields are required.");
                return;
            }
            if (comboBoxPrisonType.SelectedIndex == 2 && (textBoxPrisonAddName.Text.Length == 0 || comboBoxPrisonAddPrison.SelectedItem == null || comboBoxPrisonAddCellBlock.SelectedItem == null))
            {
                MessageBox.Show("Name, Prison, and Cell Block fields are required.");
                return;
            }

            switch(comboBoxPrisonType.SelectedIndex)
            {
                case(0):
                    Prison.Add(textBoxPrisonAddName.Text, textBoxPrisonAddLocation.Text, textBoxPrisonAddDescription.Text);
                    break;
                case(1):
                    CellBlock.Add(textBoxPrisonAddName.Text, textBoxPrisonAddDescription.Text, ((Prison)comboBoxPrisonAddPrison.SelectedItem).id);
                    break;
                case(2):
                    Cell.Add(textBoxPrisonAddName.Text, textBoxPrisonAddDescription.Text, ((CellBlock)comboBoxPrisonAddCellBlock.SelectedItem).id);
                    break;
                default:
                    break;
            }
            RefreshData();
            PopulatePrisonTreeView();
            tabControlPrison.SelectedTab = tabPrisonViewModify;
            ResetPrisonAddTab();
        }

        private void buttonPrisonAddClear_Click(object sender, EventArgs e)
        {
            ResetPrisonAddTab();
        }

        void ResetPrisonAddTab()
        {
            comboBoxPrisonType.SelectedIndex = 0;
            textBoxPrisonAddLocation.Text = "";
            textBoxPrisonAddDescription.Text = "";
            textBoxPrisonAddName.Text = "";
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
            listBoxOffenseEditPrisoners.DataSource = null;
            RefreshData();
            PopulateOffenseListView();
            listBoxOffenseEditPrisoners.DataSource = prisoners;
        }

        void PopulateOffenseListView()
        {
            String pId = textBoxOffenseId.Text.ToLower();
            String pFname = textBoxOffensePrisonerFname.Text.ToLower();
            String pLname = textBoxOffensePrisonerLname.Text.ToLower();
            String type = textBoxOffenseType.Text.ToLower();
            String loc = textBoxOffenseLocation.Text.ToLower();
            String date = textBoxOffenseDate.Text.ToLower();
            listViewOffenses.Items.Clear();

            foreach(Prisoner p in prisoners)
            {
                if (!p.id.ToString().ToLower().Contains(pId) || !p.fName.ToLower().Contains(pFname) || !p.lName.ToLower().Contains(pLname)) continue;
                foreach(Offense o in p.offenses)
                {
                    if (!o.type.ToLower().Contains(type) || !o.location.ToLower().Contains(loc) || !o.date.ToLower().Contains(date)) continue;
                    ListViewItem item = new ListViewItem(o.id.ToString());
                    item.SubItems.Add(p.fName);
                    item.SubItems.Add(p.lName);
                    item.SubItems.Add(o.type);
                    item.SubItems.Add(o.location);
                    item.SubItems.Add(o.date);
                    listViewOffenses.Items.Add(item);
                }
            }
        }
        void listViewOffenses_ItemSelectionChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("listViewOffenses_ItemSelectionChanged");
            if (listViewOffenses.SelectedItems.Count == 0)
            {
                buttonOffenseNew.Text = "New";
                buttonOffenseAddAdd.Text = "Add";
                textBoxOffenseDescription.Text = "";
            }
            else
            {
                buttonOffenseNew.Text = "Edit";
                buttonOffenseAddAdd.Text = "Save";
                textBoxOffenseDescription.Text = FindOffense(Convert.ToInt32(listViewOffenses.SelectedItems[0].Text)).description;
            }
        }

        private void buttonOffenseSearch_Click(object sender, EventArgs e)
        {
            PopulateOffenseListView();
        }

        private void buttonOffenseDelete_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("buttonOffenseDelete_Click");
            if (listViewOffenses.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                Offense.Delete(Convert.ToInt32(listViewOffenses.SelectedItems[0].Text));
                RefreshData();
                PopulateOffenseListView();
            }
        }

        private void buttonOffenseNew_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("buttonOffenseNew_Click");
            if (listViewOffenses.SelectedItems.Count == 0)
            {
                textBoxOffenseEditLocation.Text = String.Empty;
                textBoxOffenseEditDescription.Text = String.Empty;
                textBoxOffenseEditType.Text = String.Empty;
                datePickerOffenseEditDate.Text = String.Empty;
            }
            else
            {
                Offense o = FindOffense(Convert.ToInt32(listViewOffenses.SelectedItems[0].Text));
                if (o == null) return;
                textBoxOffenseEditLocation.Text = o.location;
                textBoxOffenseEditDescription.Text = o.description;
                textBoxOffenseEditType.Text = o.type;
                datePickerOffenseEditDate.Text = o.date;
                listBoxOffenseEditPrisoners.SelectedItem = o.prisoner;
            }
            tabControlOffense.SelectedTab = tabOffenseAddEdit;
        }

        private void buttonOffenseEditReset_Click(object sender, EventArgs e)
        {
            if (buttonOffenseNew.Text.Equals("New"))
            {
                textBoxOffenseEditLocation.Text = String.Empty;
                textBoxOffenseEditDescription.Text = String.Empty;
                textBoxOffenseEditType.Text = String.Empty;
                datePickerOffenseEditDate.Text = String.Empty;
            }
            else
            {
                Offense o = FindOffense(Convert.ToInt32(listViewOffenses.SelectedItems[0].Text));
                if (o == null) return;
                textBoxOffenseEditLocation.Text = o.location;
                textBoxOffenseEditDescription.Text = o.description;
                textBoxOffenseEditType.Text = o.type;
                datePickerOffenseEditDate.Text = o.date;
            }
        }

        private void buttonOffenseAddAdd_Click(object sender, EventArgs e)
        {
            if (listBoxOffenseEditPrisoners.SelectedItem == null || textBoxOffenseEditLocation.Text.Length == 0
                || textBoxOffenseEditType.Text.Length == 0)
            {
                MessageBox.Show("Prisoner, Location, and Type fields are required");
                return;
            }

            if (listViewOffenses.SelectedItems.Count == 0)
            {
                Offense.Add(textBoxOffenseEditLocation.Text, textBoxOffenseEditType.Text, textBoxOffenseEditDescription.Text,
                    datePickerOffenseEditDate.Value.Date.ToString("yyy-MM-dd"), ((Prisoner)listBoxOffenseEditPrisoners.SelectedItem).id);
            }
            else
            {
                Offense.Update(Convert.ToInt32(listViewOffenses.SelectedItems[0].Text),textBoxOffenseEditLocation.Text, textBoxOffenseEditType.Text,
                    textBoxOffenseEditDescription.Text, datePickerOffenseEditDate.Value.Date.ToString("yyy-MM-dd"), 
                    ((Prisoner)listBoxOffenseEditPrisoners.SelectedItem).id);
            }
            RefreshData();
            PopulateOffenseListView();
            tabControlOffense.SelectedTab = tabOffenseSearch;
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
