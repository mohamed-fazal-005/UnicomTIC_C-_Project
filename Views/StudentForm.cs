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
using UTIC_WindowsForm_By_Fazal.Data;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class StudentForm : Form
    {
        private int selectUserId = -1;
        public StudentForm()
        {
            InitializeComponent();
            this.Load += StudentForm_Load;
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            SetupGrid();
            LoadStudents();
        }

        private void SetupGrid()
        {
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add("StudentID", "ID");
            dgvStudents.Columns.Add("Name", "Name");
            dgvStudents.Columns.Add("Age", "Age");
            dgvStudents.Columns.Add("Address", "Address");
            dgvStudents.Columns.Add("CourseID", "Course");
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
        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();
            var students = StudentController.GetAllStudents();

            foreach (var s in students)
            {
                dgvStudents.Rows.Add(s.StudentID, s.Name, s.Age, s.Address, s.CourseID);
            }

        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) || cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string name = txtStudentName.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            string address = txtAddress.Text.Trim();
            int courseId = int.Parse(((ComboBoxItem)cmbCourse.SelectedItem).Value);

            StudentController.AddStudent(name, age, address, courseId);
            LoadStudents();
            ClearForm();
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
            string name = txtStudentName.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            string address = txtAddress.Text.Trim();
            int courseId = int.Parse(((ComboBoxItem)cmbCourse.SelectedItem).Value);

            StudentController.UpdateStudent(id, name, age, address, courseId);
            LoadStudents();
            ClearForm();
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
            StudentController.DeleteStudent(id);
            LoadStudents();
            ClearForm();
        }



        private void StudentForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                txtStudentName.Text = row.Cells[1].Value.ToString();
                txtAge.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtStudentName.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            selectUserId = -1;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
