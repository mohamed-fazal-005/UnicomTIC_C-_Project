namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class ExamForm
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
            lblExamName = new Label();
            txtExamName = new TextBox();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            btnAddExam = new Button();
            btnEditExam = new Button();
            btnDeleteExam = new Button();
            dgvExam = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExam).BeginInit();
            SuspendLayout();
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Location = new Point(159, 50);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(70, 15);
            lblExamName.TabIndex = 0;
            lblExamName.Text = "Exam Name";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(260, 42);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(178, 23);
            txtExamName.TabIndex = 1;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(159, 86);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(46, 15);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(351, 86);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(87, 23);
            cmbSubject.TabIndex = 3;
            // 
            // btnAddExam
            // 
            btnAddExam.Location = new Point(159, 139);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(75, 23);
            btnAddExam.TabIndex = 5;
            btnAddExam.Text = "Add";
            btnAddExam.UseVisualStyleBackColor = true;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // btnEditExam
            // 
            btnEditExam.Location = new Point(260, 139);
            btnEditExam.Name = "btnEditExam";
            btnEditExam.Size = new Size(75, 23);
            btnEditExam.TabIndex = 6;
            btnEditExam.Text = "Edit";
            btnEditExam.UseVisualStyleBackColor = true;
            btnEditExam.Click += btnEditExam_Click;
            // 
            // btnDeleteExam
            // 
            btnDeleteExam.Location = new Point(363, 139);
            btnDeleteExam.Name = "btnDeleteExam";
            btnDeleteExam.Size = new Size(75, 23);
            btnDeleteExam.TabIndex = 7;
            btnDeleteExam.Text = "Delete";
            btnDeleteExam.UseVisualStyleBackColor = true;
            btnDeleteExam.Click += btnDeleteExam_Click;
            // 
            // dgvExam
            // 
            dgvExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExam.Location = new Point(108, 203);
            dgvExam.Name = "dgvExam";
            dgvExam.Size = new Size(404, 191);
            dgvExam.TabIndex = 8;
            dgvExam.CellContentClick += dgvExam_CellContentClick;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvExam);
            Controls.Add(btnDeleteExam);
            Controls.Add(btnEditExam);
            Controls.Add(btnAddExam);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(txtExamName);
            Controls.Add(lblExamName);
            Name = "ExamForm";
            Text = "ExamForm";
            Load += ExamForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvExam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExamName;
        private TextBox txtExamName;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Button btnAddExam;
        private Button btnEditExam;
        private Button btnDeleteExam;
        private DataGridView dgvExam;
    }
}