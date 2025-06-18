using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIC_WindowsForm_By_Fazal.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UTIC_WindowsForm_By_Fazal.Views
{
    public partial class MainForm : Form
    {
        private User loggedInUser;

        public MainForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            this.Load += MainForm_Load;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcom.Text = $"Welcome {loggedInUser.Username} ({loggedInUser.Role})";

            if (loggedInUser.Role == "Admin")
            {
                EnableAll();
            }
            else if (loggedInUser.Role == "Staff")
            {
                btnUser.Enabled = false;
                btnLecture.Enabled = false;
            }
            else if (loggedInUser.Role == "Lecturer")
            {
                btnUser.Enabled = false;
                btnCourse.Enabled = false;
                btnStudent.Enabled = false;
            }
            else if (loggedInUser.Role == "Student")
            {
                btnUser.Enabled = false;
                btnCourse.Enabled = false;
                btnStudent.Enabled = false;
                btnLecture.Enabled = false;
                btnMark.Enabled = false;

            }
        }
        private void EnableAll()
        {
            btnCourse.Enabled = true;
            btnSubject.Enabled = true;
            btnStudent.Enabled = true;
            btnExam.Enabled = true;
            btnMark.Enabled = true;
            btnTimetable.Enabled = true;
            btnLecture.Enabled = true;
            btnUser.Enabled = true;
            btnStaff.Enabled = true;
            btnRoom.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            new LectureForm().ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            new StudentForm().ShowDialog();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            new ExamForm().ShowDialog();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            new MarkForm().ShowDialog();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            new SubjectForm().ShowDialog();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            new TimetableForm().ShowDialog();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            new CourseForm().ShowDialog();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            new StaffForm().ShowDialog();
        }
    }
}
