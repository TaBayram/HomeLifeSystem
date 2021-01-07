using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{
    class Bill
    {
        int iD;
        string name;
        string type;
        int cost;
        string currency;
        DateTime paymentDue;
        int homeID;
        int frequency;

        public Bill(string name, string type, int cost, string currency, DateTime paymentDue, int frequency,int homeID)
        {
            Name = name;
            Type = type;
            Cost = cost;
            Currency = currency;
            PaymentDue = paymentDue;
            Frequency = frequency;
            HomeID = homeID;

            AddToDatabase();
           
        }

        public Bill(int iD, string name, string type, int cost, string currency, DateTime paymentDue, int homeID, int frequency)
        {
            this.iD = iD;
            this.name = name;
            this.type = type;
            this.cost = cost;
            this.currency = currency;
            this.paymentDue = paymentDue;
            this.homeID = homeID;
            this.frequency = frequency;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Currency { get => currency; set => currency = value; }
        public DateTime PaymentDue { get => paymentDue; set => paymentDue = value; }
        public int HomeID { get => homeID; set => homeID = value; }
        public int Frequency { get => frequency; set => frequency = value; }

        public bool AddToDatabase()
        {
            ID = Database.BillTableAdd(this);

            return true;
        }

        public bool UpdateInDatabase()
        {
            Database.BillTableUpdate(this);

            return true;
        }

        public bool RemoveFromDatabase()
        {
            Database.BillTableRemove(this);

            return true;
        }


    }
}
