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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(173, 63);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(81, 15);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject Name";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(173, 95);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(44, 15);
            lblCourse.TabIndex = 1;
            lblCourse.Text = "Course";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(291, 55);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(170, 23);
            txtSubjectName.TabIndex = 2;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(291, 87);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(100, 23);
            cmbCourse.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(173, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(277, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(386, 130);
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
            dgvSubject.Location = new Point(122, 177);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.Size = new Size(409, 160);
            dgvSubject.TabIndex = 7;
            dgvSubject.CellContentClick += dgvSubject_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSubjectName);
            panel1.Controls.Add(dgvSubject);
            panel1.Controls.Add(lblSubject);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cmbCourse);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lblCourse);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(57, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 352);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 8;
            label1.Text = "Subject Details :";
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SubjectForm";
            Text = "SubjectForm";
            Load += SubjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
    }
}