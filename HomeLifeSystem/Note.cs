using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    public class Note
    {
        int iD;
        string authorName;
        string title    ;
        string text;
        string type;
        DateTime createdDate;
        DateTime expiringDate;
        int homeID;
        int personID;

        public Note(string authorName, string title, string text, string type, DateTime expiringDate, int homeID=0, int personID=0)
        {
            AuthorName = authorName;
            Title = title;
            Text = text;
            Type = type;
            ExpiringDate = expiringDate;
            CreatedDate = DateTime.Now;
            this.homeID = homeID;
            if (type == "Private") this.homeID = 0;
            this.personID = personID;

            AddToDatabase();
        }
        public Note(int ID, string authorName, string title, string text, DateTime createdDate, DateTime expiringDate, int homeID,int personID)
        {
            this.ID = ID;
            AuthorName = authorName;
            Title = title;
            Text = text;
            Type = type;
            ExpiringDate = expiringDate;
            CreatedDate = createdDate;
            this.homeID = homeID;
            this.personID = personID;
        }

        public string Title { get => title; set => title = value; }
        public string Text { get => text; set => text = value; }
        public string Type { get => type; set => type = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime ExpiringDate { get => expiringDate; set => expiringDate = value; }
        public int ID { get => iD; set => iD = value; }
        public int HomeID { get => homeID; set => homeID = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public int PersonID { get => personID; set => personID = value; }

        public bool AddToDatabase()
        {
            this.ID = Database.NoteTableAdd(this);

            return true;
        }

        public bool RemoveFromDatabase()
        {
            Database.NoteTableRemove(this);

            return true;
        }

        public bool HasExpired(bool readOnly = true)
        {
            double totalSeconds = Math.Round((ExpiringDate - DateTime.Now).TotalSeconds);
            if (totalSeconds > 0) return false;
            if (!readOnly) RemoveFromDatabase();
            return true;
        }
    }
}
