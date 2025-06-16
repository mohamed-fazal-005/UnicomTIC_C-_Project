namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class LectureForm
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
            lblLectureName = new Label();
            lblSubject = new Label();
            lblQualification = new Label();
            lblEmail = new Label();
            txtLectureName = new TextBox();
            txtSubject = new TextBox();
            txtQualification = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvLecture = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLecture).BeginInit();
            SuspendLayout();
            // 
            // lblLectureName
            // 
            lblLectureName.AutoSize = true;
            lblLectureName.Location = new Point(206, 45);
            lblLectureName.Name = "lblLectureName";
            lblLectureName.Size = new Size(81, 15);
            lblLectureName.TabIndex = 0;
            lblLectureName.Text = "Lecture Name";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(206, 81);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(45, 15);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "subject";
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Location = new Point(206, 116);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(75, 15);
            lblQualification.TabIndex = 2;
            lblQualification.Text = "Qualification";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(206, 152);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtLectureName
            // 
            txtLectureName.Location = new Point(307, 37);
            txtLectureName.Name = "txtLectureName";
            txtLectureName.Size = new Size(172, 23);
            txtLectureName.TabIndex = 4;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(307, 73);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(172, 23);
            txtSubject.TabIndex = 5;
            // 
            // txtQualification
            // 
            txtQualification.Location = new Point(307, 108);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(172, 23);
            txtQualification.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(307, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(206, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(307, 198);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(404, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvLecture
            // 
            dgvLecture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLecture.Location = new Point(136, 247);
            dgvLecture.Name = "dgvLecture";
            dgvLecture.Size = new Size(432, 178);
            dgvLecture.TabIndex = 11;
            dgvLecture.CellContentClick += dgvLecture_CellContentClick;
            // 
            // LectureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLecture);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtQualification);
            Controls.Add(txtSubject);
            Controls.Add(txtLectureName);
            Controls.Add(lblEmail);
            Controls.Add(lblQualification);
            Controls.Add(lblSubject);
            Controls.Add(lblLectureName);
            Name = "LectureForm";
            Text = "LectureForm";
            Load += LectureForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLecture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLectureName;
        private Label lblSubject;
        private Label lblQualification;
        private Label lblEmail;
        private TextBox txtLectureName;
        private TextBox txtSubject;
        private TextBox txtQualification;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvLecture;
    }
}