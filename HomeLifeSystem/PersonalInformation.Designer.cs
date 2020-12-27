namespace HomeLifeSystem
{
    partial class PersonalInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInformation));
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.groupBox_Person = new System.Windows.Forms.GroupBox();
            this.label_Finished = new System.Windows.Forms.Label();
            this.lbl_SignUpErrors = new System.Windows.Forms.Label();
            this.button_DeleteAccount = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_SaveChanges = new System.Windows.Forms.Button();
            this.tb_SignUpNickname = new System.Windows.Forms.TextBox();
            this.tb_SignUpPassword = new System.Windows.Forms.TextBox();
            this.tb_SignUpSurname = new System.Windows.Forms.TextBox();
            this.tb_SignUpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SignUpGender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_SignUpBirthday = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Nickname = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.label_VerifyError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_VerifyPassword = new System.Windows.Forms.TextBox();
            this.button_VerifyCancel = new System.Windows.Forms.Button();
            this.button_Verify = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.groupBox_Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer_Main.Panel1MinSize = 32;
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.groupBox_Person);
            this.splitContainer_Main.Size = new System.Drawing.Size(550, 450);
            this.splitContainer_Main.SplitterDistance = 32;
            this.splitContainer_Main.SplitterWidth = 1;
            this.splitContainer_Main.TabIndex = 1;
            // 
            // groupBox_Person
            // 
            this.groupBox_Person.Controls.Add(this.label_Finished);
            this.groupBox_Person.Controls.Add(this.lbl_SignUpErrors);
            this.groupBox_Person.Controls.Add(this.button_DeleteAccount);
            this.groupBox_Person.Controls.Add(this.button_Cancel);
            this.groupBox_Person.Controls.Add(this.checkBox1);
            this.groupBox_Person.Controls.Add(this.button_SaveChanges);
            this.groupBox_Person.Controls.Add(this.tb_SignUpNickname);
            this.groupBox_Person.Controls.Add(this.tb_SignUpPassword);
            this.groupBox_Person.Controls.Add(this.tb_SignUpSurname);
            this.groupBox_Person.Controls.Add(this.tb_SignUpName);
            this.groupBox_Person.Controls.Add(this.label2);
            this.groupBox_Person.Controls.Add(this.label1);
            this.groupBox_Person.Controls.Add(this.comboBox_SignUpGender);
            this.groupBox_Person.Controls.Add(this.dateTimePicker_SignUpBirthday);
            this.groupBox_Person.Controls.Add(this.pictureBox1);
            this.groupBox_Person.Controls.Add(this.label_Birthday);
            this.groupBox_Person.Controls.Add(this.label_Nickname);
            this.groupBox_Person.Controls.Add(this.label_Surname);
            this.groupBox_Person.Controls.Add(this.label_Name);
            this.groupBox_Person.Controls.Add(this.panel_Control);
            this.groupBox_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Person.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Person.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_Person.Name = "groupBox_Person";
            this.groupBox_Person.Size = new System.Drawing.Size(550, 417);
            this.groupBox_Person.TabIndex = 1;
            this.groupBox_Person.TabStop = false;
            this.groupBox_Person.Text = "Person";
            // 
            // label_Finished
            // 
            this.label_Finished.AutoSize = true;
            this.label_Finished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Finished.Location = new System.Drawing.Point(172, 61);
            this.label_Finished.Name = "label_Finished";
            this.label_Finished.Size = new System.Drawing.Size(31, 13);
            this.label_Finished.TabIndex = 30;
            this.label_Finished.Text = "finish";
            this.label_Finished.Visible = false;
            // 
            // lbl_SignUpErrors
            // 
            this.lbl_SignUpErrors.AutoSize = true;
            this.lbl_SignUpErrors.ForeColor = System.Drawing.Color.Red;
            this.lbl_SignUpErrors.Location = new System.Drawing.Point(78, 357);
            this.lbl_SignUpErrors.Name = "lbl_SignUpErrors";
            this.lbl_SignUpErrors.Size = new System.Drawing.Size(29, 13);
            this.lbl_SignUpErrors.TabIndex = 6;
            this.lbl_SignUpErrors.Text = "Error";
            this.lbl_SignUpErrors.Visible = false;
            // 
            // button_DeleteAccount
            // 
            this.button_DeleteAccount.Enabled = false;
            this.button_DeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_DeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteAccount.Location = new System.Drawing.Point(18, 387);
            this.button_DeleteAccount.Name = "button_DeleteAccount";
            this.button_DeleteAccount.Size = new System.Drawing.Size(96, 23);
            this.button_DeleteAccount.TabIndex = 12;
            this.button_DeleteAccount.Text = "Delete Account";
            this.button_DeleteAccount.UseVisualStyleBackColor = true;
            this.button_DeleteAccount.Click += new System.EventHandler(this.button_DeleteAccount_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(336, 382);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(92, 23);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Change";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_SaveChanges
            // 
            this.button_SaveChanges.FlatAppearance.BorderSize = 0;
            this.button_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveChanges.Location = new System.Drawing.Point(446, 382);
            this.button_SaveChanges.Name = "button_SaveChanges";
            this.button_SaveChanges.Size = new System.Drawing.Size(92, 23);
            this.button_SaveChanges.TabIndex = 11;
            this.button_SaveChanges.Text = "Save Changes";
            this.button_SaveChanges.UseVisualStyleBackColor = true;
            this.button_SaveChanges.Click += new System.EventHandler(this.button_SaveChanges_Click);
            // 
            // tb_SignUpNickname
            // 
            this.tb_SignUpNickname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpNickname.Location = new System.Drawing.Point(81, 110);
            this.tb_SignUpNickname.MaxLength = 20;
            this.tb_SignUpNickname.Name = "tb_SignUpNickname";
            this.tb_SignUpNickname.ReadOnly = true;
            this.tb_SignUpNickname.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpNickname.TabIndex = 4;
            // 
            // tb_SignUpPassword
            // 
            this.tb_SignUpPassword.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpPassword.Location = new System.Drawing.Point(81, 238);
            this.tb_SignUpPassword.MaxLength = 20;
            this.tb_SignUpPassword.Name = "tb_SignUpPassword";
            this.tb_SignUpPassword.PasswordChar = '*';
            this.tb_SignUpPassword.ReadOnly = true;
            this.tb_SignUpPassword.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpPassword.TabIndex = 7;
            // 
            // tb_SignUpSurname
            // 
            this.tb_SignUpSurname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpSurname.Location = new System.Drawing.Point(81, 194);
            this.tb_SignUpSurname.MaxLength = 24;
            this.tb_SignUpSurname.Name = "tb_SignUpSurname";
            this.tb_SignUpSurname.ReadOnly = true;
            this.tb_SignUpSurname.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpSurname.TabIndex = 6;
            // 
            // tb_SignUpName
            // 
            this.tb_SignUpName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpName.Location = new System.Drawing.Point(81, 150);
            this.tb_SignUpName.MaxLength = 24;
            this.tb_SignUpName.Name = "tb_SignUpName";
            this.tb_SignUpName.ReadOnly = true;
            this.tb_SignUpName.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gender:";
            // 
            // comboBox_SignUpGender
            // 
            this.comboBox_SignUpGender.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox_SignUpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SignUpGender.Enabled = false;
            this.comboBox_SignUpGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SignUpGender.FormattingEnabled = true;
            this.comboBox_SignUpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_SignUpGender.Location = new System.Drawing.Point(81, 318);
            this.comboBox_SignUpGender.Name = "comboBox_SignUpGender";
            this.comboBox_SignUpGender.Size = new System.Drawing.Size(56, 21);
            this.comboBox_SignUpGender.TabIndex = 9;
            this.comboBox_SignUpGender.SelectedIndexChanged += new System.EventHandler(this.comboBox_SignUpGender_SelectedIndexChanged);
            // 
            // dateTimePicker_SignUpBirthday
            // 
            this.dateTimePicker_SignUpBirthday.CalendarMonthBackground = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker_SignUpBirthday.Enabled = false;
            this.dateTimePicker_SignUpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_SignUpBirthday.Location = new System.Drawing.Point(81, 275);
            this.dateTimePicker_SignUpBirthday.MaxDate = new System.DateTime(2020, 11, 7, 0, 0, 0, 0);
            this.dateTimePicker_SignUpBirthday.Name = "dateTimePicker_SignUpBirthday";
            this.dateTimePicker_SignUpBirthday.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_SignUpBirthday.TabIndex = 8;
            this.dateTimePicker_SignUpBirthday.Value = new System.DateTime(1999, 6, 15, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(15, 282);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(48, 13);
            this.label_Birthday.TabIndex = 3;
            this.label_Birthday.Text = "Birthday:";
            // 
            // label_Nickname
            // 
            this.label_Nickname.AutoSize = true;
            this.label_Nickname.Location = new System.Drawing.Point(15, 110);
            this.label_Nickname.Name = "label_Nickname";
            this.label_Nickname.Size = new System.Drawing.Size(58, 13);
            this.label_Nickname.TabIndex = 2;
            this.label_Nickname.Text = "Nickname:";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(15, 194);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(55, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Surname: ";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(15, 150);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name: ";
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.label_VerifyError);
            this.panel_Control.Controls.Add(this.label3);
            this.panel_Control.Controls.Add(this.textBox_VerifyPassword);
            this.panel_Control.Controls.Add(this.button_VerifyCancel);
            this.panel_Control.Controls.Add(this.button_Verify);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Control.Enabled = false;
            this.panel_Control.Location = new System.Drawing.Point(3, 16);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(544, 398);
            this.panel_Control.TabIndex = 20;
            this.panel_Control.Visible = false;
            // 
            // label_VerifyError
            // 
            this.label_VerifyError.AutoSize = true;
            this.label_VerifyError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_VerifyError.Location = new System.Drawing.Point(183, 221);
            this.label_VerifyError.Name = "label_VerifyError";
            this.label_VerifyError.Size = new System.Drawing.Size(28, 13);
            this.label_VerifyError.TabIndex = 4;
            this.label_VerifyError.Text = "error";
            this.label_VerifyError.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(121, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 70);
            this.label3.TabIndex = 3;
            this.label3.Text = "Before you can change information you must enter your password for verification";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_VerifyPassword
            // 
            this.textBox_VerifyPassword.Location = new System.Drawing.Point(183, 196);
            this.textBox_VerifyPassword.MaxLength = 32;
            this.textBox_VerifyPassword.Name = "textBox_VerifyPassword";
            this.textBox_VerifyPassword.PasswordChar = '*';
            this.textBox_VerifyPassword.Size = new System.Drawing.Size(179, 20);
            this.textBox_VerifyPassword.TabIndex = 13;
            // 
            // button_VerifyCancel
            // 
            this.button_VerifyCancel.FlatAppearance.BorderSize = 0;
            this.button_VerifyCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VerifyCancel.Location = new System.Drawing.Point(183, 241);
            this.button_VerifyCancel.Name = "button_VerifyCancel";
            this.button_VerifyCancel.Size = new System.Drawing.Size(75, 23);
            this.button_VerifyCancel.TabIndex = 14;
            this.button_VerifyCancel.Text = "Cancel";
            this.button_VerifyCancel.UseVisualStyleBackColor = true;
            this.button_VerifyCancel.Click += new System.EventHandler(this.button_VerifyCancel_Click);
            // 
            // button_Verify
            // 
            this.button_Verify.FlatAppearance.BorderSize = 0;
            this.button_Verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Verify.Location = new System.Drawing.Point(287, 241);
            this.button_Verify.Name = "button_Verify";
            this.button_Verify.Size = new System.Drawing.Size(75, 23);
            this.button_Verify.TabIndex = 15;
            this.button_Verify.Text = "Verify";
            this.button_Verify.UseVisualStyleBackColor = true;
            this.button_Verify.Click += new System.EventHandler(this.button_Verify_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "female");
            this.imageList1.Images.SetKeyName(1, "male");
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.splitContainer_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalInformation";
            this.Text = "PersonalInformation";
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.groupBox_Person.ResumeLayout(false);
            this.groupBox_Person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.GroupBox groupBox_Person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SignUpGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SignUpBirthday;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SignUpPassword;
        private System.Windows.Forms.TextBox tb_SignUpSurname;
        private System.Windows.Forms.TextBox tb_SignUpName;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_SaveChanges;
        private System.Windows.Forms.TextBox tb_SignUpNickname;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_VerifyPassword;
        private System.Windows.Forms.Button button_VerifyCancel;
        private System.Windows.Forms.Button button_Verify;
        private System.Windows.Forms.Label label_VerifyError;
        private System.Windows.Forms.Label lbl_SignUpErrors;
        private System.Windows.Forms.Button button_DeleteAccount;
        private System.Windows.Forms.Label label_Finished;
    }
}