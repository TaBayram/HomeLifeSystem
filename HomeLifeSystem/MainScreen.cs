using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HomeLifeSystem
{
    public partial class MainScreen : Form
    {
        private Person user;
        public Home home;
 
        ViewCalendar viewCalendar;
        ViewCalendar viewPrivateCalendar;
        ViewRoomList viewRoomList;
        ViewChores viewChores;
        CreateBill createBill;
        CreateNote createNote;
        CreateNote creatPrivateNote;
        CreateHousework createHousework;
        CreateBusyTime createBusyTime;
        CreateEvent createEvent;
        CreateRequest createRequest;

        PeopleContainer peopleContainer;

        List<NotePaper> notePapersHome = new List<NotePaper>(); 
        NotePaper notePaperHomeCurrent;

        List<NotePaper> notePapersPrivate= new List<NotePaper>(); 
        NotePaper notePaperPrivateCurrent;


        UserControl userControlCurrent;
        Button buttonCurrent;
        Panel homeScreen;

        Header header;


        public Person User { get => user; set => user = value; }

        public MainScreen(Person user)
        {
            InitializeComponent();
            this.User = user;

            Coloring();

            //Call Header
            header = new Header(this);
            this.Controls.Add(header);
            header.Parent = splitContainer_Main.Panel1;
            header.Show();
            header.ChangeName(user.Nickname);

            header.menuStrip_Home.Enabled = false;

            groupBox_HomeOptions.Visible = false;

            homeScreen = panel_HomeScreen;

            if (user.SignIn(this)) 
            { 
                ShowHomeSidebar(home); 
                LoadMain();
            }
            

        }

        private void MainSreen_Shown(object sender, EventArgs e)
        {
            if (user.Birthday.ToString("dd/MM") == DateTime.Now.ToString("dd/MM"))
            {
                string[] birthdaycheck = Database.ReadConfigParameter("birthday").Split(' ');
                bool canCongratulate = true;
                if (birthdaycheck[1] == DateTime.Now.ToString("yyyy")){
                    if (birthdaycheck[0] == "1")
                    {
                        canCongratulate = false;
                    }
                }
                if (canCongratulate)
                {
                    BirthdayNotifier birthdayNotifier = new BirthdayNotifier(user);
                    birthdayNotifier.BringToFront();
                    birthdayNotifier.ShowDialog();
                    Database.WriteConfigParameter("birthday", "1 " + DateTime.Now.ToString("yyyy"));

                }
                
            }

        }

        private void Coloring()
        {
            
            this.BackColor = GlobalColorConstants.mainBackgroundColor;
            this.ForeColor = GlobalColorConstants.mainForeColor;

            panel_HomeNotes.BackColor = GlobalColorConstants.noteHolderBackgroundColor;
            panel_PrivateNotes.BackColor = GlobalColorConstants.noteHolderBackgroundColor;
            textBox1.BackColor = GlobalColorConstants.mainTextBoxInnerColor;

            btn_CreateHome.BackColor = GlobalColorConstants.mainButtonColor;
            btn_JoinHome.BackColor = GlobalColorConstants.mainButtonColor;


            btn_ViewHousehold.BackColor = GlobalColorConstants.mainButtonColor;
            btn_ViewRooms.BackColor = GlobalColorConstants.mainButtonColor;
            btn_ViewHouseCalendar.BackColor = GlobalColorConstants.mainButtonColor;
            btn_ManageChores.BackColor = GlobalColorConstants.mainButtonColor;
            btn_AddRequest.BackColor = GlobalColorConstants.mainButtonColor;
            btn_DoHousework.BackColor = GlobalColorConstants.mainButtonColor;
            btn_AddNote.BackColor = GlobalColorConstants.mainButtonColor;
            btn_AddEvent.BackColor = GlobalColorConstants.mainButtonColor;

            btn_ViewHouseCalendar.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_ViewHouseCalendar.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_ViewHousehold.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_ViewHousehold.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_ViewRooms.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_ViewRooms.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_ManageChores.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_ManageChores.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_AddRequest.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_AddRequest.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_DoHousework.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_DoHousework.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_AddEvent.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_AddEvent.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_AddNote.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_AddNote.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_AddBusyTime.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_AddBusyTime.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            btn_ViewPrivateCalendar.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_ViewPrivateCalendar.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;


            btn_AddNote2.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_AddNote2.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;



            btn_AddBusyTime.BackColor = GlobalColorConstants.mainButtonColor;
            btn_ViewPrivateCalendar.BackColor = GlobalColorConstants.mainButtonColor;
            btn_AddNote2.BackColor = GlobalColorConstants.mainButtonColor;
        }

        private void LoadMain()
        {
            if(viewCalendar != null)
                viewCalendar.CalendarEvent = home.Calendar;
            if (viewPrivateCalendar != null)
                viewPrivateCalendar.CalendarEvent = user.Calendar;
            LoadNotes();
        }

        private void LoadNotes()
        {
            home.Notes = home.Notes.OrderBy(o => o.CreatedDate).ToList();
            foreach (Note note in home.Notes)
            {
                if (note.PersonID == user.ID)
                {
                    note.AuthorName = "You";
                }

                bool alreadyExists = false;
                for(int i = 0; i < panel_HomeNotes.Controls.Count; i++)
                {
                    if (panel_HomeNotes.Controls[i].GetType() != typeof(NotePaper)) continue;
                    if (((NotePaper)panel_HomeNotes.Controls[i]).Note.ID == note.ID)
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                if (alreadyExists) continue;

                NotePaper notePaper = new NotePaper(note);

                if (note.AuthorName == "You")
                {
                    notePaper.EnableMenuStrip();
                }
                CreateANote(notePaper, false);
            }

            user.Notes = user.Notes.OrderBy(o => o.CreatedDate).ToList();
            foreach (Note note in user.Notes)
            {
                note.AuthorName = "You";
                bool alreadyExists = false;
                for (int i = 0; i < panel_PrivateNotes.Controls.Count; i++)
                {
                    if (panel_PrivateNotes.Controls[i].GetType() != typeof(NotePaper)) continue;
                    if (((NotePaper)panel_PrivateNotes.Controls[i]).Note.ID == note.ID)
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                if (alreadyExists) continue;

                NotePaper notePaper = new NotePaper(note);
                notePaper.EnableMenuStrip();
                CreateANote(notePaper, true);
            }

            if (panel_HomeNotes.Controls.Count < 1)
            {
                ShowHomeNoteButtons(false);
            }
            if (panel_PrivateNotes.Controls.Count < 1)
            {
                ShowPrivateNoteButtons(false);
            }
        }


        private void RefreshNoteExpirings()
        {
            foreach(Control control in panel_HomeNotes.Controls)
            {
                if(control.GetType() == typeof(NotePaper)) ((NotePaper)control).RefreshExpire();
            }
            foreach (Control control in panel_PrivateNotes.Controls)
            {
                if (control.GetType() == typeof(NotePaper)) ((NotePaper)control).RefreshExpire();
            }
        }

        private void btn_CreateHome_Click(object sender, EventArgs e)
        {
            HideFindingHome(true);
            CreateHome createHome = new CreateHome(this, User);
            createHome.Parent = panel_Main;
            HideOtherShowThis(createHome);


        }

        private void btn_JoinHome_Click(object sender, EventArgs e)
        {
            label_JoinHomeError.Hide();
            label_JoinHomeError.Text = "";
            
            if(textBox1.Text == "")
            {
                label_JoinHomeError.Show();
                label_JoinHomeError.Text = "ID can't be empty!";
                return;
            }
            bool isNumeric = int.TryParse(textBox1.Text,out int a);
            if (!isNumeric)
            {
                label_JoinHomeError.Show();
                label_JoinHomeError.Text = "ID can't have non-numeric characters!";
                return;
            }

            int id = int.Parse(textBox1.Text);
            if(!Database.DoesHomeExist(id))
            {
                label_JoinHomeError.Show();
                label_JoinHomeError.Text = "Home with "+textBox1.Text+" ID doesn't exist!";
                
            }
            else
            {
                user.JoinHome(id);
                ShowHomeSidebar(Database.GetHomeByID(id));
                HideFindingHome(true);
                HideThisShowMainScreen(null);

            }
        }

        private void btn_ViewRooms_Click(object sender, EventArgs e)
        {
            if (viewRoomList == null)
            {
                viewRoomList = new ViewRoomList(this);
                viewRoomList.Parent = panel_Main;
                HideOtherShowThis(viewRoomList);
                ButtonColorShow((Button)sender);
            }
            else if (!viewRoomList.Visible)
            {
                HideOtherShowThis(viewRoomList);
                ButtonColorShow((Button)sender);
            }
            else
            {
                HideThisShowMainScreen(viewRoomList);
                ButtonColorHide((Button)sender);

            }
            
        }

        private void btn_ViewPrivateCalendar_Click(object sender, EventArgs e)
        {
            if (viewPrivateCalendar == null)
            {
                user.Calendar.Occasions.Clear();
                user.Calendar.Occasions.AddRange(GetMyOccasionsFromHome());
                viewPrivateCalendar = new ViewCalendar(user.Calendar,User,home);
                viewPrivateCalendar.Parent = panel_Main;
                HideOtherShowThis(viewPrivateCalendar);
                ButtonColorShow((Button)sender);
            }
            else if (!viewPrivateCalendar.Visible)
            {
                user.Calendar.Occasions.Clear();
                user.Calendar.Occasions.AddRange(GetMyOccasionsFromHome());
                HideOtherShowThis(viewPrivateCalendar);
                ButtonColorShow((Button)sender);
            }
            else
            {
                HideThisShowMainScreen(viewPrivateCalendar);
                ButtonColorHide((Button)sender);
            }
        }

        private List<List<Object>> GetMyOccasionsFromHome()
        {
            List<List<object>> list = new List<List<object>>();
            if(home != null && home.Calendar != null)
            {
                foreach (List<Object> occasion in home.Calendar.Occasions)
                {
                    var person = occasion[3] as Person;
                    if(person.ID == user.ID)
                    {
                        list.Add(occasion);
                        continue;
                    }


                }

            }
            return list;
        }


        private void btn_ViewHouseCalendar_Click(object sender, EventArgs e)
        {
            
            if (viewCalendar == null)
            {
                viewCalendar = new ViewCalendar(home.Calendar,User, home);
                viewCalendar.Parent = panel_Main;
                HideOtherShowThis(viewCalendar);
                ButtonColorShow((Button)sender);
            }
            else if (!viewCalendar.Visible)
            {
                HideOtherShowThis(viewCalendar);
                ButtonColorShow((Button)sender);
            }
            else
            {
                HideThisShowMainScreen(viewCalendar);
                ButtonColorHide((Button)sender);
            }
          
        }

        private void btn_ManageChores_Click(object sender, EventArgs e)
        {
            if (viewChores == null)
            {
                viewChores = new ViewChores(this);
                viewChores.Parent = panel_Main;
                HideOtherShowThis(viewChores);
                ButtonColorShow((Button)sender);
            }
            else if (!viewChores.Visible)
            {
                viewChores.Show();
                HideOtherShowThis(viewChores);
                ButtonColorShow((Button)sender);
            }
            else
            {
                HideThisShowMainScreen(viewChores);
                ButtonColorHide((Button)sender);
            }
        }

        private void btn_LeaveHome_Click(object sender, EventArgs e)
        {
            showLeaveHome();
            header.menuStrip_Home.Enabled = false;
        }

        private void btn_AddNote_Click(object sender, EventArgs e)
        {
            if (createNote == null)
            {
                createNote = new CreateNote(this);
                createNote.Parent = panel_HomeNotes;
                createNote.Show();
                createNote.BringToFront();
                createNote.Location = new Point(panel_HomeNotes.Width / 2 - createNote.Size.Width / 2, panel_HomeNotes.ClientSize.Height / 2 - createNote.Size.Height / 2);
                HideThisShowMainScreen(userControlCurrent);
                ButtonColorShow((Button)sender);
            }
            else if (!createNote.Visible)
            {
                createNote.Show();
                createNote.BringToFront();
                HideThisShowMainScreen(userControlCurrent);
                ButtonColorShow((Button)sender);
            }
            else
            {
                createNote.Hide();
                ButtonColorHide((Button)sender);
            }
            
            
            
        }

        public void CreateANote(NotePaper notePaper, bool isItPrivate)
        {
            Panel panel = panel_HomeNotes;
            if (isItPrivate) panel = panel_PrivateNotes;
            Random random = new Random();
            int offsetX = random.Next(-6,6);
            int offsetY = random.Next(-6,6);
            notePaper.Parent = panel;
            notePaper.Location = new Point(panel.Width / 2 - notePaper.Size.Width / 2 + offsetX, panel.ClientSize.Height / 2 - notePaper.Size.Height / 2 + offsetY);
            notePaper.Show();
            notePaper.BringToFront();
            if (isItPrivate)
            {
                notePapersPrivate.Add(notePaper);
                notePaperPrivateCurrent = notePaper;
            }
            else
            {
                notePapersHome.Add(notePaper);
                notePaperHomeCurrent = notePaper;
            }
        }

        private void btn_DoHousework_Click(object sender, EventArgs e)
        {
            if (createHousework == null)
            {
                createHousework = new CreateHousework(this);
                createHousework.Parent = panel_Main;
                HideOtherShowThis(createHousework);
                ButtonColorShow((Button)sender);
            }
            else if (!createHousework.Visible)
            {
                createHousework.FillListBoxes();
                HideOtherShowThis(createHousework);
                ButtonColorShow((Button)sender);
            }
            else
            {
                HideThisShowMainScreen(createHousework);
                ButtonColorHide((Button)sender);
            }
        }

        private void btn_AddPrivateNote_Click(object sender, EventArgs e)
        {
            if (creatPrivateNote == null)
            {
                creatPrivateNote = new CreateNote(this);
                creatPrivateNote.Parent = panel_PrivateNotes;
                creatPrivateNote.Show();
                creatPrivateNote.BringToFront();
                creatPrivateNote.Location = new Point(panel_PrivateNotes.Width / 2 - creatPrivateNote.Size.Width / 2, panel_PrivateNotes.ClientSize.Height / 2 - creatPrivateNote.Size.Height / 2);
                HideThisShowMainScreen(userControlCurrent);
                ButtonColorShow((Button)sender);

            }
            else if (!creatPrivateNote.Visible)
            {
                creatPrivateNote.Show();
                creatPrivateNote.BringToFront();
                HideThisShowMainScreen(userControlCurrent);
                ButtonColorShow((Button)sender);
            }
            else
            {
                creatPrivateNote.Hide();
                ButtonColorHide((Button)sender);
            }
        }

        public void ShowHomeSidebar(Home home)
        {
            this.home = home;
            this.user.HomeID = home.ID;
            HideFindingHome(true);
            groupBox_HomeOptions.Visible = true;
            HideThisShowMainScreen(null);

            header.menuStrip_Home.Enabled = true;
            header.toolStripTextBox1.Text = "Home ID: " + home.ID;

        }

        public void HideFindingHome(bool hide)
        {
            if (hide)
                panel_FindingHome.Visible = false;
            else
                panel_FindingHome.Visible = true;

        }

        private void ButtonColorShow(Button button)
        {
            if(buttonCurrent != null) ButtonColorHide(buttonCurrent);
            button.BackColor = GlobalColorConstants.mainButtonDownColor;
            button.Size = new Size(button.Bounds.Width, 50);
            button.FlatAppearance.BorderSize = 1;
            buttonCurrent = button;
        }
        private void ButtonColorHide(Button button)
        {
            button.BackColor = GlobalColorConstants.mainButtonColor;
            button.Size = new Size(button.Bounds.Width, 30);
            button.FlatAppearance.BorderSize = 0;
        }

        private void HideOtherShowThis(UserControl userControl)
        {
            if (home == null) panel_FindingHome.Hide();
            panel_HomeScreen.Hide();
            userControl.Show();
            if (userControlCurrent == null) { userControlCurrent = userControl; }
            else if (userControlCurrent != userControl)
            {
                userControlCurrent.Hide();
                userControlCurrent = userControl;
            }
        }

        public void HideThisShowMainScreen(UserControl userControl)
        {
            if (buttonCurrent != null) ButtonColorHide(buttonCurrent);
            if (userControl != null) userControl.Hide();
            if (home == null) panel_FindingHome.Show();
            panel_HomeScreen.Show();
        }

        private void HideOtherShowMainScreenWithThis(UserControl userControl)
        {
            if (buttonCurrent != null) ButtonColorHide(buttonCurrent);
            if (userControlCurrent == null) { userControlCurrent = userControl; }
            else if (userControlCurrent != userControl)
            {
                userControlCurrent.Hide();
                userControlCurrent = userControl;
            }
            
            panel_HomeScreen.Show();
            userControl.Show();
        }

        private void button_NotesHomeNext_Click(object sender, EventArgs e)
        {
            if (notePapersHome.Count == 0) return;

            bool foundCurrent = false;
            foreach (NotePaper notePaper in notePapersHome)
            {
                if (foundCurrent)
                {
                    notePaperHomeCurrent = notePaper;
                    break;
                }
                if (notePaper == notePaperHomeCurrent)
                {
                    foundCurrent = true;
                }
            }
            notePaperHomeCurrent.BringToFront();
        }

        private void button_NotesHomePrevious_Click(object sender, EventArgs e)
        {
            if (notePapersHome.Count == 0) return;

            NotePaper previousNotePaper = notePaperHomeCurrent;
            foreach (NotePaper notePaper in notePapersHome)
            {
                if (notePaper == notePaperHomeCurrent)
                {
                    notePaperHomeCurrent = previousNotePaper;
                    break;
                }
                previousNotePaper = notePaper;
            }
            notePaperHomeCurrent.BringToFront();
        }

        private void button_NotesPrivateNext_Click(object sender, EventArgs e)
        {
            if (notePapersPrivate.Count == 0) return;

            bool foundCurrent = false;
            foreach (NotePaper notePaper in notePapersPrivate)
            {
                if (foundCurrent)
                {
                    notePaperPrivateCurrent = notePaper;
                    break;
                }
                if (notePaper == notePaperPrivateCurrent)
                {
                    foundCurrent = true;
                }
            }
            notePaperPrivateCurrent.BringToFront();
        }

        private void button_NotesPrivatePrevious_Click(object sender, EventArgs e)
        {
            if (notePapersPrivate.Count == 0) return;

            NotePaper previousNotePaper = notePaperPrivateCurrent;
            foreach (NotePaper notePaper in notePapersPrivate)
            {
                if (notePaper == notePaperPrivateCurrent)
                {
                    notePaperPrivateCurrent = previousNotePaper;
                    break;
                }
                previousNotePaper = notePaper;
            }
            notePaperPrivateCurrent.BringToFront();
        }

        public void showLeaveHome()
        {
            Home home = null;
            string text = "You can join again with the ID";
            string title = "Leave Home";
            if(this.home.CreatorID == user.ID) { 
                text = "If you leave it, the home will be deleted forever!";
                title = "Delete Home";
                home = this.home;
            }
            DialogResult dialogResult = MessageBox.Show(text, title, MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                user.LeaveHome(home);
                user.HomeID = 0;
                Program.CreateMainScreen(user);
                this.Close();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btn_AddRequest_Click(object sender, EventArgs e)
        {
            if (createRequest == null)
            {
                createRequest = new CreateRequest(this);
                createRequest.Parent = panel_HomeScreenUserControl;
                HideOtherShowMainScreenWithThis(createRequest);
                ButtonColorShow((Button)sender);
            }
            else if (!createRequest.Visible)
            {
                createRequest.Show();
                HideOtherShowMainScreenWithThis(createRequest);
                ButtonColorShow((Button)sender);
            }
            else
            {
                createRequest.Hide();
                ButtonColorHide((Button)sender);
            }
        }

        public void CreateBill(object sender, EventArgs e)
        {
            if (createBill == null)
            {
                createBill = new CreateBill(this);
                createBill.Parent = panel_HomeScreenUserControl;
                HideOtherShowMainScreenWithThis(createBill);
                ButtonColorHide(buttonCurrent);
            }
            else if (!createBill.Visible)
            {
                createBill.Show();
                HideOtherShowMainScreenWithThis(createBill);
                ButtonColorHide(buttonCurrent);
            }
            else
            {
                createBill.Hide();
            }
        }

        private void btn_AddEvent_Click(object sender, EventArgs e)
        {
            if (createEvent == null)
            {
                createEvent = new CreateEvent(this);
                createEvent.Parent = panel_HomeScreenUserControl;
                HideOtherShowMainScreenWithThis(createEvent);
                ButtonColorShow((Button)sender);
            }
            else if (!createEvent.Visible)
            {
                createEvent.Show();
                HideOtherShowMainScreenWithThis(createEvent);
                ButtonColorShow((Button)sender);
            }
            else
            {
                createEvent.Hide();
                ButtonColorHide((Button)sender);
            }
        }

        private void btn_AddBusyTime_Click(object sender, EventArgs e)
        {
            if (createBusyTime == null)
            {
                createBusyTime = new CreateBusyTime(this);
                createBusyTime.Parent = panel_HomeScreenUserControl;
                HideOtherShowMainScreenWithThis(createBusyTime);
                ButtonColorShow((Button)sender);
            }
            else if (!createBusyTime.Visible)
            {
                createBusyTime.Show();
                HideOtherShowMainScreenWithThis(createBusyTime);
                ButtonColorShow((Button)sender);
            }
            else
            {
                createBusyTime.Hide();
                ButtonColorHide((Button)sender);
            }
        }

        private void btn_ViewHousehold_Click(object sender, EventArgs e)
        {
            if (peopleContainer == null)
            {
                peopleContainer = new PeopleContainer(this);
                peopleContainer.Parent = panel_HomeScreenUserControl;
                HideOtherShowMainScreenWithThis(peopleContainer);
                ButtonColorShow((Button)sender);
            }
            else if (!peopleContainer.Visible)
            {
                peopleContainer.Show();
                HideOtherShowMainScreenWithThis(peopleContainer);
                ButtonColorShow((Button)sender);
            }
            else
            {
                peopleContainer.Hide();
                ButtonColorHide((Button)sender);
            }
        }

        public void btn_PersonalInformation_Click(object sender, EventArgs e)
        {
            PersonalInformation personalInformation = new PersonalInformation(User,this);
            personalInformation.ShowDialog();
           
        }

        public void ViewBill(object sender, EventArgs e)
        {

            List<object> objectList = new List<object>(home.Bills);
            ViewList viewList = new ViewList(this, objectList);
            viewList.ShowDialog();
        }

        public void ViewBusyTime(object sender, EventArgs e)
        {

            List<object> objectList = new List<object>(user.BusyTimes);
            ViewList viewList = new ViewList(this, objectList);
            viewList.ShowDialog();
        }

        private void ShowNoteButtonsOnCount()
        {
            int count = 0;
            foreach (Control item in panel_HomeNotes.Controls)
            {
                if (item.GetType() == typeof(NotePaper)) count++;
            }

            if (count < 2)
            {
                ShowHomeNoteButtons(false);
            }
            else ShowHomeNoteButtons(true);


            count = 0;
            foreach (Control item in panel_PrivateNotes.Controls)
            {
                if (item.GetType() == typeof(NotePaper)) count++;
            }
            if (count < 2)
            {
                ShowPrivateNoteButtons(false);
            }
            else ShowPrivateNoteButtons(true);

        }

        private void ShowHomeNoteButtons(bool show)
        {
            button_NotesHomeNext.Visible = show;
            button_NotesHomePrevious.Visible = show;
            button_NotesHomePrevious.Enabled = show;
            button_NotesHomeNext.Enabled = show;
            
        }
        private void ShowPrivateNoteButtons(bool show)
        {
            button_NotesPrivateNext.Visible = show;
            button_NotesPrivatePrevious.Visible = show;
            button_NotesPrivatePrevious.Enabled = show;
            button_NotesPrivateNext.Enabled = show;

        }
        private void panel_NotesControlChanged(object sender, ControlEventArgs e)
        {
            ShowNoteButtonsOnCount();
        }

        private void timer_UpdateHome_Tick(object sender, EventArgs e)
        {
            //UPDATE
            if (home == null) return;
            progressBar_UpdateHome.Style = ProgressBarStyle.Marquee;
            if (!backgroundWorker_UpdateHome.IsBusy)
                backgroundWorker_UpdateHome.RunWorkerAsync();
            
        }

        private void backgroundWorker_UpdateHome_DoWork(object sender, DoWorkEventArgs e)
        {
            Home databaseHome = Database.GetHomeByID(user.HomeID);
            bool homeExist = true;
            if (databaseHome == null)
                homeExist = Database.DoesHomeExist(home.ID);

            e.Result = new List<object>() { databaseHome,homeExist };
                       
            
        }

        private void backgroundWorker_UpdateHome_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar_UpdateHome.Style = ProgressBarStyle.Continuous;

           
            if (e.Cancelled == true)
            {
                progressBar_UpdateHome.Value = 50;
            }
            else if (e.Error != null)
            {
                progressBar_UpdateHome.Value = 90;
            }
            else
            {
                progressBar_UpdateHome.Value = 0;
                if ( ((List<object>)e.Result)[0] != null)
                {
                    home = (Home)(((List<object>)e.Result)[0]);
                }
                else
                {
                    string text = "Home does not exist anymore!";
                    string title = "Home Not Found";
                    if ((bool)((List<object>)e.Result)[1])
                    {
                        text = "You've been kicked from the home!";
                        title = "Kicked";
                    }

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(text, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        showLeaveHome();
                    }
                    else
                    {
                        Program.CreateMainScreen(user);
                        this.Close();
                    }
                }

                LoadMain();
                RefreshNoteExpirings();
            }
        }
    }
}
