using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseApplication
{
	public partial class AddEmployeeForm : Form
	{
		MainForm employeeDatabaseForm = new MainForm();
		public AddEmployeeForm()
		{
			InitializeComponent();
		}

		private void AddEmployee(object sender, EventArgs e)
		{
			if (dateOfBirthTextBox.Text == "dd/mm/yyyy") { dateOfBirthTextBox.Text = ""; }
			using (OleDbConnection connection = new OleDbConnection())
			{
				connection.ConnectionString = MainForm.Connection;
				try
				{
					connection.Open();
					OleDbCommand add = connection.CreateCommand();
					add.CommandText = "INSERT INTO Employees (ID, FirstName, MiddleName, LastName," +
						" DateOfBirth, PhoneNumber, HomeAddress)" +" VALUES ('" + FindNewID().ToString("D4")
						+ "','" + firstNameTextBox.Text + "','" + middleNameTextBox.Text + "','" +
						lastNameTextBox.Text + "','" + dateOfBirthTextBox.Text + "','" +
						phoneNumberTextBox.Text + "','" + homeAddressRichTextBox.Text + "')";
					add.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
				this.Close();
			}
		}

		public int FindNewID()
		{
			using (OleDbConnection connection = new OleDbConnection())
			{
				connection.ConnectionString = MainForm.Connection;
				int count = 0;
				try
				{
					connection.Open();
					OleDbCommand check = connection.CreateCommand();
					check.CommandText = "SELECT COUNT(*) FROM Employees";
					count = Convert.ToInt32(check.ExecuteScalar());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
				int number;
				for (int i = 1; i <= count; i++)
				{
					try
					{
						OleDbCommand find = connection.CreateCommand();
						find.CommandText = "SELECT ID FROM Employees" +
							" WHERE ID = '" + i.ToString("D4") + "'";
						number = find.ExecuteNonQuery();
						if (number == 0)
						{
							return i;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message.ToString());
					}
				}
				return count + 1;
			}
		}

		public void VerifyTextBox(object sender, string pattern)
		{
			if (!System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, pattern) &&
				((TextBox)sender).Text != "")
			{
				((TextBox)sender).ForeColor = Color.Red;
				AcceptButtonUpdate();
			}
			else
			{
				((TextBox)sender).ForeColor = Color.Black;
				AcceptButtonUpdate();
			}
		}

		private void CheckName(object sender, EventArgs e)
		{
			string pattern = @"^\s*[A-Za-zА-Яа-я]*\s*$";
			VerifyTextBox(sender, pattern);
		}

		private void CheckPhoneNumber(object sender, EventArgs e)
		{
			string pattern = @"^\s*[0-9]*\s*$";
			VerifyTextBox(sender, pattern);
		}

		private void CheckAddress(object sender, EventArgs e)
		{
			string pattern = @"^\s*.{0,50}\s*$";
			if (!System.Text.RegularExpressions.Regex.IsMatch(((RichTextBox)sender).Text, pattern)
				&& ((RichTextBox)sender).Text != "")
			{
				((RichTextBox)sender).ForeColor = Color.Red;
				AcceptButtonUpdate();
			}
			else
			{
				((RichTextBox)sender).ForeColor = Color.Black;
				AcceptButtonUpdate();
			}
		}

		private void CheckDate(object sender, EventArgs e)
		{
			string pattern = @"^\d?\d/\d?\d/\d{4}$";
			if (!System.Text.RegularExpressions.Regex.IsMatch(((MaskedTextBox)sender).Text, pattern) &&
				((MaskedTextBox)sender).Text != "")
			{
				((MaskedTextBox)sender).ForeColor = Color.Red;
				AcceptButtonUpdate();
			}
			else
			{
				((MaskedTextBox)sender).ForeColor = Color.Black;
				AcceptButtonUpdate();
			}
		}

		private void AcceptButtonUpdate()
		{
			if (firstNameTextBox.Text == "" || lastNameTextBox.Text == ""
				|| firstNameTextBox.ForeColor == Color.Red
				|| middleNameTextBox.ForeColor == Color.Red
				|| lastNameTextBox.ForeColor == Color.Red
				|| dateOfBirthTextBox.ForeColor == Color.Red
				|| phoneNumberTextBox.ForeColor == Color.Red
				|| homeAddressRichTextBox.ForeColor == Color.Red)
			{
				acceptButton.Enabled = false;
			}
			else { acceptButton.Enabled = true; }
		}

		private void ClearDateOfBirthTextBox(object sender, EventArgs e)
		{
			if (((TextBox)sender).Text == "dd/mm/yyyy") { ((TextBox)sender).Text = ""; }
		}
	}
}

/*private int FindMaxID()
{
	using (OleDbConnection connection = new OleDbConnection())
	{
		connection.ConnectionString = MainForm.CONNECTION;
		try
		{
			connection.Open();
			OleDbCommand check = connection.CreateCommand();
			check.CommandText = "SELECT COUNT(*) FROM Employees";
			int count = Convert.ToInt32(check.ExecuteScalar());
			if (count != 0)
			{
				OleDbCommand find = connection.CreateCommand();
				find.CommandText = "SELECT MAX(ID) FROM Employees";
				int maxID = Convert.ToInt32(find.ExecuteScalar());
				return maxID;
			}
			else
			{
				return 0;
			}
		}
		catch
		{
			MessageBox.Show("Database connection error!");
			this.Close();
			return 0;
		}
	}
}*/