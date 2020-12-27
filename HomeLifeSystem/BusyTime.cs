using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    class BusyTime
    {
        int iD;
        string name;
        string type;
        string description;
        string frequency;
        TimeSpan startTime;
        TimeSpan endTime;
        int personID;

        public BusyTime(string name, string type, string description, string frequency, int personID, TimeSpan startTime, TimeSpan endTime)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.frequency = frequency;
            this.personID = personID;
            this.StartTime = startTime;
            this.EndTime = endTime;

            AddToDatabase();
        }

        public BusyTime(int iD, string name, string type, string description, string frequency, int personID, TimeSpan startTime, TimeSpan endTime)
        {
            this.iD = iD;
            this.name = name;
            this.type = type;
            this.description = description;
            this.frequency = frequency;
            this.personID = personID;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public string Frequency { get => frequency; set => frequency = value; }
        public int PersonID { get => personID; set => personID = value; }
        public TimeSpan StartTime { get => startTime; set => startTime = value; }
        public TimeSpan EndTime { get => endTime; set => endTime = value; }

        public bool AddToDatabase()
        {
            ID = Database.BusyTimeTableAdd(this);

            return true;
        }

        public bool UpdateInDatabase()
        {
            Database.BusyTimeTableUpdate(this);

            return true;
        }

        public bool RemoveFromDatabase()
        {
            Database.BusyTimeTableRemove(this);

            return true;
        }




    }
}
