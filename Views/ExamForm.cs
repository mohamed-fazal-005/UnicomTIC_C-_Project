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
    public partial class ExamForm : Form
    {
        private int selectUserId = -1;
        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;
            if (Helper.UserType != "Admin" && Helper.UserType != "Staff")
            {
                btnAddExam.Visible = false;
                btnEditExam.Visible = false;
                btnDeleteExam.Visible = false;
                lblExamName.Visible = false;
                txtExamName.Visible = false;
                lblSubject.Visible = false;
                cmbSubject.Visible = false;

            }
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            SetupGrid();
            LoadExams();
        }

        private void SetupGrid()
        {
            dgvExam.AllowUserToAddRows = false;
            dgvExam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExam.MultiSelect = false;
            dgvExam.Columns.Clear();
            dgvExam.Columns.Add("ExamID", "ID");
            dgvExam.Columns.Add("ExamName", "Exam Name");
            dgvExam.Columns.Add("SubjectName", "Subject");
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

        private void LoadExams()
        {
            dgvExam.Rows.Clear();

            var exams = ExamController.GetAllExams();
            foreach (var exam in exams)
            {
                dgvExam.Rows.Add(exam.ExamID, exam.ExamName, exam.SubjectID);
            }
        }


        private void btnEditExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExam.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an exam to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtExamName.Text) || cmbSubject.SelectedItem == null)
                {
                    MessageBox.Show("Exam name and subject are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int examId = Convert.ToInt32(dgvExam.SelectedRows[0].Cells[0].Value);
                string examName = txtExamName.Text.Trim();
                int subjectId = int.Parse(((ComboBoxItem)cmbSubject.SelectedItem).Value);

                ExamController.UpdateExam(examId, examName, subjectId);
                LoadExams();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating exam:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubject.SelectedItem == null || string.IsNullOrWhiteSpace(txtExamName.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var subject = (ComboBoxItem)cmbSubject.SelectedItem;

                if (!int.TryParse(subject.Value, out int subjectId))
                {
                    MessageBox.Show("Invalid subject selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ExamController.AddExam(txtExamName.Text.Trim(), subjectId);
                LoadExams();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding exam:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExam.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an exam to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this exam?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int examId = Convert.ToInt32(dgvExam.SelectedRows[0].Cells[0].Value);
                    ExamController.DeleteExam(examId);
                    LoadExams();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while deleting exam:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }

        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExam.SelectedRows.Count > 0)
            {
                txtExamName.Text = dgvExam.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtExamName.Clear();
            selectUserId = -1;
        }

            private void ExamForm_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
