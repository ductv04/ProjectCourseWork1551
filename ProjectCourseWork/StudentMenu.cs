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
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        // Event handler for clicking on the Student Profile picture box
        private void pictureBoxStudentProfile_Click(object sender, EventArgs e)
        {
            // Open the StudentProfile form and hide the current form
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
            this.Hide();
        }

        // Event handler for clicking on the close button
        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        // Event handler for clicking on the Logout picture box
        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            // Open the Login form and close the current form
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        // Event handler for clicking on the View Student Subject picture box
        private void pictureBoxViewStudentSubject_Click(object sender, EventArgs e)
        {
            // Open the ViewStudentSubject form and hide the current form
            ViewStudentSubject studentSubject = new ViewStudentSubject();
            studentSubject.Show();
            this.Hide();
        }
    }
}
