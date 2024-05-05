using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

// Define the namespace and class for the form
namespace ProjectCourseWork
{
    public partial class AdminProfile : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..","..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        // Constructor method for the form
        public AdminProfile()
        {
            InitializeComponent(); // Initialize the form components
            // Attach event handler to handle only numeric input for the phone number field
            intPhone.KeyPress += intPhone_KeyPress;
            // Attach event handler to handle only numeric input for the salary field
            txtSalary.KeyPress += txtSalary_KeyPress;
            // Load event handler to populate user information when the form loads
            this.Load += AdminProfile_Load;
        }

        // Event handler to allow only numeric input for phone number field
        private void intPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only numeric input and control keys like backspace
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

        // Method to validate email using regular expression
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern to match valid email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        // Load event handler to display user information when the form loads
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            DisplayUserInfo(); // Call the method to display user information
        }

        // Method to display user information in the form controls
        private void DisplayUserInfo() // Method to display user information
        {
            try // Begin a try block to handle potential exceptions
            {
                connect.Open(); // Open database connection
                // SQL query to retrieve user information
                string query = @"SELECT u.id AS UserID, 
                                u.name AS Name, 
                                u.email AS Email, 
                                u.address AS Address, 
                                u.phone AS Phone, 
                                u.dob AS DateOfBirth, 
                                u.password,
                                u.role,
                                a.employment_type AS EmploymentType,
                                a.working_hours AS WorkingHours,
                                a.salary AS Salary
                            FROM users u
                            INNER JOIN admins a ON u.id = a.user_id
                            WHERE u.email = @userEmail"; // Filter by user email
                using (SqlCommand cmd = new SqlCommand(query, connect)) // Create a SqlCommand with the query and connection
                {
                    // Add parameter for user email
                    cmd.Parameters.AddWithValue("@userEmail", Login.LoggedInUserEmail); // Use logged-in user's email as parameter
                                                                                        // Create SqlDataAdapter to fill DataTable with result
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create a SqlDataAdapter with the command
                    DataTable table = new DataTable(); // Create a DataTable to hold the results
                    adapter.Fill(table); // Fill the DataTable with the results of the query

                    if (table.Rows.Count > 0) // Check if user information exists
                    {
                        DataRow row = table.Rows[0]; // Get the first row from the DataTable
                        SqlDataReader reader = cmd.ExecuteReader(); // Execute the command to get a SqlDataReader
                        while (reader.Read()) // Read user information from database
                        {
                            // Create an Administration object and populate it with data from the database
                            Administration admin = new Administration // Create a new Administration object
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
                                // Extract the value of WorkingHours from the database reader. If the value is not DBNull, convert it to a string and assign it to the WorkingHours variable. Otherwise, assign an empty string.
                                WorkingHours = reader["WorkingHours"] != DBNull.Value ? reader["WorkingHours"].ToString() : "",
                                // Extract the value of EmploymentType from the database reader. If the value is not DBNull, convert it to a string and assign it to the EmploymentType variable. Otherwise, assign an empty string.
                                EmploymentType = reader["EmploymentType"] != DBNull.Value ? reader["EmploymentType"].ToString() : "",
                            };
                            // Add the admin to the PersonManager
                            PersonManager.AddPerson(admin); // Add the admin to the PersonManager
                        }
                        // Populate form controls with user information
                        txtName.Text = row["Name"].ToString(); // Set the text of the "txtName" textbox to the Name
                        txtEmail.Text = row["Email"].ToString(); // Set the text of the "txtEmail" textbox to the Email
                        txtAddress.Text = row["Address"].ToString(); // Set the text of the "txtAddress" textbox to the Address
                        intPhone.Text = row["Phone"].ToString(); // Set the text of the "intPhone" textbox to the Phone
                        txtSalary.Text = row["Salary"].ToString(); // Set the text of the "txtSalary" textbox to the Salary
                        dateTimePickerDOB.Value = Convert.ToDateTime(row["DateOfBirth"]); // Set the value of the "dateTimePickerDOB" to the DateOfBirth
                        cmbEmploymentType.SelectedItem = row["EmploymentType"].ToString(); // Set the selected item of "cmbEmploymentType" to the EmploymentType
                        cmbWorkingHours.SelectedItem = row["WorkingHours"].ToString(); // Set the selected item of "cmbWorkingHours" to the WorkingHours
                    }
                    else 
                    {
                        // Show the message box if no user found 
                        MessageBox.Show("No user found with the provided email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show a message box indicating no user was found
                    }
                }
            }
            catch (Exception ex) // Catch any exceptions that occurred
            {
                // Show error message if there's an exception
                MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show a message box with the error message
            }
            finally // Finally block to ensure the database connection is closed
            {
                connect.Close(); // Close database connection
            }
        }


        // Method to retrieve Administration object from PersonManager
        private static Administration GetPerson(string name,string oldEmail, string email, int phone, string address, DateTime dob, float salary, string workingHours, string employmentType)
        {
            // Loop through the list of persons and return the matching admin
            foreach (var person in PersonManager.Persons)
            {
                if (person.Email == oldEmail)
                {
                    if (person is Administration admin)
                    {
                        // Update Administration object with new data
                        admin.Name = name;
                        admin.Email = email;
                        admin.Address = address;
                        admin.Dob = dob;
                        admin.Telephone = phone;
                        admin.Salary = salary;
                        admin.WorkingHours = workingHours;
                        admin.EmploymentType = employmentType;
                        return admin; // Return the updated Administration object
                    }
                }
            }
            return null;
        }


        // Method to update user information
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validation checks for empty fields, valid email, and phone number length
            if (txtEmail.Text == "" || txtName.Text == "" || intPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidEmail(txtEmail.Text)) // Checking if the entered email is valid
            {
                MessageBox.Show("Please enter a valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (intPhone.Text.Length != 9) // Checking if phone number length is not equal to 9
            {
                MessageBox.Show("Phone number must be 9 digits long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open) // Check if database connection is open
                {
                    try
                    {
                        connect.Open(); // Open database connection
                                        // Check if the updated email already exists in the database and it's not the same as the current email
                        string existingEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @newEmail AND email != @oldEmail";
                        using (SqlCommand checkEmailCmd = new SqlCommand(existingEmailQuery, connect))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@newEmail", txtEmail.Text);
                            checkEmailCmd.Parameters.AddWithValue("@oldEmail", Login.LoggedInUserEmail); // Use logged-in user's email
                            int existingEmailCount = (int)checkEmailCmd.ExecuteScalar(); // Execute scalar query

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
                        string workingHours = cmbWorkingHours.Text; // Getting working hours from combo box
                        string employmentType = cmbEmploymentType.Text; // Getting employment type from combo box

                        // Retrieve the Administration object to be updated
                        Administration person = GetPerson(name, oldEmail, email, phone, address, dob, salary, workingHours, employmentType); // Creating an Administration object

                        // SQL update query
                        string updateQuery = @"UPDATE users 
                               SET name = @name, 
                                   email = @newEmail,
                                   phone = @phone, 
                                   address = @address,
                                   dob = @dob 
                               WHERE email = @oldEmail; 

                               UPDATE admins 
                               SET employment_type = @employmentType, 
                                   working_hours = @workingHours,
                                   salary = @salary
                               WHERE user_id = (SELECT id FROM users WHERE email = @newEmail)";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                        {
                            // Add parameters to the SQL command
                            cmd.Parameters.AddWithValue("@name", person.Name);
                            cmd.Parameters.AddWithValue("@newEmail", person.Email);
                            cmd.Parameters.AddWithValue("@phone", person.Telephone);
                            cmd.Parameters.AddWithValue("@address", person.Address);
                            cmd.Parameters.AddWithValue("@dob", person.Dob);
                            cmd.Parameters.AddWithValue("@employmentType", person.EmploymentType);
                            cmd.Parameters.AddWithValue("@workingHours", person.WorkingHours);
                            cmd.Parameters.AddWithValue("@salary", person.Salary);
                            // Update the information of the currently logged-in user
                            cmd.Parameters.AddWithValue("@oldEmail", oldEmail); // Use logged-in user's email

                            Login.LoggedInUserEmail = txtEmail.Text; // Update the LoggedInUserEmail with the new email

                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update query

                            if (rowsAffected > 0) // Check if rows are affected by update
                            {
                                // Show message box updated successfully
                                MessageBox.Show("Admin information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Show error message if an update fail
                                MessageBox.Show("Failed to update admin information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Close button click event handler to exit the application
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        // Back button click event handler to navigate back to the admin menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(); // Create instance of AdminMenu form
            adminMenu.Show(); // Show AdminMenu form
            this.Hide(); // Hide current form
        }
    }
}
