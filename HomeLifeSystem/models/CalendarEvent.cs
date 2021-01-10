using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLifeSystem
{

    public class CalendarEvent
    {

        object ownership;
        int iD;
        int homeID;
        int personID;
        List<List<Object>> occasions = new List<List<Object>>();

        public int ID { get => iD; set => iD = value; }
        public int HomeID { get => homeID; set => homeID = value; }
        public int PersonID { get => personID; set => personID = value; }
        public object Ownership { get => ownership; set => ownership = value; }
        public List<List<object>> Occasions { get => occasions; set => occasions = value; }

        public CalendarEvent(object ownership)
        {
            this.Ownership = ownership;

            if(ownership.GetType() == typeof(Person))
            {
                var person = ((Person)ownership);
                ID = person.CalendarID;
                personID = person.ID;
            }
            else if (ownership.GetType() == typeof(Home))
            {
                var home = ((Home)ownership);
                ID = home.CalendarID;
                homeID = home.ID;
            }


        }

        public CalendarEvent(int iD,object ownership, int homeID=0, int personID=0)
        {
            this.iD = iD;
            this.homeID = homeID;
            this.personID = personID;
            this.ownership = ownership;
        }

        
        public void AddOccasions(Object instance, DateTime startTime, DateTime finishTime, Person person)
        {
            List<Object> occasion = new List<Object>();
            occasion.Add(instance);
            occasion.Add(startTime);
            occasion.Add(finishTime);
            occasion.Add(person);
            occasion.Add(Database.OccasionTableAdd(occasion,ID));

            Occasions.Add(occasion);

            //occasions = occasions.OrderBy(k => k);
            Occasions = Occasions.OrderBy(o => o[1]).ToList();
        }

        public void AddOccasions(Object instance, DateTime startTime, DateTime finishTime, Person person,int ID)
        {
            List<Object> occasion = new List<Object>();
            occasion.Add(instance);
            occasion.Add(startTime);
            occasion.Add(finishTime);
            occasion.Add(person);
            occasion.Add(ID);

            Occasions.Add(occasion);

            //occasions = occasions.OrderBy(k => k);
            Occasions = Occasions.OrderBy(o => o[1]).ToList();
        }

        public List<Object> GetOccasionsByType(Type type)
        {
            List<Object> choreList = new List<Object>();

            foreach (List<Object> occasion in Occasions)
            {
                if (occasion[0].GetType() == type)
                {
                    choreList.Add(occasion);
                }
            }
            return choreList;
        }

        public string GetOccasionName(List<Object> occasion)
        {
            string name = "NA";

            var item = occasion;
            if(item == occasion)
            {
                if (item[0].GetType() == typeof(Chore))
                {
                    Chore chore = item[0] as Chore;
                    name = chore.Name;
                }
                else if (item[0].GetType() == typeof(Housework))
                {
                    Housework housework = item[0] as Housework;
                    name = housework.Name;
                }
                else if (item[0].GetType() == typeof(Request))
                {
                    Request request = item[0] as Request;
                    name = request.Name;
                }
                else if (item[0].GetType() == typeof(BusyTime))
                {
                    BusyTime busyTime = item[0] as BusyTime;
                    name = busyTime.Name;
                }
                else if (item[0].GetType() == typeof(Event))
                {
                    Event @event = item[0] as Event;
                    name = @event.Name;
                }
                else if (item[0].GetType() == typeof(Request))
                {
                    Request request = item[0] as Request;
                    name = request.Name;
                }
                else if (item[0].GetType() == typeof(FreeTime))
                {
                    FreeTime freeTime = item[0] as FreeTime;
                    name = freeTime.Name;
                }

            }
            

            return name;
        }

        public List<List<object>> GetDaysOccasions(DateTime dateDay,Type type = null)
        {
            dateDay = dateDay.Date;
            List<List<object>> list = new List<List<object>>();
            bool foundTheDate = false;
            foreach (List<Object> occasion in Occasions)
            {
                DateTime startingDate = ((DateTime)occasion[1]).Date;
                
                if(startingDate == dateDay)
                {
                    foundTheDate = true;
                    
                    if(type == null || type == occasion[0].GetType())
                    {
                        list.Add(occasion);
                    }


                }
                else if (startingDate != dateDay && foundTheDate)
                {
                    break;
                }
                
            }
            list = list.OrderBy(o => o[1]).ToList();
            return list;
        }

        public void DeleteOccasion(List<Object> occasion)
        {
            Database.OccasionTableRemove(occasion);

            for(int i = 0; i < Occasions.Count; i++)
            {
                if(Occasions[i][4] == occasion[4])
                {
                    Occasions.Remove(Occasions[i]);
                    break;
                }
            }
            
        }


    }
}
