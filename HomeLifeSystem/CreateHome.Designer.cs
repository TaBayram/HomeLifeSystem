namespace HomeLifeSystem
{
    partial class CreateHome
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
            this.listBox_Rooms = new System.Windows.Forms.ListBox();
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.tb_RoomName = new System.Windows.Forms.TextBox();
            this.comboBox_RoomType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Room = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_RoomNameError = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_DeleteRoom = new System.Windows.Forms.Button();
            this.lbl_RoomListError = new System.Windows.Forms.Label();
            this.lbl_RoomTypeError = new System.Windows.Forms.Label();
            this.lbl_RoomType = new System.Windows.Forms.Label();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.groupBox_Home = new System.Windows.Forms.GroupBox();
            this.lbl_ErrorAddress = new System.Windows.Forms.Label();
            this.lbl_HomeNameError = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_HomeName = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_HomeName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Room.SuspendLayout();
            this.groupBox_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Rooms
            // 
            this.listBox_Rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Rooms.FormattingEnabled = true;
            this.listBox_Rooms.Location = new System.Drawing.Point(182, 32);
            this.listBox_Rooms.Name = "listBox_Rooms";
            this.listBox_Rooms.Size = new System.Drawing.Size(202, 156);
            this.listBox_Rooms.TabIndex = 3;
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.FlatAppearance.BorderSize = 0;
            this.btn_AddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRoom.Location = new System.Drawing.Point(252, 213);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRoom.TabIndex = 2;
            this.btn_AddRoom.Text = "Add Room";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RoomName.Location = new System.Drawing.Point(17, 112);
            this.tb_RoomName.MaxLength = 32;
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(159, 13);
            this.tb_RoomName.TabIndex = 2;
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
            this.comboBox_RoomType.Location = new System.Drawing.Point(17, 46);
            this.comboBox_RoomType.Name = "comboBox_RoomType";
            this.comboBox_RoomType.Size = new System.Drawing.Size(159, 21);
            this.comboBox_RoomType.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.61111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.38889F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Room, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Home, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.41666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_Room
            // 
            this.groupBox_Room.Controls.Add(this.btn_Cancel);
            this.groupBox_Room.Controls.Add(this.lbl_RoomNameError);
            this.groupBox_Room.Controls.Add(this.btn_Create);
            this.groupBox_Room.Controls.Add(this.btn_DeleteRoom);
            this.groupBox_Room.Controls.Add(this.lbl_RoomListError);
            this.groupBox_Room.Controls.Add(this.lbl_RoomTypeError);
            this.groupBox_Room.Controls.Add(this.lbl_RoomType);
            this.groupBox_Room.Controls.Add(this.lbl_RoomName);
            this.groupBox_Room.Controls.Add(this.listBox_Rooms);
            this.groupBox_Room.Controls.Add(this.comboBox_RoomType);
            this.groupBox_Room.Controls.Add(this.btn_AddRoom);
            this.groupBox_Room.Controls.Add(this.tb_RoomName);
            this.groupBox_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Room.Location = new System.Drawing.Point(280, 3);
            this.groupBox_Room.Name = "groupBox_Room";
            this.groupBox_Room.Size = new System.Drawing.Size(437, 314);
            this.groupBox_Room.TabIndex = 4;
            this.groupBox_Room.TabStop = false;
            this.groupBox_Room.Text = "Room";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(268, 285);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_RoomNameError
            // 
            this.lbl_RoomNameError.AutoSize = true;
            this.lbl_RoomNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_RoomNameError.Location = new System.Drawing.Point(14, 135);
            this.lbl_RoomNameError.Name = "lbl_RoomNameError";
            this.lbl_RoomNameError.Size = new System.Drawing.Size(29, 13);
            this.lbl_RoomNameError.TabIndex = 6;
            this.lbl_RoomNameError.Text = "Error";
            this.lbl_RoomNameError.Visible = false;
            // 
            // btn_Create
            // 
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Location = new System.Drawing.Point(357, 285);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_DeleteRoom
            // 
            this.btn_DeleteRoom.FlatAppearance.BorderSize = 0;
            this.btn_DeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteRoom.Location = new System.Drawing.Point(171, 213);
            this.btn_DeleteRoom.Name = "btn_DeleteRoom";
            this.btn_DeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteRoom.TabIndex = 5;
            this.btn_DeleteRoom.Text = "Delete Room";
            this.btn_DeleteRoom.UseVisualStyleBackColor = true;
            this.btn_DeleteRoom.Click += new System.EventHandler(this.btn_DeleteRoom_Click);
            // 
            // lbl_RoomListError
            // 
            this.lbl_RoomListError.AutoSize = true;
            this.lbl_RoomListError.ForeColor = System.Drawing.Color.Red;
            this.lbl_RoomListError.Location = new System.Drawing.Point(179, 195);
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
            this.lbl_RoomTypeError.Location = new System.Drawing.Point(14, 70);
            this.lbl_RoomTypeError.Name = "lbl_RoomTypeError";
            this.lbl_RoomTypeError.Size = new System.Drawing.Size(29, 13);
            this.lbl_RoomTypeError.TabIndex = 2;
            this.lbl_RoomTypeError.Text = "Error";
            this.lbl_RoomTypeError.Visible = false;
            // 
            // lbl_RoomType
            // 
            this.lbl_RoomType.AutoSize = true;
            this.lbl_RoomType.Location = new System.Drawing.Point(14, 29);
            this.lbl_RoomType.Name = "lbl_RoomType";
            this.lbl_RoomType.Size = new System.Drawing.Size(31, 13);
            this.lbl_RoomType.TabIndex = 1;
            this.lbl_RoomType.Text = "Type";
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(14, 96);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(35, 13);
            this.lbl_RoomName.TabIndex = 1;
            this.lbl_RoomName.Text = "Name";
            // 
            // groupBox_Home
            // 
            this.groupBox_Home.Controls.Add(this.lbl_ErrorAddress);
            this.groupBox_Home.Controls.Add(this.lbl_HomeNameError);
            this.groupBox_Home.Controls.Add(this.lbl_Address);
            this.groupBox_Home.Controls.Add(this.lbl_HomeName);
            this.groupBox_Home.Controls.Add(this.tb_Address);
            this.groupBox_Home.Controls.Add(this.tb_HomeName);
            this.groupBox_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Home.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Home.Name = "groupBox_Home";
            this.groupBox_Home.Size = new System.Drawing.Size(271, 314);
            this.groupBox_Home.TabIndex = 5;
            this.groupBox_Home.TabStop = false;
            this.groupBox_Home.Text = "Home";
            // 
            // lbl_ErrorAddress
            // 
            this.lbl_ErrorAddress.AutoSize = true;
            this.lbl_ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorAddress.Location = new System.Drawing.Point(6, 151);
            this.lbl_ErrorAddress.Name = "lbl_ErrorAddress";
            this.lbl_ErrorAddress.Size = new System.Drawing.Size(29, 13);
            this.lbl_ErrorAddress.TabIndex = 2;
            this.lbl_ErrorAddress.Text = "Error";
            this.lbl_ErrorAddress.Visible = false;
            // 
            // lbl_HomeNameError
            // 
            this.lbl_HomeNameError.AutoSize = true;
            this.lbl_HomeNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_HomeNameError.Location = new System.Drawing.Point(6, 73);
            this.lbl_HomeNameError.Name = "lbl_HomeNameError";
            this.lbl_HomeNameError.Size = new System.Drawing.Size(29, 13);
            this.lbl_HomeNameError.TabIndex = 2;
            this.lbl_HomeNameError.Text = "Error";
            this.lbl_HomeNameError.Visible = false;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(6, 94);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 1;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.AutoSize = true;
            this.lbl_HomeName.Location = new System.Drawing.Point(6, 32);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(35, 13);
            this.lbl_HomeName.TabIndex = 1;
            this.lbl_HomeName.Text = "Name";
            // 
            // tb_Address
            // 
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Location = new System.Drawing.Point(9, 112);
            this.tb_Address.MaxLength = 128;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(177, 36);
            this.tb_Address.TabIndex = 1;
            // 
            // tb_HomeName
            // 
            this.tb_HomeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HomeName.Location = new System.Drawing.Point(9, 50);
            this.tb_HomeName.MaxLength = 32;
            this.tb_HomeName.Name = "tb_HomeName";
            this.tb_HomeName.Size = new System.Drawing.Size(177, 13);
            this.tb_HomeName.TabIndex = 0;
            this.tb_HomeName.Text = "Sweet Home";
            // 
            // CreateHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateHome";
            this.Size = new System.Drawing.Size(720, 320);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Room.ResumeLayout(false);
            this.groupBox_Room.PerformLayout();
            this.groupBox_Home.ResumeLayout(false);
            this.groupBox_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.ComboBox comboBox_RoomType;
        private System.Windows.Forms.ListBox listBox_Rooms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_HomeName;
        private System.Windows.Forms.GroupBox groupBox_Room;
        private System.Windows.Forms.Label lbl_RoomType;
        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.GroupBox groupBox_Home;
        private System.Windows.Forms.Label lbl_HomeName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label lbl_HomeNameError;
        private System.Windows.Forms.Label lbl_RoomTypeError;
        private System.Windows.Forms.Label lbl_RoomListError;
        private System.Windows.Forms.Button btn_DeleteRoom;
        private System.Windows.Forms.Label lbl_ErrorAddress;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_RoomNameError;
    }
}
