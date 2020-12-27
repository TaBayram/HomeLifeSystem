namespace HomeLifeSystem
{
    partial class NotePaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePaper));
            this.groupBox_Note = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.label_Text = new System.Windows.Forms.Label();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.label_RemainingDays = new System.Windows.Forms.Label();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_CreatedDate = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Note.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_4.SuspendLayout();
            this.panel_3.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Note
            // 
            this.groupBox_Note.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Note.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Note.Name = "groupBox_Note";
            this.groupBox_Note.Size = new System.Drawing.Size(240, 240);
            this.groupBox_Note.TabIndex = 0;
            this.groupBox_Note.TabStop = false;
            this.groupBox_Note.Text = "Note";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel_3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 221);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel_4
            // 
            this.panel_4.Controls.Add(this.label_Text);
            this.panel_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_4.Location = new System.Drawing.Point(3, 102);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(228, 116);
            this.panel_4.TabIndex = 3;
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Text.Location = new System.Drawing.Point(0, 0);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(28, 13);
            this.label_Text.TabIndex = 3;
            this.label_Text.Text = "Text";
            // 
            // panel_3
            // 
            this.panel_3.Controls.Add(this.label_RemainingDays);
            this.panel_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_3.Location = new System.Drawing.Point(3, 69);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(228, 27);
            this.panel_3.TabIndex = 2;
            // 
            // label_RemainingDays
            // 
            this.label_RemainingDays.AutoSize = true;
            this.label_RemainingDays.Location = new System.Drawing.Point(72, 7);
            this.label_RemainingDays.Name = "label_RemainingDays";
            this.label_RemainingDays.Size = new System.Drawing.Size(31, 13);
            this.label_RemainingDays.TabIndex = 2;
            this.label_RemainingDays.Text = "Days";
            // 
            // panel_2
            // 
            this.panel_2.Controls.Add(this.label_Author);
            this.panel_2.Controls.Add(this.label_CreatedDate);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2.Location = new System.Drawing.Point(3, 36);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(228, 27);
            this.panel_2.TabIndex = 1;
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(14, 7);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(38, 13);
            this.label_Author.TabIndex = 0;
            this.label_Author.Text = "Author";
            // 
            // label_CreatedDate
            // 
            this.label_CreatedDate.AutoSize = true;
            this.label_CreatedDate.Location = new System.Drawing.Point(129, 7);
            this.label_CreatedDate.Name = "label_CreatedDate";
            this.label_CreatedDate.Size = new System.Drawing.Size(70, 13);
            this.label_CreatedDate.TabIndex = 1;
            this.label_CreatedDate.Text = "Created Date";
            // 
            // panel_1
            // 
            this.panel_1.Controls.Add(this.label_Title);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_1.Location = new System.Drawing.Point(3, 3);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(228, 27);
            this.panel_1.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(101, 7);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(27, 13);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Title";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // NotePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Note);
            this.Name = "NotePaper";
            this.Size = new System.Drawing.Size(240, 240);
            this.groupBox_Note.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_4.ResumeLayout(false);
            this.panel_4.PerformLayout();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Note;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_RemainingDays;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label label_CreatedDate;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
