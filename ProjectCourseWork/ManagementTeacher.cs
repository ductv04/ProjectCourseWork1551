using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System;
using System.IO;


namespace ProjectCourseWork
{
    public partial class ManagementTeacher : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);

        public ManagementTeacher()
        {
            InitializeComponent();
            // Add event handler for KeyPress event of intPhone TextBox
            intPhone.KeyPress += intPhone_KeyPress;
            // Attach event handler to handle only numeric input for the salary field
            txtSalary.KeyPress += txtSalary_KeyPress;
            // Add event handler for CellContentClick event of TeacherDGV DataGridView
            TeacherDGV.CellContentClick += TeachersDGV_CellContentClick;
            // Call DisplayTeacher method to display teacher data
            DisplayTeacher();
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

        // Event handler for KeyPress event of txtSalary TextBox
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
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

        int Key = 0;
        // Event handler for CellContentClick event of TeacherDGV DataGridView
        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve data from selected row and populate TextBoxes and other controls
                DataGridViewRow row = TeacherDGV.Rows[e.RowIndex];
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                intPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtSalary.Text = row.Cells["salary"].Value.ToString();
                cmbSubject.SelectedItem = row.Cells["subject"].Value.ToString();
                dateTimePickerDOB.Value = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString());
                Key = e.RowIndex; // Store the index of the selected row
                row.Selected = true;
            }
        }

        // Method to display teacher data
        private void DisplayTeacher()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    // Open database connection
                    connect.Open();
                    // SQL query to select teacher data with a join to get related records from both tables
                    string query = @"SELECT u.id AS Id, 
                            u.name AS Name, 
                            u.email AS Email, 
                            u.address AS Address, 
                            u.phone AS Phone, 
                            u.dob AS DateOfBirth, 
                            u.role,
                            u.password,
                            t.salary AS Salary,
                            t.subject AS Subject
                    FROM users u
                    INNER JOIN teachers t ON u.id = t.user_id";
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
                        TeacherDGV.DataSource = table;
                        // Hide certain columns
                        TeacherDGV.Columns["password"].Visible = false;
                        TeacherDGV.Columns["role"].Visible = false;
                        // Execute reader to retrieve individual records
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())   // Read user information from database
                        {
                            // Create Teacher object for each record and add to PersonManager
                            Teacher teacher = new Teacher
                            {
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telephone = Convert.ToInt32(reader["Phone"]),
                                Address = reader["Address"].ToString(),
                                Password = reader["password"].ToString(),
                                Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                                Dob = DateTime.Parse(reader["DateOfBirth"].ToString()),
                                // Check for null values before converting
                                Salary = reader["Salary"] != DBNull.Value ? Convert.ToSingle(reader["Salary"]) : 0.0f,
                                // Check for null values and create a list with the subject if not null
                                Subjects = reader["Subject"] != DBNull.Value ? new List<string> { reader["Subject"].ToString() } : new List<string>()
                            };
                            // Add the teacher to the PersonManager
                            PersonManager.AddPerson(teacher);
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

        // Method to update teacher information
        private static Teacher GetPerson(string name, string oldEmail, string email, int phone, string address, DateTime dob, float salary, List<string> subjects)
        {
            // Loop through the list of persons and return the matching teacher
            foreach (var person in PersonManager.Persons)
            {
                if (person.Email == oldEmail)
                {
                    if (person is Teacher teacher)
                    {
                        // Update Teacher object with new data
                        teacher.Name = name;
                        teacher.Email = email;
                        teacher.Address = address;
                        teacher.Dob = dob;
                        teacher.Telephone = phone;
                        teacher.Salary = salary;
                        teacher.Subjects = subjects;
                        return teacher; // Return the updated Teacher object
                    }
                }
            }
            return null;
        }

        // Event handler for Click event of btnUpdate Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (txtEmail.Text == "" || txtName.Text == "" || intPhone.Text == "" || txtAddress.Text == "")
            {
                // Display error message if any of the required fields are empty
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(cmbSubject.Text))
            {
                // Display error message if salary and subject fields are empty
                MessageBox.Show("Please fill in both Salary and Subject fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if phone number has 9 digits
            else if (intPhone.Text.Length != 9)
            {
                // Display error message if phone number is not 9 digits long
                MessageBox.Show("Phone number must be 9 digits long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Validate email format
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
                        // Open database connection
                        connect.Open();

                        // Check if email already exists in the database
                        string existingEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
                        using (SqlCommand checkEmailCmd = new SqlCommand(existingEmailQuery, connect))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            // Execute the query to count existing emails
                            int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();
                            // If email exists and it's not the same as the old email, show error message
                            if (existingEmailCount > 0 && txtEmail.Text != TeacherDGV.Rows[Key].Cells["email"].Value.ToString())
                            {
                                MessageBox.Show("Email already exists in the database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        // Update the user's information
                        string name = txtName.Text; // Get name from text box
                        string email = txtEmail.Text; // Get email from text box
                        string oldEmail = TeacherDGV.Rows[Key].Cells["email"].Value.ToString(); // Get old email from DataGridView
                        int phone = int.Parse(intPhone.Text); // Parse phone number from text box
                        string address = txtAddress.Text; // Get address from text box
                        DateTime dob = dateTimePickerDOB.Value; // Get date of birth from date picker
                        float salary = float.Parse(txtSalary.Text); // Parse salary from text box
                        List<string> subjects = new List<string> { cmbSubject.Text }; // Create list of subjects 

                        // Get the Teacher object with updated information
                        Teacher person = GetPerson(name, oldEmail, email, phone, address, dob, salary, subjects); // Create Teacher object
                        string subjectString = string.Join(",", subjects); // Convert list of subjects to comma-separated string

                        // SQL query to update user and teacher tables
                        string updateQuery = @"UPDATE users 
                                               SET name = @name, 
                                                   phone = @phone, 
                                                   address = @address, 
                                                   dob = @dob,
                                                   email = @newEmail
                                               WHERE email = @oldEmail;

                                               UPDATE teachers 
                                               SET salary = @salary, 
                                                   subject = @subject 
                                               WHERE user_id = (SELECT id FROM users WHERE email = @newEmail)";
                        // Execute SQL command
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", person.Name);
                            cmd.Parameters.AddWithValue("@phone", person.Telephone);
                            cmd.Parameters.AddWithValue("@address", person.Address);
                            cmd.Parameters.AddWithValue("@dob", person.Dob);
                            cmd.Parameters.AddWithValue("@salary", person.Salary);
                            cmd.Parameters.AddWithValue("@subject", subjectString);
                            cmd.Parameters.AddWithValue("@newEmail", person.Email);
                            cmd.Parameters.AddWithValue("@oldEmail", oldEmail);

                            // Execute the update command and get the number of rows affected
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)   // Check if rows are affected by update
                            {
                                // Show message box update successfully
                                MessageBox.Show("Teacher information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView
                                DisplayTeacher();
                                // Clear fields
                                ClearFields();
                            }
                            else
                            {
                                // Show error message if updated fail
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
                        // Close database connection
                        connect.Close();
                    }
                }
            }
        }


        // Event handler for Click event of closebtn Button
        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        // Event handler for Click event of btnBack Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to AdminMenu form
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }

        // Event handler for Click event of btnDelete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    if (TeacherDGV.SelectedRows.Count > 0)
                    {
                        // Get the selected row
                        DataGridViewRow row = TeacherDGV.Rows[Key];
                        foreach (Person person in PersonManager.Persons.OfType<Person>())
                        {
                            if (person.Email == row.Cells["email"].Value.ToString())
                            {
                                if (MessageBox.Show("Are you sure you want to delete this teacher?\n\nTeacher name: " + row.Cells["name"].Value + "\n\nProceed ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    // Remove row from DataGridView
                                    TeacherDGV.Rows.RemoveAt(Key);
                                    // Remove person from PersonManager
                                    PersonManager.Persons.Remove(person);
                                    string deleteTeachersQuery = @"DELETE FROM teachers WHERE user_id IN (SELECT id FROM users WHERE email = @email)";
                                    string deleteUsersQuery = @"DELETE FROM users WHERE email = @email";
                                    using (SqlCommand deleteTeachersCmd = new SqlCommand(deleteTeachersQuery, connect))
                                    using (SqlCommand deleteUsersCmd = new SqlCommand(deleteUsersQuery, connect))
                                    {
                                        // Set parameters for delete commands
                                        deleteTeachersCmd.Parameters.AddWithValue("@email", person.Email);
                                        deleteUsersCmd.Parameters.AddWithValue("@email", person.Email);

                                        // Execute deletion commands
                                        int studentsRowsAffected = deleteTeachersCmd.ExecuteNonQuery();
                                        int usersRowsAffected = deleteUsersCmd.ExecuteNonQuery();

                                        // Show success message if both deletions are successful
                                        if (studentsRowsAffected > 0 && usersRowsAffected > 0)
                                        {
                                            MessageBox.Show("Teacher deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            break;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to delete teacher information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Display error message if required fields are empty
                        MessageBox.Show("Please select a teacher to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtName.Text = "";
            txtEmail.Text = "";
            intPhone.Text = "";
            txtAddress.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;
            txtSalary.Text = "";
            cmbSubject.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayTeacher();
            timer1.Start();
        }

        private void ManagementTeacher_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
