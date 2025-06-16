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
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(156, 57);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(79, 15);
            lblCourseName.TabIndex = 0;
            lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(250, 49);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(171, 23);
            txtCourseName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(156, 104);
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
            dgvCourse.Location = new Point(121, 185);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.Size = new Size(339, 240);
            dgvCourse.TabIndex = 3;
            dgvCourse.CellContentClick += dgvCourse_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(250, 104);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(346, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 487);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvCourse);
            Controls.Add(btnAdd);
            Controls.Add(txtCourseName);
            Controls.Add(lblCourseName);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseName;
        private TextBox txtCourseName;
        private Button btnAdd;
        private DataGridView dgvCourse;
        private Button btnEdit;
        private Button btnDelete;
    }
}