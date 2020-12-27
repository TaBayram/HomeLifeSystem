using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    class Event
    {
        int iD;
        string name;
        string type;
        string description;
        int homeID;

        public Event(string name, string type, string description, int homeID)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.HomeID = homeID;

            AddToDatabase();
        }

        public Event(int iD, string name, string type, string description, int homeID)
        {
            this.iD = iD;
            this.name = name;
            this.type = type;
            this.description = description;
            this.homeID = homeID;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public int HomeID { get => homeID; set => homeID = value; }

        public bool AddToDatabase()
        {
            ID = Database.EventTableAdd(this);

            return true;
        }

        public bool UpdateInDatabase()
        {
            Database.EventTableUpdate(this);

            return true;
        }

        public bool RemoveFromDatabase()
        {
            Database.EventTableRemove(this);

            return true;
        }

    }
}
