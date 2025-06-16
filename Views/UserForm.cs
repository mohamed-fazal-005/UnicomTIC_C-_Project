using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIC_WindowsForm_By_Fazal.Controller;
using UTIC_WindowsForm_By_Fazal.Data;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.Load += UserForm_Load;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbRole.SelectedItem == null)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            UserController.AddUser(
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                cmbRole.SelectedItem.ToString()
            );

            LoadUsers();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            SetupGrid();
            LoadUsers();
        }
        private void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");
            cmbRole.SelectedIndex = 0;
        }
        private void SetupGrid()
        {
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add("UserID", "ID");
            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("Password", "Password");
            dgvUsers.Columns.Add("Role", "Role");
        }
        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();

            var users = UserController.GetAllUsers();
            foreach (var user in users)
            {
                dgvUsers.Rows.Add(user.UserID, user.Username, user.Password, user.Role);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            UserController.UpdateUser(id, username, password, role);
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
            UserController.DeleteUser(id);
            LoadUsers();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var row = dgvUsers.SelectedRows[0];
                txtUsername.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                cmbRole.SelectedItem = row.Cells[3].Value.ToString();
            }
        }
    }
}
