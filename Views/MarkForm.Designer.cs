namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class MarkForm
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
            lblStudent = new Label();
            lblExam = new Label();
            lblScore = new Label();
            cmbStudent = new ComboBox();
            cmbExam = new ComboBox();
            txtScore = new TextBox();
            btnAddMark = new Button();
            btnEditMark = new Button();
            btnDeleteMark = new Button();
            dgvMark = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMark).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(176, 54);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(48, 15);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student";
            // 
            // lblExam
            // 
            lblExam.AutoSize = true;
            lblExam.Location = new Point(176, 93);
            lblExam.Name = "lblExam";
            lblExam.Size = new Size(35, 15);
            lblExam.TabIndex = 1;
            lblExam.Text = "Exam";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(176, 133);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(36, 15);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(287, 46);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(75, 23);
            cmbStudent.TabIndex = 3;
            // 
            // cmbExam
            // 
            cmbExam.FormattingEnabled = true;
            cmbExam.Location = new Point(287, 85);
            cmbExam.Name = "cmbExam";
            cmbExam.Size = new Size(75, 23);
            cmbExam.TabIndex = 4;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(241, 125);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(211, 23);
            txtScore.TabIndex = 5;
            // 
            // btnAddMark
            // 
            btnAddMark.Location = new Point(176, 177);
            btnAddMark.Name = "btnAddMark";
            btnAddMark.Size = new Size(75, 23);
            btnAddMark.TabIndex = 6;
            btnAddMark.Text = "Add";
            btnAddMark.UseVisualStyleBackColor = true;
            btnAddMark.Click += btnAddMark_Click;
            // 
            // btnEditMark
            // 
            btnEditMark.Location = new Point(273, 177);
            btnEditMark.Name = "btnEditMark";
            btnEditMark.Size = new Size(75, 23);
            btnEditMark.TabIndex = 7;
            btnEditMark.Text = "Edit";
            btnEditMark.UseVisualStyleBackColor = true;
            btnEditMark.Click += btnEditMark_Click;
            // 
            // btnDeleteMark
            // 
            btnDeleteMark.Location = new Point(377, 177);
            btnDeleteMark.Name = "btnDeleteMark";
            btnDeleteMark.Size = new Size(75, 23);
            btnDeleteMark.TabIndex = 8;
            btnDeleteMark.Text = "Delete";
            btnDeleteMark.UseVisualStyleBackColor = true;
            btnDeleteMark.Click += btnDeleteMark_Click;
            // 
            // dgvMark
            // 
            dgvMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMark.Location = new Point(97, 231);
            dgvMark.Name = "dgvMark";
            dgvMark.Size = new Size(449, 188);
            dgvMark.TabIndex = 9;
            dgvMark.CellContentClick += dgvMark_CellContentClick;
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMark);
            Controls.Add(btnDeleteMark);
            Controls.Add(btnEditMark);
            Controls.Add(btnAddMark);
            Controls.Add(txtScore);
            Controls.Add(cmbExam);
            Controls.Add(cmbStudent);
            Controls.Add(lblScore);
            Controls.Add(lblExam);
            Controls.Add(lblStudent);
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private Label lblExam;
        private Label lblScore;
        private ComboBox cmbStudent;
        private ComboBox cmbExam;
        private TextBox txtScore;
        private Button btnAddMark;
        private Button btnEditMark;
        private Button btnDeleteMark;
        private DataGridView dgvMark;
    }
}