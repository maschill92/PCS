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
    /// <summary>
    /// Class that is the logic for the CatalogerInterface
    /// </summary>
    public partial class CatalogerInterface : Form
    {
        Cataloger cataloger;
        List<Prison> prisons;
        List<Prisoner> prisoners;

        /// <summary>
        /// Constructor that creates the cataloger based on a username given along with performing
        /// some various initialization steps like call backs and gathering initial prison data
        /// </summary>
        /// <param name="uName">Username of the cataloger that has been authenticated</param>
        public CatalogerInterface(String uName)
        {
            cataloger = new Cataloger(uName);
            prisons = new List<Prison>();
            prisoners = new List<Prisoner>();
            InitializeComponent();
            InitializeAdditional();
            panelPrisoner.Visible = true;
        }

        /// <summary>
        /// Custom initalizer for event callbacks and datasource recognitions for listview, listboxes, and comboboxes
        /// </summary>
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
        /// <summary>
        /// Event when prisoner menu button is selected
        /// </summary>
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

        /// <summary>
        /// Event when prison menu button is selected
        /// </summary>
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

        /// <summary>
        /// Event when offense menu button is selected
        /// </summary>
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

        /// <summary>
        /// Event when account menu button is selected
        /// </summary>
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

        /// <summary>
        /// Event when prisoner logout button is selected
        /// </summary>
        private void buttonMenuLogout_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(this.OwnedForms.ElementAt(0));
            this.Close();
        }
        #endregion

        #region Helpers
        /// <summary>
        /// Fetches new data from the database and populates a list of prisons and prisoners
        /// </summary>
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

        /// <summary>
        /// Searches local data and finds a prison
        /// </summary>
        /// <param name="id">The id of the prison in question</param>
        /// <returns>The Prison object with a matching id</returns>
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

        /// <summary>
        /// Seaches local data and finds a cell block
        /// </summary>
        /// <param name="id">The id of the cell block in question</param>
        /// <returns>The CellBlock object with a matching id</returns>
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

        /// <summary>
        /// Seaches local data and finds a cell
        /// </summary>
        /// <param name="id">The id of the cell in question</param>
        /// <returns>The Cell object with a matching id</returns>
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

        /// <summary>
        /// Seaches local data and finds an offense
        /// </summary>
        /// <param name="id">The id of the offense in question</param>
        /// <returns>The Offense object with a matching id</returns>
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
        /// <summary>
        /// Event that is triggered with the main prison panel's visiblilty is changed
        /// </summary>
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

        /// <summary>
        /// Helper that removes all data from the search boxes above the prisoner listview
        /// </summary>
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

        /// <summary>
        /// Populates the listview with the local data retrieved from the database based on what
        /// is currently in the search boxes
        /// </summary>
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

        /// <summary>
        /// Event triggered when a new prisoner is selected in the listbox
        /// </summary>
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

        /// <summary>
        /// Event triggered when a tab is changed in the prisoner panel.
        /// </summary>
        void tabControlPrisoner_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrisoner.SelectedTab == tabPrisonerSearch)
            {
                listViewPrisonerSearch.SelectedItems.Clear();
                buttonPrisonerNew.Text = "New";
                buttonPrisonerAddAdd.Text = "Add";
            }
        }

        /// <summary>
        /// Event triggered when the search button is clicked.
        /// </summary>
        private void buttonPrisonerSearch_Click(object sender, EventArgs e)
        {
            PopulatePrisonerListView();
        }

        /// <summary>
        /// Deletes the selected prisoner from the database
        /// </summary>
        private void buttonPrisonerDelete_Click(object sender, EventArgs e)
        {
            Prisoner.Delete(Convert.ToInt32(listViewPrisonerSearch.SelectedItems[0].Text));
            RefreshData();
            PopulatePrisonerListView();
        }
        /// <summary>
        /// Triggered when the "New" or "Add" button is clicked on the prisoner view page.
        /// It the populates are removes data in the add tab datafields appropriated depending on
        /// if a prisoner is currently is selected or not. Then it switches tabs to the Add/Modify
        /// tab as to show the newly populated (or depopulated) fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Triggered when a different prison is slected in the add prisoner tab.
        /// It populates the cell block combobox with cell blocks located in the selected prison
        /// </summary>
        void comboBoxPrisonerAddPrison_SelectedValueChanged(object sender, EventArgs e)
        {
            Prison p = (Prison)comboBoxPrisonerAddPrison.SelectedItem;
            if (p == null) return;
            comboBoxPrisonerAddBlock.DataSource = p.blocks;
            comboBoxPrisonerAddBlock.DisplayMember = "name";
            comboBoxPrisonerAddBlock.ValueMember = "id";
        }

        /// <summary>
        /// Triggered when a different cell block is slected in the add prisoner tab.
        /// It populates the cell combobox with cells located in the selected cell block
        /// </summary>
        void comboBoxPrisonerAddBlock_SelectedValueChanged(object sender, EventArgs e)
        {
            CellBlock cb = (CellBlock)comboBoxPrisonerAddBlock.SelectedItem;
            if (cb == null) return;
            comboBoxPrisonerAddCell.DataSource = cb.cells;
            comboBoxPrisonerAddCell.DisplayMember = "name";
            comboBoxPrisonerAddCell.ValueMember = "id";
        }

        /// <summary>
        /// Event triggered when the user clicks on the "New" or "Add" button.
        /// Creates a new prisoner or updates an existing one.
        /// </summary>
        private void buttonPrisonerAddAdd_Click(object sender, EventArgs e)
        {
            if (listViewPrisonerSearch.SelectedItems.Count == 0)
            {
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

        /// <summary>
        /// Resets the fields in the Add/Modify tab of the prisoner menu.
        /// If a prisoner is selected to modify, then the data is set to the original data,
        /// otherwise the boxes are set to their default empty values.
        /// </summary>
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
        /// <summary>
        /// Triggered when a prison panel's visiblity is changed
        /// </summary>
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

        /// <summary>
        /// Helper function that poulates the tree of the prisons, blocks, and cells.
        /// </summary>
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

        /// <summary>
        /// Triggered when an item in the prison tree is selected
        /// It changes panels and populates data in other locations as needed.
        /// </summary>
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

        /// <summary>
        /// Helper functions that populates the cell panel with data from a particular cell.
        /// </summary>
        /// <param name="cell">Item when data should be populated from</param>
        void PopulateCellDataPanel(Cell cell)
        {
            textBoxCellDescription.Text = cell.description;
            textBoxCellName.Text = cell.name;
        }

        /// <summary>
        /// Helper functions that populates the cell block panel with data from a particular cell block.
        /// </summary>
        /// <param name="block">Item when data should be populated from</param>
        void PopulateBlockDataPanel(CellBlock block)
        {
            textBoxCellBlockName.Text = block.name;
            textBoxCellBlockDescription.Text = block.description;
        }

        /// <summary>
        /// Helper functions that populates the prison panel with data from a particular prison.
        /// </summary>
        /// <param name="prison">Item when data should be populated from</param>
        void PopulatePrisonDataPanel(Prison prison)
        {
            textBoxPrisonName.Text = prison.name;
            textBoxPrisonLocation.Text = prison.location;
            textBoxPrisonDescription.Text = prison.description;
        }

        /// <summary>
        /// Triggered when the prison details panel's visiblilty is changed.
        /// </summary>
        void panelPrisonPrisonDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisonPrisonDetails.Visible) return;
            panelPrisonCellBlockDetails.Visible = false;
            panelPrisonCellDetails.Visible = false;
        }

        /// <summary>
        /// Triggered when the cell block details panel's visiblilty is changed.
        /// </summary>
        void panelPrisonCellBlockDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisonCellBlockDetails.Visible) return;
            panelPrisonPrisonDetails.Visible = false;
            panelPrisonCellDetails.Visible = false;
        }

        /// <summary>
        /// Triggered when the cell details panel's visiblilty is changed.
        /// </summary>
        void panelPrisonCellDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPrisonCellDetails.Visible) return;
            panelPrisonPrisonDetails.Visible = false;
            panelPrisonCellBlockDetails.Visible = false;
        }

        /// <summary>
        /// Triggered when the save button for a prison is clicked.
        /// This updates the database with the newly inserted material.
        /// </summary>
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

        /// <summary>
        /// Triggered when the reset button for a prison is clicked.
        /// This changes the data in the fields to the original data of the
        /// item selected in the tree view.
        /// </summary>
        private void buttonResetPrison_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Prison prison = FindPrison(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (prison == null) return;
            PopulatePrisonDataPanel(prison);
        }

        /// <summary>
        /// Triggered when the delete button for a prison is clicked.
        /// This removes it from the database and updates the treeview to show the changes.
        /// </summary>
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

        /// <summary>
        /// Triggered when the save button for a cell is clicked.
        /// This updates the database with the newly inserted material.
        /// </summary>
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

        /// <summary>
        /// Triggered when the reset button for a cell block is clicked.
        /// This changes the data in the fields to the original data of the
        /// item selected in the tree view.
        /// </summary>
        private void buttonResetCellBlock_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            CellBlock block = FindCellBlock(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (block == null) return;
            PopulateBlockDataPanel(block);
        }

        /// <summary>
        /// Triggered when the delete button for a cell block is clicked.
        /// This removes it from the database and updates the treeview to show the changes.
        /// </summary>
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

        /// <summary>
        /// Triggered when the save button for a cell is clicked.
        /// This updates the database with the newly inserted material.
        /// </summary>
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

        /// <summary>
        /// Triggered when the reset button for a cell is clicked.
        /// This changes the data in the fields to the original data of the
        /// item selected in the tree view.
        /// </summary>
        private void buttonResetCell_Click(object sender, EventArgs e)
        {
            if (treeViewPrison.SelectedNode == null) return;
            Cell cell = FindCell(Convert.ToInt32(treeViewPrison.SelectedNode.Name));
            if (cell == null) return;
            PopulateCellDataPanel(cell);
        }

        /// <summary>
        /// Triggered when the delete button for a cell is clicked.
        /// This removes it from the database and updates the treeview to show the changes.
        /// </summary>
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

        /// <summary>
        /// Triggered when the type of a newly additing structure is changed.  The options for
        /// the combobox are 'Prison', 'Cell Block', and 'Cell'.  Depending on the selection,
        /// new fields are shown and some are removed.
        /// </summary>
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

        /// <summary>
        /// Triggered when a new prison is selected in the combobox.
        /// It populates the data in the cell block combobox based on the selected prison
        /// </summary>
        void comboBoxPrisonAddPrison_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPrisonAddCellBlock.DataSource = ((Prison)comboBoxPrisonAddPrison.SelectedItem).blocks;
            comboBoxPrisonAddCellBlock.DisplayMember = "name";
            comboBoxPrisonAddCellBlock.ValueMember = "id";
        }

        /// <summary>
        /// Adds a new prison, cellblock or cell to the database and checks for required fields.
        /// </summary>
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

        /// <summary>
        /// Triggered when the reset button is clicked, it calls the ResetPrisonAddTab() function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrisonAddClear_Click(object sender, EventArgs e)
        {
            ResetPrisonAddTab();
        }

        /// <summary>
        /// Removes all of the data that could be entered into the prison add tab
        /// by reseting them to their default values.
        /// </summary>
        void ResetPrisonAddTab()
        {
            comboBoxPrisonType.SelectedIndex = 0;
            textBoxPrisonAddLocation.Text = "";
            textBoxPrisonAddDescription.Text = "";
            textBoxPrisonAddName.Text = "";
        }

        #endregion

        #region Offense
        /// <summary>
        /// Triggered when the main offense panel's visible is changed.
        /// </summary>
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

        /// <summary>
        /// Populates the data of the listview based on the search criteria of the textboxes above it.
        /// </summary>
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
        /// <summary>
        /// Triggered when a new item is selected in the list box.
        /// </summary>
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

        /// <summary>
        /// Repopulates the listbox so that the search criteria may be applied.
        /// </summary>
        private void buttonOffenseSearch_Click(object sender, EventArgs e)
        {
            PopulateOffenseListView();
        }

        /// <summary>
        /// Deleted the selected offense  from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Triggered when the "New" or "Add" button is clicked on the offense view page.
        /// It the populates are removes data in the add tab datafields appropriated depending on
        /// if an offense is currently is selected or not. Then it switches tabs to the Add/Modify
        /// tab as to show the newly populated (or depopulated) fields.
        /// </summary>
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

        /// <summary>
        /// Triggered when the reset button is selected in the Add/Modify tab.
        /// Resets the data in the add tab to empty if there is not an offense selected in the listview,
        /// or to the selected offense's data.
        /// </summary>
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

        /// <summary>
        /// Triggered when the Add button is selected int he Add/Modify tab.
        /// Updates exising offenses, add new ones to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Triggered when the visibilty of the main account panel is changed.
        /// </summary>
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

        /// <summary>
        /// Triggered when the Reset button is clicked.
        /// This sets the data fields to the default values of the currently authenticated cataloger
        /// </summary>
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

        /// <summary>
        /// Triggered when the Save button is clicked.
        /// Updates the authenticated catalogers database entry with the entered data.  Verifies password requirements.
        /// </summary>
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

        /// <summary>
        /// Helper function that determines if an inputted password meets the system's minimum requirements.
        /// </summary>
        /// <param name="pWord">The password entered</param>
        /// <returns>True if meets requirements, false otherwise</returns>
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
