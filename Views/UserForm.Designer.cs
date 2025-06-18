namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class UserForm
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
            lblUsername = new Label();
            lblPassword = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            dgvUsers = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(165, 53);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(165, 86);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 118);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(266, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(177, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(266, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 4;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(266, 110);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(75, 23);
            cmbRole.TabIndex = 5;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(165, 158);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(266, 158);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(75, 23);
            btnEditUser.TabIndex = 7;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(368, 158);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(97, 187);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(419, 164);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(dgvUsers);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(73, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 360);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 10;
            label1.Text = "User Details :";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private DataGridView dgvUsers;
        private Panel panel1;
        private Label label1;
    }
}