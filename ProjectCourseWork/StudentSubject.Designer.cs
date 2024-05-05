
namespace ProjectCourseWork
{
    partial class StudentSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSubject));
            StudentSubjectDGV = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            btnBack = new Button();
            txtName = new TextBox();
            label1 = new Label();
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCurrentSubject1 = new ComboBox();
            cmbCurrentSubject2 = new ComboBox();
            cmbPrevSubject1 = new ComboBox();
            cmbPrevSubject2 = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)StudentSubjectDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StudentSubjectDGV
            // 
            StudentSubjectDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentSubjectDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentSubjectDGV.Location = new Point(25, 398);
            StudentSubjectDGV.Name = "StudentSubjectDGV";
            StudentSubjectDGV.RowHeadersWidth = 51;
            StudentSubjectDGV.Size = new Size(868, 279);
            StudentSubjectDGV.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(366, 361);
            label7.Name = "label7";
            label7.Size = new Size(169, 34);
            label7.TabIndex = 30;
            label7.Text = "Student List";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(624, 310);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 161);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 131);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 29;
            label1.Text = "Name:";
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(865, 0);
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
            label3.Location = new Point(259, 23);
            label3.Name = "label3";
            label3.Size = new Size(379, 40);
            label3.TabIndex = 4;
            label3.Text = "Managament Subject";
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
            panel1.Size = new Size(905, 95);
            panel1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 131);
            label2.Name = "label2";
            label2.Size = new Size(211, 27);
            label2.TabIndex = 44;
            label2.Text = "Current Subject 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(624, 131);
            label4.Name = "label4";
            label4.Size = new Size(211, 27);
            label4.TabIndex = 46;
            label4.Text = "Current Subject 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(475, 218);
            label5.Name = "label5";
            label5.Size = new Size(222, 27);
            label5.TabIndex = 50;
            label5.Text = "Previous Subject 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(170, 218);
            label6.Name = "label6";
            label6.Size = new Size(222, 27);
            label6.TabIndex = 48;
            label6.Text = "Previous Subject 1:";
            // 
            // cmbCurrentSubject1
            // 
            cmbCurrentSubject1.FormattingEnabled = true;
            cmbCurrentSubject1.Items.AddRange(new object[] { "None", "Computer Programming", "Graphic Design", "Web Development", "Network Administration", "Database Management", "Artificial Intelligence", "Digital Marketing", "Game Development", "Mobile App Development", "Information Systems" });
            cmbCurrentSubject1.Location = new Point(319, 161);
            cmbCurrentSubject1.Name = "cmbCurrentSubject1";
            cmbCurrentSubject1.Size = new Size(241, 28);
            cmbCurrentSubject1.TabIndex = 51;
            // 
            // cmbCurrentSubject2
            // 
            cmbCurrentSubject2.FormattingEnabled = true;
            cmbCurrentSubject2.Items.AddRange(new object[] { "None", "Computer Programming", "Graphic Design", "Web Development", "Network Administration", "Database Management", "Artificial Intelligence", "Digital Marketing", "Game Development", "Mobile App Development", "Information Systems" });
            cmbCurrentSubject2.Location = new Point(624, 161);
            cmbCurrentSubject2.Name = "cmbCurrentSubject2";
            cmbCurrentSubject2.Size = new Size(241, 28);
            cmbCurrentSubject2.TabIndex = 52;
            // 
            // cmbPrevSubject1
            // 
            cmbPrevSubject1.FormattingEnabled = true;
            cmbPrevSubject1.Items.AddRange(new object[] { "None", "Computer Programming", "Graphic Design", "Web Development", "Network Administration", "Database Management", "Artificial Intelligence", "Digital Marketing", "Game Development", "Mobile App Development", "Information Systems" });
            cmbPrevSubject1.Location = new Point(170, 248);
            cmbPrevSubject1.Name = "cmbPrevSubject1";
            cmbPrevSubject1.Size = new Size(241, 28);
            cmbPrevSubject1.TabIndex = 53;
            // 
            // cmbPrevSubject2
            // 
            cmbPrevSubject2.FormattingEnabled = true;
            cmbPrevSubject2.Items.AddRange(new object[] { "None", "Computer Programming", "Graphic Design", "Web Development", "Network Administration", "Database Management", "Artificial Intelligence", "Digital Marketing", "Game Development", "Mobile App Development", "Information Systems" });
            cmbPrevSubject2.Location = new Point(475, 248);
            cmbPrevSubject2.Name = "cmbPrevSubject2";
            cmbPrevSubject2.Size = new Size(241, 28);
            cmbPrevSubject2.TabIndex = 54;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(170, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 35);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(41, 128, 185);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(396, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 35);
            btnDelete.TabIndex = 56;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // StudentSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 684);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cmbPrevSubject2);
            Controls.Add(cmbPrevSubject1);
            Controls.Add(cmbCurrentSubject2);
            Controls.Add(cmbCurrentSubject1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(StudentSubjectDGV);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject";
            Load += StudentSubject_Load;
            ((System.ComponentModel.ISupportInitialize)StudentSubjectDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView StudentSubjectDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Button btnBack;
        private TextBox txtName;
        private Label label1;
        private Button closebtn;
        private Label label3;
        private PictureBox pictureBoxHome;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCurrentSubject1;
        private ComboBox cmbCurrentSubject2;
        private ComboBox cmbPrevSubject1;
        private ComboBox cmbPrevSubject2;
        private Button btnUpdate;
        private Button btnDelete;
        private System.Windows.Forms.Timer timer1;
    }
}