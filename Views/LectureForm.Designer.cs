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
            txtQualification = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvLecture = new DataGridView();
            panel1 = new Panel();
            cmbSubject = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLecture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLectureName
            // 
            lblLectureName.AutoSize = true;
            lblLectureName.Location = new Point(130, 55);
            lblLectureName.Name = "lblLectureName";
            lblLectureName.Size = new Size(81, 15);
            lblLectureName.TabIndex = 0;
            lblLectureName.Text = "Lecture Name";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(130, 95);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(45, 15);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "subject";
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Location = new Point(130, 135);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(75, 15);
            lblQualification.TabIndex = 2;
            lblQualification.Text = "Qualification";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(130, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtLectureName
            // 
            txtLectureName.Location = new Point(247, 47);
            txtLectureName.Name = "txtLectureName";
            txtLectureName.Size = new Size(172, 23);
            txtLectureName.TabIndex = 4;
            // 
            // txtQualification
            // 
            txtQualification.Location = new Point(247, 127);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(172, 23);
            txtQualification.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(247, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(130, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(237, 202);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(344, 202);
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
            dgvLecture.Location = new Point(65, 243);
            dgvLecture.Name = "dgvLecture";
            dgvLecture.Size = new Size(432, 128);
            dgvLecture.TabIndex = 11;
            dgvLecture.CellContentClick += dgvLecture_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(cmbSubject);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblLectureName);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dgvLecture);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(txtLectureName);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblSubject);
            panel1.Controls.Add(lblQualification);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtQualification);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(63, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 388);
            panel1.TabIndex = 12;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(247, 87);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(98, 23);
            cmbSubject.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 12;
            label1.Text = "Lecture Details :";
            // 
            // LectureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LectureForm";
            Text = "LectureForm";
            Load += LectureForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLecture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLectureName;
        private Label lblSubject;
        private Label lblQualification;
        private Label lblEmail;
        private TextBox txtLectureName;
        private TextBox txtQualification;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvLecture;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbSubject;
    }
}