using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ProjectCourseWork
{
    public partial class TeacherProfile : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        public TeacherProfile()
        {
            InitializeComponent();
            // Event handler for handling key press event on intPhone textbox to allow only numeric input
            intPhone.KeyPress += intPhone_KeyPress;
            // Event handler for form load to execute TeacherProfile_Load method
            this.Load += TeacherProfile_Load;
            // Making the Salary textbox read-only
            txtSalary.ReadOnly = true;
        }

        private void intPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only numeric input and control keys like backspace for intPhone textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression for validating email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            // Call the method to display user information when the form is loaded
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            try
            {
                // Open the database connection
                connect.Open();
                // SQL query to retrieve teacher information based on user email
                string query = @"SELECT u.id AS UserID, 
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
                    INNER JOIN teachers t ON u.id = t.user_id
                    WHERE u.email = @userEmail"; // Filter by user email
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@userEmail", Login.LoggedInUserEmail); // Use logged-in user's email
                    // Create SqlDataAdapter to fill DataTable with result
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    // Create DataTable object
                    DataTable table = new DataTable();
                    // Fill DataTable with data from database
                    adapter.Fill(table);    // Read user information from database

                    if (table.Rows.Count > 0)   // Check if user information exists
                    {
                        DataRow row = table.Rows[0]; // Get the first row from the DataTable
                        SqlDataReader reader = cmd.ExecuteReader(); // Execute the command to get a SqlDataReader
                        while (reader.Read()) // Read user information from database
                        {
                            // Create Teacher object to hold teacher information
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
                        // Populate UI controls with user information
                        txtName.Text = row["Name"].ToString(); // Set the text of the "txtName" textbox to the Name
                        txtEmail.Text = row["Email"].ToString(); // Set the text of the "txtEmail" textbox to the Email
                        txtAddress.Text = row["Address"].ToString(); // Set the text of the "txtAddress" textbox to the Address
                        intPhone.Text = row["Phone"].ToString(); // Set the text of the "intPhone" textbox to the Phone
                        txtSalary.Text = row["Salary"].ToString(); // Set the text of the "txtSalary" textbox to the Salary
                        dateTimePickerDOB.Value = Convert.ToDateTime(row["DateOfBirth"]); // Set the value of the "dateTimePickerDOB" to the DateOfBirth
                        cmbSubject.SelectedItem = row["Subject"].ToString();    // Set the selected item of "cmbSubject" to the Subject
                    }
                    else
                    {
                        // Show error message if no user found with the provided email
                        MessageBox.Show("No user found with the provided email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if any exception occurs while connecting to the database
                MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connect.Close();
            }
        }

        private static Teacher GetPerson(string name,string oldEmail, string email, int phone, string address, DateTime dob, float salary, List<string> subjects)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled and valid
            if (txtEmail.Text == "" || txtName.Text == "" || intPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cmbSubject.Text))
            {
                MessageBox.Show("Please fill in Subject fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if phone number has 9 digits
            else if (intPhone.Text.Length != 9)
            {
                MessageBox.Show("Phone number must be 9 digits long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Validate email format
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        // Check if the updated email already exists in the database and it's not the same as the current email
                        string existingEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @newEmail AND email != @oldEmail";
                        using (SqlCommand checkEmailCmd = new SqlCommand(existingEmailQuery, connect))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@newEmail", txtEmail.Text);
                            checkEmailCmd.Parameters.AddWithValue("@oldEmail", Login.LoggedInUserEmail); // Use logged-in user's email
                            int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();

                            if (existingEmailCount > 0) // Check if email already exists
                            {
                                MessageBox.Show("Email already exists in the database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        // Update the user's information
                        string name = txtName.Text; // Getting name from text box
                        string email = txtEmail.Text; // Getting email from text box
                        string oldEmail = Login.LoggedInUserEmail; // Getting old email from logged-in user
                        int phone = int.Parse(intPhone.Text); // Parsing phone number from text box
                        string address = txtAddress.Text; // Getting address from text box
                        DateTime dob = dateTimePickerDOB.Value; // Getting date of birth from date picker
                        float salary = float.Parse(txtSalary.Text); // Parsing salary from text box
                        List<string> subjects = new List<string> { cmbSubject.Text }; // Create list of subjects 


                        Teacher person = GetPerson(name, oldEmail, email, phone, address, dob, salary, subjects);   // Create Teacher object
                        string subjectString = string.Join(",", subjects); // Convert list of subjects to comma-separated string
                        // SQL query to update user and teacher information
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
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                        {
                            // Add parameters to SQL command
                            cmd.Parameters.AddWithValue("@name", person.Name);
                            cmd.Parameters.AddWithValue("@phone", person.Telephone);
                            cmd.Parameters.AddWithValue("@address", person.Address);
                            cmd.Parameters.AddWithValue("@dob", person.Dob);
                            cmd.Parameters.AddWithValue("@salary", person.Salary);
                            cmd.Parameters.AddWithValue("@subject", subjectString);
                            cmd.Parameters.AddWithValue("@newEmail", person.Email);
                            // Update the information of the currently logged-in user
                            cmd.Parameters.AddWithValue("@oldEmail", oldEmail); // Use logged-in user's email

                            Login.LoggedInUserEmail = txtEmail.Text; // Update the LoggedInUserEmail with the new email
                            // Execute SQL command and get the number of affected rows
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)   // Check if rows are affected by update
                            {
                                // Show success message
                                MessageBox.Show("Teacher information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Show error message if no teacher found with the provided email
                                MessageBox.Show("No teacher found with the provided email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Show TeachingStaffMenu form and hide the current form
            TeachingStaffMenu teachingStaffMenu = new TeachingStaffMenu();
            teachingStaffMenu.Show();
            this.Hide();
        }
    }
}
