namespace ProjectCourseWork
{
    partial class ManagementStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementStudent));
            panel1 = new Panel();
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            label1 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            intPhone = new TextBox();
            txtAddress = new TextBox();
            label6 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            StudentsDGV = new DataGridView();
            txtEmail = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsDGV).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 2;
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
            label3.Size = new Size(382, 40);
            label3.TabIndex = 4;
            label3.Text = "Management Student";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 124);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(633, 124);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 9;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 209);
            label5.Name = "label5";
            label5.Size = new Size(107, 27);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // intPhone
            // 
            intPhone.Location = new Point(633, 154);
            intPhone.Name = "intPhone";
            intPhone.Size = new Size(252, 27);
            intPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(147, 239);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(485, 209);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 14;
            label6.Text = "Date of Birth:";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(485, 239);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(252, 27);
            dateTimePickerDOB.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(186, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 35);
            btnUpdate.TabIndex = 24;
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
            btnDelete.Location = new Point(412, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 35);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(633, 303);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(366, 354);
            label7.Name = "label7";
            label7.Size = new Size(169, 34);
            label7.TabIndex = 5;
            label7.Text = "Student List";
            // 
            // StudentsDGV
            // 
            StudentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsDGV.Location = new Point(25, 391);
            StudentsDGV.Name = "StudentsDGV";
            StudentsDGV.RowHeadersWidth = 51;
            StudentsDGV.Size = new Size(868, 279);
            StudentsDGV.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(331, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 124);
            label2.Name = "label2";
            label2.Size = new Size(80, 27);
            label2.TabIndex = 28;
            label2.Text = "Email:";
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // ManagementStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 684);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(StudentsDGV);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(intPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagementStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementStudent";
            Load += ManagementStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBoxHome;
        private Label label1;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private TextBox intPhone;
        private TextBox txtAddress;
        private Label label6;
        private DateTimePicker dateTimePickerDOB;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private DataGridView StudentsDGV;
        private Button closebtn;
        private TextBox txtEmail;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}