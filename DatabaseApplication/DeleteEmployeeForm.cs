using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DatabaseApplication
{
	public partial class DeleteEmployeeForm : Form
	{
		public DeleteEmployeeForm()
		{
			InitializeComponent();
		}

		private void DeleteEmployee(object sender, EventArgs e)
		{
				using (OleDbConnection connection = new OleDbConnection())
				{
					connection.ConnectionString = MainForm.Connection;
					try
					{
						connection.Open();
						OleDbCommand delete = connection.CreateCommand();
						delete.CommandText = "DELETE FROM Employees WHERE ID = " + idTextBox.Text;
						delete.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message.ToString());
					}
				}
				this.Close();
		}

		private void FindEmployeeByID(object sender, EventArgs e)
		{
			using (OleDbConnection connection = new OleDbConnection())
			{
				connection.ConnectionString = MainForm.Connection;
				try
				{
					connection.Open();
					OleDbCommand find = connection.CreateCommand();
					int iCurID = 0;
					int.TryParse(idTextBox.Text, out iCurID);
					string curID = iCurID.ToString("D4");
					find.CommandText = "SELECT FirstName, MiddleName, LastName FROM Employees" +
						" WHERE ID = " + curID;
					OleDbDataReader reader = find.ExecuteReader();
					if (reader.Read())
					{
						fullNameLabel.Text = reader.GetValue(0).ToString().TrimEnd() + " " +
							reader.GetValue(1).ToString().TrimEnd() + " " +
							reader.GetValue(2).ToString().TrimEnd();
						deleteButton.Enabled = true;
					}
					else
					{
						fullNameLabel.Text = "(Full name)";
						deleteButton.Enabled = false;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		private void CheckID(object sender, EventArgs e)
		{
			string pattern = @"^\s*[0-9]*\s*$";
			if (!System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, pattern) &&
				((TextBox)sender).Text != "")
			{
				((TextBox)sender).ForeColor = System.Drawing.Color.Red;
			}
			else
			{
				((TextBox)sender).ForeColor = System.Drawing.Color.Black;
			}
		}
	}
}
