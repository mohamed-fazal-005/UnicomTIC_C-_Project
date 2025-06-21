using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UTIC_WindowsForm_By_Fazal.Controller;
using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class LectureForm : Form
    {
        private int selectUserId = -1;
        public LectureForm()
        {
            InitializeComponent();
            this.Load += LectureForm_Load;
            if (Helper.UserType != "Admin" && Helper.UserType != "Lecture")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                lblLectureName.Visible = false;
                lblSubject.Visible = false;
                lblQualification.Visible = false;
                lblEmail.Visible = false;
                txtLectureName.Visible=false;
                txtQualification.Visible=false;
                txtEmail.Visible=false;
                cmbSubject.Visible=false;
            }
        }

        private void LectureForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadSubjects();
            LoadLectures();
        }
        private void SetupGrid()
        {
            dgvLecture.AllowUserToAddRows = false;
            dgvLecture.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLecture.MultiSelect = false;
            dgvLecture.Columns.Clear();
            dgvLecture.Columns.Add("LectureID", "ID");
            dgvLecture.Columns.Add("Name", "Name");
            dgvLecture.Columns.Add("SubjectID", "Subject");
            dgvLecture.Columns.Add("Qualification", "Qualification");
            dgvLecture.Columns.Add("Email", "Email");
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

        private void LoadLectures()
        {
            dgvLecture.Rows.Clear();
            var lectures = LectureController.GetAllLectures();

            foreach (var lec in lectures)
            {
                dgvLecture.Rows.Add(lec.LectureID, lec.Name, lec.SubjectID, lec.Qualification, lec.Email);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLectureName.Text) ||
                    string.IsNullOrWhiteSpace(txtQualification.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    cmbSubject.SelectedItem == null)
                {
                    MessageBox.Show("All fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(((ComboBoxItem)cmbSubject.SelectedItem).Value, out int subjectId))
                {
                    MessageBox.Show("Invalid subject selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LectureController.AddLecture(
                    txtLectureName.Text.Trim(),
                    subjectId,
                    txtQualification.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                LoadLectures();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding lecture:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLecture.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a lecture to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLectureName.Text) ||
                    string.IsNullOrWhiteSpace(txtQualification.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    cmbSubject.SelectedItem == null)
                {
                    MessageBox.Show("All fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvLecture.SelectedRows[0].Cells[0].Value);

                if (!int.TryParse(((ComboBoxItem)cmbSubject.SelectedItem).Value, out int subjectId))
                {
                    MessageBox.Show("Invalid subject selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LectureController.UpdateLecture(
                    id,
                    txtLectureName.Text.Trim(),
                    subjectId,
                    txtQualification.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                LoadLectures();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating lecture:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLecture.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvLecture.SelectedRows[0].Cells[0].Value);
                LectureController.DeleteLecture(id);
                LoadLectures();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLecture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLecture.SelectedRows.Count > 0)
            {
                var row = dgvLecture.SelectedRows[0];
                txtLectureName.Text = row.Cells[1].Value.ToString();
                cmbSubject.Text = row.Cells[2].Value.ToString();
                txtQualification.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtLectureName.Clear();
            cmbSubject.SelectedIndex = -1;
            txtQualification.Clear();
            txtEmail.Clear();
            selectUserId = -1;
        }
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }
    }
}
