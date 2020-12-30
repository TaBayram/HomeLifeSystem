namespace HomeLifeSystem
{
    partial class SignScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignScreen));
            this.lbAppName = new System.Windows.Forms.Label();
            this.tb_SignInNickname = new System.Windows.Forms.TextBox();
            this.tb_SignInPassword = new System.Windows.Forms.TextBox();
            this.lbl_Nickname = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.lbl_SignInNicknameError = new System.Windows.Forms.Label();
            this.lbl_SignInPasswordError = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_SignIn = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.tabPage_SignUp = new System.Windows.Forms.TabPage();
            this.lbl_SignUpErrors = new System.Windows.Forms.Label();
            this.lbl_SignUpBirthday = new System.Windows.Forms.Label();
            this.lbl_SignUpGender = new System.Windows.Forms.Label();
            this.lbl_SignUpPassword = new System.Windows.Forms.Label();
            this.lbl_SignUpSurname = new System.Windows.Forms.Label();
            this.lbl_SignUpNickname = new System.Windows.Forms.Label();
            this.lbl_SignUpName = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.dateTimePicker_SignUpBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBox_SignUpGender = new System.Windows.Forms.ComboBox();
            this.tb_SignUpPassword = new System.Windows.Forms.TextBox();
            this.tb_SignUpSurname = new System.Windows.Forms.TextBox();
            this.tb_SignUpNickname = new System.Windows.Forms.TextBox();
            this.tb_SignUpName = new System.Windows.Forms.TextBox();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_SignIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_SignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.BackColor = System.Drawing.Color.Transparent;
            this.lbAppName.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.Location = new System.Drawing.Point(120, 68);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(180, 43);
            this.lbAppName.TabIndex = 0;
            this.lbAppName.Text = "Home Life";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SignInNickname
            // 
            this.tb_SignInNickname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignInNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignInNickname.Location = new System.Drawing.Point(29, 70);
            this.tb_SignInNickname.MaxLength = 32;
            this.tb_SignInNickname.Name = "tb_SignInNickname";
            this.tb_SignInNickname.Size = new System.Drawing.Size(172, 13);
            this.tb_SignInNickname.TabIndex = 1;
            // 
            // tb_SignInPassword
            // 
            this.tb_SignInPassword.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignInPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignInPassword.Location = new System.Drawing.Point(29, 141);
            this.tb_SignInPassword.MaxLength = 32;
            this.tb_SignInPassword.Name = "tb_SignInPassword";
            this.tb_SignInPassword.PasswordChar = '*';
            this.tb_SignInPassword.Size = new System.Drawing.Size(172, 13);
            this.tb_SignInPassword.TabIndex = 2;
            // 
            // lbl_Nickname
            // 
            this.lbl_Nickname.AutoSize = true;
            this.lbl_Nickname.Location = new System.Drawing.Point(26, 54);
            this.lbl_Nickname.Name = "lbl_Nickname";
            this.lbl_Nickname.Size = new System.Drawing.Size(55, 13);
            this.lbl_Nickname.TabIndex = 3;
            this.lbl_Nickname.Text = "Nickname";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(26, 125);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.FlatAppearance.BorderSize = 0;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Location = new System.Drawing.Point(76, 226);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(75, 23);
            this.btn_SignIn.TabIndex = 4;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // lbl_SignInNicknameError
            // 
            this.lbl_SignInNicknameError.AutoSize = true;
            this.lbl_SignInNicknameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_SignInNicknameError.Location = new System.Drawing.Point(27, 93);
            this.lbl_SignInNicknameError.Name = "lbl_SignInNicknameError";
            this.lbl_SignInNicknameError.Size = new System.Drawing.Size(29, 13);
            this.lbl_SignInNicknameError.TabIndex = 7;
            this.lbl_SignInNicknameError.Text = "Error";
            this.lbl_SignInNicknameError.Visible = false;
            // 
            // lbl_SignInPasswordError
            // 
            this.lbl_SignInPasswordError.AutoSize = true;
            this.lbl_SignInPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_SignInPasswordError.Location = new System.Drawing.Point(27, 164);
            this.lbl_SignInPasswordError.Name = "lbl_SignInPasswordError";
            this.lbl_SignInPasswordError.Size = new System.Drawing.Size(29, 13);
            this.lbl_SignInPasswordError.TabIndex = 8;
            this.lbl_SignInPasswordError.Text = "Error";
            this.lbl_SignInPasswordError.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage_SignIn);
            this.tabControl1.Controls.Add(this.tabPage_SignUp);
            this.tabControl1.Location = new System.Drawing.Point(79, 150);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 320);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.TabStop = false;
            // 
            // tabPage_SignIn
            // 
            this.tabPage_SignIn.Controls.Add(this.panel1);
            this.tabPage_SignIn.Location = new System.Drawing.Point(4, 4);
            this.tabPage_SignIn.Name = "tabPage_SignIn";
            this.tabPage_SignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SignIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage_SignIn.Size = new System.Drawing.Size(232, 294);
            this.tabPage_SignIn.TabIndex = 0;
            this.tabPage_SignIn.Text = "Sign In";
            this.tabPage_SignIn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_RememberMe);
            this.panel1.Controls.Add(this.tb_SignInNickname);
            this.panel1.Controls.Add(this.tb_SignInPassword);
            this.panel1.Controls.Add(this.lbl_SignInPasswordError);
            this.panel1.Controls.Add(this.btn_SignIn);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.lbl_SignInNicknameError);
            this.panel1.Controls.Add(this.lbl_Nickname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 288);
            this.panel1.TabIndex = 10;
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.Checked = true;
            this.checkBox_RememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RememberMe.Location = new System.Drawing.Point(106, 191);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBox_RememberMe.TabIndex = 3;
            this.checkBox_RememberMe.Text = "Remember Me";
            this.checkBox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // tabPage_SignUp
            // 
            this.tabPage_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpErrors);
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpBirthday);
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpGender);
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpPassword);
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpSurname);
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpNickname);
            this.tabPage_SignUp.Controls.Add(this.lbl_SignUpName);
            this.tabPage_SignUp.Controls.Add(this.btn_SignUp);
            this.tabPage_SignUp.Controls.Add(this.dateTimePicker_SignUpBirthday);
            this.tabPage_SignUp.Controls.Add(this.comboBox_SignUpGender);
            this.tabPage_SignUp.Controls.Add(this.tb_SignUpPassword);
            this.tabPage_SignUp.Controls.Add(this.tb_SignUpSurname);
            this.tabPage_SignUp.Controls.Add(this.tb_SignUpNickname);
            this.tabPage_SignUp.Controls.Add(this.tb_SignUpName);
            this.tabPage_SignUp.Location = new System.Drawing.Point(4, 4);
            this.tabPage_SignUp.Name = "tabPage_SignUp";
            this.tabPage_SignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SignUp.Size = new System.Drawing.Size(232, 294);
            this.tabPage_SignUp.TabIndex = 1;
            this.tabPage_SignUp.Text = "Sign Up";
            // 
            // lbl_SignUpErrors
            // 
            this.lbl_SignUpErrors.AutoSize = true;
            this.lbl_SignUpErrors.ForeColor = System.Drawing.Color.Red;
            this.lbl_SignUpErrors.Location = new System.Drawing.Point(6, 222);
            this.lbl_SignUpErrors.Name = "lbl_SignUpErrors";
            this.lbl_SignUpErrors.Size = new System.Drawing.Size(29, 13);
            this.lbl_SignUpErrors.TabIndex = 5;
            this.lbl_SignUpErrors.Text = "Error";
            this.lbl_SignUpErrors.Visible = false;
            // 
            // lbl_SignUpBirthday
            // 
            this.lbl_SignUpBirthday.AutoSize = true;
            this.lbl_SignUpBirthday.Location = new System.Drawing.Point(127, 183);
            this.lbl_SignUpBirthday.Name = "lbl_SignUpBirthday";
            this.lbl_SignUpBirthday.Size = new System.Drawing.Size(45, 13);
            this.lbl_SignUpBirthday.TabIndex = 4;
            this.lbl_SignUpBirthday.Text = "Birthday";
            // 
            // lbl_SignUpGender
            // 
            this.lbl_SignUpGender.AutoSize = true;
            this.lbl_SignUpGender.Location = new System.Drawing.Point(34, 183);
            this.lbl_SignUpGender.Name = "lbl_SignUpGender";
            this.lbl_SignUpGender.Size = new System.Drawing.Size(42, 13);
            this.lbl_SignUpGender.TabIndex = 4;
            this.lbl_SignUpGender.Text = "Gender";
            // 
            // lbl_SignUpPassword
            // 
            this.lbl_SignUpPassword.AutoSize = true;
            this.lbl_SignUpPassword.Location = new System.Drawing.Point(34, 144);
            this.lbl_SignUpPassword.Name = "lbl_SignUpPassword";
            this.lbl_SignUpPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_SignUpPassword.TabIndex = 4;
            this.lbl_SignUpPassword.Text = "Password";
            // 
            // lbl_SignUpSurname
            // 
            this.lbl_SignUpSurname.AutoSize = true;
            this.lbl_SignUpSurname.Location = new System.Drawing.Point(34, 105);
            this.lbl_SignUpSurname.Name = "lbl_SignUpSurname";
            this.lbl_SignUpSurname.Size = new System.Drawing.Size(49, 13);
            this.lbl_SignUpSurname.TabIndex = 4;
            this.lbl_SignUpSurname.Text = "Surname";
            // 
            // lbl_SignUpNickname
            // 
            this.lbl_SignUpNickname.AutoSize = true;
            this.lbl_SignUpNickname.Location = new System.Drawing.Point(34, 27);
            this.lbl_SignUpNickname.Name = "lbl_SignUpNickname";
            this.lbl_SignUpNickname.Size = new System.Drawing.Size(55, 13);
            this.lbl_SignUpNickname.TabIndex = 4;
            this.lbl_SignUpNickname.Text = "Nickname";
            // 
            // lbl_SignUpName
            // 
            this.lbl_SignUpName.AutoSize = true;
            this.lbl_SignUpName.Location = new System.Drawing.Point(34, 66);
            this.lbl_SignUpName.Name = "lbl_SignUpName";
            this.lbl_SignUpName.Size = new System.Drawing.Size(35, 13);
            this.lbl_SignUpName.TabIndex = 4;
            this.lbl_SignUpName.Text = "Name";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Location = new System.Drawing.Point(151, 245);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 6;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // dateTimePicker_SignUpBirthday
            // 
            this.dateTimePicker_SignUpBirthday.CalendarMonthBackground = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker_SignUpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_SignUpBirthday.Location = new System.Drawing.Point(130, 199);
            this.dateTimePicker_SignUpBirthday.MaxDate = new System.DateTime(2020, 11, 7, 0, 0, 0, 0);
            this.dateTimePicker_SignUpBirthday.Name = "dateTimePicker_SignUpBirthday";
            this.dateTimePicker_SignUpBirthday.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_SignUpBirthday.TabIndex = 5;
            this.dateTimePicker_SignUpBirthday.Value = new System.DateTime(1999, 6, 15, 0, 0, 0, 0);
            // 
            // comboBox_SignUpGender
            // 
            this.comboBox_SignUpGender.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox_SignUpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SignUpGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SignUpGender.FormattingEnabled = true;
            this.comboBox_SignUpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_SignUpGender.Location = new System.Drawing.Point(37, 198);
            this.comboBox_SignUpGender.Name = "comboBox_SignUpGender";
            this.comboBox_SignUpGender.Size = new System.Drawing.Size(65, 21);
            this.comboBox_SignUpGender.TabIndex = 4;
            // 
            // tb_SignUpPassword
            // 
            this.tb_SignUpPassword.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpPassword.Location = new System.Drawing.Point(37, 160);
            this.tb_SignUpPassword.MaxLength = 20;
            this.tb_SignUpPassword.Name = "tb_SignUpPassword";
            this.tb_SignUpPassword.PasswordChar = '*';
            this.tb_SignUpPassword.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpPassword.TabIndex = 3;
            // 
            // tb_SignUpSurname
            // 
            this.tb_SignUpSurname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpSurname.Location = new System.Drawing.Point(37, 121);
            this.tb_SignUpSurname.MaxLength = 24;
            this.tb_SignUpSurname.Name = "tb_SignUpSurname";
            this.tb_SignUpSurname.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpSurname.TabIndex = 2;
            // 
            // tb_SignUpNickname
            // 
            this.tb_SignUpNickname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpNickname.Location = new System.Drawing.Point(37, 43);
            this.tb_SignUpNickname.MaxLength = 20;
            this.tb_SignUpNickname.Name = "tb_SignUpNickname";
            this.tb_SignUpNickname.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpNickname.TabIndex = 0;
            // 
            // tb_SignUpName
            // 
            this.tb_SignUpName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_SignUpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SignUpName.Location = new System.Drawing.Point(37, 82);
            this.tb_SignUpName.MaxLength = 24;
            this.tb_SignUpName.Name = "tb_SignUpName";
            this.tb_SignUpName.Size = new System.Drawing.Size(172, 13);
            this.tb_SignUpName.TabIndex = 1;
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Main.IsSplitterFixed = true;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.button1);
            this.splitContainer_Main.Panel2.Controls.Add(this.lbAppName);
            this.splitContainer_Main.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer_Main.Size = new System.Drawing.Size(420, 640);
            this.splitContainer_Main.SplitterDistance = 32;
            this.splitContainer_Main.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(385, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(132)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(420, 640);
            this.Controls.Add(this.splitContainer_Main);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignScreen";
            this.Text = "SignScreen";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_SignIn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_SignUp.ResumeLayout(false);
            this.tabPage_SignUp.PerformLayout();
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            this.splitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.TextBox tb_SignInNickname;
        private System.Windows.Forms.TextBox tb_SignInPassword;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label lbl_SignInNicknameError;
        private System.Windows.Forms.Label lbl_SignInPasswordError;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SignIn;
        private System.Windows.Forms.TabPage tabPage_SignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.Label lbl_SignUpBirthday;
        private System.Windows.Forms.Label lbl_SignUpGender;
        private System.Windows.Forms.Label lbl_SignUpSurname;
        private System.Windows.Forms.Label lbl_SignUpName;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SignUpBirthday;
        private System.Windows.Forms.ComboBox comboBox_SignUpGender;
        private System.Windows.Forms.TextBox tb_SignUpSurname;
        private System.Windows.Forms.TextBox tb_SignUpName;
        private System.Windows.Forms.Label lbl_SignUpPassword;
        private System.Windows.Forms.TextBox tb_SignUpPassword;
        private System.Windows.Forms.Label lbl_Nickname;
        private System.Windows.Forms.Label lbl_SignUpNickname;
        private System.Windows.Forms.TextBox tb_SignUpNickname;
        private System.Windows.Forms.Label lbl_SignUpErrors;
        private System.Windows.Forms.CheckBox checkBox_RememberMe;
        private System.Windows.Forms.Button button1;
    }
}