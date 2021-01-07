namespace HomeLifeSystem
{
    partial class CalendarFilterPopUp
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
            this.checkBox_ShowAll = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowBusyTimes = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowEvents = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowHouseworks = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowRequests = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowFreeTimes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_ShowAll
            // 
            this.checkBox_ShowAll.AutoSize = true;
            this.checkBox_ShowAll.Location = new System.Drawing.Point(13, 18);
            this.checkBox_ShowAll.Name = "checkBox_ShowAll";
            this.checkBox_ShowAll.Size = new System.Drawing.Size(67, 17);
            this.checkBox_ShowAll.TabIndex = 0;
            this.checkBox_ShowAll.Text = "Show All";
            this.checkBox_ShowAll.UseVisualStyleBackColor = true;
            this.checkBox_ShowAll.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_ShowBusyTimes
            // 
            this.checkBox_ShowBusyTimes.AutoSize = true;
            this.checkBox_ShowBusyTimes.Location = new System.Drawing.Point(13, 41);
            this.checkBox_ShowBusyTimes.Name = "checkBox_ShowBusyTimes";
            this.checkBox_ShowBusyTimes.Size = new System.Drawing.Size(110, 17);
            this.checkBox_ShowBusyTimes.TabIndex = 1;
            this.checkBox_ShowBusyTimes.Text = "Show Busy Times";
            this.checkBox_ShowBusyTimes.UseVisualStyleBackColor = true;
            this.checkBox_ShowBusyTimes.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_ShowEvents
            // 
            this.checkBox_ShowEvents.AutoSize = true;
            this.checkBox_ShowEvents.Location = new System.Drawing.Point(13, 64);
            this.checkBox_ShowEvents.Name = "checkBox_ShowEvents";
            this.checkBox_ShowEvents.Size = new System.Drawing.Size(89, 17);
            this.checkBox_ShowEvents.TabIndex = 2;
            this.checkBox_ShowEvents.Text = "Show Events";
            this.checkBox_ShowEvents.UseVisualStyleBackColor = true;
            this.checkBox_ShowEvents.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_ShowHouseworks
            // 
            this.checkBox_ShowHouseworks.AutoSize = true;
            this.checkBox_ShowHouseworks.Location = new System.Drawing.Point(13, 87);
            this.checkBox_ShowHouseworks.Name = "checkBox_ShowHouseworks";
            this.checkBox_ShowHouseworks.Size = new System.Drawing.Size(115, 17);
            this.checkBox_ShowHouseworks.TabIndex = 3;
            this.checkBox_ShowHouseworks.Text = "Show Houseworks";
            this.checkBox_ShowHouseworks.UseVisualStyleBackColor = true;
            this.checkBox_ShowHouseworks.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_ShowRequests
            // 
            this.checkBox_ShowRequests.AutoSize = true;
            this.checkBox_ShowRequests.Location = new System.Drawing.Point(13, 110);
            this.checkBox_ShowRequests.Name = "checkBox_ShowRequests";
            this.checkBox_ShowRequests.Size = new System.Drawing.Size(101, 17);
            this.checkBox_ShowRequests.TabIndex = 4;
            this.checkBox_ShowRequests.Text = "Show Requests";
            this.checkBox_ShowRequests.UseVisualStyleBackColor = true;
            this.checkBox_ShowRequests.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_ShowFreeTimes
            // 
            this.checkBox_ShowFreeTimes.AutoSize = true;
            this.checkBox_ShowFreeTimes.Location = new System.Drawing.Point(13, 180);
            this.checkBox_ShowFreeTimes.Name = "checkBox_ShowFreeTimes";
            this.checkBox_ShowFreeTimes.Size = new System.Drawing.Size(108, 17);
            this.checkBox_ShowFreeTimes.TabIndex = 5;
            this.checkBox_ShowFreeTimes.Text = "Show Free Times";
            this.checkBox_ShowFreeTimes.UseVisualStyleBackColor = true;
            this.checkBox_ShowFreeTimes.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // CalendarFilterPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_ShowFreeTimes);
            this.Controls.Add(this.checkBox_ShowRequests);
            this.Controls.Add(this.checkBox_ShowHouseworks);
            this.Controls.Add(this.checkBox_ShowEvents);
            this.Controls.Add(this.checkBox_ShowBusyTimes);
            this.Controls.Add(this.checkBox_ShowAll);
            this.Name = "CalendarFilterPopUp";
            this.Size = new System.Drawing.Size(150, 200);
            this.Leave += new System.EventHandler(this.CalendarFilterPopUp_Leave);
            this.MouseLeave += new System.EventHandler(this.CalendarFilterPopUp_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ShowAll;
        private System.Windows.Forms.CheckBox checkBox_ShowBusyTimes;
        private System.Windows.Forms.CheckBox checkBox_ShowEvents;
        private System.Windows.Forms.CheckBox checkBox_ShowHouseworks;
        private System.Windows.Forms.CheckBox checkBox_ShowRequests;
        private System.Windows.Forms.CheckBox checkBox_ShowFreeTimes;
    }
}
