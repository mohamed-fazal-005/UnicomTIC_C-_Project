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
using UTIC_WindowsForm_By_Fazal.Model;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class SubjectForm : Form
    {
        private int selectUserId = -1;
        public SubjectForm()
        {
            InitializeComponent();
            this.Load += SubjectForm_Load;
            if (Helper.UserType != "Admin" && Helper.UserType != "Staff")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            SetupGrid();
            LoadSubjects();
        }
        private void SetupGrid()
        {
            dgvSubject.AllowUserToAddRows = false;
            dgvSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubject.MultiSelect = false;
            dgvSubject.Columns.Clear();
            dgvSubject.Columns.Add("SubjectID", "ID");
            dgvSubject.Columns.Add("SubjectName", "Subject Name");
            dgvSubject.Columns.Add("CourseID", "Course");
        }
        private void LoadCourses()
        {
            cmbCourse.Items.Clear();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT CourseID, CourseName FROM Courses";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCourse.Items.Add(new ComboBoxItem
                        {
                            Text = reader["CourseName"].ToString(),
                            Value = reader["CourseID"].ToString()
                        });
                    }
                }
            }
        }
        private void LoadSubjects()
        {
            dgvSubject.Rows.Clear();
            var subjects = SubjectController.GetAllSubjects();

            foreach (var s in subjects)
            {
                dgvSubject.Rows.Add(s.SubjectID, s.SubjectName, s.CourseID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourse.SelectedItem == null)
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                string subjectName = txtSubjectName.Text.Trim();
                int courseId = int.Parse(((ComboBoxItem)cmbCourse.SelectedItem).Value);

                SubjectController.AddSubject(subjectName, courseId);
                LoadSubjects();
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
                if (dgvSubject.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells[0].Value);
                string name = txtSubjectName.Text.Trim();
                int courseId = int.Parse(((ComboBoxItem)cmbCourse.SelectedItem).Value);

                SubjectController.UpdateSubject(id, name, courseId);
                LoadSubjects();
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
                if (dgvSubject.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells[0].Value);
                SubjectController.DeleteSubject(id);
                LoadSubjects();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                txtSubjectName.Text = dgvSubject.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString() => Text;
        }
        private void ClearForm()
        {
            txtSubjectName.Clear();
            selectUserId = -1;
        }
    }
}

