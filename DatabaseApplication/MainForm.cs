using System;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DatabaseApplication
{
    public partial class MainForm : Form
    {
        // Cell editing verification?
        // Another tables?
        // Reconnect?
        // Connection delay and lags
        // Merge command text in "FindEmployees" (remove "words[0]")

        public const string Connection = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
			Persist Security Info=False;Initial Catalog=Grin's Database;Data Source=GRIN-PC\SQLEXPRESS";

        public class Employee
        {
            public string ID { get; set; }

            public string FirstName { get; set; }

            public string MiddleName { get; set; }

            public string LastName { get; set; }

            public string DateOfBirth { get; set; }

            public string PhoneNumber { get; set; }

            public string HomeAddress { get; set; }

            public Employee(string newID, string newFirstName, string newMiddleName, string newLastName,
                string newDateOfBirth, string newPhoneNumber, string newHomeAddress)
            {
                ID = newID;
                FirstName = newFirstName;
                MiddleName = newMiddleName;
                LastName = newLastName;
                DateOfBirth = newDateOfBirth;
                PhoneNumber = newPhoneNumber;
                HomeAddress = newHomeAddress;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private static bool Connected()
        {
            using (var connection = new OleDbConnection())
            {
                connection.ConnectionString = Connection;
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void ShowAboutMessage(object sender, EventArgs e)
        {
            MessageBox.Show(@"grinefimov@yandex.ru 2019");
        }

        #region Table editing

        public async void FillEmployeesTableAsync(object sender, EventArgs e)
        {
            if (await Task.Run(Connected))
            {
                progressBar1.Dispose();
                Enabled = true;
                if (searchTextBox.Text == "" && dataGridView1.SortOrder == SortOrder.None)
                {
                    dataGridView1.Rows.Clear();
                    using (var connection = new OleDbConnection())
                    {
                        connection.ConnectionString = Connection;
                        try
                        {
                            connection.Open();
                            OleDbCommand fill = connection.CreateCommand();
                            fill.CommandText = "SELECT * FROM Employees";
                            OleDbDataReader reader = fill.ExecuteReader();
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(new object[]
                                {
                                    reader.GetValue(0),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim(),
                                    reader.GetValue(6).ToString().Trim(),
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }

                        try
                        {
                            OleDbCommand count = connection.CreateCommand();
                            count.CommandText = "SELECT COUNT(*) FROM Employees";
                            employeesNumberLabel.Text = @"Employees Number: " + count.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                }
            }
            else
            {
                Activated -= new EventHandler(FillEmployeesTableAsync); //Delete.
                progressBar1.Dispose();
                MessageBox.Show(@"Unable to connect to database!");
                unableConnectLabel.Visible = true;
                //this.Close();
            }
        }

        private void FillProgressBar(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void OpenAddEmployeeForm(object sender, EventArgs e)
        {
            var aef = new AddEmployeeForm {Owner = this};
            aef.ShowDialog();
        }

        private void OpenDeleteEmployeeForm(object sender, EventArgs e)
        {
            var def = new DeleteEmployeeForm {Owner = this};
            def.ShowDialog();
        }

        private void FindEmployees(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() != "")
            {
                dataGridView1.Rows.Clear();
                using (var connection = new OleDbConnection())
                {
                    connection.ConnectionString = Connection;
                    try
                    {
                        connection.Open();
                        OleDbCommand search = connection.CreateCommand();
                        string[] words = searchTextBox.Text.Trim().Split(' ');
                        search.CommandText = "SELECT * FROM Employees WHERE ID LIKE '%" + words[0] + "%'"
                                             + " OR FirstName LIKE '%" + words[0] + "%'"
                                             + " OR MiddleName LIKE '%" + words[0] + "%'"
                                             + " OR LastName LIKE '%" + words[0] + "%'"
                                             + " OR DateOfBirth LIKE '%" + words[0] + "%'"
                                             + " OR PhoneNumber LIKE '%" + words[0] + "%'"
                                             + " OR HomeAddress LIKE '%" + words[0] + "%'";
                        for (int i = 1; i < words.Length; i++)
                        {
                            search.CommandText = "SELECT * FROM  (" + search.CommandText + ") AS e" +
                                                 " WHERE ID LIKE '%" + words[i] + "%'"
                                                 + " OR FirstName LIKE '%" + words[i] + "%'"
                                                 + " OR MiddleName LIKE '%" + words[i] + "%'"
                                                 + " OR LastName LIKE '%" + words[i] + "%'"
                                                 + " OR DateOfBirth LIKE '%" + words[i] + "%'"
                                                 + " OR PhoneNumber LIKE '%" + words[i] + "%'"
                                                 + " OR HomeAddress LIKE '%" + words[i] + "%'";
                        }

                        OleDbDataReader reader = search.ExecuteReader();
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(new object[]
                            {
                                reader.GetValue(0),
                                reader.GetValue(1).ToString().Trim(),
                                reader.GetValue(2).ToString().Trim(),
                                reader.GetValue(3).ToString().Trim(),
                                reader.GetValue(4).ToString().Trim(),
                                reader.GetValue(5).ToString().Trim(),
                                reader.GetValue(6).ToString().Trim(),
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else
            {
                FillEmployeesTableAsync(this, EventArgs.Empty);
            }
        }

        private readonly string[] _columns =
        {
            "ID", "FirstName", "MiddleName", "LastName", "DateOfBirth",
            "PhoneNumber", "HomeAddress"
        };

        private void EditCellData(object sender, DataGridViewCellEventArgs e)
        {
            using (var connection = new OleDbConnection())
            {
                connection.ConnectionString = MainForm.Connection;
                try
                {
                    connection.Open();
                    OleDbCommand set = connection.CreateCommand();
                    set.CommandText = "UPDATE Employees SET " + _columns[e.ColumnIndex] + " = '"
                                      + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' " +
                                      "WHERE ID = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                    set.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void DeleteSelectedRows(object sender, EventArgs e)
        {
            int rowsCount = dataGridView1.SelectedRows.Count;
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            if (rowsCount != 0)
            {
                string messageBoxText = "Do you want to delete selected employees?";
                DialogResult result = MessageBox.Show(messageBoxText, "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new OleDbConnection())
                    {
                        connection.ConnectionString = MainForm.Connection;
                        try
                        {
                            connection.Open();
                            OleDbCommand delete = connection.CreateCommand();
                            for (int i = 0; i < rowsCount; i++)
                            {
                                delete.CommandText = "DELETE FROM Employees WHERE ID = '"
                                                     + rows[i].Cells[0].Value.ToString() + "'";
                                delete.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }

                    FillEmployeesTableAsync(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("No rows selected!");
            }
        }

        #endregion

        #region Export

        private void ExportSelectedRows(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowsCount = dataGridView1.SelectedRows.Count;
                DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
                var saveDialog = new SaveFileDialog
                {
                    Title = "Export As...",
                    FileName = "Employees",
                    DefaultExt = ".xml",
                    Filter = "XML|*.xml|Text documents|*.txt|All files|*.*"
                };
                if (DialogResult.OK == saveDialog.ShowDialog())
                {
                    string extension = Path.GetExtension(saveDialog.FileName);
                    switch (extension.ToLower())
                    {
                        case ".txt":
                            ExportTXT(saveDialog.FileName, rows);
                            break;
                        case ".xml":
                            ExportXML(saveDialog.FileName, rows);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No rows selected!");
            }
        }

        private string[,] GetDataGridViewCells(DataGridViewSelectedRowCollection rows)
        {
            using (var connection = new OleDbConnection())
            {
                connection.ConnectionString = Connection;
                OleDbCommand select = connection.CreateCommand();
                string[,] cells = new string[rows.Count, rows[0].Cells.Count];
                connection.Open();
                for (int i = 0; i < rows.Count; i++)
                {
                    select.CommandText = "SELECT * FROM Employees WHERE ID = '"
                                         + rows[i].Cells[0].Value.ToString() + "'";
                    using (OleDbDataReader reader = select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int j = 0; j < rows[0].Cells.Count; j++)
                            {
                                cells[i, j] = reader.GetValue(j).ToString().Trim();
                            }
                        }
                    }
                }

                int rowsNumber = rows.Count / 2;
                int rowsCount = rows.Count - 1;
                for (int i = 0; i < rowsNumber; i++, rowsCount--)
                {
                    for (int j = 0; j < rows[0].Cells.Count; j++)
                    {
                        string temp = cells[i, j];
                        cells[i, j] = cells[rowsCount, j];
                        cells[rowsCount, j] = temp;
                    }
                }

                return cells;
            }
        }

        private void ExportXML(string path, DataGridViewSelectedRowCollection rows)
        {
            Employee[] employees = new Employee[rows.Count];
            string[,] cells = GetDataGridViewCells(rows);
            for (int i = 0; i < rows.Count; i++)
            {
                employees[i] = new Employee(cells[i, 0], cells[i, 1], cells[i, 2], cells[i, 3],
                    cells[i, 4], cells[i, 5], cells[i, 6]);
            }

            try
            {
                using (XmlWriter xmlwriter = XmlWriter.Create(path, new XmlWriterSettings()
                {
                    OmitXmlDeclaration = true, ConformanceLevel = ConformanceLevel.Document, Indent = true
                }))
                {
                    var serializer = new XmlSerializer(typeof(Employee[]));
                    serializer.Serialize(xmlwriter, employees, new XmlSerializerNamespaces(new[]
                    {
                        new System.Xml.XmlQualifiedName("", "")
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExportTXT(string path, DataGridViewSelectedRowCollection rows)
        {
            try
            {
                string[,] cells = GetDataGridViewCells(rows);
                using (StreamWriter writer = File.CreateText(path))
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        for (int j = 0; j < rows[0].Cells.Count; j++)
                        {
                            writer.Write(cells[i, j] + " ");
                        }

                        writer.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        #region Import

        private void ImportEmployees(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog {Title = "Import File...", Filter = "XML|*.xml|All files|*.*"};
            if (DialogResult.OK == openDialog.ShowDialog())
            {
                string extension = Path.GetExtension(openDialog.FileName);
                switch (extension.ToLower())
                {
                    case ".xml":
                        ImportXML(openDialog.FileName);
                        break;
                }
            }
        }

        private void ImportXML(string path)
        {
            using (XmlReader xmlreader = XmlReader.Create(path))
            {
                var serializer = new XmlSerializer(typeof(Employee[]));
                if (serializer.CanDeserialize(xmlreader))
                {
                    Employee[] employees = (Employee[]) serializer.Deserialize(xmlreader);
                    var aef = new AddEmployeeForm();
                    using (OleDbConnection connection = new OleDbConnection())
                    {
                        connection.ConnectionString = MainForm.Connection;
                        try
                        {
                            connection.Open();
                            for (int i = 0; i < employees.Length; i++)
                            {
                                OleDbCommand add = connection.CreateCommand();
                                //employees[i].ID or aef.FindNewID().ToString("D4")
                                add.CommandText = "INSERT INTO Employees (ID, FirstName, MiddleName," +
                                                  " LastName, DateOfBirth, PhoneNumber, HomeAddress)" +
                                                  " VALUES ('" + aef.FindNewID().ToString("D4") + "','" +
                                                  employees[i].FirstName + "','" + employees[i].MiddleName + "','" +
                                                  employees[i].LastName + "','" + employees[i].DateOfBirth + "','" +
                                                  employees[i].PhoneNumber + "','" + employees[i].HomeAddress + "')";
                                add.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                }
            }

            FillEmployeesTableAsync(this, EventArgs.Empty);
        }

        #endregion
    }
}