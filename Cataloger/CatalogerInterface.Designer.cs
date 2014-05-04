namespace Cataloger
{
    partial class CatalogerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMenuPrisoner = new System.Windows.Forms.Button();
            this.buttonMenuPrison = new System.Windows.Forms.Button();
            this.buttonMenuOffense = new System.Windows.Forms.Button();
            this.buttonMenuAccount = new System.Windows.Forms.Button();
            this.tabControlPrisoner = new System.Windows.Forms.TabControl();
            this.tabPrisonerSearch = new System.Windows.Forms.TabPage();
            this.listViewPrisonerSearch = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prisonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cellBlockName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cellNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrisonerId = new System.Windows.Forms.TextBox();
            this.textBoxPrisonerFname = new System.Windows.Forms.TextBox();
            this.textBoxPrisonerLname = new System.Windows.Forms.TextBox();
            this.textBoxPrisonerPrisonName = new System.Windows.Forms.TextBox();
            this.textBoxPrisonerBlockName = new System.Windows.Forms.TextBox();
            this.textBoxPrisonerCellName = new System.Windows.Forms.TextBox();
            this.buttonPrisonerSearch = new System.Windows.Forms.Button();
            this.buttonPrisonerDelete = new System.Windows.Forms.Button();
            this.buttonPrisonerNew = new System.Windows.Forms.Button();
            this.tabPrisonerAddEdit = new System.Windows.Forms.TabPage();
            this.textBoxPrisonerAddFname = new System.Windows.Forms.TextBox();
            this.textBoxPrisonerAddLname = new System.Windows.Forms.TextBox();
            this.datePickerAddPrisonerDob = new System.Windows.Forms.DateTimePicker();
            this.radioButtonPrisonerAddMale = new System.Windows.Forms.RadioButton();
            this.radioButtonPrisonerAddFemale = new System.Windows.Forms.RadioButton();
            this.comboBoxPrisonerAddPrison = new System.Windows.Forms.ComboBox();
            this.comboBoxPrisonerAddBlock = new System.Windows.Forms.ComboBox();
            this.comboBoxPrisonerAddCell = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrisonerAddAdd = new System.Windows.Forms.Button();
            this.buttonPrisonerAddReset = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMenuLogout = new System.Windows.Forms.Button();
            this.panelPrisoner = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOffense = new System.Windows.Forms.Panel();
            this.tabControlOffense = new System.Windows.Forms.TabControl();
            this.tabOffenseSearch = new System.Windows.Forms.TabPage();
            this.buttonOffenseDelete = new System.Windows.Forms.Button();
            this.buttonOffenseNew = new System.Windows.Forms.Button();
            this.textBoxOffenseDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewOffenses = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnfName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnlName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxOffenseId = new System.Windows.Forms.TextBox();
            this.textBoxOffensePrisonerFname = new System.Windows.Forms.TextBox();
            this.textBoxOffensePrisonerLname = new System.Windows.Forms.TextBox();
            this.textBoxOffenseType = new System.Windows.Forms.TextBox();
            this.textBoxOffenseLocation = new System.Windows.Forms.TextBox();
            this.textBoxOffenseDate = new System.Windows.Forms.TextBox();
            this.buttonOffenseSearch = new System.Windows.Forms.Button();
            this.tabOffenseAddEdit = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxOffenseEditPrisoners = new System.Windows.Forms.ListBox();
            this.textBoxOffenseEditType = new System.Windows.Forms.TextBox();
            this.buttonOffenseEditReset = new System.Windows.Forms.Button();
            this.buttonOffenseAddAdd = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxOffenseEditDescription = new System.Windows.Forms.TextBox();
            this.textBoxOffenseEditLocation = new System.Windows.Forms.TextBox();
            this.datePickerOffenseEditDate = new System.Windows.Forms.DateTimePicker();
            this.panelPrison = new System.Windows.Forms.Panel();
            this.tabControlPrison = new System.Windows.Forms.TabControl();
            this.tabPrisonViewModify = new System.Windows.Forms.TabPage();
            this.panelPrisonDetailsParent = new System.Windows.Forms.Panel();
            this.panelPrisonCellBlockDetails = new System.Windows.Forms.Panel();
            this.buttonDeleteCellBlock = new System.Windows.Forms.Button();
            this.buttonResetCellBlock = new System.Windows.Forms.Button();
            this.buttonSaveCellBlock = new System.Windows.Forms.Button();
            this.textBoxCellBlockDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCellBlockName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelPrisonCellDetails = new System.Windows.Forms.Panel();
            this.buttonDeleteCell = new System.Windows.Forms.Button();
            this.buttonResetCell = new System.Windows.Forms.Button();
            this.buttonSaveCell = new System.Windows.Forms.Button();
            this.textBoxCellDescription = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxCellName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panelPrisonPrisonDetails = new System.Windows.Forms.Panel();
            this.buttonDeletePrison = new System.Windows.Forms.Button();
            this.buttonResetPrison = new System.Windows.Forms.Button();
            this.buttonSavePrison = new System.Windows.Forms.Button();
            this.textBoxPrisonDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrisonLocation = new System.Windows.Forms.TextBox();
            this.textBoxPrisonName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelPrisonTreeView = new System.Windows.Forms.Panel();
            this.treeViewPrison = new System.Windows.Forms.TreeView();
            this.tabPrisonAdd = new System.Windows.Forms.TabPage();
            this.comboBoxPrisonAddCellBlock = new System.Windows.Forms.ComboBox();
            this.labelPrisonAddCellBlock = new System.Windows.Forms.Label();
            this.comboBoxPrisonAddPrison = new System.Windows.Forms.ComboBox();
            this.labelPrisonAddPrison = new System.Windows.Forms.Label();
            this.buttonPrisonAddClear = new System.Windows.Forms.Button();
            this.buttonPrisonAddAdd = new System.Windows.Forms.Button();
            this.textBoxPrisonAddDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrisonAddLocation = new System.Windows.Forms.TextBox();
            this.textBoxPrisonAddName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelPrisonAddLocation = new System.Windows.Forms.Label();
            this.labelPrisonAddName = new System.Windows.Forms.Label();
            this.comboBoxPrisonType = new System.Windows.Forms.ComboBox();
            this.labelSelectType = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.TextBoxAccountEmail = new System.Windows.Forms.TextBox();
            this.LabelAccountEmail = new System.Windows.Forms.Label();
            this.DateTimePickerAccountDOB = new System.Windows.Forms.DateTimePicker();
            this.LabelAccountDOB = new System.Windows.Forms.Label();
            this.LabelAccountSex = new System.Windows.Forms.Label();
            this.GroupBoxAccountSex = new System.Windows.Forms.GroupBox();
            this.RadioButtonAccountSexFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonAccountSexMale = new System.Windows.Forms.RadioButton();
            this.TextBoxAccountPassword = new System.Windows.Forms.TextBox();
            this.TextBoxAccountLName = new System.Windows.Forms.TextBox();
            this.TextBoxAccountFName = new System.Windows.Forms.TextBox();
            this.LabelAccountPassword = new System.Windows.Forms.Label();
            this.LabelAccountLName = new System.Windows.Forms.Label();
            this.LabelAccountFName = new System.Windows.Forms.Label();
            this.ButtonAccountSave = new System.Windows.Forms.Button();
            this.ButtonAccountReset = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControlPrisoner.SuspendLayout();
            this.tabPrisonerSearch.SuspendLayout();
            this.tabPrisonerAddEdit.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelPrisoner.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelOffense.SuspendLayout();
            this.tabControlOffense.SuspendLayout();
            this.tabOffenseSearch.SuspendLayout();
            this.tabOffenseAddEdit.SuspendLayout();
            this.panelPrison.SuspendLayout();
            this.tabControlPrison.SuspendLayout();
            this.tabPrisonViewModify.SuspendLayout();
            this.panelPrisonDetailsParent.SuspendLayout();
            this.panelPrisonCellBlockDetails.SuspendLayout();
            this.panelPrisonCellDetails.SuspendLayout();
            this.panelPrisonPrisonDetails.SuspendLayout();
            this.panelPrisonTreeView.SuspendLayout();
            this.tabPrisonAdd.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.GroupBoxAccountSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMenuPrisoner
            // 
            this.buttonMenuPrisoner.Location = new System.Drawing.Point(3, 3);
            this.buttonMenuPrisoner.Name = "buttonMenuPrisoner";
            this.buttonMenuPrisoner.Size = new System.Drawing.Size(106, 42);
            this.buttonMenuPrisoner.TabIndex = 1;
            this.buttonMenuPrisoner.Text = "Prisoner";
            this.buttonMenuPrisoner.UseVisualStyleBackColor = true;
            this.buttonMenuPrisoner.Click += new System.EventHandler(this.buttonMenuPrisoner_Click);
            // 
            // buttonMenuPrison
            // 
            this.buttonMenuPrison.Location = new System.Drawing.Point(3, 51);
            this.buttonMenuPrison.Name = "buttonMenuPrison";
            this.buttonMenuPrison.Size = new System.Drawing.Size(106, 42);
            this.buttonMenuPrison.TabIndex = 2;
            this.buttonMenuPrison.Text = "Prison";
            this.buttonMenuPrison.UseVisualStyleBackColor = true;
            this.buttonMenuPrison.Click += new System.EventHandler(this.buttonMenuPrison_Click);
            // 
            // buttonMenuOffense
            // 
            this.buttonMenuOffense.Location = new System.Drawing.Point(3, 99);
            this.buttonMenuOffense.Name = "buttonMenuOffense";
            this.buttonMenuOffense.Size = new System.Drawing.Size(106, 42);
            this.buttonMenuOffense.TabIndex = 3;
            this.buttonMenuOffense.Text = "Offense";
            this.buttonMenuOffense.UseVisualStyleBackColor = true;
            this.buttonMenuOffense.Click += new System.EventHandler(this.buttonMenuOffense_Click);
            // 
            // buttonMenuAccount
            // 
            this.buttonMenuAccount.Location = new System.Drawing.Point(3, 147);
            this.buttonMenuAccount.Name = "buttonMenuAccount";
            this.buttonMenuAccount.Size = new System.Drawing.Size(106, 42);
            this.buttonMenuAccount.TabIndex = 2;
            this.buttonMenuAccount.Text = "My Account";
            this.buttonMenuAccount.UseVisualStyleBackColor = true;
            this.buttonMenuAccount.Click += new System.EventHandler(this.buttonMenuAccount_Click);
            // 
            // tabControlPrisoner
            // 
            this.tabControlPrisoner.Controls.Add(this.tabPrisonerSearch);
            this.tabControlPrisoner.Controls.Add(this.tabPrisonerAddEdit);
            this.tabControlPrisoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrisoner.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrisoner.Name = "tabControlPrisoner";
            this.tabControlPrisoner.SelectedIndex = 0;
            this.tabControlPrisoner.Size = new System.Drawing.Size(845, 496);
            this.tabControlPrisoner.TabIndex = 6;
            // 
            // tabPrisonerSearch
            // 
            this.tabPrisonerSearch.Controls.Add(this.listViewPrisonerSearch);
            this.tabPrisonerSearch.Controls.Add(this.textBoxPrisonerId);
            this.tabPrisonerSearch.Controls.Add(this.textBoxPrisonerFname);
            this.tabPrisonerSearch.Controls.Add(this.textBoxPrisonerLname);
            this.tabPrisonerSearch.Controls.Add(this.textBoxPrisonerPrisonName);
            this.tabPrisonerSearch.Controls.Add(this.textBoxPrisonerBlockName);
            this.tabPrisonerSearch.Controls.Add(this.textBoxPrisonerCellName);
            this.tabPrisonerSearch.Controls.Add(this.buttonPrisonerSearch);
            this.tabPrisonerSearch.Controls.Add(this.buttonPrisonerDelete);
            this.tabPrisonerSearch.Controls.Add(this.buttonPrisonerNew);
            this.tabPrisonerSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPrisonerSearch.Name = "tabPrisonerSearch";
            this.tabPrisonerSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrisonerSearch.Size = new System.Drawing.Size(837, 470);
            this.tabPrisonerSearch.TabIndex = 0;
            this.tabPrisonerSearch.Text = "Search";
            this.tabPrisonerSearch.UseVisualStyleBackColor = true;
            // 
            // listViewPrisonerSearch
            // 
            this.listViewPrisonerSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.fName,
            this.lName,
            this.prisonName,
            this.cellBlockName,
            this.cellNumber});
            this.listViewPrisonerSearch.FullRowSelect = true;
            this.listViewPrisonerSearch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPrisonerSearch.Location = new System.Drawing.Point(20, 67);
            this.listViewPrisonerSearch.MultiSelect = false;
            this.listViewPrisonerSearch.Name = "listViewPrisonerSearch";
            this.listViewPrisonerSearch.Size = new System.Drawing.Size(798, 367);
            this.listViewPrisonerSearch.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPrisonerSearch.TabIndex = 17;
            this.listViewPrisonerSearch.UseCompatibleStateImageBehavior = false;
            this.listViewPrisonerSearch.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 133;
            // 
            // fName
            // 
            this.fName.Text = "First Name";
            this.fName.Width = 133;
            // 
            // lName
            // 
            this.lName.Text = "Last Name";
            this.lName.Width = 133;
            // 
            // prisonName
            // 
            this.prisonName.Text = "Prison";
            this.prisonName.Width = 133;
            // 
            // cellBlockName
            // 
            this.cellBlockName.Text = "Cell Block";
            this.cellBlockName.Width = 133;
            // 
            // cellNumber
            // 
            this.cellNumber.Text = "Cell";
            this.cellNumber.Width = 129;
            // 
            // textBoxPrisonerId
            // 
            this.textBoxPrisonerId.Location = new System.Drawing.Point(20, 41);
            this.textBoxPrisonerId.Name = "textBoxPrisonerId";
            this.textBoxPrisonerId.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrisonerId.TabIndex = 12;
            // 
            // textBoxPrisonerFname
            // 
            this.textBoxPrisonerFname.Location = new System.Drawing.Point(154, 41);
            this.textBoxPrisonerFname.Name = "textBoxPrisonerFname";
            this.textBoxPrisonerFname.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrisonerFname.TabIndex = 11;
            // 
            // textBoxPrisonerLname
            // 
            this.textBoxPrisonerLname.Location = new System.Drawing.Point(288, 41);
            this.textBoxPrisonerLname.Name = "textBoxPrisonerLname";
            this.textBoxPrisonerLname.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrisonerLname.TabIndex = 13;
            // 
            // textBoxPrisonerPrisonName
            // 
            this.textBoxPrisonerPrisonName.Location = new System.Drawing.Point(422, 41);
            this.textBoxPrisonerPrisonName.Name = "textBoxPrisonerPrisonName";
            this.textBoxPrisonerPrisonName.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrisonerPrisonName.TabIndex = 14;
            // 
            // textBoxPrisonerBlockName
            // 
            this.textBoxPrisonerBlockName.Location = new System.Drawing.Point(556, 41);
            this.textBoxPrisonerBlockName.Name = "textBoxPrisonerBlockName";
            this.textBoxPrisonerBlockName.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrisonerBlockName.TabIndex = 15;
            // 
            // textBoxPrisonerCellName
            // 
            this.textBoxPrisonerCellName.Location = new System.Drawing.Point(690, 41);
            this.textBoxPrisonerCellName.Name = "textBoxPrisonerCellName";
            this.textBoxPrisonerCellName.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrisonerCellName.TabIndex = 16;
            // 
            // buttonPrisonerSearch
            // 
            this.buttonPrisonerSearch.Location = new System.Drawing.Point(743, 12);
            this.buttonPrisonerSearch.Name = "buttonPrisonerSearch";
            this.buttonPrisonerSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonerSearch.TabIndex = 9;
            this.buttonPrisonerSearch.Text = "Search";
            this.buttonPrisonerSearch.UseVisualStyleBackColor = true;
            this.buttonPrisonerSearch.Click += new System.EventHandler(this.buttonPrisonerSearch_Click);
            // 
            // buttonPrisonerDelete
            // 
            this.buttonPrisonerDelete.Location = new System.Drawing.Point(662, 441);
            this.buttonPrisonerDelete.Name = "buttonPrisonerDelete";
            this.buttonPrisonerDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonerDelete.TabIndex = 6;
            this.buttonPrisonerDelete.Text = "Delete";
            this.buttonPrisonerDelete.UseVisualStyleBackColor = true;
            this.buttonPrisonerDelete.Click += new System.EventHandler(this.buttonPrisonerDelete_Click);
            // 
            // buttonPrisonerNew
            // 
            this.buttonPrisonerNew.Location = new System.Drawing.Point(743, 441);
            this.buttonPrisonerNew.Name = "buttonPrisonerNew";
            this.buttonPrisonerNew.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonerNew.TabIndex = 7;
            this.buttonPrisonerNew.Text = "New";
            this.buttonPrisonerNew.UseVisualStyleBackColor = true;
            this.buttonPrisonerNew.Click += new System.EventHandler(this.buttonPrisonerNew_Click);
            // 
            // tabPrisonerAddEdit
            // 
            this.tabPrisonerAddEdit.Controls.Add(this.textBoxPrisonerAddFname);
            this.tabPrisonerAddEdit.Controls.Add(this.textBoxPrisonerAddLname);
            this.tabPrisonerAddEdit.Controls.Add(this.datePickerAddPrisonerDob);
            this.tabPrisonerAddEdit.Controls.Add(this.radioButtonPrisonerAddMale);
            this.tabPrisonerAddEdit.Controls.Add(this.radioButtonPrisonerAddFemale);
            this.tabPrisonerAddEdit.Controls.Add(this.comboBoxPrisonerAddPrison);
            this.tabPrisonerAddEdit.Controls.Add(this.comboBoxPrisonerAddBlock);
            this.tabPrisonerAddEdit.Controls.Add(this.comboBoxPrisonerAddCell);
            this.tabPrisonerAddEdit.Controls.Add(this.label7);
            this.tabPrisonerAddEdit.Controls.Add(this.label6);
            this.tabPrisonerAddEdit.Controls.Add(this.label5);
            this.tabPrisonerAddEdit.Controls.Add(this.label4);
            this.tabPrisonerAddEdit.Controls.Add(this.label3);
            this.tabPrisonerAddEdit.Controls.Add(this.label2);
            this.tabPrisonerAddEdit.Controls.Add(this.label1);
            this.tabPrisonerAddEdit.Controls.Add(this.buttonPrisonerAddAdd);
            this.tabPrisonerAddEdit.Controls.Add(this.buttonPrisonerAddReset);
            this.tabPrisonerAddEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPrisonerAddEdit.Name = "tabPrisonerAddEdit";
            this.tabPrisonerAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrisonerAddEdit.Size = new System.Drawing.Size(837, 470);
            this.tabPrisonerAddEdit.TabIndex = 1;
            this.tabPrisonerAddEdit.Text = "Add/Edit";
            this.tabPrisonerAddEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxPrisonerAddFname
            // 
            this.textBoxPrisonerAddFname.Location = new System.Drawing.Point(120, 57);
            this.textBoxPrisonerAddFname.Name = "textBoxPrisonerAddFname";
            this.textBoxPrisonerAddFname.Size = new System.Drawing.Size(218, 20);
            this.textBoxPrisonerAddFname.TabIndex = 1;
            // 
            // textBoxPrisonerAddLname
            // 
            this.textBoxPrisonerAddLname.Location = new System.Drawing.Point(120, 101);
            this.textBoxPrisonerAddLname.Name = "textBoxPrisonerAddLname";
            this.textBoxPrisonerAddLname.Size = new System.Drawing.Size(218, 20);
            this.textBoxPrisonerAddLname.TabIndex = 3;
            // 
            // datePickerAddPrisonerDob
            // 
            this.datePickerAddPrisonerDob.Location = new System.Drawing.Point(485, 54);
            this.datePickerAddPrisonerDob.Name = "datePickerAddPrisonerDob";
            this.datePickerAddPrisonerDob.Size = new System.Drawing.Size(218, 20);
            this.datePickerAddPrisonerDob.TabIndex = 15;
            // 
            // radioButtonPrisonerAddMale
            // 
            this.radioButtonPrisonerAddMale.AutoSize = true;
            this.radioButtonPrisonerAddMale.Location = new System.Drawing.Point(485, 99);
            this.radioButtonPrisonerAddMale.Name = "radioButtonPrisonerAddMale";
            this.radioButtonPrisonerAddMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonPrisonerAddMale.TabIndex = 16;
            this.radioButtonPrisonerAddMale.TabStop = true;
            this.radioButtonPrisonerAddMale.Text = "Male";
            this.radioButtonPrisonerAddMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrisonerAddFemale
            // 
            this.radioButtonPrisonerAddFemale.AutoSize = true;
            this.radioButtonPrisonerAddFemale.Location = new System.Drawing.Point(485, 122);
            this.radioButtonPrisonerAddFemale.Name = "radioButtonPrisonerAddFemale";
            this.radioButtonPrisonerAddFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonPrisonerAddFemale.TabIndex = 17;
            this.radioButtonPrisonerAddFemale.TabStop = true;
            this.radioButtonPrisonerAddFemale.Text = "Female";
            this.radioButtonPrisonerAddFemale.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrisonerAddPrison
            // 
            this.comboBoxPrisonerAddPrison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrisonerAddPrison.FormattingEnabled = true;
            this.comboBoxPrisonerAddPrison.Location = new System.Drawing.Point(97, 240);
            this.comboBoxPrisonerAddPrison.Name = "comboBoxPrisonerAddPrison";
            this.comboBoxPrisonerAddPrison.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPrisonerAddPrison.TabIndex = 14;
            // 
            // comboBoxPrisonerAddBlock
            // 
            this.comboBoxPrisonerAddBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrisonerAddBlock.FormattingEnabled = true;
            this.comboBoxPrisonerAddBlock.Location = new System.Drawing.Point(344, 240);
            this.comboBoxPrisonerAddBlock.Name = "comboBoxPrisonerAddBlock";
            this.comboBoxPrisonerAddBlock.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPrisonerAddBlock.TabIndex = 19;
            // 
            // comboBoxPrisonerAddCell
            // 
            this.comboBoxPrisonerAddCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrisonerAddCell.FormattingEnabled = true;
            this.comboBoxPrisonerAddCell.Location = new System.Drawing.Point(561, 240);
            this.comboBoxPrisonerAddCell.Name = "comboBoxPrisonerAddCell";
            this.comboBoxPrisonerAddCell.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPrisonerAddCell.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cell:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cell Block:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prison:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // buttonPrisonerAddAdd
            // 
            this.buttonPrisonerAddAdd.Location = new System.Drawing.Point(756, 441);
            this.buttonPrisonerAddAdd.Name = "buttonPrisonerAddAdd";
            this.buttonPrisonerAddAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonerAddAdd.TabIndex = 10;
            this.buttonPrisonerAddAdd.Text = "Add";
            this.buttonPrisonerAddAdd.UseVisualStyleBackColor = true;
            this.buttonPrisonerAddAdd.Click += new System.EventHandler(this.buttonPrisonerAddAdd_Click);
            // 
            // buttonPrisonerAddReset
            // 
            this.buttonPrisonerAddReset.Location = new System.Drawing.Point(675, 441);
            this.buttonPrisonerAddReset.Name = "buttonPrisonerAddReset";
            this.buttonPrisonerAddReset.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonerAddReset.TabIndex = 9;
            this.buttonPrisonerAddReset.Text = "Reset";
            this.buttonPrisonerAddReset.UseVisualStyleBackColor = true;
            this.buttonPrisonerAddReset.Click += new System.EventHandler(this.buttonPrisonerAddReset_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonMenuLogout);
            this.panelMenu.Controls.Add(this.buttonMenuPrisoner);
            this.panelMenu.Controls.Add(this.buttonMenuPrison);
            this.panelMenu.Controls.Add(this.buttonMenuOffense);
            this.panelMenu.Controls.Add(this.buttonMenuAccount);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(112, 496);
            this.panelMenu.TabIndex = 7;
            // 
            // buttonMenuLogout
            // 
            this.buttonMenuLogout.Location = new System.Drawing.Point(3, 451);
            this.buttonMenuLogout.Name = "buttonMenuLogout";
            this.buttonMenuLogout.Size = new System.Drawing.Size(106, 42);
            this.buttonMenuLogout.TabIndex = 4;
            this.buttonMenuLogout.Text = "Logout";
            this.buttonMenuLogout.UseVisualStyleBackColor = true;
            this.buttonMenuLogout.Click += new System.EventHandler(this.buttonMenuLogout_Click);
            // 
            // panelPrisoner
            // 
            this.panelPrisoner.Controls.Add(this.tabControlPrisoner);
            this.panelPrisoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrisoner.Location = new System.Drawing.Point(0, 0);
            this.panelPrisoner.Name = "panelPrisoner";
            this.panelPrisoner.Size = new System.Drawing.Size(845, 496);
            this.panelPrisoner.TabIndex = 8;
            this.panelPrisoner.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelPrison);
            this.panelMain.Controls.Add(this.panelOffense);
            this.panelMain.Controls.Add(this.panelPrisoner);
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Location = new System.Drawing.Point(131, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(845, 496);
            this.panelMain.TabIndex = 17;
            // 
            // panelOffense
            // 
            this.panelOffense.Controls.Add(this.tabControlOffense);
            this.panelOffense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOffense.Location = new System.Drawing.Point(0, 0);
            this.panelOffense.Name = "panelOffense";
            this.panelOffense.Size = new System.Drawing.Size(845, 496);
            this.panelOffense.TabIndex = 0;
            this.panelOffense.Visible = false;
            // 
            // tabControlOffense
            // 
            this.tabControlOffense.Controls.Add(this.tabOffenseSearch);
            this.tabControlOffense.Controls.Add(this.tabOffenseAddEdit);
            this.tabControlOffense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOffense.Location = new System.Drawing.Point(0, 0);
            this.tabControlOffense.Name = "tabControlOffense";
            this.tabControlOffense.SelectedIndex = 0;
            this.tabControlOffense.Size = new System.Drawing.Size(845, 496);
            this.tabControlOffense.TabIndex = 0;
            // 
            // tabOffenseSearch
            // 
            this.tabOffenseSearch.Controls.Add(this.buttonOffenseDelete);
            this.tabOffenseSearch.Controls.Add(this.buttonOffenseNew);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffenseDescription);
            this.tabOffenseSearch.Controls.Add(this.label9);
            this.tabOffenseSearch.Controls.Add(this.listViewOffenses);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffenseId);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffensePrisonerFname);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffensePrisonerLname);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffenseType);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffenseLocation);
            this.tabOffenseSearch.Controls.Add(this.textBoxOffenseDate);
            this.tabOffenseSearch.Controls.Add(this.buttonOffenseSearch);
            this.tabOffenseSearch.Location = new System.Drawing.Point(4, 22);
            this.tabOffenseSearch.Name = "tabOffenseSearch";
            this.tabOffenseSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabOffenseSearch.Size = new System.Drawing.Size(837, 470);
            this.tabOffenseSearch.TabIndex = 0;
            this.tabOffenseSearch.Text = "Search";
            this.tabOffenseSearch.UseVisualStyleBackColor = true;
            // 
            // buttonOffenseDelete
            // 
            this.buttonOffenseDelete.Location = new System.Drawing.Point(675, 444);
            this.buttonOffenseDelete.Name = "buttonOffenseDelete";
            this.buttonOffenseDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonOffenseDelete.TabIndex = 29;
            this.buttonOffenseDelete.Text = "Delete";
            this.buttonOffenseDelete.UseVisualStyleBackColor = true;
            this.buttonOffenseDelete.Click += new System.EventHandler(this.buttonOffenseDelete_Click);
            // 
            // buttonOffenseNew
            // 
            this.buttonOffenseNew.Location = new System.Drawing.Point(756, 444);
            this.buttonOffenseNew.Name = "buttonOffenseNew";
            this.buttonOffenseNew.Size = new System.Drawing.Size(75, 23);
            this.buttonOffenseNew.TabIndex = 28;
            this.buttonOffenseNew.Text = "New";
            this.buttonOffenseNew.UseVisualStyleBackColor = true;
            this.buttonOffenseNew.Click += new System.EventHandler(this.buttonOffenseNew_Click);
            // 
            // textBoxOffenseDescription
            // 
            this.textBoxOffenseDescription.Location = new System.Drawing.Point(70, 385);
            this.textBoxOffenseDescription.Multiline = true;
            this.textBoxOffenseDescription.Name = "textBoxOffenseDescription";
            this.textBoxOffenseDescription.ReadOnly = true;
            this.textBoxOffenseDescription.Size = new System.Drawing.Size(437, 79);
            this.textBoxOffenseDescription.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Description:";
            // 
            // listViewOffenses
            // 
            this.listViewOffenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnfName,
            this.columnlName,
            this.columnType,
            this.columnLocation,
            this.columnDate});
            this.listViewOffenses.FullRowSelect = true;
            this.listViewOffenses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOffenses.Location = new System.Drawing.Point(20, 67);
            this.listViewOffenses.MultiSelect = false;
            this.listViewOffenses.Name = "listViewOffenses";
            this.listViewOffenses.Size = new System.Drawing.Size(798, 312);
            this.listViewOffenses.TabIndex = 25;
            this.listViewOffenses.UseCompatibleStateImageBehavior = false;
            this.listViewOffenses.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Offense ID";
            this.columnId.Width = 133;
            // 
            // columnfName
            // 
            this.columnfName.Text = "First Name";
            this.columnfName.Width = 133;
            // 
            // columnlName
            // 
            this.columnlName.Text = "Last Name";
            this.columnlName.Width = 133;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 133;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.Width = 133;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 129;
            // 
            // textBoxOffenseId
            // 
            this.textBoxOffenseId.Location = new System.Drawing.Point(20, 41);
            this.textBoxOffenseId.Name = "textBoxOffenseId";
            this.textBoxOffenseId.Size = new System.Drawing.Size(128, 20);
            this.textBoxOffenseId.TabIndex = 20;
            // 
            // textBoxOffensePrisonerFname
            // 
            this.textBoxOffensePrisonerFname.Location = new System.Drawing.Point(154, 41);
            this.textBoxOffensePrisonerFname.Name = "textBoxOffensePrisonerFname";
            this.textBoxOffensePrisonerFname.Size = new System.Drawing.Size(128, 20);
            this.textBoxOffensePrisonerFname.TabIndex = 19;
            // 
            // textBoxOffensePrisonerLname
            // 
            this.textBoxOffensePrisonerLname.Location = new System.Drawing.Point(288, 41);
            this.textBoxOffensePrisonerLname.Name = "textBoxOffensePrisonerLname";
            this.textBoxOffensePrisonerLname.Size = new System.Drawing.Size(128, 20);
            this.textBoxOffensePrisonerLname.TabIndex = 21;
            // 
            // textBoxOffenseType
            // 
            this.textBoxOffenseType.Location = new System.Drawing.Point(422, 41);
            this.textBoxOffenseType.Name = "textBoxOffenseType";
            this.textBoxOffenseType.Size = new System.Drawing.Size(128, 20);
            this.textBoxOffenseType.TabIndex = 22;
            // 
            // textBoxOffenseLocation
            // 
            this.textBoxOffenseLocation.Location = new System.Drawing.Point(556, 41);
            this.textBoxOffenseLocation.Name = "textBoxOffenseLocation";
            this.textBoxOffenseLocation.Size = new System.Drawing.Size(128, 20);
            this.textBoxOffenseLocation.TabIndex = 23;
            // 
            // textBoxOffenseDate
            // 
            this.textBoxOffenseDate.Location = new System.Drawing.Point(689, 41);
            this.textBoxOffenseDate.Name = "textBoxOffenseDate";
            this.textBoxOffenseDate.Size = new System.Drawing.Size(128, 20);
            this.textBoxOffenseDate.TabIndex = 24;
            // 
            // buttonOffenseSearch
            // 
            this.buttonOffenseSearch.Location = new System.Drawing.Point(742, 12);
            this.buttonOffenseSearch.Name = "buttonOffenseSearch";
            this.buttonOffenseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonOffenseSearch.TabIndex = 18;
            this.buttonOffenseSearch.Text = "Search";
            this.buttonOffenseSearch.UseVisualStyleBackColor = true;
            this.buttonOffenseSearch.Click += new System.EventHandler(this.buttonOffenseSearch_Click);
            // 
            // tabOffenseAddEdit
            // 
            this.tabOffenseAddEdit.Controls.Add(this.label8);
            this.tabOffenseAddEdit.Controls.Add(this.listBoxOffenseEditPrisoners);
            this.tabOffenseAddEdit.Controls.Add(this.textBoxOffenseEditType);
            this.tabOffenseAddEdit.Controls.Add(this.buttonOffenseEditReset);
            this.tabOffenseAddEdit.Controls.Add(this.buttonOffenseAddAdd);
            this.tabOffenseAddEdit.Controls.Add(this.label28);
            this.tabOffenseAddEdit.Controls.Add(this.label27);
            this.tabOffenseAddEdit.Controls.Add(this.label26);
            this.tabOffenseAddEdit.Controls.Add(this.label25);
            this.tabOffenseAddEdit.Controls.Add(this.textBoxOffenseEditDescription);
            this.tabOffenseAddEdit.Controls.Add(this.textBoxOffenseEditLocation);
            this.tabOffenseAddEdit.Controls.Add(this.datePickerOffenseEditDate);
            this.tabOffenseAddEdit.Location = new System.Drawing.Point(4, 22);
            this.tabOffenseAddEdit.Name = "tabOffenseAddEdit";
            this.tabOffenseAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabOffenseAddEdit.Size = new System.Drawing.Size(837, 470);
            this.tabOffenseAddEdit.TabIndex = 1;
            this.tabOffenseAddEdit.Text = "Add/Edit";
            this.tabOffenseAddEdit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Prisoners";
            // 
            // listBoxOffenseEditPrisoners
            // 
            this.listBoxOffenseEditPrisoners.FormattingEnabled = true;
            this.listBoxOffenseEditPrisoners.Location = new System.Drawing.Point(6, 32);
            this.listBoxOffenseEditPrisoners.Name = "listBoxOffenseEditPrisoners";
            this.listBoxOffenseEditPrisoners.Size = new System.Drawing.Size(200, 433);
            this.listBoxOffenseEditPrisoners.TabIndex = 11;
            // 
            // textBoxOffenseEditType
            // 
            this.textBoxOffenseEditType.Location = new System.Drawing.Point(316, 32);
            this.textBoxOffenseEditType.Name = "textBoxOffenseEditType";
            this.textBoxOffenseEditType.Size = new System.Drawing.Size(340, 20);
            this.textBoxOffenseEditType.TabIndex = 10;
            // 
            // buttonOffenseEditReset
            // 
            this.buttonOffenseEditReset.Location = new System.Drawing.Point(675, 441);
            this.buttonOffenseEditReset.Name = "buttonOffenseEditReset";
            this.buttonOffenseEditReset.Size = new System.Drawing.Size(75, 23);
            this.buttonOffenseEditReset.TabIndex = 9;
            this.buttonOffenseEditReset.Text = "Reset";
            this.buttonOffenseEditReset.UseVisualStyleBackColor = true;
            this.buttonOffenseEditReset.Click += new System.EventHandler(this.buttonOffenseEditReset_Click);
            // 
            // buttonOffenseAddAdd
            // 
            this.buttonOffenseAddAdd.Location = new System.Drawing.Point(756, 441);
            this.buttonOffenseAddAdd.Name = "buttonOffenseAddAdd";
            this.buttonOffenseAddAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonOffenseAddAdd.TabIndex = 8;
            this.buttonOffenseAddAdd.Text = "Save";
            this.buttonOffenseAddAdd.UseVisualStyleBackColor = true;
            this.buttonOffenseAddAdd.Click += new System.EventHandler(this.buttonOffenseAddAdd_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(247, 113);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 7;
            this.label28.Text = "Description:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(259, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "Location:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(277, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Date:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(276, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Type:";
            // 
            // textBoxOffenseEditDescription
            // 
            this.textBoxOffenseEditDescription.Location = new System.Drawing.Point(316, 110);
            this.textBoxOffenseEditDescription.Multiline = true;
            this.textBoxOffenseEditDescription.Name = "textBoxOffenseEditDescription";
            this.textBoxOffenseEditDescription.Size = new System.Drawing.Size(342, 131);
            this.textBoxOffenseEditDescription.TabIndex = 3;
            // 
            // textBoxOffenseEditLocation
            // 
            this.textBoxOffenseEditLocation.Location = new System.Drawing.Point(315, 84);
            this.textBoxOffenseEditLocation.Name = "textBoxOffenseEditLocation";
            this.textBoxOffenseEditLocation.Size = new System.Drawing.Size(341, 20);
            this.textBoxOffenseEditLocation.TabIndex = 2;
            // 
            // datePickerOffenseEditDate
            // 
            this.datePickerOffenseEditDate.Location = new System.Drawing.Point(315, 59);
            this.datePickerOffenseEditDate.Name = "datePickerOffenseEditDate";
            this.datePickerOffenseEditDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerOffenseEditDate.TabIndex = 1;
            // 
            // panelPrison
            // 
            this.panelPrison.Controls.Add(this.tabControlPrison);
            this.panelPrison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrison.Location = new System.Drawing.Point(0, 0);
            this.panelPrison.Name = "panelPrison";
            this.panelPrison.Size = new System.Drawing.Size(845, 496);
            this.panelPrison.TabIndex = 11;
            this.panelPrison.Visible = false;
            // 
            // tabControlPrison
            // 
            this.tabControlPrison.Controls.Add(this.tabPrisonViewModify);
            this.tabControlPrison.Controls.Add(this.tabPrisonAdd);
            this.tabControlPrison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrison.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrison.Name = "tabControlPrison";
            this.tabControlPrison.SelectedIndex = 0;
            this.tabControlPrison.Size = new System.Drawing.Size(845, 496);
            this.tabControlPrison.TabIndex = 0;
            // 
            // tabPrisonViewModify
            // 
            this.tabPrisonViewModify.Controls.Add(this.label18);
            this.tabPrisonViewModify.Controls.Add(this.panelPrisonDetailsParent);
            this.tabPrisonViewModify.Controls.Add(this.panelPrisonTreeView);
            this.tabPrisonViewModify.Location = new System.Drawing.Point(4, 22);
            this.tabPrisonViewModify.Name = "tabPrisonViewModify";
            this.tabPrisonViewModify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrisonViewModify.Size = new System.Drawing.Size(837, 470);
            this.tabPrisonViewModify.TabIndex = 0;
            this.tabPrisonViewModify.Text = "View and Modify";
            this.tabPrisonViewModify.UseVisualStyleBackColor = true;
            // 
            // panelPrisonDetailsParent
            // 
            this.panelPrisonDetailsParent.Controls.Add(this.panelPrisonCellBlockDetails);
            this.panelPrisonDetailsParent.Controls.Add(this.panelPrisonCellDetails);
            this.panelPrisonDetailsParent.Controls.Add(this.panelPrisonPrisonDetails);
            this.panelPrisonDetailsParent.Location = new System.Drawing.Point(216, 32);
            this.panelPrisonDetailsParent.Name = "panelPrisonDetailsParent";
            this.panelPrisonDetailsParent.Size = new System.Drawing.Size(615, 432);
            this.panelPrisonDetailsParent.TabIndex = 3;
            // 
            // panelPrisonCellBlockDetails
            // 
            this.panelPrisonCellBlockDetails.Controls.Add(this.buttonDeleteCellBlock);
            this.panelPrisonCellBlockDetails.Controls.Add(this.buttonResetCellBlock);
            this.panelPrisonCellBlockDetails.Controls.Add(this.buttonSaveCellBlock);
            this.panelPrisonCellBlockDetails.Controls.Add(this.textBoxCellBlockDescription);
            this.panelPrisonCellBlockDetails.Controls.Add(this.label14);
            this.panelPrisonCellBlockDetails.Controls.Add(this.textBoxCellBlockName);
            this.panelPrisonCellBlockDetails.Controls.Add(this.label16);
            this.panelPrisonCellBlockDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrisonCellBlockDetails.Location = new System.Drawing.Point(0, 0);
            this.panelPrisonCellBlockDetails.Name = "panelPrisonCellBlockDetails";
            this.panelPrisonCellBlockDetails.Size = new System.Drawing.Size(615, 432);
            this.panelPrisonCellBlockDetails.TabIndex = 1;
            this.panelPrisonCellBlockDetails.Visible = false;
            // 
            // buttonDeleteCellBlock
            // 
            this.buttonDeleteCellBlock.Location = new System.Drawing.Point(375, 406);
            this.buttonDeleteCellBlock.Name = "buttonDeleteCellBlock";
            this.buttonDeleteCellBlock.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCellBlock.TabIndex = 18;
            this.buttonDeleteCellBlock.Text = "Delete";
            this.buttonDeleteCellBlock.UseVisualStyleBackColor = true;
            this.buttonDeleteCellBlock.Click += new System.EventHandler(this.buttonDeleteCellBlock_Click);
            // 
            // buttonResetCellBlock
            // 
            this.buttonResetCellBlock.Location = new System.Drawing.Point(456, 406);
            this.buttonResetCellBlock.Name = "buttonResetCellBlock";
            this.buttonResetCellBlock.Size = new System.Drawing.Size(75, 23);
            this.buttonResetCellBlock.TabIndex = 17;
            this.buttonResetCellBlock.Text = "Reset";
            this.buttonResetCellBlock.UseVisualStyleBackColor = true;
            this.buttonResetCellBlock.Click += new System.EventHandler(this.buttonResetCellBlock_Click);
            // 
            // buttonSaveCellBlock
            // 
            this.buttonSaveCellBlock.Location = new System.Drawing.Point(537, 406);
            this.buttonSaveCellBlock.Name = "buttonSaveCellBlock";
            this.buttonSaveCellBlock.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCellBlock.TabIndex = 16;
            this.buttonSaveCellBlock.Text = "Save";
            this.buttonSaveCellBlock.UseVisualStyleBackColor = true;
            this.buttonSaveCellBlock.Click += new System.EventHandler(this.buttonSaveCellBlock_Click);
            // 
            // textBoxCellBlockDescription
            // 
            this.textBoxCellBlockDescription.Location = new System.Drawing.Point(94, 48);
            this.textBoxCellBlockDescription.Multiline = true;
            this.textBoxCellBlockDescription.Name = "textBoxCellBlockDescription";
            this.textBoxCellBlockDescription.Size = new System.Drawing.Size(480, 158);
            this.textBoxCellBlockDescription.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Description:";
            // 
            // textBoxCellBlockName
            // 
            this.textBoxCellBlockName.Location = new System.Drawing.Point(94, 22);
            this.textBoxCellBlockName.Name = "textBoxCellBlockName";
            this.textBoxCellBlockName.Size = new System.Drawing.Size(204, 20);
            this.textBoxCellBlockName.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Name:";
            // 
            // panelPrisonCellDetails
            // 
            this.panelPrisonCellDetails.Controls.Add(this.buttonDeleteCell);
            this.panelPrisonCellDetails.Controls.Add(this.buttonResetCell);
            this.panelPrisonCellDetails.Controls.Add(this.buttonSaveCell);
            this.panelPrisonCellDetails.Controls.Add(this.textBoxCellDescription);
            this.panelPrisonCellDetails.Controls.Add(this.label15);
            this.panelPrisonCellDetails.Controls.Add(this.textBoxCellName);
            this.panelPrisonCellDetails.Controls.Add(this.label13);
            this.panelPrisonCellDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrisonCellDetails.Location = new System.Drawing.Point(0, 0);
            this.panelPrisonCellDetails.Name = "panelPrisonCellDetails";
            this.panelPrisonCellDetails.Size = new System.Drawing.Size(615, 432);
            this.panelPrisonCellDetails.TabIndex = 2;
            this.panelPrisonCellDetails.Visible = false;
            // 
            // buttonDeleteCell
            // 
            this.buttonDeleteCell.Location = new System.Drawing.Point(375, 406);
            this.buttonDeleteCell.Name = "buttonDeleteCell";
            this.buttonDeleteCell.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCell.TabIndex = 11;
            this.buttonDeleteCell.Text = "Delete";
            this.buttonDeleteCell.UseVisualStyleBackColor = true;
            this.buttonDeleteCell.Click += new System.EventHandler(this.buttonDeleteCell_Click);
            // 
            // buttonResetCell
            // 
            this.buttonResetCell.Location = new System.Drawing.Point(456, 406);
            this.buttonResetCell.Name = "buttonResetCell";
            this.buttonResetCell.Size = new System.Drawing.Size(75, 23);
            this.buttonResetCell.TabIndex = 10;
            this.buttonResetCell.Text = "Reset";
            this.buttonResetCell.UseVisualStyleBackColor = true;
            this.buttonResetCell.Click += new System.EventHandler(this.buttonResetCell_Click);
            // 
            // buttonSaveCell
            // 
            this.buttonSaveCell.Location = new System.Drawing.Point(537, 406);
            this.buttonSaveCell.Name = "buttonSaveCell";
            this.buttonSaveCell.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCell.TabIndex = 9;
            this.buttonSaveCell.Text = "Save";
            this.buttonSaveCell.UseVisualStyleBackColor = true;
            this.buttonSaveCell.Click += new System.EventHandler(this.buttonSaveCell_Click);
            // 
            // textBoxCellDescription
            // 
            this.textBoxCellDescription.Location = new System.Drawing.Point(94, 48);
            this.textBoxCellDescription.Multiline = true;
            this.textBoxCellDescription.Name = "textBoxCellDescription";
            this.textBoxCellDescription.Size = new System.Drawing.Size(480, 158);
            this.textBoxCellDescription.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Description:";
            // 
            // textBoxCellName
            // 
            this.textBoxCellName.Location = new System.Drawing.Point(94, 22);
            this.textBoxCellName.Name = "textBoxCellName";
            this.textBoxCellName.Size = new System.Drawing.Size(204, 20);
            this.textBoxCellName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Number:";
            // 
            // panelPrisonPrisonDetails
            // 
            this.panelPrisonPrisonDetails.Controls.Add(this.buttonDeletePrison);
            this.panelPrisonPrisonDetails.Controls.Add(this.buttonResetPrison);
            this.panelPrisonPrisonDetails.Controls.Add(this.buttonSavePrison);
            this.panelPrisonPrisonDetails.Controls.Add(this.textBoxPrisonDescription);
            this.panelPrisonPrisonDetails.Controls.Add(this.textBoxPrisonLocation);
            this.panelPrisonPrisonDetails.Controls.Add(this.textBoxPrisonName);
            this.panelPrisonPrisonDetails.Controls.Add(this.label12);
            this.panelPrisonPrisonDetails.Controls.Add(this.label11);
            this.panelPrisonPrisonDetails.Controls.Add(this.label10);
            this.panelPrisonPrisonDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrisonPrisonDetails.Location = new System.Drawing.Point(0, 0);
            this.panelPrisonPrisonDetails.Name = "panelPrisonPrisonDetails";
            this.panelPrisonPrisonDetails.Size = new System.Drawing.Size(615, 432);
            this.panelPrisonPrisonDetails.TabIndex = 0;
            this.panelPrisonPrisonDetails.Visible = false;
            // 
            // buttonDeletePrison
            // 
            this.buttonDeletePrison.Location = new System.Drawing.Point(375, 406);
            this.buttonDeletePrison.Name = "buttonDeletePrison";
            this.buttonDeletePrison.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePrison.TabIndex = 8;
            this.buttonDeletePrison.Text = "Delete";
            this.buttonDeletePrison.UseVisualStyleBackColor = true;
            this.buttonDeletePrison.Click += new System.EventHandler(this.buttonDeletePrison_Click);
            // 
            // buttonResetPrison
            // 
            this.buttonResetPrison.Location = new System.Drawing.Point(456, 406);
            this.buttonResetPrison.Name = "buttonResetPrison";
            this.buttonResetPrison.Size = new System.Drawing.Size(75, 23);
            this.buttonResetPrison.TabIndex = 7;
            this.buttonResetPrison.Text = "Reset";
            this.buttonResetPrison.UseVisualStyleBackColor = true;
            this.buttonResetPrison.Click += new System.EventHandler(this.buttonResetPrison_Click);
            // 
            // buttonSavePrison
            // 
            this.buttonSavePrison.Location = new System.Drawing.Point(537, 406);
            this.buttonSavePrison.Name = "buttonSavePrison";
            this.buttonSavePrison.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePrison.TabIndex = 6;
            this.buttonSavePrison.Text = "Save";
            this.buttonSavePrison.UseVisualStyleBackColor = true;
            this.buttonSavePrison.Click += new System.EventHandler(this.buttonSavePrison_Click);
            // 
            // textBoxPrisonDescription
            // 
            this.textBoxPrisonDescription.Location = new System.Drawing.Point(94, 74);
            this.textBoxPrisonDescription.Multiline = true;
            this.textBoxPrisonDescription.Name = "textBoxPrisonDescription";
            this.textBoxPrisonDescription.Size = new System.Drawing.Size(480, 158);
            this.textBoxPrisonDescription.TabIndex = 5;
            // 
            // textBoxPrisonLocation
            // 
            this.textBoxPrisonLocation.Location = new System.Drawing.Point(94, 48);
            this.textBoxPrisonLocation.Name = "textBoxPrisonLocation";
            this.textBoxPrisonLocation.Size = new System.Drawing.Size(204, 20);
            this.textBoxPrisonLocation.TabIndex = 4;
            // 
            // textBoxPrisonName
            // 
            this.textBoxPrisonName.Location = new System.Drawing.Point(94, 22);
            this.textBoxPrisonName.Name = "textBoxPrisonName";
            this.textBoxPrisonName.Size = new System.Drawing.Size(204, 20);
            this.textBoxPrisonName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Location:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name:";
            // 
            // panelPrisonTreeView
            // 
            this.panelPrisonTreeView.Controls.Add(this.treeViewPrison);
            this.panelPrisonTreeView.Location = new System.Drawing.Point(9, 32);
            this.panelPrisonTreeView.Name = "panelPrisonTreeView";
            this.panelPrisonTreeView.Size = new System.Drawing.Size(200, 432);
            this.panelPrisonTreeView.TabIndex = 2;
            // 
            // treeViewPrison
            // 
            this.treeViewPrison.Location = new System.Drawing.Point(4, 4);
            this.treeViewPrison.Name = "treeViewPrison";
            this.treeViewPrison.Size = new System.Drawing.Size(193, 425);
            this.treeViewPrison.TabIndex = 0;
            // 
            // tabPrisonAdd
            // 
            this.tabPrisonAdd.Controls.Add(this.comboBoxPrisonAddCellBlock);
            this.tabPrisonAdd.Controls.Add(this.labelPrisonAddCellBlock);
            this.tabPrisonAdd.Controls.Add(this.comboBoxPrisonAddPrison);
            this.tabPrisonAdd.Controls.Add(this.labelPrisonAddPrison);
            this.tabPrisonAdd.Controls.Add(this.buttonPrisonAddClear);
            this.tabPrisonAdd.Controls.Add(this.buttonPrisonAddAdd);
            this.tabPrisonAdd.Controls.Add(this.textBoxPrisonAddDescription);
            this.tabPrisonAdd.Controls.Add(this.textBoxPrisonAddLocation);
            this.tabPrisonAdd.Controls.Add(this.textBoxPrisonAddName);
            this.tabPrisonAdd.Controls.Add(this.label17);
            this.tabPrisonAdd.Controls.Add(this.labelPrisonAddLocation);
            this.tabPrisonAdd.Controls.Add(this.labelPrisonAddName);
            this.tabPrisonAdd.Controls.Add(this.comboBoxPrisonType);
            this.tabPrisonAdd.Controls.Add(this.labelSelectType);
            this.tabPrisonAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPrisonAdd.Name = "tabPrisonAdd";
            this.tabPrisonAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrisonAdd.Size = new System.Drawing.Size(837, 470);
            this.tabPrisonAdd.TabIndex = 1;
            this.tabPrisonAdd.Text = "Add";
            this.tabPrisonAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrisonAddCellBlock
            // 
            this.comboBoxPrisonAddCellBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrisonAddCellBlock.FormattingEnabled = true;
            this.comboBoxPrisonAddCellBlock.Location = new System.Drawing.Point(452, 111);
            this.comboBoxPrisonAddCellBlock.Name = "comboBoxPrisonAddCellBlock";
            this.comboBoxPrisonAddCellBlock.Size = new System.Drawing.Size(204, 21);
            this.comboBoxPrisonAddCellBlock.TabIndex = 17;
            // 
            // labelPrisonAddCellBlock
            // 
            this.labelPrisonAddCellBlock.AutoSize = true;
            this.labelPrisonAddCellBlock.Location = new System.Drawing.Point(389, 114);
            this.labelPrisonAddCellBlock.Name = "labelPrisonAddCellBlock";
            this.labelPrisonAddCellBlock.Size = new System.Drawing.Size(57, 13);
            this.labelPrisonAddCellBlock.TabIndex = 16;
            this.labelPrisonAddCellBlock.Text = "Cell Block:";
            // 
            // comboBoxPrisonAddPrison
            // 
            this.comboBoxPrisonAddPrison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrisonAddPrison.FormattingEnabled = true;
            this.comboBoxPrisonAddPrison.Location = new System.Drawing.Point(176, 111);
            this.comboBoxPrisonAddPrison.Name = "comboBoxPrisonAddPrison";
            this.comboBoxPrisonAddPrison.Size = new System.Drawing.Size(204, 21);
            this.comboBoxPrisonAddPrison.TabIndex = 15;
            // 
            // labelPrisonAddPrison
            // 
            this.labelPrisonAddPrison.AutoSize = true;
            this.labelPrisonAddPrison.Location = new System.Drawing.Point(131, 114);
            this.labelPrisonAddPrison.Name = "labelPrisonAddPrison";
            this.labelPrisonAddPrison.Size = new System.Drawing.Size(39, 13);
            this.labelPrisonAddPrison.TabIndex = 14;
            this.labelPrisonAddPrison.Text = "Prison:";
            // 
            // buttonPrisonAddClear
            // 
            this.buttonPrisonAddClear.Location = new System.Drawing.Point(331, 327);
            this.buttonPrisonAddClear.Name = "buttonPrisonAddClear";
            this.buttonPrisonAddClear.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonAddClear.TabIndex = 13;
            this.buttonPrisonAddClear.Text = "Clear";
            this.buttonPrisonAddClear.UseVisualStyleBackColor = true;
            this.buttonPrisonAddClear.Click += new System.EventHandler(this.buttonPrisonAddClear_Click);
            // 
            // buttonPrisonAddAdd
            // 
            this.buttonPrisonAddAdd.Location = new System.Drawing.Point(412, 327);
            this.buttonPrisonAddAdd.Name = "buttonPrisonAddAdd";
            this.buttonPrisonAddAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPrisonAddAdd.TabIndex = 12;
            this.buttonPrisonAddAdd.Text = "Add";
            this.buttonPrisonAddAdd.UseVisualStyleBackColor = true;
            this.buttonPrisonAddAdd.Click += new System.EventHandler(this.buttonPrisonAddAdd_Click);
            // 
            // textBoxPrisonAddDescription
            // 
            this.textBoxPrisonAddDescription.Location = new System.Drawing.Point(176, 164);
            this.textBoxPrisonAddDescription.Multiline = true;
            this.textBoxPrisonAddDescription.Name = "textBoxPrisonAddDescription";
            this.textBoxPrisonAddDescription.Size = new System.Drawing.Size(480, 158);
            this.textBoxPrisonAddDescription.TabIndex = 11;
            // 
            // textBoxPrisonAddLocation
            // 
            this.textBoxPrisonAddLocation.Location = new System.Drawing.Point(452, 138);
            this.textBoxPrisonAddLocation.Name = "textBoxPrisonAddLocation";
            this.textBoxPrisonAddLocation.Size = new System.Drawing.Size(204, 20);
            this.textBoxPrisonAddLocation.TabIndex = 10;
            // 
            // textBoxPrisonAddName
            // 
            this.textBoxPrisonAddName.Location = new System.Drawing.Point(176, 138);
            this.textBoxPrisonAddName.Name = "textBoxPrisonAddName";
            this.textBoxPrisonAddName.Size = new System.Drawing.Size(204, 20);
            this.textBoxPrisonAddName.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(107, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Description:";
            // 
            // labelPrisonAddLocation
            // 
            this.labelPrisonAddLocation.AutoSize = true;
            this.labelPrisonAddLocation.Location = new System.Drawing.Point(395, 141);
            this.labelPrisonAddLocation.Name = "labelPrisonAddLocation";
            this.labelPrisonAddLocation.Size = new System.Drawing.Size(51, 13);
            this.labelPrisonAddLocation.TabIndex = 7;
            this.labelPrisonAddLocation.Text = "Location:";
            // 
            // labelPrisonAddName
            // 
            this.labelPrisonAddName.AutoSize = true;
            this.labelPrisonAddName.Location = new System.Drawing.Point(130, 141);
            this.labelPrisonAddName.Name = "labelPrisonAddName";
            this.labelPrisonAddName.Size = new System.Drawing.Size(38, 13);
            this.labelPrisonAddName.TabIndex = 6;
            this.labelPrisonAddName.Text = "Name:";
            this.labelPrisonAddName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPrisonType
            // 
            this.comboBoxPrisonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrisonType.FormattingEnabled = true;
            this.comboBoxPrisonType.Items.AddRange(new object[] {
            "Prison",
            "Cell Block",
            "Cell"});
            this.comboBoxPrisonType.Location = new System.Drawing.Point(176, 84);
            this.comboBoxPrisonType.Name = "comboBoxPrisonType";
            this.comboBoxPrisonType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrisonType.TabIndex = 1;
            // 
            // labelSelectType
            // 
            this.labelSelectType.AutoSize = true;
            this.labelSelectType.Location = new System.Drawing.Point(136, 87);
            this.labelSelectType.Name = "labelSelectType";
            this.labelSelectType.Size = new System.Drawing.Size(34, 13);
            this.labelSelectType.TabIndex = 0;
            this.labelSelectType.Text = "Type:";
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.TextBoxAccountEmail);
            this.panelAccount.Controls.Add(this.LabelAccountEmail);
            this.panelAccount.Controls.Add(this.DateTimePickerAccountDOB);
            this.panelAccount.Controls.Add(this.LabelAccountDOB);
            this.panelAccount.Controls.Add(this.LabelAccountSex);
            this.panelAccount.Controls.Add(this.GroupBoxAccountSex);
            this.panelAccount.Controls.Add(this.TextBoxAccountPassword);
            this.panelAccount.Controls.Add(this.TextBoxAccountLName);
            this.panelAccount.Controls.Add(this.TextBoxAccountFName);
            this.panelAccount.Controls.Add(this.LabelAccountPassword);
            this.panelAccount.Controls.Add(this.LabelAccountLName);
            this.panelAccount.Controls.Add(this.LabelAccountFName);
            this.panelAccount.Controls.Add(this.ButtonAccountSave);
            this.panelAccount.Controls.Add(this.ButtonAccountReset);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(845, 496);
            this.panelAccount.TabIndex = 0;
            this.panelAccount.Visible = false;
            // 
            // TextBoxAccountEmail
            // 
            this.TextBoxAccountEmail.Location = new System.Drawing.Point(320, 199);
            this.TextBoxAccountEmail.Name = "TextBoxAccountEmail";
            this.TextBoxAccountEmail.Size = new System.Drawing.Size(191, 20);
            this.TextBoxAccountEmail.TabIndex = 69;
            // 
            // LabelAccountEmail
            // 
            this.LabelAccountEmail.AutoSize = true;
            this.LabelAccountEmail.Location = new System.Drawing.Point(239, 206);
            this.LabelAccountEmail.Name = "LabelAccountEmail";
            this.LabelAccountEmail.Size = new System.Drawing.Size(76, 13);
            this.LabelAccountEmail.TabIndex = 68;
            this.LabelAccountEmail.Text = "Email Address:";
            // 
            // DateTimePickerAccountDOB
            // 
            this.DateTimePickerAccountDOB.Location = new System.Drawing.Point(320, 228);
            this.DateTimePickerAccountDOB.Name = "DateTimePickerAccountDOB";
            this.DateTimePickerAccountDOB.Size = new System.Drawing.Size(191, 20);
            this.DateTimePickerAccountDOB.TabIndex = 67;
            // 
            // LabelAccountDOB
            // 
            this.LabelAccountDOB.AutoSize = true;
            this.LabelAccountDOB.Location = new System.Drawing.Point(245, 229);
            this.LabelAccountDOB.Name = "LabelAccountDOB";
            this.LabelAccountDOB.Size = new System.Drawing.Size(69, 13);
            this.LabelAccountDOB.TabIndex = 66;
            this.LabelAccountDOB.Text = "Date of Birth:";
            // 
            // LabelAccountSex
            // 
            this.LabelAccountSex.AutoSize = true;
            this.LabelAccountSex.Location = new System.Drawing.Point(286, 271);
            this.LabelAccountSex.Name = "LabelAccountSex";
            this.LabelAccountSex.Size = new System.Drawing.Size(28, 13);
            this.LabelAccountSex.TabIndex = 65;
            this.LabelAccountSex.Text = "Sex:";
            // 
            // GroupBoxAccountSex
            // 
            this.GroupBoxAccountSex.Controls.Add(this.RadioButtonAccountSexFemale);
            this.GroupBoxAccountSex.Controls.Add(this.RadioButtonAccountSexMale);
            this.GroupBoxAccountSex.Location = new System.Drawing.Point(320, 254);
            this.GroupBoxAccountSex.Name = "GroupBoxAccountSex";
            this.GroupBoxAccountSex.Size = new System.Drawing.Size(75, 56);
            this.GroupBoxAccountSex.TabIndex = 64;
            this.GroupBoxAccountSex.TabStop = false;
            // 
            // RadioButtonAccountSexFemale
            // 
            this.RadioButtonAccountSexFemale.AutoSize = true;
            this.RadioButtonAccountSexFemale.Location = new System.Drawing.Point(0, 29);
            this.RadioButtonAccountSexFemale.Name = "RadioButtonAccountSexFemale";
            this.RadioButtonAccountSexFemale.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonAccountSexFemale.TabIndex = 1;
            this.RadioButtonAccountSexFemale.TabStop = true;
            this.RadioButtonAccountSexFemale.Text = "Female";
            this.RadioButtonAccountSexFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAccountSexMale
            // 
            this.RadioButtonAccountSexMale.AutoSize = true;
            this.RadioButtonAccountSexMale.Location = new System.Drawing.Point(0, 7);
            this.RadioButtonAccountSexMale.Name = "RadioButtonAccountSexMale";
            this.RadioButtonAccountSexMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonAccountSexMale.TabIndex = 0;
            this.RadioButtonAccountSexMale.TabStop = true;
            this.RadioButtonAccountSexMale.Text = "Male";
            this.RadioButtonAccountSexMale.UseVisualStyleBackColor = true;
            // 
            // TextBoxAccountPassword
            // 
            this.TextBoxAccountPassword.Location = new System.Drawing.Point(320, 174);
            this.TextBoxAccountPassword.Name = "TextBoxAccountPassword";
            this.TextBoxAccountPassword.PasswordChar = '*';
            this.TextBoxAccountPassword.Size = new System.Drawing.Size(191, 20);
            this.TextBoxAccountPassword.TabIndex = 63;
            // 
            // TextBoxAccountLName
            // 
            this.TextBoxAccountLName.Location = new System.Drawing.Point(320, 147);
            this.TextBoxAccountLName.Name = "TextBoxAccountLName";
            this.TextBoxAccountLName.Size = new System.Drawing.Size(191, 20);
            this.TextBoxAccountLName.TabIndex = 62;
            // 
            // TextBoxAccountFName
            // 
            this.TextBoxAccountFName.Location = new System.Drawing.Point(318, 121);
            this.TextBoxAccountFName.Name = "TextBoxAccountFName";
            this.TextBoxAccountFName.Size = new System.Drawing.Size(193, 20);
            this.TextBoxAccountFName.TabIndex = 61;
            // 
            // LabelAccountPassword
            // 
            this.LabelAccountPassword.AutoSize = true;
            this.LabelAccountPassword.Location = new System.Drawing.Point(258, 180);
            this.LabelAccountPassword.Name = "LabelAccountPassword";
            this.LabelAccountPassword.Size = new System.Drawing.Size(56, 13);
            this.LabelAccountPassword.TabIndex = 60;
            this.LabelAccountPassword.Text = "Password:";
            // 
            // LabelAccountLName
            // 
            this.LabelAccountLName.AutoSize = true;
            this.LabelAccountLName.Location = new System.Drawing.Point(253, 153);
            this.LabelAccountLName.Name = "LabelAccountLName";
            this.LabelAccountLName.Size = new System.Drawing.Size(61, 13);
            this.LabelAccountLName.TabIndex = 59;
            this.LabelAccountLName.Text = "Last Name:";
            // 
            // LabelAccountFName
            // 
            this.LabelAccountFName.AutoSize = true;
            this.LabelAccountFName.Location = new System.Drawing.Point(257, 127);
            this.LabelAccountFName.Name = "LabelAccountFName";
            this.LabelAccountFName.Size = new System.Drawing.Size(60, 13);
            this.LabelAccountFName.TabIndex = 58;
            this.LabelAccountFName.Text = "First Name:";
            // 
            // ButtonAccountSave
            // 
            this.ButtonAccountSave.Location = new System.Drawing.Point(416, 335);
            this.ButtonAccountSave.Name = "ButtonAccountSave";
            this.ButtonAccountSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccountSave.TabIndex = 57;
            this.ButtonAccountSave.Text = "Save";
            this.ButtonAccountSave.UseVisualStyleBackColor = true;
            this.ButtonAccountSave.Click += new System.EventHandler(this.ButtonAccountSave_Click);
            // 
            // ButtonAccountReset
            // 
            this.ButtonAccountReset.Location = new System.Drawing.Point(292, 335);
            this.ButtonAccountReset.Name = "ButtonAccountReset";
            this.ButtonAccountReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccountReset.TabIndex = 56;
            this.ButtonAccountReset.Text = "Reset";
            this.ButtonAccountReset.UseVisualStyleBackColor = true;
            this.ButtonAccountReset.Click += new System.EventHandler(this.ButtonAccountReset_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(58, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 25);
            this.label18.TabIndex = 13;
            this.label18.Text = "Prisons";
            // 
            // CatalogerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 520);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CatalogerInterface";
            this.Text = "Prisoner Cataloging System";
            this.tabControlPrisoner.ResumeLayout(false);
            this.tabPrisonerSearch.ResumeLayout(false);
            this.tabPrisonerSearch.PerformLayout();
            this.tabPrisonerAddEdit.ResumeLayout(false);
            this.tabPrisonerAddEdit.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelPrisoner.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelOffense.ResumeLayout(false);
            this.tabControlOffense.ResumeLayout(false);
            this.tabOffenseSearch.ResumeLayout(false);
            this.tabOffenseSearch.PerformLayout();
            this.tabOffenseAddEdit.ResumeLayout(false);
            this.tabOffenseAddEdit.PerformLayout();
            this.panelPrison.ResumeLayout(false);
            this.tabControlPrison.ResumeLayout(false);
            this.tabPrisonViewModify.ResumeLayout(false);
            this.tabPrisonViewModify.PerformLayout();
            this.panelPrisonDetailsParent.ResumeLayout(false);
            this.panelPrisonCellBlockDetails.ResumeLayout(false);
            this.panelPrisonCellBlockDetails.PerformLayout();
            this.panelPrisonCellDetails.ResumeLayout(false);
            this.panelPrisonCellDetails.PerformLayout();
            this.panelPrisonPrisonDetails.ResumeLayout(false);
            this.panelPrisonPrisonDetails.PerformLayout();
            this.panelPrisonTreeView.ResumeLayout(false);
            this.tabPrisonAdd.ResumeLayout(false);
            this.tabPrisonAdd.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.GroupBoxAccountSex.ResumeLayout(false);
            this.GroupBoxAccountSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenuPrisoner;
        private System.Windows.Forms.Button buttonMenuPrison;
        private System.Windows.Forms.Button buttonMenuOffense;
        private System.Windows.Forms.Button buttonMenuAccount;
        private System.Windows.Forms.TabControl tabControlPrisoner;
        private System.Windows.Forms.TabPage tabPrisonerSearch;
        private System.Windows.Forms.TabPage tabPrisonerAddEdit;
        private System.Windows.Forms.Button buttonPrisonerSearch;
        private System.Windows.Forms.Button buttonPrisonerNew;
        private System.Windows.Forms.Button buttonPrisonerDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrisonerAddAdd;
        private System.Windows.Forms.Button buttonPrisonerAddReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrisonerAddLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrisonerAddFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrisoner;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelOffense;
        private System.Windows.Forms.Panel panelPrison;
        private System.Windows.Forms.TextBox textBoxPrisonerId;
        private System.Windows.Forms.TextBox textBoxPrisonerFname;
        private System.Windows.Forms.TextBox textBoxPrisonerLname;
        private System.Windows.Forms.TextBox textBoxPrisonerPrisonName;
        private System.Windows.Forms.TextBox textBoxPrisonerBlockName;
        private System.Windows.Forms.TextBox textBoxPrisonerCellName;
        private System.Windows.Forms.DateTimePicker datePickerAddPrisonerDob;
        private System.Windows.Forms.ComboBox comboBoxPrisonerAddPrison;
        private System.Windows.Forms.ListView listViewPrisonerSearch;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader lName;
        private System.Windows.Forms.ColumnHeader prisonName;
        private System.Windows.Forms.ColumnHeader cellBlockName;
        private System.Windows.Forms.ColumnHeader cellNumber;
        private System.Windows.Forms.TabControl tabControlPrison;
        private System.Windows.Forms.TabPage tabPrisonViewModify;
        private System.Windows.Forms.TabPage tabPrisonAdd;
        private System.Windows.Forms.Panel panelPrisonTreeView;
        private System.Windows.Forms.TreeView treeViewPrison;
        private System.Windows.Forms.Panel panelPrisonDetailsParent;
        private System.Windows.Forms.Panel panelPrisonPrisonDetails;
        private System.Windows.Forms.Panel panelPrisonCellDetails;
        private System.Windows.Forms.Panel panelPrisonCellBlockDetails;
        private System.Windows.Forms.Label labelSelectType;
        private System.Windows.Forms.RadioButton radioButtonPrisonerAddMale;
        private System.Windows.Forms.RadioButton radioButtonPrisonerAddFemale;
        private System.Windows.Forms.ComboBox comboBoxPrisonerAddBlock;
        private System.Windows.Forms.ComboBox comboBoxPrisonerAddCell;
        private System.Windows.Forms.Button buttonDeleteCell;
        private System.Windows.Forms.Button buttonResetCell;
        private System.Windows.Forms.Button buttonSaveCell;
        private System.Windows.Forms.TextBox textBoxCellDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxCellName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonDeletePrison;
        private System.Windows.Forms.Button buttonResetPrison;
        private System.Windows.Forms.Button buttonSavePrison;
        private System.Windows.Forms.TextBox textBoxPrisonDescription;
        private System.Windows.Forms.TextBox textBoxPrisonLocation;
        private System.Windows.Forms.TextBox textBoxPrisonName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDeleteCellBlock;
        private System.Windows.Forms.Button buttonResetCellBlock;
        private System.Windows.Forms.Button buttonSaveCellBlock;
        private System.Windows.Forms.TextBox textBoxCellBlockDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCellBlockName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPrisonAddLocation;
        private System.Windows.Forms.TextBox textBoxPrisonAddName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelPrisonAddLocation;
        private System.Windows.Forms.Label labelPrisonAddName;
        private System.Windows.Forms.TabControl tabControlOffense;
        private System.Windows.Forms.TabPage tabOffenseSearch;
        private System.Windows.Forms.ListView listViewOffenses;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnfName;
        private System.Windows.Forms.ColumnHeader columnlName;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.TextBox textBoxOffenseId;
        private System.Windows.Forms.TextBox textBoxOffensePrisonerFname;
        private System.Windows.Forms.TextBox textBoxOffensePrisonerLname;
        private System.Windows.Forms.TextBox textBoxOffenseType;
        private System.Windows.Forms.TextBox textBoxOffenseLocation;
        private System.Windows.Forms.TextBox textBoxOffenseDate;
        private System.Windows.Forms.Button buttonOffenseSearch;
        private System.Windows.Forms.TabPage tabOffenseAddEdit;
        private System.Windows.Forms.Button buttonOffenseDelete;
        private System.Windows.Forms.Button buttonOffenseNew;
        private System.Windows.Forms.TextBox textBoxOffenseDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOffenseEditReset;
        private System.Windows.Forms.Button buttonOffenseAddAdd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxOffenseEditDescription;
        private System.Windows.Forms.TextBox textBoxOffenseEditLocation;
        private System.Windows.Forms.DateTimePicker datePickerOffenseEditDate;
        private System.Windows.Forms.TextBox TextBoxAccountEmail;
        private System.Windows.Forms.Label LabelAccountEmail;
        private System.Windows.Forms.DateTimePicker DateTimePickerAccountDOB;
        private System.Windows.Forms.Label LabelAccountDOB;
        private System.Windows.Forms.Label LabelAccountSex;
        private System.Windows.Forms.GroupBox GroupBoxAccountSex;
        private System.Windows.Forms.RadioButton RadioButtonAccountSexFemale;
        private System.Windows.Forms.RadioButton RadioButtonAccountSexMale;
        private System.Windows.Forms.TextBox TextBoxAccountPassword;
        private System.Windows.Forms.TextBox TextBoxAccountLName;
        private System.Windows.Forms.TextBox TextBoxAccountFName;
        private System.Windows.Forms.Label LabelAccountPassword;
        private System.Windows.Forms.Label LabelAccountLName;
        private System.Windows.Forms.Label LabelAccountFName;
        private System.Windows.Forms.Button ButtonAccountSave;
        private System.Windows.Forms.Button ButtonAccountReset;
        private System.Windows.Forms.TextBox textBoxPrisonAddDescription;
        private System.Windows.Forms.ComboBox comboBoxPrisonType;
        private System.Windows.Forms.Button buttonPrisonAddClear;
        private System.Windows.Forms.Button buttonPrisonAddAdd;
        private System.Windows.Forms.ComboBox comboBoxPrisonAddCellBlock;
        private System.Windows.Forms.Label labelPrisonAddCellBlock;
        private System.Windows.Forms.ComboBox comboBoxPrisonAddPrison;
        private System.Windows.Forms.Label labelPrisonAddPrison;
        private System.Windows.Forms.TextBox textBoxOffenseEditType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxOffenseEditPrisoners;
        private System.Windows.Forms.Button buttonMenuLogout;
        private System.Windows.Forms.Label label18;
    }
}

