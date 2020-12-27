namespace HomeLifeSystem
{
    partial class ViewRoomList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Room = new System.Windows.Forms.GroupBox();
            this.btn_DoneView = new System.Windows.Forms.Button();
            this.btn_RestoreRoom = new System.Windows.Forms.Button();
            this.btn_DeleteRoom = new System.Windows.Forms.Button();
            this.lbl_DeletedRooms = new System.Windows.Forms.Label();
            this.lbl_CurrentRooms = new System.Windows.Forms.Label();
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.listBox_DeletedRooms = new System.Windows.Forms.ListBox();
            this.lbl_RoomListError = new System.Windows.Forms.Label();
            this.lbl_RoomTypeError = new System.Windows.Forms.Label();
            this.lbl_RoomType = new System.Windows.Forms.Label();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.listBox_CurrentRooms = new System.Windows.Forms.ListBox();
            this.comboBox_RoomType = new System.Windows.Forms.ComboBox();
            this.tb_RoomName = new System.Windows.Forms.TextBox();
            this.groupBox_Room.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Room
            // 
            this.groupBox_Room.Controls.Add(this.btn_DoneView);
            this.groupBox_Room.Controls.Add(this.btn_RestoreRoom);
            this.groupBox_Room.Controls.Add(this.btn_DeleteRoom);
            this.groupBox_Room.Controls.Add(this.lbl_DeletedRooms);
            this.groupBox_Room.Controls.Add(this.lbl_CurrentRooms);
            this.groupBox_Room.Controls.Add(this.btn_AddRoom);
            this.groupBox_Room.Controls.Add(this.listBox_DeletedRooms);
            this.groupBox_Room.Controls.Add(this.lbl_RoomListError);
            this.groupBox_Room.Controls.Add(this.lbl_RoomTypeError);
            this.groupBox_Room.Controls.Add(this.lbl_RoomType);
            this.groupBox_Room.Controls.Add(this.lbl_RoomName);
            this.groupBox_Room.Controls.Add(this.listBox_CurrentRooms);
            this.groupBox_Room.Controls.Add(this.comboBox_RoomType);
            this.groupBox_Room.Controls.Add(this.tb_RoomName);
            this.groupBox_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Room.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Room.Name = "groupBox_Room";
            this.groupBox_Room.Size = new System.Drawing.Size(720, 480);
            this.groupBox_Room.TabIndex = 5;
            this.groupBox_Room.TabStop = false;
            this.groupBox_Room.Text = "Room";
            // 
            // btn_DoneView
            // 
            this.btn_DoneView.FlatAppearance.BorderSize = 0;
            this.btn_DoneView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoneView.Location = new System.Drawing.Point(642, 347);
            this.btn_DoneView.Name = "btn_DoneView";
            this.btn_DoneView.Size = new System.Drawing.Size(75, 23);
            this.btn_DoneView.TabIndex = 12;
            this.btn_DoneView.Text = "Done";
            this.btn_DoneView.UseVisualStyleBackColor = true;
            this.btn_DoneView.Click += new System.EventHandler(this.btn_DoneView_Click);
            // 
            // btn_RestoreRoom
            // 
            this.btn_RestoreRoom.FlatAppearance.BorderSize = 0;
            this.btn_RestoreRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RestoreRoom.Location = new System.Drawing.Point(404, 269);
            this.btn_RestoreRoom.Name = "btn_RestoreRoom";
            this.btn_RestoreRoom.Size = new System.Drawing.Size(72, 36);
            this.btn_RestoreRoom.TabIndex = 11;
            this.btn_RestoreRoom.Text = "Restore Room";
            this.btn_RestoreRoom.UseVisualStyleBackColor = true;
            this.btn_RestoreRoom.Click += new System.EventHandler(this.btn_RestoreRoom_Click);
            // 
            // btn_DeleteRoom
            // 
            this.btn_DeleteRoom.FlatAppearance.BorderSize = 0;
            this.btn_DeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteRoom.Location = new System.Drawing.Point(404, 220);
            this.btn_DeleteRoom.Name = "btn_DeleteRoom";
            this.btn_DeleteRoom.Size = new System.Drawing.Size(72, 36);
            this.btn_DeleteRoom.TabIndex = 10;
            this.btn_DeleteRoom.Text = "Delete Room";
            this.btn_DeleteRoom.UseVisualStyleBackColor = true;
            this.btn_DeleteRoom.Click += new System.EventHandler(this.btn_DeleteRoom_Click);
            // 
            // lbl_DeletedRooms
            // 
            this.lbl_DeletedRooms.AutoSize = true;
            this.lbl_DeletedRooms.Location = new System.Drawing.Point(534, 15);
            this.lbl_DeletedRooms.Name = "lbl_DeletedRooms";
            this.lbl_DeletedRooms.Size = new System.Drawing.Size(80, 13);
            this.lbl_DeletedRooms.TabIndex = 9;
            this.lbl_DeletedRooms.Text = "Deleted Rooms";
            // 
            // lbl_CurrentRooms
            // 
            this.lbl_CurrentRooms.AutoSize = true;
            this.lbl_CurrentRooms.Location = new System.Drawing.Point(253, 15);
            this.lbl_CurrentRooms.Name = "lbl_CurrentRooms";
            this.lbl_CurrentRooms.Size = new System.Drawing.Size(77, 13);
            this.lbl_CurrentRooms.TabIndex = 8;
            this.lbl_CurrentRooms.Text = "Current Rooms";
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.FlatAppearance.BorderSize = 0;
            this.btn_AddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRoom.Location = new System.Drawing.Point(104, 177);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRoom.TabIndex = 7;
            this.btn_AddRoom.Text = "Add Room";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // listBox_DeletedRooms
            // 
            this.listBox_DeletedRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_DeletedRooms.FormattingEnabled = true;
            this.listBox_DeletedRooms.Location = new System.Drawing.Point(495, 41);
            this.listBox_DeletedRooms.Name = "listBox_DeletedRooms";
            this.listBox_DeletedRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_DeletedRooms.Size = new System.Drawing.Size(177, 260);
            this.listBox_DeletedRooms.TabIndex = 6;
            // 
            // lbl_RoomListError
            // 
            this.lbl_RoomListError.AutoSize = true;
            this.lbl_RoomListError.ForeColor = System.Drawing.Color.Red;
            this.lbl_RoomListError.Location = new System.Drawing.Point(206, 308);
            this.lbl_RoomListError.Name = "lbl_RoomListError";
            this.lbl_RoomListError.Size = new System.Drawing.Size(29, 13);
            this.lbl_RoomListError.TabIndex = 2;
            this.lbl_RoomListError.Text = "Error";
            this.lbl_RoomListError.Visible = false;
            // 
            // lbl_RoomTypeError
            // 
            this.lbl_RoomTypeError.AutoSize = true;
            this.lbl_RoomTypeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_RoomTypeError.Location = new System.Drawing.Point(17, 92);
            this.lbl_RoomTypeError.Name = "lbl_RoomTypeError";
            this.lbl_RoomTypeError.Size = new System.Drawing.Size(29, 13);
            this.lbl_RoomTypeError.TabIndex = 2;
            this.lbl_RoomTypeError.Text = "Error";
            this.lbl_RoomTypeError.Visible = false;
            // 
            // lbl_RoomType
            // 
            this.lbl_RoomType.AutoSize = true;
            this.lbl_RoomType.Location = new System.Drawing.Point(17, 48);
            this.lbl_RoomType.Name = "lbl_RoomType";
            this.lbl_RoomType.Size = new System.Drawing.Size(31, 13);
            this.lbl_RoomType.TabIndex = 1;
            this.lbl_RoomType.Text = "Type";
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(17, 115);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(35, 13);
            this.lbl_RoomName.TabIndex = 1;
            this.lbl_RoomName.Text = "Name";
            // 
            // listBox_CurrentRooms
            // 
            this.listBox_CurrentRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_CurrentRooms.FormattingEnabled = true;
            this.listBox_CurrentRooms.Location = new System.Drawing.Point(209, 41);
            this.listBox_CurrentRooms.Name = "listBox_CurrentRooms";
            this.listBox_CurrentRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_CurrentRooms.Size = new System.Drawing.Size(177, 260);
            this.listBox_CurrentRooms.TabIndex = 3;
            // 
            // comboBox_RoomType
            // 
            this.comboBox_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_RoomType.FormattingEnabled = true;
            this.comboBox_RoomType.Items.AddRange(new object[] {
            "Balcony",
            "Bathroom",
            "Bedroom",
            "Dining Room",
            "Gaming Room",
            "Guest Room",
            "Hall",
            "Kitchen",
            "Laundry Room",
            "Living Room",
            "Study Room",
            "Other"});
            this.comboBox_RoomType.Location = new System.Drawing.Point(20, 65);
            this.comboBox_RoomType.Name = "comboBox_RoomType";
            this.comboBox_RoomType.Size = new System.Drawing.Size(159, 21);
            this.comboBox_RoomType.TabIndex = 1;
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RoomName.Location = new System.Drawing.Point(20, 131);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(159, 13);
            this.tb_RoomName.TabIndex = 2;
            // 
            // ViewRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Room);
            this.Name = "ViewRoomList";
            this.Size = new System.Drawing.Size(720, 480);
            this.groupBox_Room.ResumeLayout(false);
            this.groupBox_Room.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Room;
        private System.Windows.Forms.ListBox listBox_DeletedRooms;
        private System.Windows.Forms.Label lbl_RoomListError;
        private System.Windows.Forms.Label lbl_RoomTypeError;
        private System.Windows.Forms.Label lbl_RoomType;
        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.ListBox listBox_CurrentRooms;
        private System.Windows.Forms.ComboBox comboBox_RoomType;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.Button btn_RestoreRoom;
        private System.Windows.Forms.Button btn_DeleteRoom;
        private System.Windows.Forms.Label lbl_DeletedRooms;
        private System.Windows.Forms.Label lbl_CurrentRooms;
        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.Button btn_DoneView;
    }
}
