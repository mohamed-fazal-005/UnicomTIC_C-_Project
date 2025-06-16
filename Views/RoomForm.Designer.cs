namespace UTIC_WindowsForm_By_Fazal.Views
{
    partial class RoomForm
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
            lblRoomName = new Label();
            txtRoomName = new TextBox();
            cmbRoomType = new ComboBox();
            lblRoomTyoe = new Label();
            btnAdd = new Button();
            dgvRooms = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(173, 45);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(74, 15);
            lblRoomName.TabIndex = 0;
            lblRoomName.Text = "Room Name";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(269, 37);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(172, 23);
            txtRoomName.TabIndex = 1;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(269, 80);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(75, 23);
            cmbRoomType.TabIndex = 2;
            // 
            // lblRoomTyoe
            // 
            lblRoomTyoe.AutoSize = true;
            lblRoomTyoe.Location = new Point(173, 88);
            lblRoomTyoe.Name = "lblRoomTyoe";
            lblRoomTyoe.Size = new Size(67, 15);
            lblRoomTyoe.TabIndex = 3;
            lblRoomTyoe.Text = "Room Type";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(173, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(124, 202);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(353, 196);
            dgvRooms.TabIndex = 5;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(269, 133);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(366, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvRooms);
            Controls.Add(btnAdd);
            Controls.Add(lblRoomTyoe);
            Controls.Add(cmbRoomType);
            Controls.Add(txtRoomName);
            Controls.Add(lblRoomName);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomName;
        private TextBox txtRoomName;
        private ComboBox cmbRoomType;
        private Label lblRoomTyoe;
        private Button btnAdd;
        private DataGridView dgvRooms;
        private Button btnEdit;
        private Button btnDelete;
    }
}