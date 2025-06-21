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

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class RoomForm : Form
    {
        private int selectUserId = -1;
        public RoomForm()
        {
            InitializeComponent();
            this.Load += RoomForm_Load;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomTypes();
            SetupGrid();
            LoadRooms();
        }
        private void SetupGrid()
        {
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.MultiSelect = false;
            dgvRooms.Columns.Clear();
            dgvRooms.Columns.Add("RoomID", "ID");
            dgvRooms.Columns.Add("RoomName", "Room Name");
            dgvRooms.Columns.Add("RoomType", "Room Type");
        }
        private void LoadRoomTypes()
        {
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.Add("Lab");
            cmbRoomType.Items.Add("Hall");
            cmbRoomType.SelectedIndex = 0;
        }
        private void LoadRooms()
        {
            dgvRooms.Rows.Clear();

            var rooms = RoomController.GetAllRooms();
            foreach (var r in rooms)
            {
                dgvRooms.Rows.Add(r.RoomID, r.RoomName, r.RoomType);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRoomName.Text) || cmbRoomType.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                RoomController.AddRoom(txtRoomName.Text.Trim(), cmbRoomType.SelectedItem.ToString());
                LoadRooms();
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
                if (dgvRooms.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells[0].Value);
                string name = txtRoomName.Text.Trim();
                string type = cmbRoomType.SelectedItem.ToString();

                RoomController.UpdateRoom(id, name, type);
                LoadRooms();
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
                if (dgvRooms.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells[0].Value);
                RoomController.DeleteRoom(id);
                LoadRooms();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                txtRoomName.Text = dgvRooms.SelectedRows[0].Cells[1].Value.ToString();
                cmbRoomType.SelectedItem = dgvRooms.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtRoomName.Clear();
            selectUserId = -1;
        }
    }
}
