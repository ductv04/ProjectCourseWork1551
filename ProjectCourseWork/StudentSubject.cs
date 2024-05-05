using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ProjectCourseWork
{
    public partial class StudentSubject : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        public StudentSubject()
        {
            InitializeComponent();
            // Adding event handler for DataGridView cell click event
            StudentSubjectDGV.CellContentClick += StudentsSubjectDGV_CellClick;
            // Display student subjects when form is loaded
            DisplayStudentSubject();
            // Making the Name textbox read-only
            txtName.ReadOnly = true;

        }

        private void DisplayStudentSubject()
        {
            // Check if the connection is not already open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    // Open the database connection
                    connect.Open();
                    // SQL query to retrieve student subjects
                    string query = @"SELECT u.id AS Id, 
                                            u.name AS Name, 
                                            u.email AS Email, 
                                            u.address AS Address, 
                                            u.phone AS Phone, 
                                            u.dob AS DateOfBirth,
                                            u.password,
                                            u.role,
                                            s.current_subject1 AS CurrentSubject1, 
                                            s.current_subject2 AS CurrentSubject2, 
                                            s.prev_subject1 AS PreviousSubject1, 
                                            s.prev_subject2 AS PreviousSubject2
                                    FROM users u
                                    INNER JOIN students s ON u.id = s.user_id";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Create a SqlDataAdapter to fill a DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        // Set DataGridView's DataSource to the DataTable
                        StudentSubjectDGV.DataSource = table;
                        // Hide unnecessary columns
                        StudentSubjectDGV.Columns["password"].Visible = false;
                        StudentSubjectDGV.Columns["role"].Visible = false;
                        StudentSubjectDGV.Columns["Email"].Visible = false;
                        StudentSubjectDGV.Columns["Address"].Visible = false;
                        StudentSubjectDGV.Columns["Phone"].Visible = false;
                        StudentSubjectDGV.Columns["DateOfBirth"].Visible = false;
                        // Execute SqlDataReader to read data while filling DataTable
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create Student object to hold student information
                            Student student = new Student
                            {
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telephone = Convert.ToInt32(reader["Phone"]),
                                Address = reader["Address"].ToString(),
                                Password = reader["password"].ToString(),
                                Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                                Dob = DateTime.Parse(reader["DateOfBirth"].ToString()),
                                // Check for null values and create a list with the CurrentSubject1 if not null
                                CurrentSubject1 = reader["CurrentSubject1"] != DBNull.Value ? new List<string> { reader["CurrentSubject1"].ToString() } : new List<string>(),
                                // Check for null values and create a list with the CurrentSubject2 if not null
                                CurrentSubject2 = reader["CurrentSubject2"] != DBNull.Value ? new List<string> { reader["CurrentSubject2"].ToString() } : new List<string>(),
                                // Check for null values and create a list with the PreviousSubject1 if not null
                                PreviousSubject1 = reader["PreviousSubject1"] != DBNull.Value ? new List<string> { reader["PreviousSubject1"].ToString() } : new List<string>(),
                                // Check for null values and create a list with the PreviousSubject2 if not null
                                PreviousSubject2 = reader["PreviousSubject2"] != DBNull.Value ? new List<string> { reader["PreviousSubject2"].ToString() } : new List<string>()
                            };
                            // Add the student to the PersonManager
                            PersonManager.AddPerson(student);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show error message if there's an exception
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the database connection
                    connect.Close();
                }
            }
        }

        // Variable to hold the index of the selected row in the DataGridView
        int Key = 0;
        private void StudentsSubjectDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = StudentSubjectDGV.Rows[e.RowIndex];
                // Populate textboxes with row data
                txtName.Text = row.Cells["Name"].Value.ToString();
                cmbCurrentSubject1.Text = row.Cells["CurrentSubject1"].Value.ToString();
                cmbCurrentSubject2.Text = row.Cells["CurrentSubject2"].Value.ToString();
                cmbPrevSubject1.Text = row.Cells["PreviousSubject1"].Value.ToString();
                cmbPrevSubject2.Text = row.Cells["PreviousSubject2"].Value.ToString();
                // Store the index of the clicked row
                Key = e.RowIndex;
                row.Selected = true;
            }
        }

        private static Student GetPerson(string name, List<string> CurrentSubject1, List<string> CurrentSubject2, List<string> PreviousSubject1, List<string> PreviousSubject2)
        {
            // Loop through the list of persons and return the matching student
            foreach (var person in PersonManager.Persons)
            {
                if (person.Name == name)
                {
                    if (person is Student student)
                    {
                        // Update student information
                        student.Name = name;
                        student.CurrentSubject1 = CurrentSubject1;
                        student.CurrentSubject2 = CurrentSubject2;
                        student.PreviousSubject1 = PreviousSubject1;
                        student.PreviousSubject2 = PreviousSubject2;
                        return student; // Return the updated Student object
                    }
                }
            }
            return null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (cmbCurrentSubject1.SelectedItem == null ||
                cmbCurrentSubject2.SelectedItem == null ||
                cmbPrevSubject1.SelectedItem == null ||
                cmbPrevSubject2.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the connection is not already open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    // Open the database connection
                    connect.Open();
                    // Retrieve values from UI controls
                    string name = txtName.Text;
                    List<string> currentSubject1 = new List<string> { cmbCurrentSubject1.Text };
                    List<string> currentSubject2 = new List<string> { cmbCurrentSubject2.Text };
                    List<string> previousSubject1 = new List<string> { cmbPrevSubject1.Text };
                    List<string> previousSubject2 = new List<string> { cmbPrevSubject2.Text };

                    // Retrieve the student from PersonManager
                    Student person = GetPerson(name, currentSubject1, currentSubject2, previousSubject1, previousSubject2);
                    // Convert lists to comma-separated strings
                    string currentSubjectString1 = string.Join(",", currentSubject1);
                    string currentSubjectString2 = string.Join(",", currentSubject2);
                    string previousSubjectString1 = string.Join(",", previousSubject1);
                    string previousSubjectString2 = string.Join(",", previousSubject2);

                    // SQL query to update user and student information
                    string updateQuery = @"UPDATE users 
                                   SET name = @name 
                                   WHERE name = @name;

                                   UPDATE students
                                   SET current_subject1 = @current_subject1,
                                       current_subject2 = @current_subject2,
                                       prev_subject1 = @prev_subject1,
                                       prev_subject2 = @prev_subject2
                                   WHERE user_id = (SELECT id FROM users WHERE name = @name)";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        // Add parameters to SQL command
                        cmd.Parameters.AddWithValue("@name", person.Name);
                        cmd.Parameters.AddWithValue("@current_subject1", currentSubjectString1);
                        cmd.Parameters.AddWithValue("@current_subject2", currentSubjectString2);
                        cmd.Parameters.AddWithValue("@prev_subject1", previousSubjectString1);
                        cmd.Parameters.AddWithValue("@prev_subject2", previousSubjectString2);
                        // Execute SQL command and get the number of affected rows
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show success message
                            MessageBox.Show("Student information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the DataGridView
                            DisplayStudentSubject();
                            // Clear fields
                            ClearFields();
                        }
                        else
                        {
                            // Show error message if no student found
                            MessageBox.Show("No student found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show error message if any exception occurs
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the database connection
                    connect.Close();
                }
            }
        }

        private void ClearFields()
        {
            // Clear all textboxes and combo boxes
            txtName.Text = "";
            cmbCurrentSubject1.Text = "";
            cmbCurrentSubject2.Text = "";
            cmbPrevSubject1.Text = "";
            cmbPrevSubject2.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Show TeachingStaffMenu form and hide the current form
            TeachingStaffMenu teachingStaffMenuForm = new TeachingStaffMenu();
            teachingStaffMenuForm.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        // Event handler for click event of btnDelete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    if (StudentSubjectDGV.SelectedRows.Count > 0)
                    {
                        // Get the selected row
                        DataGridViewRow row = StudentSubjectDGV.Rows[Key];
                        foreach (Person person in PersonManager.Persons.OfType<Person>())
                        {
                            if (person.Name == row.Cells["name"].Value.ToString())
                            {
                                if (MessageBox.Show("Are you sure you want to delete this student?\n\nStudent name: " + row.Cells["name"].Value + "\n\nProceed ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    // Remove row from DataGridView
                                    StudentSubjectDGV.Rows.RemoveAt(Key);
                                    // Remove person from PersonManager
                                    PersonManager.Persons.Remove(person);
                                    string deleteStudentsQuery = @"DELETE FROM students WHERE user_id IN (SELECT id FROM users WHERE name = @name)";
                                    string deleteUsersQuery = @"DELETE FROM users WHERE name = @name";
                                    using (SqlCommand deleteStudentsCmd = new SqlCommand(deleteStudentsQuery, connect))
                                    using (SqlCommand deleteUsersCmd = new SqlCommand(deleteUsersQuery, connect))
                                    {
                                        // Set parameters for delete commands
                                        deleteStudentsCmd.Parameters.AddWithValue("@name", person.Name);
                                        deleteUsersCmd.Parameters.AddWithValue("@name", person.Name);

                                        // Execute deletion commands
                                        int studentsRowsAffected = deleteStudentsCmd.ExecuteNonQuery();
                                        int usersRowsAffected = deleteUsersCmd.ExecuteNonQuery();

                                        // Show success message if both deletions are successful
                                        if (studentsRowsAffected > 0 && usersRowsAffected > 0)
                                        {
                                            MessageBox.Show("Student deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            break;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to delete student information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Display error message if required fields are empty
                        MessageBox.Show("Please select a student to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Show error message if there's an exception
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the database connection
                    connect.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayStudentSubject();
            timer1.Start();
        }

        private void StudentSubject_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
