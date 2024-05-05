namespace ProjectCourseWork
{
    partial class ManagementTeacher
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementTeacher));
            TeacherDGV = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            btnBack = new Button();
            btnUpdate = new Button();
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            panel1 = new Panel();
            dateTimePickerDOB = new DateTimePicker();
            label6 = new Label();
            txtAddress = new TextBox();
            intPhone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            label9 = new Label();
            btnDelete = new Button();
            label1 = new Label();
            txtSalary = new TextBox();
            label8 = new Label();
            cmbSubject = new ComboBox();
            txtEmail = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TeacherDGV
            // 
            TeacherDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeacherDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherDGV.Location = new Point(25, 398);
            TeacherDGV.Name = "TeacherDGV";
            TeacherDGV.RowHeadersWidth = 51;
            TeacherDGV.Size = new Size(1118, 279);
            TeacherDGV.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(492, 361);
            label7.Name = "label7";
            label7.Size = new Size(173, 34);
            label7.TabIndex = 30;
            label7.Text = "Teacher List";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(755, 306);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(297, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 35);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(1115, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 5;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(403, 18);
            label3.Name = "label3";
            label3.Size = new Size(387, 40);
            label3.TabIndex = 4;
            label3.Text = "Management Teacher";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 95);
            panel1.TabIndex = 28;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(130, 235);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(252, 27);
            dateTimePickerDOB.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(130, 205);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 55;
            label6.Text = "Date of Birth:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(919, 150);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 54;
            // 
            // intPhone
            // 
            intPhone.Location = new Point(633, 150);
            intPhone.Name = "intPhone";
            intPhone.Size = new Size(229, 27);
            intPhone.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(919, 120);
            label5.Name = "label5";
            label5.Size = new Size(107, 27);
            label5.TabIndex = 52;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(633, 120);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 51;
            label4.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 150);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 120);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 47;
            label9.Text = "Name:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(41, 128, 185);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(537, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 35);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(827, 205);
            label1.Name = "label1";
            label1.Size = new Size(87, 27);
            label1.TabIndex = 57;
            label1.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(827, 235);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(229, 27);
            txtSalary.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(492, 205);
            label8.Name = "label8";
            label8.Size = new Size(102, 27);
            label8.TabIndex = 59;
            label8.Text = "Subject:";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "None", "Software Engineering", "Visual Arts", "Frontend Development", "Network Security", "Data Engineering", "Machine Learning", "Marketing Analytics", "Game Design", "Mobile Computing", "IT Management" });
            cmbSubject.Location = new Point(492, 237);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(231, 28);
            cmbSubject.TabIndex = 60;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(338, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 120);
            label2.Name = "label2";
            label2.Size = new Size(80, 27);
            label2.TabIndex = 61;
            label2.Text = "Email:";
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // ManagementTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 684);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(cmbSubject);
            Controls.Add(label8);
            Controls.Add(txtSalary);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(intPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(TeacherDGV);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagementTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementTeacher";
            Load += ManagementTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TeacherDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Button btnBack;
        private Button btnUpdate;
        private Button closebtn;
        private Label label3;
        private PictureBox pictureBoxHome;
        private Panel panel1;
        private DateTimePicker dateTimePickerDOB;
        private Label label6;
        private TextBox txtAddress;
        private TextBox intPhone;
        private Label label5;
        private Label label4;
        private TextBox txtName;
        private Label label9;
        private Button btnDelete;
        private Label label1;
        private TextBox txtSalary;
        private Label label8;
        private ComboBox cmbSubject;
        private TextBox txtEmail;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}