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
    public partial class SignUp : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);


        public SignUp()
        {
            InitializeComponent();
            // Attach event handler for KeyPress event of intPhone TextBox
            intPhone.KeyPress += intPhone_KeyPress;
        }

        // Event handler for closebtn Click event
        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        // Event handler for linkLabel_Login LinkClicked event
        private void linkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open Login form and hide the current form
            Login lForm = new Login();
            lForm.Show();
            this.Hide();
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

        // Method to check if the user already exists in the database
        private void checkUser(string name, string email, int phone, string address, string password, string role, DateTime dob)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                    // Check if the email already exists
                    string selectQuery = "SELECT COUNT(*) FROM users WHERE email = @email";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("User with this email already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method without inserting duplicate user
                        }
                    }

                    // User doesn't exist, proceed with inserting new user
                    string insertData = "INSERT INTO users (name, email, phone, address, password, role, dob) VALUES(@name, @email, @phone, @address, @password, @role, @dob)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        cmd.ExecuteNonQuery();

                        // Show message box after registered successfully
                        MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open Login form and hide the current form
                        Login lForm = new Login();
                        lForm.Show();
                        this.Hide();
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

        // Event handler for btnSignUp Click event
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (txtEmail.Text == "" || txtName.Text == "" || intPhone.Text == "" || txtAddress.Text == ""
                || txtPassword.Text == "" || cmbRole.SelectedIndex == -1)
            {
                // Display error message if any of the required fields are empty
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Validate email format
            else if (!IsValidEmail(txtEmail.Text))
            {
                // Display error message if email format is not valid
                MessageBox.Show("Please enter a valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if phone number has 9 digits
            else if (intPhone.Text.Length != 9)
            {
                // Display error message if phone number is not 9 digits long
                MessageBox.Show("Phone number must be 9 digits long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Determine role
                Role role = (Role)Enum.Parse(typeof(Role), cmbRole.GetItemText(cmbRole.SelectedItem).Trim());

                // Create corresponding class object and add it to the list
                switch (role)
                {
                    case Role.Administration:
                        Administration admin = new Administration
                        {
                            Name = txtName.Text,
                            Email = txtEmail.Text.Trim(),
                            Telephone = int.Parse(intPhone.Text),
                            Address = txtAddress.Text.Trim(),
                            Password = txtPassword.Text.Trim(),
                            Role = Role.Administration,
                            Dob = DoBPicker.Value
                        };
                        // Check user and add to database
                        checkUser(admin.Name, admin.Email, admin.Telephone, admin.Address, admin.Password, admin.Role.ToString(), admin.Dob);
                        PersonManager.AddPerson(admin); // Add the admin to the PersonManager
                        break;

                    case Role.TeachingStaff:
                        Teacher teacher = new Teacher
                        {
                            Name = txtName.Text,
                            Email = txtEmail.Text.Trim(),
                            Telephone = int.Parse(intPhone.Text),
                            Address = txtAddress.Text.Trim(),
                            Password = txtPassword.Text.Trim(),
                            Role = Role.TeachingStaff,
                            Dob = DoBPicker.Value
                        };
                        // Check user and add to database
                        checkUser(teacher.Name, teacher.Email, teacher.Telephone, teacher.Address, teacher.Password, teacher.Role.ToString(), teacher.Dob);
                        PersonManager.AddPerson(teacher); // Add the teacher to the PersonManager
                        break;

                    case Role.Student:
                        Student student = new Student
                        {
                            Name = txtName.Text,
                            Email = txtEmail.Text.Trim(),
                            Telephone = int.Parse(intPhone.Text),
                            Address = txtAddress.Text.Trim(),
                            Password = txtPassword.Text.Trim(),
                            Role = Role.Student,
                            Dob = DoBPicker.Value
                        };
                        // Check user and add to database
                        checkUser(student.Name, student.Email, student.Telephone, student.Address, student.Password, student.Role.ToString(), student.Dob);
                        PersonManager.AddPerson(student);   // Add the student to the PersonManager
                        break;

                    default:
                        // Handle unexpected role
                        break;
                }
            }
        }
    }
}
