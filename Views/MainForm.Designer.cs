namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUser = new Button();
            btnLecture = new Button();
            btnStudent = new Button();
            btnExam = new Button();
            btnMark = new Button();
            btnSubject = new Button();
            btnTimetable = new Button();
            btnCourse = new Button();
            btnRoom = new Button();
            panel1 = new Panel();
            btnStaff = new Button();
            lblWelcom = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.Location = new Point(47, 11);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(75, 23);
            btnUser.TabIndex = 0;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnLecture
            // 
            btnLecture.Location = new Point(47, 52);
            btnLecture.Name = "btnLecture";
            btnLecture.Size = new Size(75, 23);
            btnLecture.TabIndex = 1;
            btnLecture.Text = "Lecture";
            btnLecture.UseVisualStyleBackColor = true;
            btnLecture.Click += btnLecture_Click;
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(47, 145);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(75, 23);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnExam
            // 
            btnExam.Location = new Point(47, 193);
            btnExam.Name = "btnExam";
            btnExam.Size = new Size(75, 23);
            btnExam.TabIndex = 3;
            btnExam.Text = "Exam";
            btnExam.UseVisualStyleBackColor = true;
            btnExam.Click += btnExam_Click;
            // 
            // btnMark
            // 
            btnMark.Location = new Point(47, 239);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(75, 23);
            btnMark.TabIndex = 4;
            btnMark.Text = "Mark";
            btnMark.UseVisualStyleBackColor = true;
            btnMark.Click += btnMark_Click;
            // 
            // btnSubject
            // 
            btnSubject.Location = new Point(47, 286);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(75, 23);
            btnSubject.TabIndex = 5;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnTimetable
            // 
            btnTimetable.Location = new Point(47, 327);
            btnTimetable.Name = "btnTimetable";
            btnTimetable.Size = new Size(75, 23);
            btnTimetable.TabIndex = 6;
            btnTimetable.Text = "Timetable";
            btnTimetable.UseVisualStyleBackColor = true;
            btnTimetable.Click += btnTimetable_Click;
            // 
            // btnCourse
            // 
            btnCourse.Location = new Point(47, 371);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(75, 23);
            btnCourse.TabIndex = 7;
            btnCourse.Text = "Course";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(47, 414);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(75, 23);
            btnRoom.TabIndex = 8;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnLecture);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(btnExam);
            panel1.Controls.Add(btnMark);
            panel1.Controls.Add(btnSubject);
            panel1.Controls.Add(btnTimetable);
            panel1.Controls.Add(btnCourse);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 9;
            // 
            // btnStaff
            // 
            btnStaff.Location = new Point(47, 98);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(75, 23);
            btnStaff.TabIndex = 11;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // lblWelcom
            // 
            lblWelcom.AutoSize = true;
            lblWelcom.Location = new Point(340, 57);
            lblWelcom.Name = "lblWelcom";
            lblWelcom.Size = new Size(57, 15);
            lblWelcom.TabIndex = 10;
            lblWelcom.Text = "Welcome";
            lblWelcom.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcom);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUser;
        private Button btnLecture;
        private Button btnStudent;
        private Button btnExam;
        private Button btnMark;
        private Button btnSubject;
        private Button btnTimetable;
        private Button btnCourse;
        private Button btnRoom;
        private Panel panel1;
        private Label lblWelcom;
        private Button btnStaff;
    }
}