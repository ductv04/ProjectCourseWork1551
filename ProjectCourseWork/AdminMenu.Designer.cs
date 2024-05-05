namespace ProjectCourseWork
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            pictureBoxStudents = new PictureBox();
            label1 = new Label();
            pictureBoxTeachers = new PictureBox();
            pictureBoxHome = new PictureBox();
            label3 = new Label();
            closebtn = new Button();
            panel1 = new Panel();
            pictureBoxViewData = new PictureBox();
            label2 = new Label();
            pictureBoxAdminProfile = new PictureBox();
            label5 = new Label();
            pictureBoxLogout = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdminProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxStudents
            // 
            pictureBoxStudents.Image = (Image)resources.GetObject("pictureBoxStudents.Image");
            pictureBoxStudents.Location = new Point(298, 129);
            pictureBoxStudents.Name = "pictureBoxStudents";
            pictureBoxStudents.Size = new Size(141, 125);
            pictureBoxStudents.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudents.TabIndex = 10;
            pictureBoxStudents.TabStop = false;
            pictureBoxStudents.Click += pictureBoxStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(304, 257);
            label1.Name = "label1";
            label1.Size = new Size(131, 34);
            label1.TabIndex = 9;
            label1.Text = "Students";
            // 
            // pictureBoxTeachers
            // 
            pictureBoxTeachers.Image = (Image)resources.GetObject("pictureBoxTeachers.Image");
            pictureBoxTeachers.Location = new Point(525, 129);
            pictureBoxTeachers.Name = "pictureBoxTeachers";
            pictureBoxTeachers.Size = new Size(141, 125);
            pictureBoxTeachers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeachers.TabIndex = 13;
            pictureBoxTeachers.TabStop = false;
            pictureBoxTeachers.Click += pictureBoxTeachers_Click;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.blob_removebg_preview1;
            pictureBoxHome.Location = new Point(0, 0);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(99, 95);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 1;
            pictureBoxHome.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(213, 24);
            label3.Name = "label3";
            label3.Size = new Size(352, 40);
            label3.TabIndex = 4;
            label3.Text = "Administration Menu";
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(710, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 2;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 95);
            panel1.TabIndex = 1;
            // 
            // pictureBoxViewData
            // 
            pictureBoxViewData.Image = (Image)resources.GetObject("pictureBoxViewData.Image");
            pictureBoxViewData.Location = new Point(74, 129);
            pictureBoxViewData.Name = "pictureBoxViewData";
            pictureBoxViewData.Size = new Size(141, 125);
            pictureBoxViewData.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxViewData.TabIndex = 15;
            pictureBoxViewData.TabStop = false;
            pictureBoxViewData.Click += pictureBoxView_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(99, 257);
            label2.Name = "label2";
            label2.Size = new Size(85, 34);
            label2.TabIndex = 14;
            label2.Text = "View";
            // 
            // pictureBoxAdminProfile
            // 
            pictureBoxAdminProfile.Image = (Image)resources.GetObject("pictureBoxAdminProfile.Image");
            pictureBoxAdminProfile.Location = new Point(74, 332);
            pictureBoxAdminProfile.Name = "pictureBoxAdminProfile";
            pictureBoxAdminProfile.Size = new Size(141, 125);
            pictureBoxAdminProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdminProfile.TabIndex = 17;
            pictureBoxAdminProfile.TabStop = false;
            pictureBoxAdminProfile.Click += pictureBoxAdminProfile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(91, 460);
            label5.Name = "label5";
            label5.Size = new Size(98, 34);
            label5.TabIndex = 16;
            label5.Text = "Profile";
            // 
            // pictureBoxLogout
            // 
            pictureBoxLogout.Image = Properties.Resources._5932994;
            pictureBoxLogout.Location = new Point(667, 460);
            pictureBoxLogout.Name = "pictureBoxLogout";
            pictureBoxLogout.Size = new Size(83, 73);
            pictureBoxLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogout.TabIndex = 18;
            pictureBoxLogout.TabStop = false;
            pictureBoxLogout.Click += pictureBoxLogout_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(525, 257);
            label4.Name = "label4";
            label4.Size = new Size(135, 34);
            label4.TabIndex = 19;
            label4.Text = "Teachers";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(label4);
            Controls.Add(pictureBoxLogout);
            Controls.Add(pictureBoxAdminProfile);
            Controls.Add(label5);
            Controls.Add(pictureBoxViewData);
            Controls.Add(label2);
            Controls.Add(pictureBoxTeachers);
            Controls.Add(pictureBoxStudents);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdminProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxStudents;
        private Label label1;
        private PictureBox pictureBoxTeachers;
        private PictureBox pictureBoxHome;
        private Label label3;
        private Button closebtn;
        private Panel panel1;
        private PictureBox pictureBoxViewData;
        private Label label2;
        private PictureBox pictureBoxAdminProfile;
        private Label label5;
        private PictureBox pictureBoxLogout;
        private Label label4;
    }
}