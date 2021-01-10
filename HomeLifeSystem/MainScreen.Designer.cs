namespace HomeLifeSystem
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_FindingHome = new System.Windows.Forms.Panel();
            this.label_JoinHomeError = new System.Windows.Forms.Label();
            this.lbl_JoinHomeID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_CreateOrJoin = new System.Windows.Forms.Label();
            this.btn_CreateHome = new System.Windows.Forms.Button();
            this.btn_JoinHome = new System.Windows.Forms.Button();
            this.panel_HomeScreen = new System.Windows.Forms.Panel();
            this.panel_HomeScreenUserControl = new System.Windows.Forms.Panel();
            this.button_NotesPrivateNext = new System.Windows.Forms.Button();
            this.button_NotesPrivatePrevious = new System.Windows.Forms.Button();
            this.button_NotesHomeNext = new System.Windows.Forms.Button();
            this.button_NotesHomePrevious = new System.Windows.Forms.Button();
            this.panel_PrivateNotes = new System.Windows.Forms.Panel();
            this.panel_HomeNotes = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_PersonOptions = new System.Windows.Forms.GroupBox();
            this.btn_AddNote2 = new System.Windows.Forms.Button();
            this.btn_AddBusyTime = new System.Windows.Forms.Button();
            this.btn_ViewPrivateCalendar = new System.Windows.Forms.Button();
            this.groupBox_HomeOptions = new System.Windows.Forms.GroupBox();
            this.progressBar_UpdateHome = new System.Windows.Forms.ProgressBar();
            this.btn_ViewHousehold = new System.Windows.Forms.Button();
            this.btn_ViewRooms = new System.Windows.Forms.Button();
            this.btn_AddEvent = new System.Windows.Forms.Button();
            this.btn_AddNote = new System.Windows.Forms.Button();
            this.btn_DoHousework = new System.Windows.Forms.Button();
            this.btn_AddRequest = new System.Windows.Forms.Button();
            this.btn_ManageChores = new System.Windows.Forms.Button();
            this.btn_ViewHouseCalendar = new System.Windows.Forms.Button();
            this.timer_UpdateHome = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_UpdateHome = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_FindingHome.SuspendLayout();
            this.panel_HomeScreen.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_PersonOptions.SuspendLayout();
            this.groupBox_HomeOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_Main.IsSplitterFixed = true;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer_Main.Panel1MinSize = 32;
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer_Main.Size = new System.Drawing.Size(1440, 810);
            this.splitContainer_Main.SplitterDistance = 32;
            this.splitContainer_Main.SplitterWidth = 1;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.panel_Main, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 777);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_FindingHome);
            this.panel_Main.Controls.Add(this.panel_HomeScreen);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(219, 3);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1218, 771);
            this.panel_Main.TabIndex = 1;
            // 
            // panel_FindingHome
            // 
            this.panel_FindingHome.Controls.Add(this.label_JoinHomeError);
            this.panel_FindingHome.Controls.Add(this.lbl_JoinHomeID);
            this.panel_FindingHome.Controls.Add(this.textBox1);
            this.panel_FindingHome.Controls.Add(this.lbl_CreateOrJoin);
            this.panel_FindingHome.Controls.Add(this.btn_CreateHome);
            this.panel_FindingHome.Controls.Add(this.btn_JoinHome);
            this.panel_FindingHome.Location = new System.Drawing.Point(461, 82);
            this.panel_FindingHome.Name = "panel_FindingHome";
            this.panel_FindingHome.Size = new System.Drawing.Size(346, 230);
            this.panel_FindingHome.TabIndex = 1;
            // 
            // label_JoinHomeError
            // 
            this.label_JoinHomeError.AutoSize = true;
            this.label_JoinHomeError.ForeColor = System.Drawing.Color.Red;
            this.label_JoinHomeError.Location = new System.Drawing.Point(72, 197);
            this.label_JoinHomeError.Name = "label_JoinHomeError";
            this.label_JoinHomeError.Size = new System.Drawing.Size(35, 13);
            this.label_JoinHomeError.TabIndex = 4;
            this.label_JoinHomeError.Text = "label1";
            this.label_JoinHomeError.Visible = false;
            // 
            // lbl_JoinHomeID
            // 
            this.lbl_JoinHomeID.AutoSize = true;
            this.lbl_JoinHomeID.Location = new System.Drawing.Point(72, 127);
            this.lbl_JoinHomeID.Name = "lbl_JoinHomeID";
            this.lbl_JoinHomeID.Size = new System.Drawing.Size(49, 13);
            this.lbl_JoinHomeID.TabIndex = 3;
            this.lbl_JoinHomeID.Text = "Home ID";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(172, 122);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 19);
            this.textBox1.TabIndex = 12;
            // 
            // lbl_CreateOrJoin
            // 
            this.lbl_CreateOrJoin.AutoSize = true;
            this.lbl_CreateOrJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateOrJoin.Location = new System.Drawing.Point(154, 90);
            this.lbl_CreateOrJoin.Name = "lbl_CreateOrJoin";
            this.lbl_CreateOrJoin.Size = new System.Drawing.Size(35, 20);
            this.lbl_CreateOrJoin.TabIndex = 1;
            this.lbl_CreateOrJoin.Text = "OR";
            // 
            // btn_CreateHome
            // 
            this.btn_CreateHome.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_CreateHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateHome.Location = new System.Drawing.Point(66, 36);
            this.btn_CreateHome.Name = "btn_CreateHome";
            this.btn_CreateHome.Size = new System.Drawing.Size(215, 41);
            this.btn_CreateHome.TabIndex = 11;
            this.btn_CreateHome.Text = "Create Home";
            this.btn_CreateHome.UseVisualStyleBackColor = true;
            this.btn_CreateHome.Click += new System.EventHandler(this.btn_CreateHome_Click);
            // 
            // btn_JoinHome
            // 
            this.btn_JoinHome.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_JoinHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JoinHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JoinHome.Location = new System.Drawing.Point(66, 147);
            this.btn_JoinHome.Name = "btn_JoinHome";
            this.btn_JoinHome.Size = new System.Drawing.Size(215, 41);
            this.btn_JoinHome.TabIndex = 13;
            this.btn_JoinHome.Text = "Join Home";
            this.btn_JoinHome.UseVisualStyleBackColor = true;
            this.btn_JoinHome.Click += new System.EventHandler(this.btn_JoinHome_Click);
            // 
            // panel_HomeScreen
            // 
            this.panel_HomeScreen.Controls.Add(this.panel_HomeScreenUserControl);
            this.panel_HomeScreen.Controls.Add(this.button_NotesPrivateNext);
            this.panel_HomeScreen.Controls.Add(this.button_NotesPrivatePrevious);
            this.panel_HomeScreen.Controls.Add(this.button_NotesHomeNext);
            this.panel_HomeScreen.Controls.Add(this.button_NotesHomePrevious);
            this.panel_HomeScreen.Controls.Add(this.panel_PrivateNotes);
            this.panel_HomeScreen.Controls.Add(this.panel_HomeNotes);
            this.panel_HomeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_HomeScreen.Location = new System.Drawing.Point(0, 0);
            this.panel_HomeScreen.Name = "panel_HomeScreen";
            this.panel_HomeScreen.Size = new System.Drawing.Size(1218, 771);
            this.panel_HomeScreen.TabIndex = 3;
            this.panel_HomeScreen.Visible = false;
            // 
            // panel_HomeScreenUserControl
            // 
            this.panel_HomeScreenUserControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_HomeScreenUserControl.Location = new System.Drawing.Point(0, 0);
            this.panel_HomeScreenUserControl.Name = "panel_HomeScreenUserControl";
            this.panel_HomeScreenUserControl.Size = new System.Drawing.Size(949, 771);
            this.panel_HomeScreenUserControl.TabIndex = 6;
            // 
            // button_NotesPrivateNext
            // 
            this.button_NotesPrivateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NotesPrivateNext.FlatAppearance.BorderSize = 0;
            this.button_NotesPrivateNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NotesPrivateNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NotesPrivateNext.Image = ((System.Drawing.Image)(resources.GetObject("button_NotesPrivateNext.Image")));
            this.button_NotesPrivateNext.Location = new System.Drawing.Point(1134, 457);
            this.button_NotesPrivateNext.Name = "button_NotesPrivateNext";
            this.button_NotesPrivateNext.Size = new System.Drawing.Size(25, 25);
            this.button_NotesPrivateNext.TabIndex = 4;
            this.button_NotesPrivateNext.UseVisualStyleBackColor = true;
            this.button_NotesPrivateNext.Click += new System.EventHandler(this.button_NotesPrivateNext_Click);
            // 
            // button_NotesPrivatePrevious
            // 
            this.button_NotesPrivatePrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NotesPrivatePrevious.FlatAppearance.BorderSize = 0;
            this.button_NotesPrivatePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NotesPrivatePrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NotesPrivatePrevious.Image = ((System.Drawing.Image)(resources.GetObject("button_NotesPrivatePrevious.Image")));
            this.button_NotesPrivatePrevious.Location = new System.Drawing.Point(1003, 457);
            this.button_NotesPrivatePrevious.Name = "button_NotesPrivatePrevious";
            this.button_NotesPrivatePrevious.Size = new System.Drawing.Size(25, 25);
            this.button_NotesPrivatePrevious.TabIndex = 5;
            this.button_NotesPrivatePrevious.UseVisualStyleBackColor = true;
            this.button_NotesPrivatePrevious.Click += new System.EventHandler(this.button_NotesPrivatePrevious_Click);
            // 
            // button_NotesHomeNext
            // 
            this.button_NotesHomeNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NotesHomeNext.FlatAppearance.BorderSize = 0;
            this.button_NotesHomeNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NotesHomeNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NotesHomeNext.Image = ((System.Drawing.Image)(resources.GetObject("button_NotesHomeNext.Image")));
            this.button_NotesHomeNext.Location = new System.Drawing.Point(1134, 269);
            this.button_NotesHomeNext.Name = "button_NotesHomeNext";
            this.button_NotesHomeNext.Size = new System.Drawing.Size(25, 25);
            this.button_NotesHomeNext.TabIndex = 0;
            this.button_NotesHomeNext.UseVisualStyleBackColor = true;
            this.button_NotesHomeNext.Click += new System.EventHandler(this.button_NotesHomeNext_Click);
            // 
            // button_NotesHomePrevious
            // 
            this.button_NotesHomePrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NotesHomePrevious.FlatAppearance.BorderSize = 0;
            this.button_NotesHomePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NotesHomePrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NotesHomePrevious.Image = ((System.Drawing.Image)(resources.GetObject("button_NotesHomePrevious.Image")));
            this.button_NotesHomePrevious.Location = new System.Drawing.Point(1003, 269);
            this.button_NotesHomePrevious.Name = "button_NotesHomePrevious";
            this.button_NotesHomePrevious.Size = new System.Drawing.Size(25, 25);
            this.button_NotesHomePrevious.TabIndex = 1;
            this.button_NotesHomePrevious.UseVisualStyleBackColor = true;
            this.button_NotesHomePrevious.Click += new System.EventHandler(this.button_NotesHomePrevious_Click);
            // 
            // panel_PrivateNotes
            // 
            this.panel_PrivateNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PrivateNotes.Location = new System.Drawing.Point(955, 488);
            this.panel_PrivateNotes.Name = "panel_PrivateNotes";
            this.panel_PrivateNotes.Size = new System.Drawing.Size(260, 280);
            this.panel_PrivateNotes.TabIndex = 3;
            this.panel_PrivateNotes.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_NotesControlChanged);
            this.panel_PrivateNotes.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_NotesControlChanged);
            // 
            // panel_HomeNotes
            // 
            this.panel_HomeNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_HomeNotes.Location = new System.Drawing.Point(955, 3);
            this.panel_HomeNotes.Name = "panel_HomeNotes";
            this.panel_HomeNotes.Size = new System.Drawing.Size(260, 260);
            this.panel_HomeNotes.TabIndex = 2;
            this.panel_HomeNotes.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_NotesControlChanged);
            this.panel_HomeNotes.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_NotesControlChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox_PersonOptions, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_HomeOptions, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 771);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox_PersonOptions
            // 
            this.groupBox_PersonOptions.Controls.Add(this.btn_AddNote2);
            this.groupBox_PersonOptions.Controls.Add(this.btn_AddBusyTime);
            this.groupBox_PersonOptions.Controls.Add(this.btn_ViewPrivateCalendar);
            this.groupBox_PersonOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PersonOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PersonOptions.Location = new System.Drawing.Point(3, 465);
            this.groupBox_PersonOptions.Name = "groupBox_PersonOptions";
            this.groupBox_PersonOptions.Size = new System.Drawing.Size(204, 303);
            this.groupBox_PersonOptions.TabIndex = 2;
            this.groupBox_PersonOptions.TabStop = false;
            this.groupBox_PersonOptions.Text = "Person";
            // 
            // btn_AddNote2
            // 
            this.btn_AddNote2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNote2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_AddNote2.FlatAppearance.BorderSize = 0;
            this.btn_AddNote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNote2.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNote2.Image")));
            this.btn_AddNote2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddNote2.Location = new System.Drawing.Point(0, 143);
            this.btn_AddNote2.Name = "btn_AddNote2";
            this.btn_AddNote2.Size = new System.Drawing.Size(204, 30);
            this.btn_AddNote2.TabIndex = 10;
            this.btn_AddNote2.Text = "Add Private Note";
            this.btn_AddNote2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddNote2.UseVisualStyleBackColor = true;
            this.btn_AddNote2.Click += new System.EventHandler(this.btn_AddPrivateNote_Click);
            // 
            // btn_AddBusyTime
            // 
            this.btn_AddBusyTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddBusyTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_AddBusyTime.FlatAppearance.BorderSize = 0;
            this.btn_AddBusyTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddBusyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBusyTime.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddBusyTime.Image")));
            this.btn_AddBusyTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddBusyTime.Location = new System.Drawing.Point(0, 83);
            this.btn_AddBusyTime.Name = "btn_AddBusyTime";
            this.btn_AddBusyTime.Size = new System.Drawing.Size(204, 30);
            this.btn_AddBusyTime.TabIndex = 9;
            this.btn_AddBusyTime.Text = "Add Busy Time";
            this.btn_AddBusyTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddBusyTime.UseVisualStyleBackColor = true;
            this.btn_AddBusyTime.Click += new System.EventHandler(this.btn_AddBusyTime_Click);
            // 
            // btn_ViewPrivateCalendar
            // 
            this.btn_ViewPrivateCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ViewPrivateCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_ViewPrivateCalendar.FlatAppearance.BorderSize = 0;
            this.btn_ViewPrivateCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewPrivateCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewPrivateCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewPrivateCalendar.Image")));
            this.btn_ViewPrivateCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewPrivateCalendar.Location = new System.Drawing.Point(0, 23);
            this.btn_ViewPrivateCalendar.Name = "btn_ViewPrivateCalendar";
            this.btn_ViewPrivateCalendar.Size = new System.Drawing.Size(204, 30);
            this.btn_ViewPrivateCalendar.TabIndex = 8;
            this.btn_ViewPrivateCalendar.Text = "View Private Calendar";
            this.btn_ViewPrivateCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ViewPrivateCalendar.UseVisualStyleBackColor = true;
            this.btn_ViewPrivateCalendar.Click += new System.EventHandler(this.btn_ViewPrivateCalendar_Click);
            // 
            // groupBox_HomeOptions
            // 
            this.groupBox_HomeOptions.Controls.Add(this.progressBar_UpdateHome);
            this.groupBox_HomeOptions.Controls.Add(this.btn_ViewHousehold);
            this.groupBox_HomeOptions.Controls.Add(this.btn_ViewRooms);
            this.groupBox_HomeOptions.Controls.Add(this.btn_AddEvent);
            this.groupBox_HomeOptions.Controls.Add(this.btn_AddNote);
            this.groupBox_HomeOptions.Controls.Add(this.btn_DoHousework);
            this.groupBox_HomeOptions.Controls.Add(this.btn_AddRequest);
            this.groupBox_HomeOptions.Controls.Add(this.btn_ManageChores);
            this.groupBox_HomeOptions.Controls.Add(this.btn_ViewHouseCalendar);
            this.groupBox_HomeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_HomeOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_HomeOptions.Location = new System.Drawing.Point(3, 3);
            this.groupBox_HomeOptions.Name = "groupBox_HomeOptions";
            this.groupBox_HomeOptions.Size = new System.Drawing.Size(204, 456);
            this.groupBox_HomeOptions.TabIndex = 2;
            this.groupBox_HomeOptions.TabStop = false;
            this.groupBox_HomeOptions.Text = "Home";
            this.groupBox_HomeOptions.Visible = false;
            // 
            // progressBar_UpdateHome
            // 
            this.progressBar_UpdateHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_UpdateHome.BackColor = System.Drawing.Color.Black;
            this.progressBar_UpdateHome.Location = new System.Drawing.Point(174, 0);
            this.progressBar_UpdateHome.MarqueeAnimationSpeed = 5;
            this.progressBar_UpdateHome.Name = "progressBar_UpdateHome";
            this.progressBar_UpdateHome.Size = new System.Drawing.Size(24, 12);
            this.progressBar_UpdateHome.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_UpdateHome.TabIndex = 0;
            // 
            // btn_ViewHousehold
            // 
            this.btn_ViewHousehold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ViewHousehold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_ViewHousehold.FlatAppearance.BorderSize = 0;
            this.btn_ViewHousehold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewHousehold.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewHousehold.Image")));
            this.btn_ViewHousehold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewHousehold.Location = new System.Drawing.Point(0, 395);
            this.btn_ViewHousehold.Name = "btn_ViewHousehold";
            this.btn_ViewHousehold.Size = new System.Drawing.Size(204, 30);
            this.btn_ViewHousehold.TabIndex = 7;
            this.btn_ViewHousehold.Text = "View Household";
            this.btn_ViewHousehold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ViewHousehold.UseVisualStyleBackColor = true;
            this.btn_ViewHousehold.Click += new System.EventHandler(this.btn_ViewHousehold_Click);
            // 
            // btn_ViewRooms
            // 
            this.btn_ViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ViewRooms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_ViewRooms.FlatAppearance.BorderSize = 0;
            this.btn_ViewRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewRooms.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewRooms.Image")));
            this.btn_ViewRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewRooms.Location = new System.Drawing.Point(1, 343);
            this.btn_ViewRooms.Name = "btn_ViewRooms";
            this.btn_ViewRooms.Size = new System.Drawing.Size(204, 30);
            this.btn_ViewRooms.TabIndex = 6;
            this.btn_ViewRooms.Text = "View Rooms";
            this.btn_ViewRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ViewRooms.UseVisualStyleBackColor = true;
            this.btn_ViewRooms.Click += new System.EventHandler(this.btn_ViewRooms_Click);
            // 
            // btn_AddEvent
            // 
            this.btn_AddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddEvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_AddEvent.FlatAppearance.BorderSize = 0;
            this.btn_AddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEvent.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddEvent.Image")));
            this.btn_AddEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEvent.Location = new System.Drawing.Point(1, 291);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Size = new System.Drawing.Size(204, 30);
            this.btn_AddEvent.TabIndex = 5;
            this.btn_AddEvent.Text = "Add Event";
            this.btn_AddEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddEvent.UseVisualStyleBackColor = true;
            this.btn_AddEvent.Click += new System.EventHandler(this.btn_AddEvent_Click);
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_AddNote.FlatAppearance.BorderSize = 0;
            this.btn_AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNote.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNote.Image")));
            this.btn_AddNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddNote.Location = new System.Drawing.Point(1, 239);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(204, 30);
            this.btn_AddNote.TabIndex = 4;
            this.btn_AddNote.Text = "Add Note";
            this.btn_AddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddNote.UseVisualStyleBackColor = true;
            this.btn_AddNote.Click += new System.EventHandler(this.btn_AddNote_Click);
            // 
            // btn_DoHousework
            // 
            this.btn_DoHousework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DoHousework.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_DoHousework.FlatAppearance.BorderSize = 0;
            this.btn_DoHousework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoHousework.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoHousework.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoHousework.Image")));
            this.btn_DoHousework.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoHousework.Location = new System.Drawing.Point(1, 187);
            this.btn_DoHousework.Name = "btn_DoHousework";
            this.btn_DoHousework.Size = new System.Drawing.Size(204, 30);
            this.btn_DoHousework.TabIndex = 3;
            this.btn_DoHousework.Text = "Do Housework";
            this.btn_DoHousework.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DoHousework.UseVisualStyleBackColor = true;
            this.btn_DoHousework.Click += new System.EventHandler(this.btn_DoHousework_Click);
            // 
            // btn_AddRequest
            // 
            this.btn_AddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_AddRequest.FlatAppearance.BorderSize = 0;
            this.btn_AddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRequest.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddRequest.Image")));
            this.btn_AddRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddRequest.Location = new System.Drawing.Point(1, 135);
            this.btn_AddRequest.Name = "btn_AddRequest";
            this.btn_AddRequest.Size = new System.Drawing.Size(204, 30);
            this.btn_AddRequest.TabIndex = 2;
            this.btn_AddRequest.Text = "Add Request";
            this.btn_AddRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddRequest.UseVisualStyleBackColor = true;
            this.btn_AddRequest.Click += new System.EventHandler(this.btn_AddRequest_Click);
            // 
            // btn_ManageChores
            // 
            this.btn_ManageChores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ManageChores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_ManageChores.FlatAppearance.BorderSize = 0;
            this.btn_ManageChores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ManageChores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageChores.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManageChores.Image")));
            this.btn_ManageChores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ManageChores.Location = new System.Drawing.Point(1, 83);
            this.btn_ManageChores.Name = "btn_ManageChores";
            this.btn_ManageChores.Size = new System.Drawing.Size(204, 30);
            this.btn_ManageChores.TabIndex = 1;
            this.btn_ManageChores.Text = "Manage Chores";
            this.btn_ManageChores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ManageChores.UseVisualStyleBackColor = true;
            this.btn_ManageChores.Click += new System.EventHandler(this.btn_ManageChores_Click);
            // 
            // btn_ViewHouseCalendar
            // 
            this.btn_ViewHouseCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ViewHouseCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.btn_ViewHouseCalendar.FlatAppearance.BorderSize = 0;
            this.btn_ViewHouseCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewHouseCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewHouseCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewHouseCalendar.Image")));
            this.btn_ViewHouseCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewHouseCalendar.Location = new System.Drawing.Point(1, 31);
            this.btn_ViewHouseCalendar.Name = "btn_ViewHouseCalendar";
            this.btn_ViewHouseCalendar.Size = new System.Drawing.Size(204, 30);
            this.btn_ViewHouseCalendar.TabIndex = 0;
            this.btn_ViewHouseCalendar.Text = "View House Calendar";
            this.btn_ViewHouseCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ViewHouseCalendar.UseVisualStyleBackColor = true;
            this.btn_ViewHouseCalendar.Click += new System.EventHandler(this.btn_ViewHouseCalendar_Click);
            // 
            // timer_UpdateHome
            // 
            this.timer_UpdateHome.Enabled = true;
            this.timer_UpdateHome.Interval = 10000;
            this.timer_UpdateHome.Tick += new System.EventHandler(this.timer_UpdateHome_Tick);
            // 
            // backgroundWorker_UpdateHome
            // 
            this.backgroundWorker_UpdateHome.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_UpdateHome_DoWork);
            this.backgroundWorker_UpdateHome.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_UpdateHome_RunWorkerCompleted);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.splitContainer_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Shown += new System.EventHandler(this.MainSreen_Shown);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel_FindingHome.ResumeLayout(false);
            this.panel_FindingHome.PerformLayout();
            this.panel_HomeScreen.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox_PersonOptions.ResumeLayout(false);
            this.groupBox_HomeOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_JoinHome;
        private System.Windows.Forms.Button btn_CreateHome;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_FindingHome;
        private System.Windows.Forms.GroupBox groupBox_PersonOptions;
        private System.Windows.Forms.Button btn_AddNote2;
        private System.Windows.Forms.Button btn_ViewPrivateCalendar;
        private System.Windows.Forms.GroupBox groupBox_HomeOptions;
        private System.Windows.Forms.Button btn_ViewHousehold;
        private System.Windows.Forms.Button btn_ViewRooms;
        private System.Windows.Forms.Button btn_AddEvent;
        private System.Windows.Forms.Button btn_AddNote;
        private System.Windows.Forms.Button btn_DoHousework;
        private System.Windows.Forms.Button btn_AddRequest;
        private System.Windows.Forms.Button btn_ManageChores;
        private System.Windows.Forms.Button btn_ViewHouseCalendar;
        private System.Windows.Forms.Button btn_AddBusyTime;
        private System.Windows.Forms.Label lbl_JoinHomeID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_CreateOrJoin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel_HomeNotes;
        private System.Windows.Forms.Panel panel_HomeScreen;
        private System.Windows.Forms.Panel panel_PrivateNotes;
        private System.Windows.Forms.Button button_NotesPrivateNext;
        private System.Windows.Forms.Button button_NotesPrivatePrevious;
        private System.Windows.Forms.Button button_NotesHomeNext;
        private System.Windows.Forms.Button button_NotesHomePrevious;
        private System.Windows.Forms.Label label_JoinHomeError;
        private System.Windows.Forms.Panel panel_HomeScreenUserControl;
        private System.Windows.Forms.Timer timer_UpdateHome;
        private System.ComponentModel.BackgroundWorker backgroundWorker_UpdateHome;
        private System.Windows.Forms.ProgressBar progressBar_UpdateHome;
    }
}