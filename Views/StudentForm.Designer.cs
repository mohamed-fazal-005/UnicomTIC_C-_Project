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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSrudentName
            // 
            lblSrudentName.AutoSize = true;
            lblSrudentName.Location = new Point(157, 56);
            lblSrudentName.Name = "lblSrudentName";
            lblSrudentName.Size = new Size(83, 15);
            lblSrudentName.TabIndex = 0;
            lblSrudentName.Text = "Student Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(157, 91);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(157, 127);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(157, 156);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(44, 15);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(280, 148);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(86, 23);
            cmbCourse.TabIndex = 4;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(280, 48);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(182, 23);
            txtStudentName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(280, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(182, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(280, 114);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(182, 23);
            txtAge.TabIndex = 7;
            // 
            // btnStudentAdd
            // 
            btnStudentAdd.Location = new Point(157, 192);
            btnStudentAdd.Name = "btnStudentAdd";
            btnStudentAdd.Size = new Size(75, 23);
            btnStudentAdd.TabIndex = 8;
            btnStudentAdd.Text = "Add";
            btnStudentAdd.UseVisualStyleBackColor = true;
            btnStudentAdd.Click += btnStudentAdd_Click;
            // 
            // btnStudentEdit
            // 
            btnStudentEdit.Location = new Point(268, 192);
            btnStudentEdit.Name = "btnStudentEdit";
            btnStudentEdit.Size = new Size(75, 23);
            btnStudentEdit.TabIndex = 9;
            btnStudentEdit.Text = "Edit";
            btnStudentEdit.UseVisualStyleBackColor = true;
            btnStudentEdit.Click += btnStudentEdit_Click;
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.Location = new Point(387, 192);
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
            dgvStudents.Location = new Point(66, 221);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(491, 162);
            dgvStudents.TabIndex = 11;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSrudentName);
            panel1.Controls.Add(dgvStudents);
            panel1.Controls.Add(txtStudentName);
            panel1.Controls.Add(btnStudentDelete);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(btnStudentEdit);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(btnStudentAdd);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(lblCourse);
            panel1.Controls.Add(cmbCourse);
            panel1.Controls.Add(lblAge);
            panel1.Location = new Point(77, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 386);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 12;
            label1.Text = "Student Details :";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
    }
}