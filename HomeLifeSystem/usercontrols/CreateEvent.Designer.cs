namespace HomeLifeSystem
{
    partial class CreateEvent
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
            this.groupBox_Event = new System.Windows.Forms.GroupBox();
            this.label_Finished = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_EndingTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartingTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.groupBox_Event.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Event
            // 
            this.groupBox_Event.Controls.Add(this.label_Finished);
            this.groupBox_Event.Controls.Add(this.label_Error);
            this.groupBox_Event.Controls.Add(this.button2);
            this.groupBox_Event.Controls.Add(this.button1);
            this.groupBox_Event.Controls.Add(this.label6);
            this.groupBox_Event.Controls.Add(this.label4);
            this.groupBox_Event.Controls.Add(this.label3);
            this.groupBox_Event.Controls.Add(this.label2);
            this.groupBox_Event.Controls.Add(this.label1);
            this.groupBox_Event.Controls.Add(this.dateTimePicker_EndingTime);
            this.groupBox_Event.Controls.Add(this.dateTimePicker_StartingTime);
            this.groupBox_Event.Controls.Add(this.textBox_Description);
            this.groupBox_Event.Controls.Add(this.textBox_Name);
            this.groupBox_Event.Controls.Add(this.comboBox_Type);
            this.groupBox_Event.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Event.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Event.Name = "groupBox_Event";
            this.groupBox_Event.Size = new System.Drawing.Size(360, 280);
            this.groupBox_Event.TabIndex = 0;
            this.groupBox_Event.TabStop = false;
            this.groupBox_Event.Text = "Event";
            // 
            // label_Finished
            // 
            this.label_Finished.AutoSize = true;
            this.label_Finished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Finished.Location = new System.Drawing.Point(36, 16);
            this.label_Finished.Name = "label_Finished";
            this.label_Finished.Size = new System.Drawing.Size(31, 13);
            this.label_Finished.TabIndex = 27;
            this.label_Finished.Text = "finish";
            this.label_Finished.Visible = false;
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(135, 209);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(28, 13);
            this.label_Error.TabIndex = 26;
            this.label_Error.Text = "error";
            this.label_Error.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(138, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(230, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_CreateEvent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ending Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // dateTimePicker_EndingTime
            // 
            this.dateTimePicker_EndingTime.CustomFormat = "HH:mm";
            this.dateTimePicker_EndingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndingTime.Location = new System.Drawing.Point(253, 166);
            this.dateTimePicker_EndingTime.Name = "dateTimePicker_EndingTime";
            this.dateTimePicker_EndingTime.ShowUpDown = true;
            this.dateTimePicker_EndingTime.Size = new System.Drawing.Size(52, 20);
            this.dateTimePicker_EndingTime.TabIndex = 14;
            // 
            // dateTimePicker_StartingTime
            // 
            this.dateTimePicker_StartingTime.CustomFormat = "HH:mm ddd d/MM/yyyy";
            this.dateTimePicker_StartingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartingTime.Location = new System.Drawing.Point(39, 166);
            this.dateTimePicker_StartingTime.Name = "dateTimePicker_StartingTime";
            this.dateTimePicker_StartingTime.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker_StartingTime.TabIndex = 13;
            this.dateTimePicker_StartingTime.ValueChanged += new System.EventHandler(this.dateTimePicker_StartingTime_ValueChanged);
            // 
            // textBox_Description
            // 
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Description.Location = new System.Drawing.Point(36, 110);
            this.textBox_Description.MaxLength = 64;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(280, 13);
            this.textBox_Description.TabIndex = 12;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Location = new System.Drawing.Point(36, 51);
            this.textBox_Name.MaxLength = 16;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(122, 13);
            this.textBox_Name.TabIndex = 10;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Watch",
            "Game",
            "Eat",
            "Guest"});
            this.comboBox_Type.Location = new System.Drawing.Point(215, 51);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(101, 21);
            this.comboBox_Type.TabIndex = 11;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Event);
            this.Name = "CreateEvent";
            this.Size = new System.Drawing.Size(360, 280);
            this.VisibleChanged += new System.EventHandler(this.CreateEvent_VisibleChanged);
            this.groupBox_Event.ResumeLayout(false);
            this.groupBox_Event.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Event;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndingTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartingTime;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label_Finished;
    }
}
