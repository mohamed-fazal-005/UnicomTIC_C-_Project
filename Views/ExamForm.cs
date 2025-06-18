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
    public partial class ExamForm : Form
    {
        private int selectUserId = -1;
        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;
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
            if (dgvExam.SelectedRows.Count == 0) return;

            int examId = Convert.ToInt32(dgvExam.SelectedRows[0].Cells[0].Value);
            string examName = txtExamName.Text.Trim();
            int subjectId = int.Parse(((ComboBoxItem)cmbSubject.SelectedItem).Value);

            ExamController.UpdateExam(examId, examName, subjectId);
            LoadExams();
            ClearForm();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedItem == null || string.IsNullOrWhiteSpace(txtExamName.Text))
            {
                MessageBox.Show("Fill all fields.");
                return;
            }

            var subject = (ComboBoxItem)cmbSubject.SelectedItem;
            ExamController.AddExam(txtExamName.Text.Trim(), int.Parse(subject.Value));
            LoadExams();
            ClearForm();
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (dgvExam.SelectedRows.Count == 0) return;

            int examId = Convert.ToInt32(dgvExam.SelectedRows[0].Cells[0].Value);
            ExamController.DeleteExam(examId);
            LoadExams();
            ClearForm();
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
