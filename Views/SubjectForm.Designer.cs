namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class SubjectForm
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
            lblSubject = new Label();
            lblCourse = new Label();
            txtSubjectName = new TextBox();
            cmbCourse = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvSubject = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(206, 61);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(81, 15);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject Name";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(206, 107);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(44, 15);
            lblCourse.TabIndex = 1;
            lblCourse.Text = "Course";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(312, 53);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(170, 23);
            txtSubjectName.TabIndex = 2;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(312, 99);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(100, 23);
            cmbCourse.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(206, 149);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(312, 149);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(407, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(168, 226);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.Size = new Size(359, 212);
            dgvSubject.TabIndex = 7;
            dgvSubject.CellContentClick += dgvSubject_CellContentClick;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSubject);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbCourse);
            Controls.Add(txtSubjectName);
            Controls.Add(lblCourse);
            Controls.Add(lblSubject);
            Name = "SubjectForm";
            Text = "SubjectForm";
            Load += SubjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubject;
        private Label lblCourse;
        private TextBox txtSubjectName;
        private ComboBox cmbCourse;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvSubject;
    }
}