namespace DatabaseApplication
{
	partial class DeleteEmployeeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployeeForm));
			this.deleteButton = new System.Windows.Forms.Button();
			this.cancelButton2 = new System.Windows.Forms.Button();
			this.infoLabel2 = new System.Windows.Forms.Label();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.Enabled = false;
			this.deleteButton.Location = new System.Drawing.Point(116, 176);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 0;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteEmployee);
			// 
			// cancelButton2
			// 
			this.cancelButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton2.Location = new System.Drawing.Point(197, 176);
			this.cancelButton2.Name = "cancelButton2";
			this.cancelButton2.Size = new System.Drawing.Size(75, 23);
			this.cancelButton2.TabIndex = 1;
			this.cancelButton2.Text = "Cancel";
			this.cancelButton2.UseVisualStyleBackColor = true;
			// 
			// infoLabel2
			// 
			this.infoLabel2.AutoSize = true;
			this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoLabel2.Location = new System.Drawing.Point(12, 9);
			this.infoLabel2.Name = "infoLabel2";
			this.infoLabel2.Size = new System.Drawing.Size(115, 13);
			this.infoLabel2.TabIndex = 2;
			this.infoLabel2.Text = "Enter employee ID:";
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(133, 6);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(139, 20);
			this.idTextBox.TabIndex = 0;
			this.idTextBox.TextChanged += new System.EventHandler(this.FindEmployeeByID);
			this.idTextBox.TextChanged += new System.EventHandler(this.CheckID);
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 51);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(58, 13);
			this.fullNameLabel.TabIndex = 4;
			this.fullNameLabel.Text = "(Full name)";
			// 
			// DeleteEmployeeForm
			// 
			this.AcceptButton = this.deleteButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton2;
			this.ClientSize = new System.Drawing.Size(284, 211);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.infoLabel2);
			this.Controls.Add(this.cancelButton2);
			this.Controls.Add(this.deleteButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DeleteEmployeeForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Delete Employee";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button cancelButton2;
		private System.Windows.Forms.Label infoLabel2;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Label fullNameLabel;
	}
}