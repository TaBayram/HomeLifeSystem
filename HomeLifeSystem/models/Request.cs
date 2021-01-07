using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    class Request
    {
        int iD;
        string name;
        string description;

        int accepterID;
        string accepterName;

        int homeID;

        public Request(string name, string description,int homeID)
        {
            this.name = name;
            this.description = description;
            this.homeID = homeID;

            AddToDatabase();
        }

        public Request(int iD, string name, string description, int homeID, int accepterID=0, string accepterName="")
        {
            this.iD = iD;
            this.name = name;
            this.description = description;
            this.accepterID = accepterID;
            this.accepterName = accepterName;
            this.homeID = homeID;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int AccepterID { get => accepterID; set => accepterID = value; }
        public string AccepterName { get => accepterName; set => accepterName = value; }
        public int HomeID { get => homeID; set => homeID = value; }

        public bool AddToDatabase()
        {
            ID = Database.RequestTableAdd(this);

            return true;
        }

        public bool UpdateInDatabase()
        {
            Database.RequestTableUpdate(this);

            return true;
        }

        public bool RemoveFromDatabase()
        {
            Database.RequestTableRemove(this);

            return true;
        }

    }
}
