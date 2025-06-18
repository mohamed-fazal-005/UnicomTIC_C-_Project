namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class StaffForm
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
            lblStaffName = new Label();
            lblPosition = new Label();
            lblEmail = new Label();
            txtStaffName = new TextBox();
            txtPosition = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(156, 35);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(66, 15);
            lblStaffName.TabIndex = 0;
            lblStaffName.Text = "Staff Name";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(156, 78);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Position";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(156, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(263, 27);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(173, 23);
            txtStaffName.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(263, 70);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(173, 23);
            txtPosition.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(263, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(156, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(263, 169);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(361, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(133, 239);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.Size = new Size(362, 150);
            dgvStaff.TabIndex = 9;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStaff);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPosition);
            Controls.Add(txtStaffName);
            Controls.Add(lblEmail);
            Controls.Add(lblPosition);
            Controls.Add(lblStaffName);
            Name = "StaffForm";
            Text = "StaffForm";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStaffName;
        private Label lblPosition;
        private Label lblEmail;
        private TextBox txtStaffName;
        private TextBox txtPosition;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvStaff;
    }
}