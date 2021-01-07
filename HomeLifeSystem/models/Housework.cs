using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    class Housework : Chore
    {
        int iDh;

        List<string> answers;
        public Housework(List<string> answers,Chore chore) : base(chore.ID,chore.Name,chore.Type,chore.Description,chore.Frequency,chore.Questions,chore.HomeID)
        {
            this.Answers = answers;
        }
        public List<string> Answers { get => answers; set => answers = value; }
        public int IDh { get => iDh; set => iDh = value; }

        public new bool AddToDatabase()
        {
            this.IDh = Database.HouseworkTableAdd(this);
            return true;
        }
        public new bool UpdateInDatabase()
        {
            Database.HouseworkTableUpdate(this);
            return true;
        }
        public new bool RemoveFromDatabase()
        {
            Database.HouseworkTableRemove(this);
            return true;
        }

    }
}
