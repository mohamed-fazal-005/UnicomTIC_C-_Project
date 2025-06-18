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
    public partial class CourseForm : Form
    {
        private int selectUserId = -1;
        public CourseForm()
        {
            InitializeComponent();
            this.Load += CourseForm_Load;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadCourses();
        }
        private void SetupGrid()
        {
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.MultiSelect = false;
            dgvCourse.Columns.Clear();
            dgvCourse.Columns.Add("CourseID", "ID");
            dgvCourse.Columns.Add("CourseName", "Course Name");
        }

        private void LoadCourses()
        {
            dgvCourse.Rows.Clear();
            var courses = CourseController.GetAllCourses();

            foreach (var c in courses)
            {
                dgvCourse.Rows.Add(c.CourseID, c.CourseName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Course name required.");
                return;
            }

            CourseController.AddCourse(txtCourseName.Text.Trim());
            LoadCourses();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvCourse.SelectedRows[0].Cells[0].Value);
            string name = txtCourseName.Text.Trim();

            CourseController.UpdateCourse(id, name);
            LoadCourses();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvCourse.SelectedRows[0].Cells[0].Value);
            CourseController.DeleteCourse(id);
            LoadCourses();
            ClearForm();
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                txtCourseName.Text = dgvCourse.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtCourseName.Clear();
            selectUserId = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
