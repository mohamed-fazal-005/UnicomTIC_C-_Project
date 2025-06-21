using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UTIC_WindowsForm_By_Fazal.Controller;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class StaffForm : Form
    {
        private int selectUserId = -1;
        public StaffForm()
        {
            InitializeComponent();
            this.Load += StaffForm_Load;
            if (Helper.UserType != "Admin")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                lblStaffName.Visible = false;
                lblPosition.Visible = false;
                lblEmail.Visible = false;
                txtStaffName.Visible = false;
                txtPosition.Visible = false;
                txtEmail.Visible = false;

            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadStaff();
        }
        private void SetupGrid()
        {
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.MultiSelect = false;
            dgvStaff.Columns.Clear();
            dgvStaff.Columns.Add("StaffID", "ID");
            dgvStaff.Columns.Add("Name", "Name");
            dgvStaff.Columns.Add("Position", "Position");
            dgvStaff.Columns.Add("Email", "Email");
        }

        private void LoadStaff()
        {
            dgvStaff.Rows.Clear();
            var staffList = StaffController.GetAllStaff();

            foreach (var staff in staffList)
            {
                dgvStaff.Rows.Add(staff.StaffID, staff.Name, staff.Position, staff.Email);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStaffName.Text) ||
                    string.IsNullOrWhiteSpace(txtPosition.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                StaffController.AddStaff(
                    txtStaffName.Text.Trim(),
                    txtPosition.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                LoadStaff();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);

                StaffController.UpdateStaff(
                    id,
                    txtStaffName.Text.Trim(),
                    txtPosition.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                LoadStaff();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
                StaffController.DeleteStaff(id);
                LoadStaff();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                var row = dgvStaff.SelectedRows[0];
                txtStaffName.Text = row.Cells[1].Value.ToString();
                txtPosition.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtStaffName.Clear();
            txtPosition.Clear();
            txtEmail.Clear();
            selectUserId = -1;
        }
    }
}
