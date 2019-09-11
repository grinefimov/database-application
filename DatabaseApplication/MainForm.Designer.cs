namespace DatabaseApplication
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEmployeebyIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.addEmployeeButton = new System.Windows.Forms.Button();
			this.deleteEmployeeButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeesNumberLabel = new System.Windows.Forms.Label();
			this.tipLabel = new System.Windows.Forms.Label();
			this.searchLabel = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.unableConnectLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(9, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(350, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tableToolStripMenuItem
			// 
			this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.deleteEmployeebyIDToolStripMenuItem,
            this.updateToolStripMenuItem});
			this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
			this.tableToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.tableToolStripMenuItem.Text = "Table";
			// 
			// addEmployeeToolStripMenuItem
			// 
			this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
			this.addEmployeeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			this.addEmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.addEmployeeToolStripMenuItem.Text = "Add Employee";
			this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.OpenAddEmployeeForm);
			// 
			// deleteEmployeebyIDToolStripMenuItem
			// 
			this.deleteEmployeebyIDToolStripMenuItem.Name = "deleteEmployeebyIDToolStripMenuItem";
			this.deleteEmployeebyIDToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
			this.deleteEmployeebyIDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.deleteEmployeebyIDToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.deleteEmployeebyIDToolStripMenuItem.Text = "Delete Employee";
			this.deleteEmployeebyIDToolStripMenuItem.Click += new System.EventHandler(this.OpenDeleteEmployeeForm);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.ShortcutKeyDisplayString = "F5";
			this.updateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.updateToolStripMenuItem.Text = "Update Table";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.FillEmployeesTableAsync);
			// 
			// selectToolStripMenuItem
			// 
			this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
			this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.selectToolStripMenuItem.Text = "Select";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.importToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.importToolStripMenuItem.Text = "Import File...";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportEmployees);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.saveToolStripMenuItem.Text = "Export As...";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.ExportSelectedRows);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedRows);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowAboutMessage);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTextBox.Location = new System.Drawing.Point(57, 27);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(512, 20);
			this.searchTextBox.TabIndex = 3;
			this.searchTextBox.TextChanged += new System.EventHandler(this.FindEmployees);
			// 
			// addEmployeeButton
			// 
			this.addEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addEmployeeButton.Location = new System.Drawing.Point(575, 25);
			this.addEmployeeButton.Name = "addEmployeeButton";
			this.addEmployeeButton.Size = new System.Drawing.Size(91, 23);
			this.addEmployeeButton.TabIndex = 6;
			this.addEmployeeButton.Text = "Add Employee";
			this.addEmployeeButton.UseVisualStyleBackColor = true;
			this.addEmployeeButton.Click += new System.EventHandler(this.OpenAddEmployeeForm);
			// 
			// deleteEmployeeButton
			// 
			this.deleteEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteEmployeeButton.Location = new System.Drawing.Point(672, 25);
			this.deleteEmployeeButton.Name = "deleteEmployeeButton";
			this.deleteEmployeeButton.Size = new System.Drawing.Size(100, 23);
			this.deleteEmployeeButton.TabIndex = 7;
			this.deleteEmployeeButton.Text = "Delete Employee";
			this.deleteEmployeeButton.UseVisualStyleBackColor = true;
			this.deleteEmployeeButton.Click += new System.EventHandler(this.OpenDeleteEmployeeForm);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.homeAddressDataGridViewTextBoxColumn});
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.dataGridView1.Location = new System.Drawing.Point(12, 53);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(760, 396);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditCellData);
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.iDDataGridViewTextBoxColumn.Width = 45;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First name";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// middleNameDataGridViewTextBoxColumn
			// 
			this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle name";
			this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle name";
			this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last name";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of birth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of birth";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dateOfBirthDataGridViewTextBoxColumn.Width = 90;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone number";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone number";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.Width = 105;
			// 
			// homeAddressDataGridViewTextBoxColumn
			// 
			this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "Home address";
			this.homeAddressDataGridViewTextBoxColumn.HeaderText = "Home address";
			this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
			this.homeAddressDataGridViewTextBoxColumn.Width = 175;
			// 
			// employeesNumberLabel
			// 
			this.employeesNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.employeesNumberLabel.Location = new System.Drawing.Point(620, 7);
			this.employeesNumberLabel.Name = "employeesNumberLabel";
			this.employeesNumberLabel.Size = new System.Drawing.Size(152, 13);
			this.employeesNumberLabel.TabIndex = 8;
			this.employeesNumberLabel.Text = "Employees Number: 0";
			this.employeesNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tipLabel
			// 
			this.tipLabel.AutoSize = true;
			this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tipLabel.Location = new System.Drawing.Point(386, 7);
			this.tipLabel.Name = "tipLabel";
			this.tipLabel.Size = new System.Drawing.Size(228, 13);
			this.tipLabel.TabIndex = 10;
			this.tipLabel.Text = "TripleClick or click-pause-click or F2 to edit cell";
			// 
			// searchLabel
			// 
			this.searchLabel.AutoSize = true;
			this.searchLabel.Location = new System.Drawing.Point(12, 30);
			this.searchLabel.Name = "searchLabel";
			this.searchLabel.Size = new System.Drawing.Size(44, 13);
			this.searchLabel.TabIndex = 11;
			this.searchLabel.Text = "Search:";
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progressBar1.Location = new System.Drawing.Point(275, 245);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(250, 23);
			this.progressBar1.TabIndex = 12;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 145;
			this.timer1.Tick += new System.EventHandler(this.FillProgressBar);
			// 
			// unableConnectLabel
			// 
			this.unableConnectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.unableConnectLabel.AutoSize = true;
			this.unableConnectLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.unableConnectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.unableConnectLabel.Location = new System.Drawing.Point(288, 245);
			this.unableConnectLabel.Name = "unableConnectLabel";
			this.unableConnectLabel.Size = new System.Drawing.Size(224, 16);
			this.unableConnectLabel.TabIndex = 13;
			this.unableConnectLabel.Text = "Unable to connect to database!";
			this.unableConnectLabel.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.unableConnectLabel);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.searchLabel);
			this.Controls.Add(this.tipLabel);
			this.Controls.Add(this.employeesNumberLabel);
			this.Controls.Add(this.deleteEmployeeButton);
			this.Controls.Add(this.addEmployeeButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Enabled = false;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(500, 200);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employees Database";
			this.Activated += new System.EventHandler(this.FillEmployeesTableAsync);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button addEmployeeButton;
		private System.Windows.Forms.Button deleteEmployeeButton;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteEmployeebyIDToolStripMenuItem;
		private System.Windows.Forms.Label employeesNumberLabel;
		private System.Windows.Forms.Label tipLabel;
		private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
		private System.Windows.Forms.Label searchLabel;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label unableConnectLabel;
	}
}