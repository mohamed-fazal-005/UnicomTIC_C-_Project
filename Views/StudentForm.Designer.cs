namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class StudentForm
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
            lblSrudentName = new Label();
            lblAddress = new Label();
            lblAge = new Label();
            lblCourse = new Label();
            cmbCourse = new ComboBox();
            txtStudentName = new TextBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            btnStudentAdd = new Button();
            btnStudentEdit = new Button();
            btnStudentDelete = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblSrudentName
            // 
            lblSrudentName.AutoSize = true;
            lblSrudentName.Location = new Point(167, 46);
            lblSrudentName.Name = "lblSrudentName";
            lblSrudentName.Size = new Size(83, 15);
            lblSrudentName.TabIndex = 0;
            lblSrudentName.Text = "Student Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(167, 85);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(167, 125);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(167, 163);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(44, 15);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(270, 155);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(86, 23);
            cmbCourse.TabIndex = 4;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(270, 38);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(205, 23);
            txtStudentName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(270, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(205, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(270, 117);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(205, 23);
            txtAge.TabIndex = 7;
            // 
            // btnStudentAdd
            // 
            btnStudentAdd.Location = new Point(167, 205);
            btnStudentAdd.Name = "btnStudentAdd";
            btnStudentAdd.Size = new Size(75, 23);
            btnStudentAdd.TabIndex = 8;
            btnStudentAdd.Text = "Add";
            btnStudentAdd.UseVisualStyleBackColor = true;
            btnStudentAdd.Click += btnStudentAdd_Click;
            // 
            // btnStudentEdit
            // 
            btnStudentEdit.Location = new Point(281, 205);
            btnStudentEdit.Name = "btnStudentEdit";
            btnStudentEdit.Size = new Size(75, 23);
            btnStudentEdit.TabIndex = 9;
            btnStudentEdit.Text = "Edit";
            btnStudentEdit.UseVisualStyleBackColor = true;
            btnStudentEdit.Click += btnStudentEdit_Click;
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.Location = new Point(400, 205);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(75, 23);
            btnStudentDelete.TabIndex = 10;
            btnStudentDelete.Text = "Delete";
            btnStudentDelete.UseVisualStyleBackColor = true;
            btnStudentDelete.Click += btnStudentDelete_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(76, 253);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(495, 185);
            dgvStudents.TabIndex = 11;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(btnStudentDelete);
            Controls.Add(btnStudentEdit);
            Controls.Add(btnStudentAdd);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtStudentName);
            Controls.Add(cmbCourse);
            Controls.Add(lblCourse);
            Controls.Add(lblAge);
            Controls.Add(lblAddress);
            Controls.Add(lblSrudentName);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSrudentName;
        private Label lblAddress;
        private Label lblAge;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private TextBox txtStudentName;
        private TextBox txtAddress;
        private TextBox txtAge;
        private Button btnStudentAdd;
        private Button btnStudentEdit;
        private Button btnStudentDelete;
        private DataGridView dgvStudents;
    }
}