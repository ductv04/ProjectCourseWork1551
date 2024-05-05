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
    public partial class Login : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        // Static variable to store the email of the logged-in user
        public static string LoggedInUserEmail;

        public Login()
        {
            InitializeComponent();
        }

        // Close button click event handler to exit the application
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        // LinkLabel click event handler to navigate to the sign-up form
        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp(); // Create an instance of the SignUp form
            signUpForm.Show(); // Show the SignUp form
            this.Hide(); // Hide the current form (Login form)
        }

        // Button click event handler to perform user login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if email or password is empty
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter email and password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                return; // Exit the method
            }

            try
            {
                connect.Open(); // Open database connection
                string selectData = "SELECT * FROM users WHERE email=@email AND password=@password"; // SQL query to select user data
                using (SqlCommand cmd = new SqlCommand(selectData, connect)) // Create SqlCommand object
                {
                    // Add parameters to the SQL query
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter object
                    DataTable table = new DataTable(); // Create DataTable object
                    adapter.Fill(table); // Fill DataTable with data from database

                    if (table.Rows.Count >= 1) // If user data exists
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) // Create SqlDataReader object
                        {
                            if (reader.Read()) // Read user data
                            {
                                // Check user role and navigate to respective menu
                                if (reader["role"].ToString() == Role.Administration.ToString())
                                {
                                    // Create Administration object and populate data from database
                                    Administration admin = new Administration
                                    {
                                        Name = reader["name"].ToString(),
                                        Email = reader["email"].ToString(),
                                        Telephone = Convert.ToInt32(reader["phone"]),
                                        Address = reader["address"].ToString(),
                                        Password = reader["password"].ToString(),
                                        Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                                        Dob = DateTime.Parse(reader["dob"].ToString())
                                    };
                                    AdminMenu adminMenu = new AdminMenu(); // Create an instance of the AdminMenu form
                                    MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                                    adminMenu.Show(); // Show the AdminMenu form
                                    this.Hide(); // Hide the current form (Login form)
                                }
                                else if (reader["role"].ToString() == Role.TeachingStaff.ToString())
                                {
                                    // Create Teaching Staff object and populate data from database
                                    Teacher teacher = new Teacher
                                    {
                                        Name = reader["name"].ToString(),
                                        Email = reader["email"].ToString(),
                                        Telephone = Convert.ToInt32(reader["phone"]),
                                        Address = reader["address"].ToString(),
                                        Password = reader["password"].ToString(),
                                        Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                                        Dob = DateTime.Parse(reader["dob"].ToString())
                                    };
                                    TeachingStaffMenu teachingStaffMenu = new TeachingStaffMenu(); // Create an instance of the TeachingStaffMenu form
                                    MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                                    teachingStaffMenu.Show(); // Show the AdminMenu form
                                    this.Hide(); // Hide the current form (Login form)
                                }
                                else if (reader["role"].ToString() == Role.Student.ToString())
                                {
                                    // Create Teaching Staff object and populate data from database
                                    Teacher teacher = new Teacher
                                    {
                                        Name = reader["name"].ToString(),
                                        Email = reader["email"].ToString(),
                                        Telephone = Convert.ToInt32(reader["phone"]),
                                        Address = reader["address"].ToString(),
                                        Password = reader["password"].ToString(),
                                        Role = (Role)Enum.Parse(typeof(Role), reader["role"].ToString()),
                                        Dob = DateTime.Parse(reader["dob"].ToString())
                                    };
                                    StudentMenu studentMenu = new StudentMenu(); // Create an instance of the StudentMenu form
                                    MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                                    studentMenu.Show(); // Show the StudentMenu form
                                    this.Hide(); // Hide the current form (Login form)
                                }
                                else
                                {
                                    MessageBox.Show("Login Failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                                }
                            }
                        }

                        // Determine the role of the logged-in user
                        string role = table.Rows[0]["role"].ToString().Trim().ToLower();

                        // Store the logged-in user's Email
                        LoggedInUserEmail = txtEmail.Text;

                        
                        this.Hide(); // Hide the current form (Login form)
                    }
                    else
                    {
                        // Show an error message when login fails
                        MessageBox.Show("Invalid email or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                    }
                }
            }
            catch (SqlException ex)
            {
                // Show error message if there's an exception
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
            }
            finally
            {
                connect.Close(); // Close database connection
            }
        }

    }
}
