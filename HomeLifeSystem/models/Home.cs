using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    public class Home
    {
        int iD;
        string name;
        string address;
        int creatorID;
        int calendarID;
        CalendarEvent calendar;
        List<Bill> bills = new List<Bill>();
        List<BusyTime> busyTimes = new List<BusyTime>();
        List<Chore> chores = new List<Chore>();
        List<Event> events = new List<Event>();
        List<Housework> houseworks = new List<Housework>();
        List<Note> notes = new List<Note>();
        List<Person> household = new List<Person>();
        List<Request> requests = new List<Request>();
        List<Room> rooms = new List<Room>();


        public Home(Person creator, string name, List<Room> rooms, string address)
        {
            this.Household.Add(creator);
            this.CreatorID = creator.ID;
            this.Name = name;
            this.Address = address;
            this.Rooms.AddRange(rooms);

            AddToDatabase();
        }

        public Home(int ID, string name, string address, int creatorID, int calendarID)
        {
            this.ID = ID;
            this.Name = name;
            this.Address = address;
            this.CreatorID = creatorID;
            this.CalendarID = calendarID;

            calendar = new CalendarEvent(this);
        }


        public CalendarEvent Calendar { get => calendar; set => calendar = value; }
        public int CalendarID { get => calendarID; set => calendarID = value; }
        public int CreatorID { get => creatorID; set => creatorID = value; }
        public int ID { get => iD; set => iD = value; }
        internal List<Bill> Bills { get => bills; set => bills = value; }
        internal List<BusyTime> BusyTimes { get => busyTimes; set => busyTimes = value; }
        internal List<Chore> Chores { get => chores; set => chores = value; }
        internal List<Event> Events { get => events; set => events = value; }
        internal List<Housework> Houseworks { get => houseworks; set => houseworks = value; }
        internal List<Note> Notes { get => notes; set => notes = value; }
        internal List<Person> Household { get => household; set => household = value; }
        internal List<Request> Requests { get => requests; set => requests = value; }
        internal List<Room> Rooms { get => rooms; set => rooms = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        

        public bool AddToDatabase()
        {

            this.ID = Database.HomeTableAdd(Name, Address, CreatorID);
            calendar = new CalendarEvent(this);
            foreach (Room room in rooms)
            {
                room.HomeID = ID;
                room.AddToDatabase();
            }
            
            return true;
        }
        public bool RemoveFromDatabase()
        {
            Database.HomeTableRemove(this);

            return true;
        }
    }

    public class Room
    {
        int iD;
        string name;
        string type;
        int homeID;

        public Room(string name, string type)
        {
            this.Name = name;
            this.type = type;
        }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int ID { get => iD; set => iD = value; }
        public int HomeID { get => homeID; set => homeID = value; }

        public bool AddToDatabase()
        {
            ID = Database.RoomTableAdd(name, type, HomeID);
            return true;
        }

        public bool RemoveFromDatabase()
        {
            return Database.RoomTableRemove(this);
        }

    }
}
