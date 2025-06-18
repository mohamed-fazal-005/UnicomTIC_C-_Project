namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class CourseForm
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
            lblCourseName = new Label();
            txtCourseName = new TextBox();
            btnAdd = new Button();
            dgvCourse = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(163, 64);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(79, 15);
            lblCourseName.TabIndex = 0;
            lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(272, 56);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(171, 23);
            txtCourseName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(163, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCourse
            // 
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(141, 156);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.Size = new Size(339, 223);
            dgvCourse.TabIndex = 3;
            dgvCourse.CellContentClick += dgvCourse_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(260, 110);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(368, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCourseName);
            panel1.Controls.Add(dgvCourse);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtCourseName);
            panel1.Location = new Point(78, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 399);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(144, 18);
            label1.TabIndex = 6;
            label1.Text = "Course Deatails :";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(828, 487);
            Controls.Add(panel1);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCourseName;
        private TextBox txtCourseName;
        private Button btnAdd;
        private DataGridView dgvCourse;
        private Button btnEdit;
        private Button btnDelete;
        private Panel panel1;
        private Label label1;
    }
}