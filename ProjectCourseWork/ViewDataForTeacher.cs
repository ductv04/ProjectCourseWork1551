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
    public partial class ViewDataForTeacher : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";
        // SqlConnection object to connect to the database
        SqlConnection connect = new SqlConnection(connectionString);

        public ViewDataForTeacher()
        {
            InitializeComponent();
        }

        // Method to display all data from the database
        public void DisplayData()
        {
            connect.Open(); // Open the database connection
            string query = @"SELECT
                                u.id AS Id,
                                u.name AS Name, 
                                u.email AS Email,
                                u.phone AS Phone, 
                                u.address AS Address, 
                                u.dob AS DateOfBirth,
                                u.role AS Role,
                                s.current_subject1 AS CurrentSubject1,
                                s.current_subject2 AS CurrentSubject2,
                                s.prev_subject1 AS PreviousSubject1,
                                s.prev_subject2 AS PreviousSubject2,
                                t.salary AS TeacherSalary,
                                t.subject AS TeacherSubject
                            FROM
                                users u
                            LEFT JOIN students s ON u.id = s.user_id
                            LEFT JOIN teachers t ON u.id = t.user_id"; // SQL query to fetch data

            SqlDataAdapter adapter = new SqlDataAdapter(query, connect); // Create a data adapter
            var dataSet = new DataSet();
            adapter.Fill(dataSet); // Fill the dataset with data from the database
            DataDGV.DataSource = dataSet.Tables[0]; // Display the data in the DataGridView
            connect.Close(); // Close the database connection
        }

        // Method to filter data based on search criteria
        public void TextBoxFilter()
        {
            connect.Open(); // Open the database connection
            string query = @"SELECT
                                u.id AS Id,
                                u.name AS Name, 
                                u.email AS Email,
                                u.phone AS Phone, 
                                u.address AS Address, 
                                u.dob AS DateOfBirth,
                                u.role AS Role,
                                s.current_subject1 AS CurrentSubject1,
                                s.current_subject2 AS CurrentSubject2,
                                s.prev_subject1 AS PreviousSubject1,
                                s.prev_subject2 AS PreviousSubject2,
                                t.salary AS TeacherSalary,
                                t.subject AS TeacherSubject
                            FROM
                                users u
                            LEFT JOIN students s ON u.id = s.user_id
                            LEFT JOIN teachers t ON u.id = t.user_id
                            WHERE 1=1"; // SQL query to fetch data

            // Check if search box is not empty
            if (!string.IsNullOrEmpty(txtSearchBox.Text))
            {
                query += " AND u.name LIKE '%" + txtSearchBox.Text + "%'"; // Add filter condition for name
            }

            // Check if filter combo box is selected and not "All"
            if (cmbFilter.SelectedItem != null && cmbFilter.SelectedItem.ToString() != "All")
            {
                query += " AND u.role = '" + cmbFilter.SelectedItem.ToString() + "'"; // Add filter condition for role
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, connect); // Create a data adapter
            var dataSet = new DataSet();
            adapter.Fill(dataSet); // Fill the dataset with filtered data
            DataDGV.DataSource = dataSet.Tables[0]; // Display the filtered data in the DataGridView
            connect.Close(); // Close the database connection
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the close button is clicked
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData(); // Call the method to display all data when the refresh button is clicked
            // Clear the search box text
            txtSearchBox.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TeachingStaffMenu teachingStaffMenu = new TeachingStaffMenu(); // Create an instance of TeachingStaffMenu form
            teachingStaffMenu.Show(); // Show the TeachingStaffMenu form
            this.Hide(); // Hide the current form
        }

        private void ViewStudentData_Load(object sender, EventArgs e)
        {
            DisplayData(); // Call the method to display data when the form is loaded
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TextBoxFilter(); // Call the method to filter data when the search button is clicked
        }
    }
}
