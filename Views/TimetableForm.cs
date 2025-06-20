﻿using System;
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
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class TimetableForm : Form
    {
        private int selectUserId = -1;
        public TimetableForm()
        {
            InitializeComponent();
            this.Load += TimetableForm_Load;
            this.txtTimeSlot.Leave += txtTimeSlot_Leave;
            if (Helper.UserType != "Admin" && Helper.UserType != "Staff" )
            {
                btnAddTimetable.Visible = false;
                btnEditTimetable.Visible = false;
                btnDeleteTimetable.Visible = false;
                lblSubject.Visible = false;
                lblTimeSlot.Visible = false;
                cmbSubject.Visible = false;
                cmbRooms.Visible = false;
                txtTimeSlot.Visible = false;
                lblRoom.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadRooms();
            SetupGrid();
            LoadTimetables();
        }
        private void SetupGrid()
        {
            dgvTimetables.AllowUserToAddRows = false;
            dgvTimetables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimetables.MultiSelect = false;
            dgvTimetables.Columns.Clear();
            dgvTimetables.Columns.Add("TimetableID", "ID");
            dgvTimetables.Columns.Add("SubjectID", "Subject");
            dgvTimetables.Columns.Add("TimeSlot", "Time Slot");
            dgvTimetables.Columns.Add("RoomID", "Room");
        }
        private void LoadSubjects()
        {
            cmbSubject.Items.Clear();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT SubjectID, SubjectName FROM Subjects";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbSubject.Items.Add(new ComboBoxItem
                        {
                            Text = reader["SubjectName"].ToString(),
                            Value = reader["SubjectID"].ToString()
                        });
                    }
                }
            }
        }
        private void LoadRooms()
        {
            cmbRooms.Items.Clear();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT RoomID, RoomName FROM Rooms";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbRooms.Items.Add(new ComboBoxItem
                        {
                            Text = reader["RoomName"].ToString(),
                            Value = reader["RoomID"].ToString()
                        });
                    }
                }
            }
        }
        private void LoadTimetables()
        {
            dgvTimetables.Rows.Clear();
            var list = TimetableController.GetAllTimetables();
            foreach (var t in list)
            {
                dgvTimetables.Rows.Add(t.TimetableID, t.SubjectID, t.TimeSlot, t.RoomID);
            }
        }

        private void btnAddTimetable_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubject.SelectedItem == null || cmbRooms.SelectedItem == null || string.IsNullOrWhiteSpace(txtTimeSlot.Text))
                {
                    MessageBox.Show("Fill all fields.");
                    return;
                }

                var subject = (ComboBoxItem)cmbSubject.SelectedItem;
                var room = (ComboBoxItem)cmbRooms.SelectedItem;

                TimetableController.AddTimetable(int.Parse(subject.Value), txtTimeSlot.Text.Trim(), int.Parse(room.Value));
                LoadTimetables();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTimetable_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTimetables.SelectedRows.Count == 0)
                    return;

                if (cmbSubject.SelectedItem == null || cmbRooms.SelectedItem == null || string.IsNullOrWhiteSpace(txtTimeSlot.Text))
                {
                    MessageBox.Show("Fill all fields.");
                    return;
                }

                int id = Convert.ToInt32(dgvTimetables.SelectedRows[0].Cells[0].Value);
                var subject = (ComboBoxItem)cmbSubject.SelectedItem;
                var room = (ComboBoxItem)cmbRooms.SelectedItem;
                string timeSlot = txtTimeSlot.Text.Trim();

                TimetableController.UpdateTimetable(id, int.Parse(subject.Value), timeSlot, int.Parse(room.Value));
                LoadTimetables();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTimetable_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTimetables.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvTimetables.SelectedRows[0].Cells[0].Value);
                TimetableController.DeleteTimetable(id);
                LoadTimetables();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTimetables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTimetables.SelectedRows.Count > 0)
            {
                txtTimeSlot.Text = dgvTimetables.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtTimeSlot.Clear();
            selectUserId = -1;
        }
        private void txtTimeSlot_Leave(object sender, EventArgs e)
        {
            string input = txtTimeSlot.Text.Trim();

            if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d{1,2}$"))
            {
                txtTimeSlot.Text = input + ".00";
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d{1,2}\.\d{2}$"))
            {
                MessageBox.Show("TimeSlot must be a Number", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimeSlot.Focus();
            }
        }


        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
    }
}
