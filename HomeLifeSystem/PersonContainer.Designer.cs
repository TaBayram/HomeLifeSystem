namespace HomeLifeSystem
{
    partial class PersonContainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonContainer));
            this.groupBox_Person = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Nickname = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Person
            // 
            this.groupBox_Person.Controls.Add(this.pictureBox1);
            this.groupBox_Person.Controls.Add(this.label_Birthday);
            this.groupBox_Person.Controls.Add(this.label_Nickname);
            this.groupBox_Person.Controls.Add(this.label_Surname);
            this.groupBox_Person.Controls.Add(this.label_Name);
            this.groupBox_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Person.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Person.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_Person.Name = "groupBox_Person";
            this.groupBox_Person.Size = new System.Drawing.Size(198, 218);
            this.groupBox_Person.TabIndex = 0;
            this.groupBox_Person.TabStop = false;
            this.groupBox_Person.Text = "Person";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(15, 197);
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
            this.label_Surname.Location = new System.Drawing.Point(15, 168);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(55, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Surname: ";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(15, 139);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name: ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "female");
            this.imageList1.Images.SetKeyName(1, "male");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kickToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // kickToolStripMenuItem
            // 
            this.kickToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kickToolStripMenuItem.Image")));
            this.kickToolStripMenuItem.Name = "kickToolStripMenuItem";
            this.kickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kickToolStripMenuItem.Text = "Kick";
            this.kickToolStripMenuItem.Click += new System.EventHandler(this.kickToolStripMenuItem_Click);
            // 
            // PersonContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox_Person);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonContainer";
            this.Size = new System.Drawing.Size(198, 218);
            this.groupBox_Person.ResumeLayout(false);
            this.groupBox_Person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Person;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kickToolStripMenuItem;
    }
}
