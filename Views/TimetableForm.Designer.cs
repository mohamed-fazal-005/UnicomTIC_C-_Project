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
            ((System.ComponentModel.ISupportInitialize)dgvTimetables).BeginInit();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(219, 38);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(46, 15);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject";
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Location = new Point(219, 75);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(57, 15);
            lblTimeSlot.TabIndex = 1;
            lblTimeSlot.Text = "Time Slot";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(304, 30);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(105, 23);
            cmbSubject.TabIndex = 2;
            // 
            // cmbRooms
            // 
            cmbRooms.FormattingEnabled = true;
            cmbRooms.Location = new Point(304, 110);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(105, 23);
            cmbRooms.TabIndex = 3;
            // 
            // txtTimeSlot
            // 
            txtTimeSlot.Location = new Point(304, 67);
            txtTimeSlot.Name = "txtTimeSlot";
            txtTimeSlot.Size = new Size(204, 23);
            txtTimeSlot.TabIndex = 4;
            txtTimeSlot.TextChanged += textBox1_TextChanged;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(226, 118);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(39, 15);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room";
            // 
            // btnAddTimetable
            // 
            btnAddTimetable.Location = new Point(201, 160);
            btnAddTimetable.Name = "btnAddTimetable";
            btnAddTimetable.Size = new Size(75, 23);
            btnAddTimetable.TabIndex = 6;
            btnAddTimetable.Text = "Add";
            btnAddTimetable.UseVisualStyleBackColor = true;
            btnAddTimetable.Click += btnAddTimetable_Click;
            // 
            // btnEditTimetable
            // 
            btnEditTimetable.Location = new Point(318, 160);
            btnEditTimetable.Name = "btnEditTimetable";
            btnEditTimetable.Size = new Size(75, 23);
            btnEditTimetable.TabIndex = 7;
            btnEditTimetable.Text = "Edit";
            btnEditTimetable.UseVisualStyleBackColor = true;
            btnEditTimetable.Click += btnEditTimetable_Click;
            // 
            // btnDeleteTimetable
            // 
            btnDeleteTimetable.Location = new Point(433, 160);
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
            dgvTimetables.Location = new Point(134, 221);
            dgvTimetables.Name = "dgvTimetables";
            dgvTimetables.Size = new Size(449, 183);
            dgvTimetables.TabIndex = 9;
            dgvTimetables.CellContentClick += dgvTimetables_CellContentClick;
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTimetables);
            Controls.Add(btnDeleteTimetable);
            Controls.Add(btnEditTimetable);
            Controls.Add(btnAddTimetable);
            Controls.Add(lblRoom);
            Controls.Add(txtTimeSlot);
            Controls.Add(cmbRooms);
            Controls.Add(cmbSubject);
            Controls.Add(lblTimeSlot);
            Controls.Add(lblSubject);
            Name = "TimetableForm";
            Text = "TimetableForm";
            Load += TimetableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTimetables).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}