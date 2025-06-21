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
    public partial class MarkForm : Form
    {
        private int selectUserId = -1;
        public MarkForm()
        {
            InitializeComponent();
            this.Load += MarkForm_Load;
            if (Helper.UserType != "Admin")
            {
                btnAddMark.Visible = false;
                btnEditMark.Visible = false;
                btnDeleteMark.Visible = false;
                lblStudent.Visible = false;
                lblExam.Visible = false;
                lblScore.Visible = false;
                cmbStudent.Visible = false;
                cmbExam.Visible = false;
                txtScore.Visible = false;
            }
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadExams();
            SetupGrid();
            LoadMarks();
        }
        private void SetupGrid()
        {
            dgvMark.AllowUserToAddRows = false;
            dgvMark.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMark.MultiSelect = false;
            dgvMark.Columns.Clear();
            dgvMark.Columns.Add("MarkID", "ID");
            dgvMark.Columns.Add("StudentID", "Student");
            dgvMark.Columns.Add("ExamID", "Exam");
            dgvMark.Columns.Add("Score", "Score");
        }
        private void LoadStudents()
        {
            cmbStudent.Items.Clear();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT StudentID, Name FROM Students";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbStudent.Items.Add(new ComboBoxItem
                        {
                            Text = reader["Name"].ToString(),
                            Value = reader["StudentID"].ToString()
                        });
                    }
                }
            }
        }
        private void LoadExams()
        {
            cmbExam.Items.Clear();

            using (var cmd = DataCon.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT ExamID, ExamName FROM Exams";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbExam.Items.Add(new ComboBoxItem
                        {
                            Text = reader["ExamName"].ToString(),
                            Value = reader["ExamID"].ToString()
                        });
                    }
                }
            }
        }
        private void LoadMarks()
        {
            dgvMark.Rows.Clear();
            var marks = MarkController.GetAllMarks();

            foreach (var m in marks)
            {
                dgvMark.Rows.Add(m.MarkID, m.StudentID, m.ExamID, m.Score);
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedItem == null || cmbExam.SelectedItem == null || string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("All fields required.");
                    return;
                }

                if (!int.TryParse(txtScore.Text.Trim(), out int score))
                {
                    MessageBox.Show("Score must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var student = (ComboBoxItem)cmbStudent.SelectedItem;
                var exam = (ComboBoxItem)cmbExam.SelectedItem;

                MarkController.AddMark(int.Parse(student.Value), int.Parse(exam.Value), score);
                LoadMarks();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMark.SelectedRows.Count == 0) return;

                if (!int.TryParse(txtScore.Text.Trim(), out int score))
                {
                    MessageBox.Show("Mark must be a number.");
                    return;
                }

                int markId = Convert.ToInt32(dgvMark.SelectedRows[0].Cells[0].Value);
                var student = (ComboBoxItem)cmbStudent.SelectedItem;
                var exam = (ComboBoxItem)cmbExam.SelectedItem;

                MarkController.UpdateMark(markId, int.Parse(student.Value), int.Parse(exam.Value), score);
                LoadMarks();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMark.SelectedRows.Count == 0) return;

                int markId = Convert.ToInt32(dgvMark.SelectedRows[0].Cells[0].Value);
                MarkController.DeleteMark(markId);
                LoadMarks();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMark.SelectedRows.Count > 0)
            {
                txtScore.Text = dgvMark.SelectedRows[0].Cells[3].Value.ToString();
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
        private void ClearForm()
        {
            txtScore.Clear();
            selectUserId = -1;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
