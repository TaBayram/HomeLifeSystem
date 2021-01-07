using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeLifeSystem
{
    public class Chore
    {
        int iD;
        int homeID;
        string name;
        string type;
        string description;
        string frequency;
        List<string> questions = new List<string>();

        // Daily: D
        // Weekly: MoTuWeThFrSaSu
        // Monthly: 1-31
        //Cleaning, Cooking, Laundry, Dishes, Shopping, Caring Pet, Yardwork, Car, Other

        public Chore(string name, string type, string description, string frequency, List<string> questions, int homeID)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.questions = questions;
            this.frequency = frequency;
            this.homeID = homeID;
        }

        public Chore(int ID, string name, string type, string description, string frequency, List<string> questions, int homeID)
        {
            this.iD = ID;
            this.name = name;
            this.type = type;
            this.description = description;
            this.questions = questions;
            this.frequency = frequency;
            this.homeID = homeID;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public List<string> Questions { get => questions; set => questions = value; }
        public string Frequency { get => frequency; set => frequency = value; }
        public int ID { get => iD; set => iD = value; }
        public int HomeID { get => homeID; set => homeID = value; }

        public bool AddToDatabase()
        {
            this.ID = Database.ChoreTableAdd(this);
            return true;
        }
        public bool UpdateInDatabase()
        {
            Database.ChoreTableUpdate(this);
            return true;
        }
        public bool RemoveFromDatabase()
        {
            Database.ChoreTableRemove(this);
            return true;
        }
    }
}
