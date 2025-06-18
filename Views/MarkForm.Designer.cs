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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMark).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(177, 68);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(48, 15);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student";
            // 
            // lblExam
            // 
            lblExam.AutoSize = true;
            lblExam.Location = new Point(177, 106);
            lblExam.Name = "lblExam";
            lblExam.Size = new Size(35, 15);
            lblExam.TabIndex = 1;
            lblExam.Text = "Exam";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(176, 147);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(34, 15);
            lblScore.TabIndex = 2;
            lblScore.Text = "Mark";
            lblScore.Click += lblScore_Click;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(257, 60);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(75, 23);
            cmbStudent.TabIndex = 3;
            // 
            // cmbExam
            // 
            cmbExam.FormattingEnabled = true;
            cmbExam.Location = new Point(257, 98);
            cmbExam.Name = "cmbExam";
            cmbExam.Size = new Size(75, 23);
            cmbExam.TabIndex = 4;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(257, 139);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(188, 23);
            txtScore.TabIndex = 5;
            // 
            // btnAddMark
            // 
            btnAddMark.Location = new Point(176, 181);
            btnAddMark.Name = "btnAddMark";
            btnAddMark.Size = new Size(75, 23);
            btnAddMark.TabIndex = 6;
            btnAddMark.Text = "Add";
            btnAddMark.UseVisualStyleBackColor = true;
            btnAddMark.Click += btnAddMark_Click;
            // 
            // btnEditMark
            // 
            btnEditMark.Location = new Point(272, 181);
            btnEditMark.Name = "btnEditMark";
            btnEditMark.Size = new Size(75, 23);
            btnEditMark.TabIndex = 7;
            btnEditMark.Text = "Edit";
            btnEditMark.UseVisualStyleBackColor = true;
            btnEditMark.Click += btnEditMark_Click;
            // 
            // btnDeleteMark
            // 
            btnDeleteMark.Location = new Point(370, 181);
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
            dgvMark.Location = new Point(88, 224);
            dgvMark.Name = "dgvMark";
            dgvMark.Size = new Size(449, 147);
            dgvMark.TabIndex = 9;
            dgvMark.CellContentClick += dgvMark_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblStudent);
            panel1.Controls.Add(btnDeleteMark);
            panel1.Controls.Add(dgvMark);
            panel1.Controls.Add(btnEditMark);
            panel1.Controls.Add(cmbStudent);
            panel1.Controls.Add(lblExam);
            panel1.Controls.Add(cmbExam);
            panel1.Controls.Add(btnAddMark);
            panel1.Controls.Add(lblScore);
            panel1.Controls.Add(txtScore);
            panel1.Location = new Point(66, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 384);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 10;
            label1.Text = "Mark Details :";
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMark).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
    }
}