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
    public partial class ViewStudentSubject : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);



        public ViewStudentSubject()
        {
            InitializeComponent(); // Initialize the components of the form
            this.Load += StudentSubject_Load; // Add an event handler for the form load event
            txtEmail.ReadOnly = true; // Set the Email text box to read-only
            txtName.ReadOnly = true; // Set the Name text box to read-only
            txtCurrentSubject1.ReadOnly = true; // Set the CurrentSubject1 text box to read-only
            txtCurrentSubject2.ReadOnly = true; // Set the CurrentSubject2 text box to read-only
            txtPrevSubject1.ReadOnly = true;    // Set the PrevSubject1 text box to read-only
            txtPrevSubject2.ReadOnly = true;    // Set the PrevSubject2 text box to read-only
        }

        // Event handler for the form load event
        private void StudentSubject_Load(object sender, EventArgs e)
        {
            DisplayUserInfo(); // Call the method to display user information when the form loads
        }

        // Method to display user information
        private void DisplayUserInfo()
        {
            try
            {
                connect.Open(); // Open the database connection
                string query = @"SELECT u.id AS UserID, 
                                        u.name AS Name, 
                                        u.email AS Email,
                                        s.current_subject1 AS CurrentSubject1, 
                                        s.current_subject2 AS CurrentSubject2,
                                        s.prev_subject1 AS PreviousSubject1,
                                        s.prev_subject2 AS PreviousSubject2
                                    FROM users u
                                    INNER JOIN students s ON u.id = s.user_id
                                    WHERE u.email = @userEmail"; // SQL query to fetch user information
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@userEmail", Login.LoggedInUserEmail); // Use logged-in user's email as parameter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create a data adapter
                    DataTable table = new DataTable(); // Create a DataTable to store the fetched data
                    adapter.Fill(table); // Fill the DataTable with data from the database

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0]; // Get the first row from the DataTable
                        txtName.Text = row["Name"].ToString(); // Set the Name text box text to the user's name
                        txtEmail.Text = row["Email"].ToString(); // Set the Email text box text to the user's email
                        txtCurrentSubject1.Text = row["CurrentSubject1"].ToString(); // Set the CurrentSubject1 text box text to the user's current subject 1
                        txtCurrentSubject2.Text = row["CurrentSubject2"].ToString(); // Set the CurrentSubject2 text box text to the user's current subject 2
                        txtPrevSubject1.Text = row["PreviousSubject1"].ToString(); // Set the PreviousSubject1 text box text to the user's previous subject 1
                        txtPrevSubject2.Text = row["PreviousSubject2"].ToString(); // Set the PreviousSubject2 text box text to the user's previous subject 2
                    }
                    else
                    {
                        // Show the message box if no user found 
                        MessageBox.Show("No user found with the provided email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message if no user is found with the provided email
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an exception
                MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message if there is an exception while connecting to the database
            }
            finally
            {
                connect.Close(); // Close the database connection
            }
        }

        // Event handler for the Back button click event
        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentMenu studentMenu = new StudentMenu(); // Create an instance of StudentMenu form
            studentMenu.Show(); // Show the StudentMenu form
            this.Hide(); // Hide the current form
        }

        // Event handler for the Close button click event
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the Close button is clicked
        }
    }
}
