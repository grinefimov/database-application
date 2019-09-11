namespace DatabaseApplication
{
	partial class AddEmployeeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.middleNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.infoLabel1 = new System.Windows.Forms.Label();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.middleNameLabel = new System.Windows.Forms.Label();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.cancelButton1 = new System.Windows.Forms.Button();
			this.acceptButton = new System.Windows.Forms.Button();
			this.dateOfBirthLabel = new System.Windows.Forms.Label();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.homeAddressLabel = new System.Windows.Forms.Label();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.homeAddressRichTextBox = new System.Windows.Forms.RichTextBox();
			this.infoLabel2 = new System.Windows.Forms.Label();
			this.dateOfBirthTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
			this.firstNameTextBox.Location = new System.Drawing.Point(122, 38);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(150, 20);
			this.firstNameTextBox.TabIndex = 0;
			this.firstNameTextBox.TextChanged += new System.EventHandler(this.CheckName);
			// 
			// middleNameTextBox
			// 
			this.middleNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.middleNameTextBox.ForeColor = System.Drawing.Color.Black;
			this.middleNameTextBox.Location = new System.Drawing.Point(122, 64);
			this.middleNameTextBox.Name = "middleNameTextBox";
			this.middleNameTextBox.Size = new System.Drawing.Size(150, 20);
			this.middleNameTextBox.TabIndex = 1;
			this.middleNameTextBox.TextChanged += new System.EventHandler(this.CheckName);
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
			this.lastNameTextBox.Location = new System.Drawing.Point(122, 90);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(150, 20);
			this.lastNameTextBox.TabIndex = 2;
			this.lastNameTextBox.TextChanged += new System.EventHandler(this.CheckName);
			// 
			// infoLabel1
			// 
			this.infoLabel1.AutoSize = true;
			this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoLabel1.Location = new System.Drawing.Point(12, 9);
			this.infoLabel1.Name = "infoLabel1";
			this.infoLabel1.Size = new System.Drawing.Size(191, 13);
			this.infoLabel1.TabIndex = 3;
			this.infoLabel1.Text = "Enter new employee information:";
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(12, 41);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(59, 13);
			this.firstNameLabel.TabIndex = 4;
			this.firstNameLabel.Text = "First name*";
			// 
			// middleNameLabel
			// 
			this.middleNameLabel.AutoSize = true;
			this.middleNameLabel.Location = new System.Drawing.Point(12, 67);
			this.middleNameLabel.Name = "middleNameLabel";
			this.middleNameLabel.Size = new System.Drawing.Size(67, 13);
			this.middleNameLabel.TabIndex = 5;
			this.middleNameLabel.Text = "Middle name";
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(12, 93);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(60, 13);
			this.lastNameLabel.TabIndex = 6;
			this.lastNameLabel.Text = "Last name*";
			// 
			// cancelButton1
			// 
			this.cancelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton1.Location = new System.Drawing.Point(197, 276);
			this.cancelButton1.Name = "cancelButton1";
			this.cancelButton1.Size = new System.Drawing.Size(75, 23);
			this.cancelButton1.TabIndex = 7;
			this.cancelButton1.Text = "Cancel";
			this.cancelButton1.UseVisualStyleBackColor = true;
			// 
			// acceptButton
			// 
			this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.acceptButton.Enabled = false;
			this.acceptButton.Location = new System.Drawing.Point(116, 276);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(75, 23);
			this.acceptButton.TabIndex = 8;
			this.acceptButton.Text = "Add";
			this.acceptButton.UseVisualStyleBackColor = true;
			this.acceptButton.Click += new System.EventHandler(this.AddEmployee);
			// 
			// dateOfBirthLabel
			// 
			this.dateOfBirthLabel.AutoSize = true;
			this.dateOfBirthLabel.Location = new System.Drawing.Point(12, 122);
			this.dateOfBirthLabel.Name = "dateOfBirthLabel";
			this.dateOfBirthLabel.Size = new System.Drawing.Size(65, 13);
			this.dateOfBirthLabel.TabIndex = 9;
			this.dateOfBirthLabel.Text = "Date of birth";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(12, 145);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(76, 13);
			this.phoneNumberLabel.TabIndex = 10;
			this.phoneNumberLabel.Text = "Phone number";
			// 
			// homeAddressLabel
			// 
			this.homeAddressLabel.AutoSize = true;
			this.homeAddressLabel.Location = new System.Drawing.Point(12, 171);
			this.homeAddressLabel.Name = "homeAddressLabel";
			this.homeAddressLabel.Size = new System.Drawing.Size(75, 13);
			this.homeAddressLabel.TabIndex = 11;
			this.homeAddressLabel.Text = "Home address";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneNumberTextBox.ForeColor = System.Drawing.Color.Black;
			this.phoneNumberTextBox.Location = new System.Drawing.Point(122, 142);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(150, 20);
			this.phoneNumberTextBox.TabIndex = 14;
			this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.CheckPhoneNumber);
			// 
			// homeAddressRichTextBox
			// 
			this.homeAddressRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.homeAddressRichTextBox.ForeColor = System.Drawing.Color.Black;
			this.homeAddressRichTextBox.Location = new System.Drawing.Point(122, 168);
			this.homeAddressRichTextBox.Name = "homeAddressRichTextBox";
			this.homeAddressRichTextBox.Size = new System.Drawing.Size(150, 45);
			this.homeAddressRichTextBox.TabIndex = 16;
			this.homeAddressRichTextBox.Text = "";
			this.homeAddressRichTextBox.TextChanged += new System.EventHandler(this.CheckAddress);
			// 
			// infoLabel2
			// 
			this.infoLabel2.AutoSize = true;
			this.infoLabel2.Location = new System.Drawing.Point(12, 224);
			this.infoLabel2.Name = "infoLabel2";
			this.infoLabel2.Size = new System.Drawing.Size(75, 13);
			this.infoLabel2.TabIndex = 17;
			this.infoLabel2.Text = "* is necessary.";
			// 
			// dateOfBirthTextBox
			// 
			this.dateOfBirthTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.dateOfBirthTextBox.Location = new System.Drawing.Point(122, 116);
			this.dateOfBirthTextBox.Mask = "00/00/0000";
			this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
			this.dateOfBirthTextBox.Size = new System.Drawing.Size(150, 20);
			this.dateOfBirthTextBox.TabIndex = 18;
			this.dateOfBirthTextBox.TextChanged += new System.EventHandler(this.CheckDate);
			// 
			// AddEmployeeForm
			// 
			this.AcceptButton = this.acceptButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton1;
			this.ClientSize = new System.Drawing.Size(284, 311);
			this.Controls.Add(this.dateOfBirthTextBox);
			this.Controls.Add(this.infoLabel2);
			this.Controls.Add(this.homeAddressRichTextBox);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.homeAddressLabel);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.dateOfBirthLabel);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.cancelButton1);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.middleNameLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.infoLabel1);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.middleNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 350);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 350);
			this.Name = "AddEmployeeForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Employee";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox middleNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label infoLabel1;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label middleNameLabel;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Button cancelButton1;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Label dateOfBirthLabel;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.Label homeAddressLabel;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.RichTextBox homeAddressRichTextBox;
		private System.Windows.Forms.Label infoLabel2;
		private System.Windows.Forms.MaskedTextBox dateOfBirthTextBox;
	}
}