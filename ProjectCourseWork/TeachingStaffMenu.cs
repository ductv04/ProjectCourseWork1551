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
    public partial class TeachingStaffMenu : Form
    {
        public TeachingStaffMenu()
        {
            InitializeComponent(); // Initialize the components of the form
        }

        // Event handler for clicking on the "Subjects" picture box
        private void pictureBoxSubject_Click(object sender, EventArgs e)
        {
            StudentSubject studentSubjectForm = new StudentSubject(); // Create an instance of the StudentSubject form
            studentSubjectForm.Show(); // Show the StudentSubject form
            this.Hide(); // Hide the current form
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the close button is clicked
        }

        // Event handler for clicking on the "Teacher Profile" picture box
        private void pictureBoxTeacherProfile_Click(object sender, EventArgs e)
        {
            TeacherProfile teacherProfileForm = new TeacherProfile(); // Create an instance of the TeacherProfile form
            teacherProfileForm.Show(); // Show the TeacherProfile form
            this.Hide(); // Hide the current form
        }

        // Event handler for clicking on the "Logout" picture box
        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Create an instance of the Login form
            loginForm.Show(); // Show the Login form
            this.Close(); // Close the current form
        }

        // Event handler for clicking on the "View Student Data" picture box
        private void pictureBoxViewStudentData_Click(object sender, EventArgs e)
        {
            ViewDataForTeacher studentDataForm = new ViewDataForTeacher();    // Create an instance of the studentDataForm
            studentDataForm.Show(); // Show the studentDataForm 
            this.Hide();    // Close the current form
        }
    }
}
