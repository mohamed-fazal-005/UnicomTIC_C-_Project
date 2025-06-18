namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class TimetableForm
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
            lblSubject = new Label();
            lblTimeSlot = new Label();
            cmbSubject = new ComboBox();
            cmbRooms = new ComboBox();
            txtTimeSlot = new TextBox();
            lblRoom = new Label();
            btnAddTimetable = new Button();
            btnEditTimetable = new Button();
            btnDeleteTimetable = new Button();
            dgvTimetables = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTimetables).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(179, 55);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(46, 15);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject";
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Location = new Point(179, 84);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(57, 15);
            lblTimeSlot.TabIndex = 1;
            lblTimeSlot.Text = "Time Slot";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(273, 47);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(105, 23);
            cmbSubject.TabIndex = 2;
            // 
            // cmbRooms
            // 
            cmbRooms.FormattingEnabled = true;
            cmbRooms.Location = new Point(273, 109);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(105, 23);
            cmbRooms.TabIndex = 3;
            // 
            // txtTimeSlot
            // 
            txtTimeSlot.Location = new Point(273, 76);
            txtTimeSlot.Name = "txtTimeSlot";
            txtTimeSlot.Size = new Size(181, 23);
            txtTimeSlot.TabIndex = 4;
            txtTimeSlot.TextChanged += textBox1_TextChanged;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(179, 117);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(39, 15);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room";
            // 
            // btnAddTimetable
            // 
            btnAddTimetable.Location = new Point(179, 155);
            btnAddTimetable.Name = "btnAddTimetable";
            btnAddTimetable.Size = new Size(75, 23);
            btnAddTimetable.TabIndex = 6;
            btnAddTimetable.Text = "Add";
            btnAddTimetable.UseVisualStyleBackColor = true;
            btnAddTimetable.Click += btnAddTimetable_Click;
            // 
            // btnEditTimetable
            // 
            btnEditTimetable.Location = new Point(273, 155);
            btnEditTimetable.Name = "btnEditTimetable";
            btnEditTimetable.Size = new Size(75, 23);
            btnEditTimetable.TabIndex = 7;
            btnEditTimetable.Text = "Edit";
            btnEditTimetable.UseVisualStyleBackColor = true;
            btnEditTimetable.Click += btnEditTimetable_Click;
            // 
            // btnDeleteTimetable
            // 
            btnDeleteTimetable.Location = new Point(379, 155);
            btnDeleteTimetable.Name = "btnDeleteTimetable";
            btnDeleteTimetable.Size = new Size(75, 23);
            btnDeleteTimetable.TabIndex = 8;
            btnDeleteTimetable.Text = "Delete";
            btnDeleteTimetable.UseVisualStyleBackColor = true;
            btnDeleteTimetable.Click += btnDeleteTimetable_Click;
            // 
            // dgvTimetables
            // 
            dgvTimetables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimetables.Location = new Point(97, 184);
            dgvTimetables.Name = "dgvTimetables";
            dgvTimetables.Size = new Size(423, 161);
            dgvTimetables.TabIndex = 9;
            dgvTimetables.CellContentClick += dgvTimetables_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSubject);
            panel1.Controls.Add(btnDeleteTimetable);
            panel1.Controls.Add(dgvTimetables);
            panel1.Controls.Add(cmbSubject);
            panel1.Controls.Add(txtTimeSlot);
            panel1.Controls.Add(btnEditTimetable);
            panel1.Controls.Add(lblTimeSlot);
            panel1.Controls.Add(btnAddTimetable);
            panel1.Controls.Add(cmbRooms);
            panel1.Controls.Add(lblRoom);
            panel1.Location = new Point(70, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 356);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 10;
            label1.Text = "Timetable Details :";
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "TimetableForm";
            Text = "TimetableForm";
            Load += TimetableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTimetables).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSubject;
        private Label lblTimeSlot;
        private ComboBox cmbSubject;
        private ComboBox cmbRooms;
        private TextBox txtTimeSlot;
        private Label lblRoom;
        private Button btnAddTimetable;
        private Button btnEditTimetable;
        private Button btnDeleteTimetable;
        private DataGridView dgvTimetables;
        private Panel panel1;
        private Label label1;
    }
}