using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCourseWork
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        // Close button click event handler to exit the application
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for clicking on the Student Management icon
        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            // Create and display the Student Management form
            ManagementStudent MStudentForm = new ManagementStudent();
            MStudentForm.Show();
            this.Hide(); // Hide the AdminMenu form
        }

        // Event handler for clicking on the Teachers Management icon
        private void pictureBoxTeachers_Click(object sender, EventArgs e)
        {
            // Create and display the Teachers Management form
            ManagementTeacher MTeacherForm = new ManagementTeacher();
            MTeacherForm.Show();
            this.Hide(); // Hide the AdminMenu form
        }

        // Event handler for clicking on the View Data icon
        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            // Create and display the View Data form
            ViewDataForAdmin viewData = new ViewDataForAdmin();
            viewData.Show();
            this.Hide(); // Hide the AdminMenu form
        }

        // Event handler for clicking on the Admin Profile icon
        private void pictureBoxAdminProfile_Click(object sender, EventArgs e)
        {
            // Create and display the Admin Profile form
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.Show();
            this.Hide(); // Hide the AdminMenu form
        }

        // Event handler for clicking on the Logout icon
        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            // Create and display the Login form
            Login loginForm = new Login();
            loginForm.Show();
            this.Close(); // Close the AdminMenu form
        }
    }
}
