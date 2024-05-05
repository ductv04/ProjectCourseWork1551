using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ProjectCourseWork
{
    public partial class ManagementStudent : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        public ManagementStudent()
        {
            InitializeComponent();
            // Add event handler for KeyPress event of intPhone TextBox
            intPhone.KeyPress += intPhone_KeyPress;
            // Add event handler for CellContentClick event of StudentsDGV DataGridView
            StudentsDGV.CellContentClick += StudentsDGV_CellContentClick;
            // Call DisplayStudent method to display student data
            DisplayStudent();
        }

        // Event handler for KeyPress event of intPhone TextBox
        private void intPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Method to validate email format using regular expression
        private bool IsValidEmail(string email)
        {
            // Regular expression for validating email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        // Method to display student data
        private void DisplayStudent()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    // Open database connection
                    connect.Open();
                    // SQL query to select student data
                    string query = "SELECT id AS Id, name AS Name, email AS Email, address AS Address, dob AS DateOfBirth, password, role, phone AS Phone FROM users WHERE role ='Student'";
                    // Execute SQL command
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Create SqlDataAdapter to fill DataTable with result
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        // Create DataTable object
                        DataTable table = new DataTable();
                        // Fill DataTable with data from database
                        adapter.Fill(table);
                        // Set DataGridView's DataSource to DataTable
                        StudentsDGV.DataSource = table;
                        // Hide certain columns
                        StudentsDGV.Columns["password"].Visible = false;
                        StudentsDGV.Columns["role"].Visible = false;
                        // Execute reader to retrieve individual records
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()) // Read user information from database
                        {
                            // Create Student object for each record and add to PersonManager
                            Student student = new Student
                            {
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telephone = Convert.ToInt32(reader["Phone"]),
                                Address = reader["Address"].ToString(),
                                Password = reader["password"].ToString(),
                                Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                                Dob = DateTime.Parse(reader["DateOfBirth"].ToString()),
                            };
                            // Add the student to the PersonManager
                            PersonManager.AddPerson(student);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show error message if there's an exception
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close database connection
                    connect.Close();
                }
            }
        }
        int Key = 0;
        // Event handler for CellContentClick event of StudentsDGV DataGridView
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve data from selected row and populate TextBoxes
                DataGridViewRow row = StudentsDGV.Rows[e.RowIndex];
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                intPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                dateTimePickerDOB.Value = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString());
                Key = e.RowIndex; // Store the index of the selected row
                row.Selected = true;
            }
        }

        // Method to update student information
        private static Student GetPerson(string name, string oldEmail, string email, int phone, string address, DateTime dob)
        {
            // Loop through the list of persons and return the matching student
            foreach (var person in PersonManager.Persons)
            {
                if (person.Email == oldEmail)
                {
                    if (person is Student student)
                    {
                        // Update Student object with new data
                        student.Name = name;
                        student.Email = email;
                        student.Address = address;
                        student.Dob = dob;
                        student.Telephone = phone;
                        return student; // Return the updated Student object
                    }
                }
            }
            return null;
        }

        // Event handler for click event of btnUpdate Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check for empty fields, valid phone number, and valid email format
            if (txtEmail.Text == "" || txtName.Text == "" || intPhone.Text == "" || txtAddress.Text == "" || txtEmail.Text == "")
            {
                // Display error message if any of the required fields are empty
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (intPhone.Text.Length != 9)
            {
                // Display error message if phone number is not 9 digits long
                MessageBox.Show("Phone number must be 9 digits long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                // Display error message if email format is not valid
                MessageBox.Show("Please enter a valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // Check if email already exists in the database
                        string existingEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
                        using (SqlCommand checkEmailCmd = new SqlCommand(existingEmailQuery, connect))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            // Execute the query to count existing emails
                            int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();
                            // If email exists and it's not the same as the old email, show error message
                            if (existingEmailCount > 0 && txtEmail.Text != StudentsDGV.Rows[Key].Cells["email"].Value.ToString())
                            {
                                MessageBox.Show("Email already exists in the database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        // Update user's information
                        string name = txtName.Text; // Get name from text box
                        string oldEmail = StudentsDGV.Rows[Key].Cells["email"].Value.ToString(); // Get the old email address
                        string email = txtEmail.Text; // Get email from text box
                        int phone = int.Parse(intPhone.Text); // Parse phone number from text box
                        string address = txtAddress.Text; // Get address from text box
                        DateTime dob = dateTimePickerDOB.Value; // Get date of birth from date picker

                        // Create Student object with updated information
                        Student student = GetPerson(name, oldEmail, email, phone, address, dob); // Create Student object

                        // SQL query to update user information in the database
                        string updateQuery = @"UPDATE users SET name = @name, email = @newEmail, phone = @phone, address = @address, dob = @dob WHERE email = @oldEmail";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                        {
                            // Add parameters to the SQL command
                            cmd.Parameters.AddWithValue("@name", student.Name);
                            cmd.Parameters.AddWithValue("@newEmail", student.Email);
                            cmd.Parameters.AddWithValue("@phone", student.Telephone);
                            cmd.Parameters.AddWithValue("@address", student.Address);
                            cmd.Parameters.AddWithValue("@dob", student.Dob);
                            cmd.Parameters.AddWithValue("@oldEmail", oldEmail);

                            // Execute the update command and get the number of rows affected
                            int rowsAffected = cmd.ExecuteNonQuery();
                            DisplayStudent();
                            if (rowsAffected > 0)   // Check if rows are affected by update
                            {

                                // Show success message if update is successful
                                MessageBox.Show("Student information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear fields
                                ClearFields();
                                // Refresh DataGridView
                                DisplayStudent();
                            }
                            else
                            {
                                // Show a success message if an update fails
                                MessageBox.Show("Failed to update student information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }



        // Event handler for click event of btnBack Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to AdminMenu form
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }

        // Event handler for click event of btnDelete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    if (StudentsDGV.SelectedRows.Count > 0)
                    {
                        // Get the selected row
                        DataGridViewRow row = StudentsDGV.Rows[Key];
                        foreach (Person person in PersonManager.Persons.OfType<Person>())
                        {
                            if (person.Email == row.Cells["email"].Value.ToString())
                            {
                                if (MessageBox.Show("Are you sure you want to delete this student?\n\nStudent name: " + row.Cells["name"].Value + "\n\nProceed ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    // Remove row from DataGridView
                                    StudentsDGV.Rows.RemoveAt(Key);
                                    // Remove person from PersonManager
                                    PersonManager.Persons.Remove(person);
                                    string deleteStudentsQuery = @"DELETE FROM students WHERE user_id IN (SELECT id FROM users WHERE email = @email)";
                                    string deleteUsersQuery = @"DELETE FROM users WHERE email = @email";
                                    using (SqlCommand deleteStudentsCmd = new SqlCommand(deleteStudentsQuery, connect))
                                    using (SqlCommand deleteUsersCmd = new SqlCommand(deleteUsersQuery, connect))
                                    {
                                        // Set parameters for delete commands
                                        deleteStudentsCmd.Parameters.AddWithValue("@email", person.Email);
                                        deleteUsersCmd.Parameters.AddWithValue("@email", person.Email);

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

        // Method to clear input fields
        private void ClearFields()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            intPhone.Text = "";
            txtAddress.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;
        }

        // Event handler for click event of closebtn Button
        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void ManagementStudent_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayStudent();
            timer1.Start();
        }
    }
}
