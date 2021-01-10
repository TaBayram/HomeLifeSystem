using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HomeLifeSystem
{
    public partial class ViewCalendar : UserControl
    {
        DateTime firstDay;
        List<Label> labelDays = new List<Label>();
        List<Label> labelDaysDay = new List<Label>();
        List<Panel> PanelDays = new List<Panel>();
        CalendarEvent calendarEvent;
        Person person;
        Home home;

        CalendarInformationPopUp calendarInformationPopUp;
        CalendarFilterPopUp calendarFilterPopUp;


        List<List<object>> freeTimes = new List<List<object>>();

        List<String> filters = new List<string>() {"BusyTime","0","Event","0","Housework", "0", "Request", "0","FreeTime","1"};

        public CalendarEvent CalendarEvent { get => calendarEvent; set => calendarEvent = value; }
        public List<string> Filters { get => filters; set => filters = value; }
        public Person Person { get => person; set => person = value; }
        public Home Home { get => home; set => home = value; }

        public ViewCalendar(CalendarEvent calendarEvent,Person person,Home home)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            labelDays.Add(lbl_Day1);
            labelDays.Add(lbl_Day2);
            labelDays.Add(lbl_Day3);
            labelDays.Add(lbl_Day4);
            labelDays.Add(lbl_Day5);
            labelDays.Add(lbl_Day6);
            labelDays.Add(lbl_Day7);

            labelDaysDay.Add(lbl_Day1Name);
            labelDaysDay.Add(lbl_Day2Name);
            labelDaysDay.Add(lbl_Day3Name);
            labelDaysDay.Add(lbl_Day4Name);
            labelDaysDay.Add(lbl_Day5Name);
            labelDaysDay.Add(lbl_Day6Name);
            labelDaysDay.Add(lbl_Day7Name);

            PanelDays.Add(panel_BigDay1);
            PanelDays.Add(panel_BigDay2);
            PanelDays.Add(panel_BigDay3);
            PanelDays.Add(panel_BigDay4);
            PanelDays.Add(panel_BigDay5);
            PanelDays.Add(panel_BigDay6);
            PanelDays.Add(panel_BigDay7);

            this.home = home;
            this.person = person;
            this.CalendarEvent = calendarEvent;



            ResetCalendar();
            DrawOccasions();
            Coloring();

        }

        private void Coloring()
        {
            this.BackColor = GlobalColorConstants.calendarBackground;

            button_NextDay.BackColor = GlobalColorConstants.mainButtonColor;
            button_NextDay.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;
            button_NextDay.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;

            button_PreviousDay.BackColor = GlobalColorConstants.mainButtonColor;
            button_PreviousDay.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;
            button_PreviousDay.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;

            button_NextWeek.BackColor = GlobalColorConstants.minorButtonColor;
            button_NextWeek.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            button_NextWeek.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            button_PreviousWeek.BackColor = GlobalColorConstants.minorButtonColor;
            button_PreviousWeek.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            button_PreviousWeek.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;


        }

        private void DrawOccasions()
        {
            ClearOccasions();
            if(Filters[9] == "0") DrawFreeTime();
            double sumHeight = panel_BigDay1.Height;
            double hourHeight = sumHeight / 24;
            for (int i = 1; i < 25; i++)
            {
                Label label = new Label();
                label.Text = i.ToString();
                label.Parent = panel_Hours;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Location = new Point(panel_Hours.ClientSize.Width / 3, (int)(panel_Hours.Height / 24 * (i) - 8));

            }
            foreach (List<Object> occasion in calendarEvent.Occasions)
            {
                DateTime startingDateTime = (DateTime)occasion[1];
                DateTime endingDateTime = (DateTime)occasion[2];
                TimeSpan duration = endingDateTime - startingDateTime;

                DateTime startingDate = startingDateTime.Date;
                DateTime endingDate = endingDateTime.Date;
                TimeSpan leak = startingDate - endingDate;

                if (leak.TotalDays != 0)
                {
                    TimeSpan duration2 = endingDateTime - endingDate;
                    double position2 = 0;
                    for (int i = 0; i < labelDays.Count; i++)
                    {
                        DateTime dateTime = Convert.ToDateTime(labelDays[i].Text);
                        if (dateTime == endingDate)
                        {
                            DrawOccasion(occasion, PanelDays[i], hourHeight, position2, duration2, startingDateTime, endingDateTime);
                        }
                    }
                    duration = endingDate - startingDateTime;
                }
                TimeSpan startingTime = startingDateTime.TimeOfDay;
                double position = (startingTime.TotalHours) * hourHeight;
                for (int i = 0; i < labelDays.Count; i++)
                {
                    DateTime dateTime = Convert.ToDateTime(labelDays[i].Text);
                    if (dateTime == startingDate)
                    {
                        DrawOccasion(occasion, PanelDays[i], hourHeight, position, duration, startingDateTime, endingDateTime);
                    }
                }
            }
            for (int i = 0; i < labelDays.Count; i++)
            {
                DateTime dateTime = Convert.ToDateTime(labelDays[i].Text);
                var busyTimes = GetBusyTimesByDate(dateTime);
                if (busyTimes != null)
                {
                    foreach (BusyTime busyTime in busyTimes)
                    {
                        DateTime startingDateTime = dateTime + busyTime.StartTime;
                        DateTime endingDateTime = dateTime + busyTime.EndTime;
                        TimeSpan duration = endingDateTime - startingDateTime;
                        DateTime startingDate = startingDateTime.Date;
                        DateTime endingDate = endingDateTime.Date;
                        TimeSpan leak = startingDate - endingDate;
                        TimeSpan startingTime = startingDateTime.TimeOfDay;
                        double position = (startingTime.TotalHours) * hourHeight;

                        DrawOccasion(busyTime, PanelDays[i], hourHeight, position, duration, startingDateTime, endingDateTime);
                    }
                }
            }
            for (int i = 0; i < labelDays.Count; i++)
            {
                DateTime dateTime = Convert.ToDateTime(labelDays[i].Text);
                if (freeTimes != null)
                {
                    foreach (List<object> freeTime in freeTimes)
                    {
                        
                        DateTime startingDateTime = (DateTime)freeTime[1];
                        DateTime endingDateTime = (DateTime)freeTime[2];
                        TimeSpan duration = endingDateTime - startingDateTime;
                        DateTime startingDate = startingDateTime.Date;
                        DateTime endingDate = endingDateTime.Date;
                        TimeSpan leak = startingDate - endingDate;
                        TimeSpan startingTime = startingDateTime.TimeOfDay;
                        double position = (startingTime.TotalHours) * hourHeight;

                        if (dateTime == startingDateTime.Date)
                            DrawOccasion(freeTime, PanelDays[i], hourHeight, position, duration, startingDateTime, endingDateTime);
                    }
                }
            }


            FixCollidedPanels();
        }

        private void DrawOccasion(List<Object> occasion, Panel parentPanel, double hourHeight, double positionY, TimeSpan duration, DateTime startingTime, DateTime endingTime)
        {
            if(IsItFiltered(occasion[0].GetType())) return;

            Panel panel = new Panel();
            Label label = new Label();


            panel.Tag = new List<object>() { GetOccasionActivityID(occasion[0]), occasion[0].GetType(), occasion };
            panel.Parent = parentPanel;
            panel.Height = (int)(duration.TotalHours * hourHeight);
            panel.Width = panel_BigDay1.Width;
            panel.Location = new Point(parentPanel.ClientSize.Width / 2 - panel.Size.Width / 2, (int)positionY);
            panel.BackColor = GetOccasionColor(occasion);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Hide();

            if (occasion[0].GetType() != typeof(FreeTime)) 
            {
                if (((Person)occasion[3]).ID == person.ID)
                {
                    panel.ContextMenuStrip = contextMenuStrip_OccasionUser;
                }
                else
                {
                    if(occasion[0].GetType() == typeof(Request))
                    {
                        Request request = (Request)occasion[0];
                        if(request.AccepterID == 0)
                        {
                            panel.ContextMenuStrip = contextMenuStrip_Request;
                        }
                        else
                        {
                            panel.ContextMenuStrip = contextMenuStrip_Occasion;
                        }
                        
                    }
                    else
                    {
                        panel.ContextMenuStrip = contextMenuStrip_Occasion;
                    }
                    
                }
            }


            label.Parent = panel;
            label.Dock = DockStyle.Fill;
            label.Location = new Point(panel.ClientSize.Width / 2, panel.ClientSize.Height / 2);
            label.Text = CalendarEvent.GetOccasionName(occasion) + "\n" + startingTime.ToString("HH:mm") + "\n" + endingTime.ToString("HH:mm");
            label.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void DrawOccasion(BusyTime busyTime, Panel parentPanel, double hourHeight, double positionY, TimeSpan duration, DateTime startingTime, DateTime endingTime)
        {
            if (IsItFiltered(busyTime.GetType())) return;

            Panel panel = new Panel();
            Label label = new Label();

            Person busyTimePerson = null;
            if (busyTime.PersonID == person.ID) busyTimePerson = person;
            else busyTimePerson = Database.GetPersonByID(busyTime.PersonID);

            panel.Tag = new List<Object>() { busyTime.ID.ToString(), busyTime.GetType(), new List<object>() {busyTime,startingTime,endingTime, busyTimePerson, busyTime.ID } };
            panel.Parent = parentPanel;
            panel.Height = (int)(duration.TotalHours * hourHeight);
            panel.Width = panel_BigDay1.Width;
            panel.Location = new Point(parentPanel.ClientSize.Width / 2 - panel.Size.Width / 2, (int)positionY);
            panel.BackColor = GetOccasionColor( new List<object>(){busyTime,startingTime,endingTime});
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Show();

            panel.ContextMenuStrip = contextMenuStrip_OccasionUser;


            if (busyTime.PersonID != person.ID)
            {
                if (busyTime.PersonID == person.ID)
                {
                    panel.ContextMenuStrip = contextMenuStrip_OccasionUser;
                }
                else
                {
                    panel.ContextMenuStrip = contextMenuStrip_Occasion;
                }
            }

            label.Parent = panel;
            label.Dock = DockStyle.Fill;
            label.Location = new Point(panel.ClientSize.Width / 2, panel.ClientSize.Height / 2);
            label.Text = busyTime.Name + "\n" + startingTime.ToString("HH:mm") + "\n" + endingTime.ToString("HH:mm");
            label.TextAlign = ContentAlignment.MiddleCenter;

        }

        private Color GetOccasionColor(List<Object> occasion)
        {
            Color color = Color.White;
            var activity = occasion[0];

            DateTime startTime = (DateTime)occasion[1];
            DateTime endTime = (DateTime)occasion[2];

            int dayDifference = 0;
            int hourDifference = 0;

            if((startTime - DateTime.Now).TotalMinutes >= 0 && (endTime - DateTime.Now ).TotalMinutes <= 0)
            {
                hourDifference = 0;
                dayDifference = 0;
            }
            else if((startTime - DateTime.Now).TotalMinutes >= 0 && (endTime - DateTime.Now).TotalMinutes >= 0)
            {
                dayDifference = (int)(startTime - DateTime.Now).TotalDays;
                hourDifference = (int)(startTime - DateTime.Now).TotalHours;
            }
            else if ((startTime - DateTime.Now).TotalMinutes <= 0 && (endTime - DateTime.Now).TotalMinutes <= 0)
            {
                dayDifference = (int)(endTime - DateTime.Now).TotalDays;
                hourDifference = (int)(endTime - DateTime.Now).TotalHours;
            }


            color = GlobalColorConstants.GetOccasionColor(activity, dayDifference, hourDifference);



            return color;
        }

        private int GetOccasionActivityID(object occasion)
        {
            int id = 0;

            if (occasion.GetType() == typeof(Housework))
            {
                Housework housework = occasion as Housework;
                id = housework.ID;
            }
            else if (occasion.GetType() == typeof(Request))
            {
                Request request = occasion as Request;
                id = request.ID;
            }
            else if (occasion.GetType() == typeof(BusyTime))
            {
                BusyTime busyTime = occasion as BusyTime;
                id = busyTime.ID;
            }
            else if (occasion.GetType() == typeof(Event))
            {
                Event @event = occasion as Event;
                id = @event.ID;
            }


            return id;
        }

        private void ClearOccasions()
        {

            foreach (Panel panel in PanelDays)
            {
                /*foreach (Control control in panel.Controls)
                {
                    panel.Controls.Remove(control);
                    
                }*/
                panel.Controls.Clear();
            }
            /*foreach (Label label in panel_Hours.Controls)
            {
                label.Hide();
                panel_Hours.Controls.Remove(label);
            }*/
            panel_Hours.Controls.Clear();
            freeTimes.Clear();
        }

        private void ResetCalendar()
        {
            DateTime dateTime = new DateTime();
            CultureInfo myCI = new CultureInfo("tr-TR");
            Calendar myCalendar = myCI.Calendar;

            myCalendar.GetDayOfWeek(dateTime);

            dateTime = StartOfWeek(DateTime.Now, DayOfWeek.Monday);
            firstDay = dateTime;

            DrawPanels(dateTime);
        }

        private DateTime StartOfWeek(DateTime dateTimeNow, DayOfWeek startOfWeek)
        {
            int difference = (7 + (dateTimeNow.DayOfWeek - startOfWeek)) % 7;
            return dateTimeNow.AddDays(-1 * difference).Date;
        }

        private void btn_NextDay_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddDays(1);
            DateTime dateTime = firstDay;
            DrawPanels(dateTime);

            DrawOccasions();
        }

        private void btn_PreviousDay_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddDays(-1);
            DateTime dateTime = firstDay;
            DrawPanels(dateTime);

            DrawOccasions();
        }

        private void button_NextWeek_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddDays(7);
            DateTime dateTime = firstDay;
            DrawPanels(dateTime);

            DrawOccasions();
        }

        private void btton_PreviousDay_Click(object sender, EventArgs e)
        {
            firstDay = firstDay.AddDays(-7);
            DateTime dateTime = firstDay;
            DrawPanels(dateTime);

            DrawOccasions();
        }

        private void DrawPanels(DateTime dateTime)
        {

            for (int i = 0; i < labelDays.Count; i++)
            {
                if (dateTime.Date == DateTime.Now.Date)
                {
                    PanelDays[i].BackColor = GlobalColorConstants.calendarThisDay;
                }
                else
                {
                    PanelDays[i].BackColor = GlobalColorConstants.calendarOtherDay;
                }

                labelDays[i].Text = dateTime.ToShortDateString();
                labelDaysDay[i].Text = dateTime.DayOfWeek.ToString();
                dateTime = dateTime.AddDays(1);
            }

        }

        private List<BusyTime> GetBusyTimesByDate(DateTime dateTime)
        {
            List<BusyTime> busyTimes;
            List<BusyTime> busyTimesToday = new List<BusyTime>();
            if (calendarEvent.Ownership.GetType() == typeof(Person))
            {
                busyTimes = ((Person)calendarEvent.Ownership).BusyTimes;
            }
            else
            {
                busyTimes = ((Home)calendarEvent.Ownership).BusyTimes;
            }
            foreach (BusyTime busyTime in busyTimes)
            {
                bool isToday = false;
                var isNumeric = int.TryParse(busyTime.Frequency, out int n);
                if (busyTime.Frequency == "D")
                {
                    isToday = true;
                }
                else if (isNumeric && n == dateTime.Day)
                {
                    isToday = true;
                }
                else if (busyTime.Frequency.Contains(dateTime.DayOfWeek.ToString().Substring(0, 2)))
                {
                    isToday = true;
                }
                if (isToday)
                {
                    busyTimesToday.Add(busyTime);

                }
            }
            return busyTimesToday;

        }

        private void FixCollidedPanels()
        {
            for (int i = 0; i < PanelDays.Count; i++)
            {
                List<Panel> panels = new List<Panel>();
                foreach (Panel panel in PanelDays[i].Controls) panels.Add(panel);

                int panelDayAvaliableWidth = PanelDays[i].Width;
                int panelDayStartingX = 0;

                List<Panel> panelsIntersectX = new List<Panel>();
                for (int m = 0; m < panels.Count; m++)
                {
                    for (int j = 0; j < panels.Count; j++)
                    {
                        List<Panel> panelsIntersect = new List<Panel>();

                        //CHECK IF IT IS ALREADY BEEN PLACED
                        bool cont = false;
                        for (int l = 0; l < panelsIntersectX.Count; l++)
                        {
                            if (panels[j] == panelsIntersectX[l]) cont = true;
                        }
                        if (cont) continue;


                        //GET THE PANELS THAT ARE INTERSECTING WITH 
                        for (int k = 0; k < panels.Count; k++)
                        {
                            if (k != j && panels[j].Bounds.IntersectsWith(panels[k].Bounds))
                            {
                                panelsIntersect.Add(panels[k]);
                            }
                        }

                        //IF NO PANEL IS INTERSECTING CONTINUE
                        if (panelsIntersect.Count == 0) continue;
                        panelsIntersect.Add(panels[j]);

                        //IF YOU ARE NOT THE NEXT ONE TO PLACED BY LEFT MOST RULE CONTINUE
                        if (panels[j].Bounds.IntersectsWith(panels[m].Bounds) && m != j) continue;


                        //SEE IF THE CURRENT PANEL INTERSECTS WITH THE ALREADY PLACED PANELS IF TRUE GIVE IT NEW LOCATION AND WIDTH
                        int freeWidth = panelDayAvaliableWidth;
                        int freeX = panelDayStartingX;
                        bool placed = false;
                        for (int l = 0; l < panelsIntersectX.Count; l++)
                        {
                            if (panels[j].Bounds.IntersectsWith(panelsIntersectX[l].Bounds))
                            {
                                int diff = panels[l].Bounds.Width + (panels[j].Bounds.X - panels[l].Bounds.X);

                                freeWidth -= diff;
                                freeX += diff;

                                panelsIntersect.Remove(panelsIntersectX[l]);

                                int width = freeWidth / (panelsIntersect.Count);
                                panels[j].Location = new Point((int)(freeX), panels[j].Location.Y);
                                panels[j].Width = (int)width;

                                placed = true;

                                //WITH THE NEW LOCATION AND WIDTH CHECK IF YOU STILL ARE INTERSECTING THE PANELS REMOVE IF NOT
                                for (int k = 0; k < panelsIntersect.Count; k++)
                                {
                                    if (panels[j] != panelsIntersect[k] && !panels[j].Bounds.IntersectsWith(panels[k].Bounds))
                                    {
                                        panelsIntersect.RemoveAt(k);
                                        k--;
                                    }
                                }

                            }
                        }
                        //ADD TO ALREADY PLACED PANELS
                        if (placed)
                        {
                            panelsIntersectX.Add(panels[j]);
                            continue;
                        }

                        //THIS ONLY TRIGGERS FOR THE LEFT MOST PANELS
                        if (!panels[j].Bounds.IntersectsWith(panels[m].Bounds) || m == j)
                        {
                            int width = freeWidth / (panelsIntersect.Count);
                            panels[j].Location = new Point((int)(freeX), panels[j].Location.Y);
                            panels[j].Width = (int)width;
                            panelsIntersectX.Add(panels[j]);

                        }



                    }


                }
            }

            //REDUCE WIDTH BY 1 FOR EACH PANEL INCASE OF SOME INTERSECT
            for (int i = 0; i < PanelDays.Count; i++)
            {
                List<Panel> panels = new List<Panel>();
                foreach (Panel panel in PanelDays[i].Controls) panels.Add(panel);

                for (int m = 0; m < panels.Count; m++)
                {
                    panels[m].Width = panels[m].Width - 1;
                } 
            }


            //NOW TRY FOR EVERY PANEL TO INCREASE WITDH BEFORE HITTING ANOTHER PANEL
            for (int i = 0; i < PanelDays.Count; i++)
            {
                List<Panel> panels = new List<Panel>();
                foreach (Panel panel in PanelDays[i].Controls) panels.Add(panel);

                for (int m = 0; m < panels.Count; m++)
                {
                    int newWidth = panels[m].Width;

                    bool loop = true;
                    int oldWidth = 0 + newWidth;
                    while (loop)
                    {
                        newWidth += 5;
                        panels[m].Width = newWidth;
                        for (int j = 0; j < panels.Count; j++)
                        {
                            if ((panels[m].Bounds.IntersectsWith(panels[j].Bounds) && m != j) 
                                || (panels[m].Bounds.X + newWidth) >= PanelDays[i].Bounds.Width)
                            {
                                newWidth -= 5;
                                loop = false;
                                break;
                                
                            }
                        }
                        oldWidth = newWidth + 0;
                    }
                    panels[m].Width = oldWidth;
                    
                }
            }
            for (int i = 0; i < PanelDays.Count; i++)
            {
                foreach (Control control in PanelDays[i].Controls)
                {
                    control.Show();
                }
            }
        }

        private void ViewCalendar_VisibleChanged(object sender, EventArgs e)
        {
            DrawOccasions();
        }

        private void ViewCalendar_SizeChanged(object sender, EventArgs e)
        {
            DrawOccasions();
        }

        private void DrawFreeTime()
        {
            
            for (int i = 0; i < labelDays.Count; i++)
            {
                DateTime dateTime = Convert.ToDateTime(labelDays[i].Text);
                List<List<object>> todaysOccasions = calendarEvent.GetDaysOccasions(dateTime);

                var busyTimes = GetBusyTimesByDate(dateTime);
                if (busyTimes != null)
                {
                    foreach (BusyTime busyTime in busyTimes)
                    {
                        DateTime startingDateTime = dateTime + busyTime.StartTime;
                        DateTime endingDateTime = dateTime + busyTime.EndTime;
                        todaysOccasions.Add(new List<object>() {busyTime,startingDateTime,endingDateTime});
                    }
                }
                todaysOccasions = todaysOccasions.OrderBy(o => o[1]).ToList();

                int startingTimeByMinutes = 0;
                int endingTimeByMinutes = 0;
                int newStartingTimeByMinutes = 0;
                int increment = 5;
                bool hasStart = true;
                while (startingTimeByMinutes < 24 * 60)
                {
                    //Console.WriteLine(i + "." + hasStart + "-" + startingTimeByMinutes + ":" + endingTimeByMinutes);
                    if (hasStart)
                    {
                        endingTimeByMinutes += increment;

                        bool isFree = true;
                        foreach (List<object> item in todaysOccasions)
                        {
                            int occasionStartingTimeByMinute = (int)(((DateTime)item[1]) - ((DateTime)item[1]).Date).TotalMinutes;
                            if (occasionStartingTimeByMinute < startingTimeByMinutes) continue;
                            if (occasionStartingTimeByMinute > endingTimeByMinutes)
                            {
                                endingTimeByMinutes = occasionStartingTimeByMinute;
                                break;
                            }
                            else if (occasionStartingTimeByMinute <= endingTimeByMinutes)
                            {
                                endingTimeByMinutes = occasionStartingTimeByMinute - 1;
                                newStartingTimeByMinutes = 1+ (int)(((DateTime)item[2]) - ((DateTime)item[2]).Date).TotalMinutes;
                                isFree = false;
                                
                                break;
                            }
                        }

                        if (endingTimeByMinutes >= 24 * 60)
                        {
                            endingTimeByMinutes = (24 * 60 - 1);
                            newStartingTimeByMinutes = endingTimeByMinutes + 0;
                            isFree = false;
                        }

                        if (!isFree)
                        {
                            DateTime startDateTime = dateTime.AddMinutes(startingTimeByMinutes);
                            DateTime endDateTime = dateTime.AddMinutes(endingTimeByMinutes);
                            freeTimes.Add(new List<object>() { new FreeTime("Free Time"), startDateTime, endDateTime,0,0 });

                            startingTimeByMinutes = newStartingTimeByMinutes + 0;
                            endingTimeByMinutes = newStartingTimeByMinutes + 0;
                            hasStart = false;
                        }

                    }
                    else
                    {
                        startingTimeByMinutes += increment;

                        bool isFree = true;
                        int lastOccasionEndingTime = 0;
                        foreach (List<object> item in todaysOccasions)
                        {
                            int occasionStartingTimeByMinute = (int)(((DateTime)item[1]) - ((DateTime)item[1]).Date).TotalMinutes;
                            int occasionEndingTimeByMinute = (int)(((DateTime)item[2]) - ((DateTime)item[2]).Date).TotalMinutes;
                            if (occasionStartingTimeByMinute <= startingTimeByMinutes && occasionEndingTimeByMinute > startingTimeByMinutes)
                            {
                                isFree = false;
                                break;
                            }
                            else if (occasionStartingTimeByMinute <= startingTimeByMinutes && occasionEndingTimeByMinute <= startingTimeByMinutes)
                            {
                                if(occasionEndingTimeByMinute > lastOccasionEndingTime)
                                    lastOccasionEndingTime = 1 + occasionEndingTimeByMinute;
                            }
                        }

                        if(startingTimeByMinutes >= 24 * 60)
                        {
                            break;
                        }

                        if (isFree)
                        {
                            hasStart = true;
                            //if(lastOccasionEndingTime>startingTimeByMinutes) 
                            startingTimeByMinutes = lastOccasionEndingTime;
                            endingTimeByMinutes = startingTimeByMinutes;
                        }



                    }
                    

                }

                
            }
        }

        public void FilterChange()
        {
            DrawOccasions();
        }

        private bool IsItFiltered(Type type)
        {
            bool isIt = false;
            string sType = type.Name;

            for (int i = 0; i < Filters.Count; i += 2)
            {
                if (sType == Filters[i])
                {
                    if (Filters[i + 1] == "1") 
                        isIt = true;
                }
            }

            return isIt;

        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            if (calendarFilterPopUp != null) this.Controls.Remove(calendarFilterPopUp);
            calendarFilterPopUp = new CalendarFilterPopUp(this);
            calendarFilterPopUp.Location = new Point(this.Location.X + button_Filter.Location.X ,splitContainer1.Panel1.Height - calendarFilterPopUp.Height);
            calendarFilterPopUp.Parent = this;
            this.Controls.SetChildIndex(calendarFilterPopUp, 0);
            calendarFilterPopUp.BringToFront();
            calendarFilterPopUp.Show();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            List<object> tag = (List<object>)control.Tag;
            Type type = (Type)tag[1];
            int id = int.Parse(tag[0].ToString());
            List<object> occasion = (List<object>)tag[2];

            if (calendarInformationPopUp != null) this.Controls.Remove(calendarInformationPopUp);
            calendarInformationPopUp = new CalendarInformationPopUp(occasion);
            calendarInformationPopUp.Location = new Point(this.Location.X + this.Width/2, this.Location.Y + this.Height/2);
            calendarInformationPopUp.Parent = this;
            this.Controls.SetChildIndex(calendarInformationPopUp, 0);
            calendarInformationPopUp.BringToFront();
            calendarInformationPopUp.Show();



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            List<object> tag = (List<object>)control.Tag;
            Type type =(Type)tag[1];
            int id = int.Parse(tag[0].ToString());
            List<object> occasion = (List<object>)tag[2];

            string text = "Are you sure you want to delete?";
            string title = "Delete " + type.Name;
            DialogResult dialogResult = MessageBox.Show(text, title, MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                if (type == typeof(BusyTime))
                {
                    if(calendarEvent.Ownership.GetType() == typeof(Home))
                    {
                        ((Home)calendarEvent.Ownership).BusyTimes.Remove((BusyTime)occasion[0]);
                    }
                    ((Person)occasion[3]).BusyTimes.Remove((BusyTime)occasion[0]);
                    
                    Database.BusyTimeTableRemove(((BusyTime)occasion[0]).ID);


                }
                else if (type == typeof(Event))
                {
                    Database.EventTableRemove(((Event)occasion[0]).ID);
                    
                }
                else if (type == typeof(Request))
                {
                    Database.RequestTableRemove(((Request)occasion[0]).ID);

                }
                else if (type == typeof(Housework))
                {
                    Database.HouseworkTableRemove(((Housework)occasion[0]).ID);

                }

                if(calendarEvent.Ownership.GetType() == typeof(Person) && type != typeof(BusyTime) && home != null)
                {
                    home.Calendar.DeleteOccasion(occasion);

                }

                List<List<object>> list = calendarEvent.Occasions;
                for(int i = 0; i < list.Count; i++)
                {
                    if(GetOccasionActivityID(list[i][0]) == id && type == list[i][0].GetType())
                    {
                        calendarEvent.DeleteOccasion(list[i]);
                        break;
                    }
                }

                control.Parent.Controls.Remove(control);
                DrawOccasions();

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            List<object> tag = (List<object>)control.Tag;
            Type type = (Type)tag[1];
            int id = int.Parse(tag[0].ToString());
            List<object> occasion = (List<object>)tag[2];
            Request request = (Request)occasion[0];

            request.AccepterID = person.ID;
            request.AccepterName = person.Nickname;
            request.UpdateInDatabase();

            control.ContextMenuStrip = contextMenuStrip_Occasion;

        }
    }

    class FreeTime
    {
        string name;
        public FreeTime(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
