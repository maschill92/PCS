namespace PCS
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
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.idSearchBox = new System.Windows.Forms.TextBox();
            this.fNameSearchBox = new System.Windows.Forms.TextBox();
            this.lNameSearchBox = new System.Windows.Forms.TextBox();
            this.prisonSearchBox = new System.Windows.Forms.TextBox();
            this.cellBlockSearchBox = new System.Windows.Forms.TextBox();
            this.cellNumSearchBox = new System.Windows.Forms.TextBox();
            this.buttonSearchPrisoner = new System.Windows.Forms.Button();
            this.buttonViewOffenses = new System.Windows.Forms.Button();
            this.buttonDeletePrisoner = new System.Windows.Forms.Button();
            this.buttonEditPrisoner = new System.Windows.Forms.Button();
            this.buttonAddPrisoner = new System.Windows.Forms.Button();
            this.tabAddEdit = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPrisoner = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPrison = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelOffense = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prisonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cellBlockName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cellNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlPrisoner.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabAddEdit.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelPrisoner.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelPrison.SuspendLayout();
            this.panelOffense.SuspendLayout();
            this.panelAccount.SuspendLayout();
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
            this.tabControlPrisoner.Controls.Add(this.tabSearch);
            this.tabControlPrisoner.Controls.Add(this.tabAddEdit);
            this.tabControlPrisoner.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrisoner.Name = "tabControlPrisoner";
            this.tabControlPrisoner.SelectedIndex = 0;
            this.tabControlPrisoner.Size = new System.Drawing.Size(845, 496);
            this.tabControlPrisoner.TabIndex = 6;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.listView1);
            this.tabSearch.Controls.Add(this.idSearchBox);
            this.tabSearch.Controls.Add(this.fNameSearchBox);
            this.tabSearch.Controls.Add(this.lNameSearchBox);
            this.tabSearch.Controls.Add(this.prisonSearchBox);
            this.tabSearch.Controls.Add(this.cellBlockSearchBox);
            this.tabSearch.Controls.Add(this.cellNumSearchBox);
            this.tabSearch.Controls.Add(this.buttonSearchPrisoner);
            this.tabSearch.Controls.Add(this.buttonViewOffenses);
            this.tabSearch.Controls.Add(this.buttonDeletePrisoner);
            this.tabSearch.Controls.Add(this.buttonEditPrisoner);
            this.tabSearch.Controls.Add(this.buttonAddPrisoner);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(837, 470);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // idSearchBox
            // 
            this.idSearchBox.Location = new System.Drawing.Point(20, 41);
            this.idSearchBox.Name = "idSearchBox";
            this.idSearchBox.Size = new System.Drawing.Size(128, 20);
            this.idSearchBox.TabIndex = 12;
            // 
            // fNameSearchBox
            // 
            this.fNameSearchBox.Location = new System.Drawing.Point(154, 41);
            this.fNameSearchBox.Name = "fNameSearchBox";
            this.fNameSearchBox.Size = new System.Drawing.Size(128, 20);
            this.fNameSearchBox.TabIndex = 11;
            // 
            // lNameSearchBox
            // 
            this.lNameSearchBox.Location = new System.Drawing.Point(288, 41);
            this.lNameSearchBox.Name = "lNameSearchBox";
            this.lNameSearchBox.Size = new System.Drawing.Size(128, 20);
            this.lNameSearchBox.TabIndex = 13;
            // 
            // prisonSearchBox
            // 
            this.prisonSearchBox.Location = new System.Drawing.Point(422, 41);
            this.prisonSearchBox.Name = "prisonSearchBox";
            this.prisonSearchBox.Size = new System.Drawing.Size(128, 20);
            this.prisonSearchBox.TabIndex = 14;
            // 
            // cellBlockSearchBox
            // 
            this.cellBlockSearchBox.Location = new System.Drawing.Point(556, 41);
            this.cellBlockSearchBox.Name = "cellBlockSearchBox";
            this.cellBlockSearchBox.Size = new System.Drawing.Size(128, 20);
            this.cellBlockSearchBox.TabIndex = 15;
            // 
            // cellNumSearchBox
            // 
            this.cellNumSearchBox.Location = new System.Drawing.Point(690, 41);
            this.cellNumSearchBox.Name = "cellNumSearchBox";
            this.cellNumSearchBox.Size = new System.Drawing.Size(128, 20);
            this.cellNumSearchBox.TabIndex = 16;
            // 
            // buttonSearchPrisoner
            // 
            this.buttonSearchPrisoner.Location = new System.Drawing.Point(743, 12);
            this.buttonSearchPrisoner.Name = "buttonSearchPrisoner";
            this.buttonSearchPrisoner.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPrisoner.TabIndex = 9;
            this.buttonSearchPrisoner.Text = "Search";
            this.buttonSearchPrisoner.UseVisualStyleBackColor = true;
            // 
            // buttonViewOffenses
            // 
            this.buttonViewOffenses.Location = new System.Drawing.Point(490, 441);
            this.buttonViewOffenses.Name = "buttonViewOffenses";
            this.buttonViewOffenses.Size = new System.Drawing.Size(85, 23);
            this.buttonViewOffenses.TabIndex = 10;
            this.buttonViewOffenses.Text = "View Offenses";
            this.buttonViewOffenses.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePrisoner
            // 
            this.buttonDeletePrisoner.Location = new System.Drawing.Point(581, 441);
            this.buttonDeletePrisoner.Name = "buttonDeletePrisoner";
            this.buttonDeletePrisoner.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePrisoner.TabIndex = 6;
            this.buttonDeletePrisoner.Text = "Delete";
            this.buttonDeletePrisoner.UseVisualStyleBackColor = true;
            // 
            // buttonEditPrisoner
            // 
            this.buttonEditPrisoner.Location = new System.Drawing.Point(662, 441);
            this.buttonEditPrisoner.Name = "buttonEditPrisoner";
            this.buttonEditPrisoner.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPrisoner.TabIndex = 8;
            this.buttonEditPrisoner.Text = "Edit";
            this.buttonEditPrisoner.UseVisualStyleBackColor = true;
            // 
            // buttonAddPrisoner
            // 
            this.buttonAddPrisoner.Location = new System.Drawing.Point(743, 441);
            this.buttonAddPrisoner.Name = "buttonAddPrisoner";
            this.buttonAddPrisoner.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPrisoner.TabIndex = 7;
            this.buttonAddPrisoner.Text = "Add";
            this.buttonAddPrisoner.UseVisualStyleBackColor = true;
            // 
            // tabAddEdit
            // 
            this.tabAddEdit.Controls.Add(this.dateTimePicker1);
            this.tabAddEdit.Controls.Add(this.comboBox1);
            this.tabAddEdit.Controls.Add(this.label7);
            this.tabAddEdit.Controls.Add(this.label6);
            this.tabAddEdit.Controls.Add(this.label5);
            this.tabAddEdit.Controls.Add(this.button12);
            this.tabAddEdit.Controls.Add(this.button11);
            this.tabAddEdit.Controls.Add(this.button10);
            this.tabAddEdit.Controls.Add(this.textBox4);
            this.tabAddEdit.Controls.Add(this.label4);
            this.tabAddEdit.Controls.Add(this.label3);
            this.tabAddEdit.Controls.Add(this.textBox2);
            this.tabAddEdit.Controls.Add(this.label2);
            this.tabAddEdit.Controls.Add(this.textBox1);
            this.tabAddEdit.Controls.Add(this.label1);
            this.tabAddEdit.Location = new System.Drawing.Point(4, 22);
            this.tabAddEdit.Name = "tabAddEdit";
            this.tabAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEdit.Size = new System.Drawing.Size(837, 470);
            this.tabAddEdit.TabIndex = 1;
            this.tabAddEdit.Text = "Add/Edit";
            this.tabAddEdit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(485, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cell:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 353);
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
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(756, 441);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 10;
            this.button12.Text = "Add";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(675, 441);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "Edit";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(594, 441);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(485, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 7;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
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
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonMenuPrisoner);
            this.panelMenu.Controls.Add(this.buttonMenuPrison);
            this.panelMenu.Controls.Add(this.buttonMenuOffense);
            this.panelMenu.Controls.Add(this.buttonMenuAccount);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(112, 496);
            this.panelMenu.TabIndex = 7;
            // 
            // panelPrisoner
            // 
            this.panelPrisoner.Controls.Add(this.tabControlPrisoner);
            this.panelPrisoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrisoner.Location = new System.Drawing.Point(0, 0);
            this.panelPrisoner.Name = "panelPrisoner";
            this.panelPrisoner.Size = new System.Drawing.Size(845, 496);
            this.panelPrisoner.TabIndex = 8;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelPrisoner);
            this.panelMain.Controls.Add(this.panelPrison);
            this.panelMain.Controls.Add(this.panelOffense);
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Location = new System.Drawing.Point(131, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(845, 496);
            this.panelMain.TabIndex = 17;
            // 
            // panelPrison
            // 
            this.panelPrison.Controls.Add(this.label10);
            this.panelPrison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrison.Location = new System.Drawing.Point(0, 0);
            this.panelPrison.Name = "panelPrison";
            this.panelPrison.Size = new System.Drawing.Size(845, 496);
            this.panelPrison.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Prison";
            // 
            // panelOffense
            // 
            this.panelOffense.Controls.Add(this.label9);
            this.panelOffense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOffense.Location = new System.Drawing.Point(0, 0);
            this.panelOffense.Name = "panelOffense";
            this.panelOffense.Size = new System.Drawing.Size(845, 496);
            this.panelOffense.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Offense";
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.label8);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(845, 496);
            this.panelAccount.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Account";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.fName,
            this.lName,
            this.prisonName,
            this.cellBlockName,
            this.cellNumber});
            this.listView1.Location = new System.Drawing.Point(20, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 367);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 125;
            // 
            // fName
            // 
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.Text = "Last Name";
            // 
            // prisonName
            // 
            this.prisonName.Text = "Prison";
            // 
            // cellBlockName
            // 
            this.cellBlockName.Text = "Cell Block";
            // 
            // cellNumber
            // 
            this.cellNumber.Text = "Cell";
            // 
            // CatalogerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 520);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "CatalogerInterface";
            this.Text = "Form1";
            this.tabControlPrisoner.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabAddEdit.ResumeLayout(false);
            this.tabAddEdit.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelPrisoner.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelPrison.ResumeLayout(false);
            this.panelPrison.PerformLayout();
            this.panelOffense.ResumeLayout(false);
            this.panelOffense.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenuPrisoner;
        private System.Windows.Forms.Button buttonMenuPrison;
        private System.Windows.Forms.Button buttonMenuOffense;
        private System.Windows.Forms.Button buttonMenuAccount;
        private System.Windows.Forms.TabControl tabControlPrisoner;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabAddEdit;
        private System.Windows.Forms.Button buttonViewOffenses;
        private System.Windows.Forms.Button buttonSearchPrisoner;
        private System.Windows.Forms.Button buttonEditPrisoner;
        private System.Windows.Forms.Button buttonAddPrisoner;
        private System.Windows.Forms.Button buttonDeletePrisoner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrisoner;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelOffense;
        private System.Windows.Forms.Panel panelPrison;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idSearchBox;
        private System.Windows.Forms.TextBox fNameSearchBox;
        private System.Windows.Forms.TextBox lNameSearchBox;
        private System.Windows.Forms.TextBox prisonSearchBox;
        private System.Windows.Forms.TextBox cellBlockSearchBox;
        private System.Windows.Forms.TextBox cellNumSearchBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader lName;
        private System.Windows.Forms.ColumnHeader prisonName;
        private System.Windows.Forms.ColumnHeader cellBlockName;
        private System.Windows.Forms.ColumnHeader cellNumber;
    }
}

