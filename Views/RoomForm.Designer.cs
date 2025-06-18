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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(152, 64);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(74, 15);
            lblRoomName.TabIndex = 0;
            lblRoomName.Text = "Room Name";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(273, 56);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(154, 23);
            txtRoomName.TabIndex = 1;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(273, 92);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(75, 23);
            cmbRoomType.TabIndex = 2;
            // 
            // lblRoomTyoe
            // 
            lblRoomTyoe.AutoSize = true;
            lblRoomTyoe.Location = new Point(152, 100);
            lblRoomTyoe.Name = "lblRoomTyoe";
            lblRoomTyoe.Size = new Size(67, 15);
            lblRoomTyoe.TabIndex = 3;
            lblRoomTyoe.Text = "Room Type";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(152, 140);
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
            dgvRooms.Location = new Point(117, 183);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(353, 171);
            dgvRooms.TabIndex = 5;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(251, 140);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblRoomName);
            panel1.Controls.Add(dgvRooms);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtRoomName);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lblRoomTyoe);
            panel1.Controls.Add(cmbRoomType);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(72, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 366);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 8;
            label1.Text = "Room Details :";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
    }
}