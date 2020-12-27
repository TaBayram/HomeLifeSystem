namespace HomeLifeSystem
{
    partial class CreateBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Finished = new System.Windows.Forms.Label();
            this.checkBox_Yearly = new System.Windows.Forms.CheckBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.button_CreateBill = new System.Windows.Forms.Button();
            this.label_Currency = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.label_PaymentDue = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.textBox_Currency = new System.Windows.Forms.TextBox();
            this.numericUpDown_Cost = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_PaymentDue = new System.Windows.Forms.DateTimePicker();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cost)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_Finished);
            this.groupBox1.Controls.Add(this.checkBox_Yearly);
            this.groupBox1.Controls.Add(this.label_Error);
            this.groupBox1.Controls.Add(this.button_CreateBill);
            this.groupBox1.Controls.Add(this.label_Currency);
            this.groupBox1.Controls.Add(this.label_Cost);
            this.groupBox1.Controls.Add(this.label_PaymentDue);
            this.groupBox1.Controls.Add(this.label_Type);
            this.groupBox1.Controls.Add(this.textBox_Currency);
            this.groupBox1.Controls.Add(this.numericUpDown_Cost);
            this.groupBox1.Controls.Add(this.dateTimePicker_PaymentDue);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.comboBox_Type);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bills";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(78, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Finished
            // 
            this.label_Finished.AutoSize = true;
            this.label_Finished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Finished.Location = new System.Drawing.Point(30, 16);
            this.label_Finished.Name = "label_Finished";
            this.label_Finished.Size = new System.Drawing.Size(31, 13);
            this.label_Finished.TabIndex = 30;
            this.label_Finished.Text = "finish";
            this.label_Finished.Visible = false;
            // 
            // checkBox_Yearly
            // 
            this.checkBox_Yearly.AutoSize = true;
            this.checkBox_Yearly.Checked = true;
            this.checkBox_Yearly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Yearly.Location = new System.Drawing.Point(32, 207);
            this.checkBox_Yearly.Name = "checkBox_Yearly";
            this.checkBox_Yearly.Size = new System.Drawing.Size(55, 17);
            this.checkBox_Yearly.TabIndex = 14;
            this.checkBox_Yearly.Text = "Yearly";
            this.checkBox_Yearly.UseVisualStyleBackColor = true;
            this.checkBox_Yearly.CheckedChanged += new System.EventHandler(this.checkBox_Yearly_CheckedChanged);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(78, 275);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(29, 13);
            this.label_Error.TabIndex = 11;
            this.label_Error.Text = "Error";
            this.label_Error.Visible = false;
            // 
            // button_CreateBill
            // 
            this.button_CreateBill.FlatAppearance.BorderSize = 0;
            this.button_CreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateBill.Location = new System.Drawing.Point(159, 291);
            this.button_CreateBill.Name = "button_CreateBill";
            this.button_CreateBill.Size = new System.Drawing.Size(75, 23);
            this.button_CreateBill.TabIndex = 17;
            this.button_CreateBill.Text = "Create";
            this.button_CreateBill.UseVisualStyleBackColor = true;
            this.button_CreateBill.Click += new System.EventHandler(this.button_AddBill_Click);
            // 
            // label_Currency
            // 
            this.label_Currency.AutoSize = true;
            this.label_Currency.Location = new System.Drawing.Point(103, 135);
            this.label_Currency.Name = "label_Currency";
            this.label_Currency.Size = new System.Drawing.Size(49, 13);
            this.label_Currency.TabIndex = 9;
            this.label_Currency.Text = "Currency";
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.Location = new System.Drawing.Point(29, 135);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(28, 13);
            this.label_Cost.TabIndex = 8;
            this.label_Cost.Text = "Cost";
            // 
            // label_PaymentDue
            // 
            this.label_PaymentDue.AutoSize = true;
            this.label_PaymentDue.Location = new System.Drawing.Point(78, 186);
            this.label_PaymentDue.Name = "label_PaymentDue";
            this.label_PaymentDue.Size = new System.Drawing.Size(71, 13);
            this.label_PaymentDue.TabIndex = 7;
            this.label_PaymentDue.Text = "Payment Due";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(33, 85);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(31, 13);
            this.label_Type.TabIndex = 6;
            this.label_Type.Text = "Type";
            // 
            // textBox_Currency
            // 
            this.textBox_Currency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Currency.Location = new System.Drawing.Point(106, 151);
            this.textBox_Currency.MaxLength = 3;
            this.textBox_Currency.Name = "textBox_Currency";
            this.textBox_Currency.Size = new System.Drawing.Size(31, 13);
            this.textBox_Currency.TabIndex = 13;
            // 
            // numericUpDown_Cost
            // 
            this.numericUpDown_Cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_Cost.Location = new System.Drawing.Point(32, 151);
            this.numericUpDown_Cost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Cost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Cost.Name = "numericUpDown_Cost";
            this.numericUpDown_Cost.Size = new System.Drawing.Size(68, 16);
            this.numericUpDown_Cost.TabIndex = 4;
            this.numericUpDown_Cost.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // dateTimePicker_PaymentDue
            // 
            this.dateTimePicker_PaymentDue.CustomFormat = "dd/MM";
            this.dateTimePicker_PaymentDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_PaymentDue.Location = new System.Drawing.Point(93, 202);
            this.dateTimePicker_PaymentDue.Name = "dateTimePicker_PaymentDue";
            this.dateTimePicker_PaymentDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_PaymentDue.ShowUpDown = true;
            this.dateTimePicker_PaymentDue.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker_PaymentDue.TabIndex = 15;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Location = new System.Drawing.Point(32, 52);
            this.textBox_Name.MaxLength = 16;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 13);
            this.textBox_Name.TabIndex = 10;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.ItemHeight = 13;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Gas",
            "Electric",
            "Water",
            "Internet",
            "Rent",
            "Streaming Service"});
            this.comboBox_Type.Location = new System.Drawing.Point(32, 101);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Type.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(29, 36);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateBill";
            this.Size = new System.Drawing.Size(240, 320);
            this.VisibleChanged += new System.EventHandler(this.CreateBill_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PaymentDue;
        private System.Windows.Forms.TextBox textBox_Currency;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cost;
        private System.Windows.Forms.Label label_Currency;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.Label label_PaymentDue;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Button button_CreateBill;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.CheckBox checkBox_Yearly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Finished;
    }
}
