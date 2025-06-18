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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExam).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Location = new Point(134, 67);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(70, 15);
            lblExamName.TabIndex = 0;
            lblExamName.Text = "Exam Name";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(247, 59);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(178, 23);
            txtExamName.TabIndex = 1;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(134, 109);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(46, 15);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(247, 101);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(87, 23);
            cmbSubject.TabIndex = 3;
            // 
            // btnAddExam
            // 
            btnAddExam.Location = new Point(134, 145);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(75, 23);
            btnAddExam.TabIndex = 5;
            btnAddExam.Text = "Add";
            btnAddExam.UseVisualStyleBackColor = true;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // btnEditExam
            // 
            btnEditExam.Location = new Point(238, 145);
            btnEditExam.Name = "btnEditExam";
            btnEditExam.Size = new Size(75, 23);
            btnEditExam.TabIndex = 6;
            btnEditExam.Text = "Edit";
            btnEditExam.UseVisualStyleBackColor = true;
            btnEditExam.Click += btnEditExam_Click;
            // 
            // btnDeleteExam
            // 
            btnDeleteExam.Location = new Point(350, 145);
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
            dgvExam.Location = new Point(84, 188);
            dgvExam.Name = "dgvExam";
            dgvExam.Size = new Size(404, 177);
            dgvExam.TabIndex = 8;
            dgvExam.CellContentClick += dgvExam_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblExamName);
            panel1.Controls.Add(btnDeleteExam);
            panel1.Controls.Add(dgvExam);
            panel1.Controls.Add(btnEditExam);
            panel1.Controls.Add(txtExamName);
            panel1.Controls.Add(btnAddExam);
            panel1.Controls.Add(lblSubject);
            panel1.Controls.Add(cmbSubject);
            panel1.Location = new Point(88, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 382);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 9;
            label1.Text = "Exam Deatails :";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ExamForm";
            Text = "ExamForm";
            Load += ExamForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvExam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
    }
}