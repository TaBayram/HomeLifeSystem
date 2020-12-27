using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeLifeSystem
{
    public class Person
    {
        int iD;
        string nickname;
        string name;
        string surname;
        string gender;
        int homeID;
        int calendarID;
        DateTime birthday;
        CalendarEvent calendar;
        List<Note> notes = new List<Note>();
        List<BusyTime> busyTimes = new List<BusyTime>();
        
        //SIGN UP
        public Person(string nickname, string name, string surname, string gender, DateTime birthday,string password)
        {
            this.nickname = nickname;
            this.name = name; 
            this.surname = surname; 
            this.gender = gender;
            this.birthday = birthday;


            calendar = new CalendarEvent(this);
            AddToDatabase(password);
            
        }

        //CASUAL PERSON OBJECT
        public Person(string nickname, string name, string surname, string gender, DateTime birthday)
        {
            this.nickname = nickname;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.birthday = birthday;

        }

        public Person(int id, string nickname, string name, string surname, string gender, DateTime birthday, int homeID=0)
        {
            this.ID = id;
            this.nickname = nickname;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.birthday = birthday;
            this.HomeID = homeID;

            calendar = new CalendarEvent(this);
        }

        public string Nickname { get => nickname; set => nickname = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int ID { get => iD; set => iD = value; }
        public CalendarEvent Calendar { get => calendar; set => calendar = value; }
        public int HomeID { get => homeID; set => homeID = value; }
        internal List<BusyTime> BusyTimes { get => busyTimes; set => busyTimes = value; }
        public int CalendarID { get => calendarID; set => calendarID = value; }
        public List<Note> Notes { get => notes; set => notes = value; }

        private void AddToDatabase(string password)
        {
            this.ID = Database.PersonTableAdd(this, password);

        }
        public void RemoveFromDatabase()
        {
            Database.PersonTableRemove(this);
        }
        public void UpdateInDatabase(string password)
        {
            Database.UpdatePerson(this, password);
        }
        public Home JoinHome(int homeID)
        {
            if (Database.DoesHomeExist(homeID))
            {
                Home home = Database.GetHomeByID(homeID);
                HomeID = homeID;
                Database.JoinHome(ID, homeID);
            }
            return null;
        }
        public void LeaveHome(Home home)
        {
            if (home != null) home.RemoveFromDatabase();

            Database.LeaveHome(this);

        }
        public bool SignIn(MainScreen mainScreen)
        {
            BusyTimes = Database.BusyTimeTableGetByID(ID);
            ViewCalendar();
            ViewNotes();
            


            if (Database.DoesHomeExist(homeID))
            {
                mainScreen.home = Database.GetHomeByID(homeID);
                return true;
            }
            return false;
        }

        public void SignOut(MainScreen mainScreen)
        {
            Program.CreateSignScreen();
            mainScreen.Close();
        }

        private void ViewCalendar()
        {
            Calendar = Database.CalendarEventTableGet(this);
        }
        private void ViewNotes()
        {
            Notes = Database.NoteTableGetByID(0, this.ID);
        }

        public string GetPassword()
        {
            return Database.GetPersonPassword(this);
        }
    }
}
