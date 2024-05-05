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
    public partial class StudentProfile : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        public StudentProfile()
        {
            InitializeComponent();
            // Adding event handler for form load event
            this.Load += StudentProfile_Load;
            // Setting certain textboxes as read-only
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCurrentSubject1.ReadOnly = true;
            txtCurrentSubject2.ReadOnly = true;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Creating instance of StudentMenu form and displaying it
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
            // Hiding the current form
            this.Hide();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            // Call the method to display user information when form is loaded
            DisplayUserInfo();
        }

        private void DisplayUserInfo() // Method to display user information
        {
            try // Begin a try block to handle potential exceptions
            {
                connect.Open(); // Open the database connection
                // SQL query to retrieve user information
                string query = @"SELECT u.id AS UserID, 
                                u.name AS Name, 
                                u.email AS Email, 
                                u.address AS Address, 
                                u.phone AS Phone, 
                                u.dob AS DateOfBirth,
                                u.password,
                                u.role,
                                s.current_subject1 AS CurrentSubject1, 
                                s.current_subject2 AS CurrentSubject2
                            FROM users u
                            INNER JOIN students s ON u.id = s.user_id
                            WHERE u.email = @userEmail"; // Filter by user email
                using (SqlCommand cmd = new SqlCommand(query, connect)) // Create a SqlCommand with the query and connection
                {
                    // Adding parameter for user email
                    cmd.Parameters.AddWithValue("@userEmail", Login.LoggedInUserEmail); // Use logged-in user's email as parameter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create a SqlDataAdapter with the command
                    DataTable table = new DataTable(); // Create a DataTable to hold the results
                    adapter.Fill(table); // Fill the DataTable with the results of the query

                    if (table.Rows.Count > 0) // Check if any rows were returned
                    {
                        DataRow row = table.Rows[0]; // Get the first row from the DataTable
                        SqlDataReader reader = cmd.ExecuteReader(); // Execute the command to get a SqlDataReader
                        while (reader.Read()) // Loop through the rows returned by the SqlDataReader
                        {
                            // Creating Student object to hold user information
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
                                CurrentSubject2 = reader["CurrentSubject2"] != DBNull.Value ? new List<string> { reader["CurrentSubject2"].ToString() } : new List<string>() 
                            };
                            // Add the student to the PersonManager
                            PersonManager.AddPerson(student); // Add the student to the PersonManager
                        }
                        // Displaying user information in textboxes
                        txtName.Text = row["Name"].ToString(); // Set the text of the "txtName" textbox to the Name
                        txtEmail.Text = row["Email"].ToString(); // Set the text of the "txtEmail" textbox to the Email
                        txtAddress.Text = row["Address"].ToString(); // Set the text of the "txtAddress" textbox to the Address
                        intPhone.Text = row["Phone"].ToString(); // Set the text of the "intPhone" textbox to the Phone
                        dateTimePickerDOB.Value = Convert.ToDateTime(row["DateOfBirth"]); // Set the value of the "dateTimePickerDOB" to the DateOfBirth
                        txtCurrentSubject1.Text = row["CurrentSubject1"].ToString(); // Set the text of the "txtCurrentSubject1" textbox to the CurrentSubject1
                        txtCurrentSubject2.Text = row["CurrentSubject2"].ToString(); // Set the text of the "txtCurrentSubject2" textbox to the CurrentSubject2
                    }
                    else // If no rows were returned
                    {
                        MessageBox.Show("No user found with the provided email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show a message box indicating no user was found
                    }
                }
            }
            catch (Exception ex) // Catch any exceptions that occurred
            {
                MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show a message box with the error message
            }
            finally // Finally block to ensure the database connection is closed
            {
                connect.Close(); // Close the database connection
            }
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application when close button is clicked
            Application.Exit();
        }

        private static Student GetPerson(string email, int phone, string address, DateTime dob, List<string> CurrentSubject1, List<string> CurrentSubject2)
        {
            // Loop through the list of persons and return the matching student
            foreach (var person in PersonManager.Persons)
            {
                if (person.Email == email)
                {
                    if (person is Student student)
                    {
                        // Update the student information
                        student.Email = email;
                        student.Address = address;
                        student.Dob = dob;
                        student.Telephone = phone;
                        student.CurrentSubject1 = CurrentSubject1;
                        student.CurrentSubject2 = CurrentSubject2;

                        return student; // Return the updated Student object
                    }
                }
            }
            return null;
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Event handler for the update button click
        {
            if (intPhone.Text == "" || txtAddress.Text == "") // Check if required fields are empty
            {
                // Show error message if required fields are empty
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if phone number has 9 digits
            else if (intPhone.Text.Length != 9) // Check if the phone number length is not 9 digits
            {
                MessageBox.Show("Phone number must be 9 digits long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message
            }
            else // If all validations pass
            {
                if (connect.State != ConnectionState.Open) // Check if the database connection is not already open
                {
                    try // Begin a try block to handle potential exceptions
                    {
                        connect.Open(); // Open the database connection

                        // Update the user's information
                        string email = txtEmail.Text; // Get the email from the email textbox
                        int phone = int.Parse(intPhone.Text); // Parse the phone number from the phone textbox
                        string address = txtAddress.Text; // Get the address from the address textbox
                        DateTime dob = dateTimePickerDOB.Value; // Get the date of birth from the date of birth datetime picker
                        List<string> currentSubject1 = new List<string> { txtCurrentSubject1.Text }; // Create a list with the current subject 1 from the textbox
                        List<string> currentSubject2 = new List<string> { txtCurrentSubject1.Text }; // Create a list with the current subject 2 from the textbox

                        // Retrieve the student from PersonManager
                        Student person = GetPerson(email, phone, address, dob, currentSubject1, currentSubject2); 
                        string currentSubjectString1 = string.Join(",", currentSubject1); // Join the current subjects into a comma-separated string
                        string currentSubjectString2 = string.Join(",", currentSubject2); // Join the current subjects into a comma-separated string

                        // SQL query to update user and student information
                        string updateQuery = @"UPDATE users 
                                               SET  phone = @phone, 
                                                   address = @address, 
                                                   dob = @dob,
                                                   email = @email
                                               WHERE email = @email;

                                               UPDATE students 
                                               SET current_subject1 = @current_subject1, 
                                                   current_subject2 = @current_subject2 
                                               WHERE user_id = (SELECT id FROM users WHERE email = @email)";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connect)) // Create a SqlCommand with the update query and connection
                        {
                            cmd.Parameters.AddWithValue("@phone", person.Telephone); // Add parameter for phone number
                            cmd.Parameters.AddWithValue("@address", person.Address); // Add parameter for address
                            cmd.Parameters.AddWithValue("@dob", person.Dob); // Add parameter for date of birth
                            cmd.Parameters.AddWithValue("@email", person.Email); // Add parameter for email
                            cmd.Parameters.AddWithValue("@current_subject1", currentSubjectString1); // Add parameter for current subject 1
                            cmd.Parameters.AddWithValue("@current_subject2", currentSubjectString2); // Add parameter for current subject 2
                            cmd.Parameters.AddWithValue("@newEmail", person.Email); // Add parameter for new email

                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update query and get the number of rows affected

                            if (rowsAffected > 0) // Check if any rows were affected
                            {
                                MessageBox.Show("Teacher information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a success message
                            }
                            else // If no rows were affected
                            {
                                MessageBox.Show("No teacher found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message
                            }
                        }
                    }
                    catch (Exception ex) // Catch any exceptions that occurred
                    {
                        MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message
                    }
                    finally // Finally block to ensure the database connection is closed
                    {
                        connect.Close(); // Close the database connection
                    }
                }
            }
        }

    }
}
