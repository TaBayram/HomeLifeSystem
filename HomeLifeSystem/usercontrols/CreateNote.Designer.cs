namespace HomeLifeSystem
{
    partial class CreateNote
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
            this.groupBox_CreateNote = new System.Windows.Forms.GroupBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.label_Text = new System.Windows.Forms.Label();
            this.label_ExpiringDate = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_CreateNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_CreateNote
            // 
            this.groupBox_CreateNote.Controls.Add(this.label_Error);
            this.groupBox_CreateNote.Controls.Add(this.button_Cancel);
            this.groupBox_CreateNote.Controls.Add(this.button_Create);
            this.groupBox_CreateNote.Controls.Add(this.label_Text);
            this.groupBox_CreateNote.Controls.Add(this.label_ExpiringDate);
            this.groupBox_CreateNote.Controls.Add(this.label_Title);
            this.groupBox_CreateNote.Controls.Add(this.dateTimePicker1);
            this.groupBox_CreateNote.Controls.Add(this.textBox2);
            this.groupBox_CreateNote.Controls.Add(this.textBox1);
            this.groupBox_CreateNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_CreateNote.Location = new System.Drawing.Point(0, 0);
            this.groupBox_CreateNote.Name = "groupBox_CreateNote";
            this.groupBox_CreateNote.Size = new System.Drawing.Size(240, 240);
            this.groupBox_CreateNote.TabIndex = 0;
            this.groupBox_CreateNote.TabStop = false;
            this.groupBox_CreateNote.Text = "Create Note";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(12, 220);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(28, 13);
            this.label_Error.TabIndex = 8;
            this.label_Error.Text = "error";
            this.label_Error.Visible = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(115, 211);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(54, 23);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Create
            // 
            this.button_Create.FlatAppearance.BorderSize = 0;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Create.Location = new System.Drawing.Point(175, 211);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(54, 23);
            this.button_Create.TabIndex = 14;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Location = new System.Drawing.Point(9, 89);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(28, 13);
            this.label_Text.TabIndex = 5;
            this.label_Text.Text = "Text";
            // 
            // label_ExpiringDate
            // 
            this.label_ExpiringDate.AutoSize = true;
            this.label_ExpiringDate.Location = new System.Drawing.Point(112, 23);
            this.label_ExpiringDate.Name = "label_ExpiringDate";
            this.label_ExpiringDate.Size = new System.Drawing.Size(70, 13);
            this.label_ExpiringDate.TabIndex = 4;
            this.label_ExpiringDate.Text = "Expiring Date";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(9, 46);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(27, 13);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Title";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(10, 105);
            this.textBox2.MaxLength = 128;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 100);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(10, 66);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 13);
            this.textBox1.TabIndex = 11;
            // 
            // CreateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_CreateNote);
            this.Name = "CreateNote";
            this.Size = new System.Drawing.Size(240, 240);
            this.groupBox_CreateNote.ResumeLayout(false);
            this.groupBox_CreateNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_CreateNote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.Label label_ExpiringDate;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label_Error;
    }
}
