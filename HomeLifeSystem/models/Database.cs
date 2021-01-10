using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;

namespace HomeLifeSystem
{
    static class Database
    {
        static SqlConnection connection;
        static bool isConnectionOpen = false;
        private static string path = Properties.Settings.Default.connectionPath;

        static Database()
        {

        }

        /* -------------------------- MISC -------------------------- */

        public static bool ConnectToDatabase()
        {
            try
            {
                connection = new SqlConnection(path);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    isConnectionOpen = true;
                }

                return isConnectionOpen;
            }
            catch(Exception e)
            {
                string message = "Could not connect to database! Please check your connection. \n " + e.Message;
                string title = "Connection Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                return isConnectionOpen;
            }
        }

        public static void DisconnectFromDatabase()
        {
            if(isConnectionOpen)
                connection.Close();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                isConnectionOpen = false;
            }
        }

        public static DataTable GetDataTable(string sqlCMD)
        {
            bool selfOpen = false;
            try
            {
                
                if (connection.State != ConnectionState.Open)
                {
                    if (!ConnectToDatabase()) return new DataTable();
                    selfOpen = true;
                }
                SqlCommand command = new SqlCommand(sqlCMD, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch(Exception e)
            {
                DatabaseErrorBox(e.Message);
                return new DataTable();
            }
            finally
            {
                if (selfOpen) DisconnectFromDatabase();
                
            }
           
            
        }

        private static bool RemoveRow(string sqlCMD)
        {
            try
            {
                if (!ConnectToDatabase()) return false;
                SqlCommand command = new SqlCommand(sqlCMD, connection);
                int i = command.ExecuteNonQuery();
                if(i != 0)
                    return true;
                
                return false;
            }
            catch (Exception e)
            {
                DatabaseErrorBox(e.Message);
                return false;
            }
            finally
            {
                DisconnectFromDatabase();

            }
        }



        /* -------------------------- PERSON -------------------------- */

        public static List<Person> PersonTableGetByHomeID(int homeID = 0)
        {
            string sqlCMD = $"SELECT * FROM Person WHERE homeID='{homeID}'";

            DataTable dataTable = GetDataTable(sqlCMD);
            List<Person> people = new List<Person>();

            foreach (DataRow row in dataTable.Rows)
            {
                Person person = new Person(row.Field<String>("nickname"), row.Field<String>("name"), row.Field<String>("surname"),
                    row.Field<String>("gender"), row.Field<DateTime>("birthday"));
                person.ID = row.Field<int>("ID");
                people.Add(person);

            }

            return people;
        }

        public static int PersonTableAdd(Person person, string password)
        {
            if (!ConnectToDatabase()) return 0;

            string sqlFormattedDate = person.Birthday.ToString("yyyy-MM-dd");
            string sqlCMD = "INSERT INTO Person(nickname,name,surname,gender,birthday,password) OUTPUT INSERTED.ID VALUES(@nickname,@name,@surname,@gender,@birthday,@password)";

            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@nickname", person.Nickname);
            command.Parameters.AddWithValue("@name", person.Name);
            command.Parameters.AddWithValue("@surname", person.Surname);
            command.Parameters.AddWithValue("@gender", person.Gender);
            command.Parameters.AddWithValue("@birthday", sqlFormattedDate);
            command.Parameters.AddWithValue("@password", password);

            int personKey = (int)command.ExecuteScalar();

            sqlCMD = $"INSERT INTO CalendarEvent(personID) output INSERTED.ID VALUES ({personKey})";
            command = new SqlCommand(sqlCMD, connection);
            int calendarKey = (int)command.ExecuteScalar();
            person.Calendar.ID = calendarKey;
            person.Calendar.PersonID = person.ID;
            person.Calendar.Ownership = person;
            DisconnectFromDatabase();

            return personKey;
        }

        public static bool UpdatePerson(Person person, string password)
        {
            if (!ConnectToDatabase()) return false;

            string sqlFormattedDate = person.Birthday.ToString("yyyy-MM-dd");
            string sqlCMD = "UPDATE Person " +
                "Set name = @name,surname =@surname,gender=@gender,birthday =@birthday,password =@password " +
                "WHERE ID = @ID";

            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@ID", person.ID);
            command.Parameters.AddWithValue("@name", person.Name);
            command.Parameters.AddWithValue("@surname", person.Surname);
            command.Parameters.AddWithValue("@gender", person.Gender);
            command.Parameters.AddWithValue("@birthday", sqlFormattedDate);
            command.Parameters.AddWithValue("@password", password);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool PersonTableRemove(Person user)
        {
            string sqlCMD = $"DELETE FROM Person WHERE ID={user.ID}";
            bool removed = RemoveRow(sqlCMD);
            sqlCMD = $"DELETE FROM Home WHERE creatorID={user.ID}";
            RemoveRow(sqlCMD);
            return removed;
        }

        public static string DoesPersonExist(string nickname, string password)
        {
            if (!ConnectToDatabase()) return "";

            string sqlCMD = $"SELECT * FROM Person WHERE nickname='{nickname}'";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            string returnString = "";
            if (dataTable.Rows.Count == 1)
            {

                string pass = dataTable.Rows[0]["password"].ToString();
                if (pass == password)
                {
                    returnString = "in";
                }
                else
                    returnString = "Error: Wrong password P";
            }
            else
            {
                returnString = "Error: User does not exist N";
            }

            DisconnectFromDatabase();
            return returnString;

        }

        public static Person GetPersonByNickname(string nickname,bool load = false)
        {
            if (!ConnectToDatabase()) return null;

            string sqlCMD = "SELECT * FROM Person WHERE nickname=(@nickname)";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            command.Parameters.AddWithValue("@nickname", nickname);
            SqlDataReader reader = command.ExecuteReader();

            Person person = null;
            if (reader.HasRows)
            {
                reader.Read();
                int id = int.Parse(reader[0].ToString());
                string name = reader[2].ToString();
                string surname = reader[3].ToString();
                string gender = reader[4].ToString();

                DateTime birthday = (DateTime)reader[5];
                int homeID = int.Parse(reader[7].ToString());

                person = new Person(id, nickname, name, surname, gender, birthday, homeID);
            }

            DisconnectFromDatabase();
            return person;
        }

        public static Person GetPersonByID(int ID)
        {
            if (!ConnectToDatabase()) return null;

            string sqlCMD = "SELECT * FROM Person WHERE ID=(@ID)";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            command.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = command.ExecuteReader();

            Person person = null;
            if (reader.HasRows)
            {
                reader.Read();
                int id = int.Parse(reader[0].ToString());
                string nickname = reader[1].ToString();
                string name = reader[2].ToString();
                string surname = reader[3].ToString();
                string gender = reader[4].ToString();
                DateTime birthday = (DateTime)reader[5];

                person = new Person(id, nickname, name, surname, gender, birthday);
            }

            DisconnectFromDatabase();
            return person;
        }

        public static string GetPersonPassword(Person person)
        {
            if (!ConnectToDatabase()) return "";

            string sqlCMD = $"SELECT password FROM Person WHERE ID={person.ID}";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            SqlDataReader reader = command.ExecuteReader();
            string password = "";
            if (reader.HasRows)
            {
                reader.Read();
                password = reader[0].ToString();
            }

            DisconnectFromDatabase();
            return password;
        }

        public static bool JoinHome(int personID, int homeID)
        {
            if (!ConnectToDatabase()) return false;

            string sqlCMD = $"UPDATE Person Set homeID = {homeID} Where ID = {personID}";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();

            DisconnectFromDatabase();

            return true;
        }

        public static bool LeaveHome(Person user)
        {
            ConnectToDatabase();
            string sqlCMD = $"UPDATE Person SET homeID = 0 WHERE ID ={user.ID}";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();


            return false;
        }



        /* -------------------------- HOME -------------------------- */

        public static int HomeTableAdd(string name, string address, int creatorID)
        {
            if (!ConnectToDatabase()) return 0;

            string sqlCMD = "INSERT INTO Home(name,address,creatorID) output INSERTED.ID  VALUES(@name,@address,@creatorID)";

            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@creatorID", creatorID);


            int homeKey = (int)command.ExecuteScalar();

            sqlCMD = $"INSERT INTO CalendarEvent(homeID) output INSERTED.ID VALUES ({homeKey})";
            command = new SqlCommand(sqlCMD, connection);
            int calendarKey = (int)command.ExecuteScalar();

            sqlCMD = $"UPDATE Home SET calendarID = {calendarKey} WHERE ID = {homeKey} ";
            command = new SqlCommand(sqlCMD, connection);

            command.ExecuteNonQuery();

            sqlCMD = $"UPDATE Person SET homeID = {homeKey} WHERE ID = {creatorID} ";
            command = new SqlCommand(sqlCMD, connection);

            command.ExecuteNonQuery();


            DisconnectFromDatabase();
            return homeKey;
        }

        public static bool DoesHomeExist(int ID)
        {
            if (!ConnectToDatabase()) return false;

            string sqlCMD = $"SELECT * FROM Home WHERE ID='{ID}'";
            DataTable dataTable = new DataTable();
            dataTable = GetDataTable(sqlCMD);
            DisconnectFromDatabase();


            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Home GetHomeByID(int ID)
        {
            if (!ConnectToDatabase()) return null;

            string sqlCMD = $"SELECT * FROM Home WHERE ID='{ID}'";
            DataTable dataTable = new DataTable();
            dataTable = GetDataTable(sqlCMD);
            DisconnectFromDatabase();


            if (dataTable.Rows.Count == 1)
            {
                DataRow[] dataRow = dataTable.Select("ID = " + ID);
                int hID = dataRow[0].Field<int>("ID");
                string name = dataRow[0].Field<String>("name");
                string address = dataRow[0].Field<String>("address");
                int creatorID = dataRow[0].Field<int>("creatorID");
                int calendarID = dataRow[0].Field<int>("calendarID");

                Home home = new Home(hID, name, address, creatorID, calendarID);


                home.Rooms.AddRange(RoomTableGetByID(hID));

                home.Household.AddRange(PersonTableGetByHomeID(hID));

                home.Notes.AddRange(NoteTableGetByID(hID));

                home.Chores.AddRange(ChoreTableGetByID(hID));

                home.Houseworks.AddRange(HouseworkTableGetByID(hID));

                home.Requests.AddRange(RequestTableGetByID(hID));

                home.Events.AddRange(EventTableGetByID(hID));

                home.Calendar.ID = CalendarEventTableGet(home).ID;

                home.BusyTimes = BusyTimeTableGetByHomeID(home.ID);

                home.Bills.AddRange(BillTableGetByID(hID));

                OccasionTableGetByID(hID, home.Calendar);


                return home;
            }
            else
            {
                return null;
            }
        }

        public static bool HomeTableRemove(Home home)
        {
            if (!ConnectToDatabase()) return false;

            string sqlCMD = $"DELETE FROM Home WHERE ID='{home.ID}'";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();

            /*sqlCMD = $"DELETE * FROM Room WHERE homeID='{home.ID}'";
            command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();*/

            sqlCMD = $"UPDATE Person SET homeID = 0 WHERE homeID='{home.ID}'";
            command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();

            /*sqlCMD = $"DELETE * FROM CalendarEvent WHERE homeID='{home.ID}'";
            command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();

            sqlCMD = $"DELETE * FROM Occasion WHERE homeID='{home.ID}'";
            command = new SqlCommand(sqlCMD, connection);
            command.ExecuteNonQuery();*/


            return true;
        }

        /* -------------------------- CALENDAR -------------------------- */

        public static CalendarEvent CalendarEventTableGet(Person person)
        {
            string sqlCMD = $"SELECT * FROM CalendarEvent WHERE personID = {person.ID}";

            return CalendarEventTableGetWithSQL(person, sqlCMD);
        }

        public static CalendarEvent CalendarEventTableGet(Home home)
        {
            string sqlCMD = $"SELECT * FROM CalendarEvent WHERE homeID = {home.ID}";

            return CalendarEventTableGetWithSQL(home, sqlCMD);
        }

        private static CalendarEvent CalendarEventTableGetWithSQL(object owner, string sqlCMD)
        {
            var dataTable = GetDataTable(sqlCMD);
            CalendarEvent calendarEvent = null;

            foreach (DataRow row in dataTable.Rows)
            {
                int homeID,personID;
                if (row.Field<int?>("homeID") == null) homeID = 0;
                else homeID = row.Field<int>("homeID");
                if (row.Field<int?>("personID") == null) personID = 0;
                else personID = row.Field<int>("personID");


                calendarEvent = new CalendarEvent(row.Field<int>("ID"), owner, personID, homeID);
                break;

            }
            return calendarEvent;

        }

        /* -------------------------- ROOM -------------------------- */

        public static List<Room> RoomTableGetByID(int homeID)
        {
            string sqlCMD = $"SELECT * FROM Room WHERE homeID={homeID}";

            DataTable dataTable = GetDataTable(sqlCMD);
            List<Room> rooms = new List<Room>();

            foreach (DataRow row in dataTable.Rows)
            {
                Room room = new Room(row.Field<String>("name"), row.Field<String>("type"));
                room.ID = row.Field<int>("ID");
                room.HomeID = row.Field<int>("homeID");
                rooms.Add(room);
            }

            return rooms;
        }

        public static int RoomTableAdd(string name, string type, int homeID)
        {
            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Room(name,type,homeID) OUTPUT INSERTED.ID VALUES('{name}','{type}',{homeID})";
            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int roomKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return roomKey;
        }

        public static bool RoomTableRemove(Room room)
        {
            string sqlCMD = $"DELETE FROM Room WHERE ID={room.ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- NOTE -------------------------- */

        public static List<Note> NoteTableGetByID(int homeID=0,int personID=0)
        {
            string sqlCMD = $"SELECT * FROM Note WHERE homeID='{homeID}'";
            if(homeID == 0) sqlCMD = $"SELECT * FROM Note WHERE personID='{personID}' AND homeID = 0";

            DataTable dataTable = GetDataTable(sqlCMD);
            List<Note> notes = new List<Note>();

            foreach (DataRow row in dataTable.Rows)
            {
                Note note = new Note(row.Field<int>("ID"), row.Field<String>("author"), row.Field<String>("title"), row.Field<String>("text"),
                    row.Field<DateTime>("createdDate"), row.Field<DateTime>("expiringDate"), homeID, row.Field<int>("personID"));
                if (!note.HasExpired(false))
                    notes.Add(note);

            }

            return notes;
        }

        public static int NoteTableAdd(Note note)
        {
            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Note(author, title, text, createdDate, expiringDate, homeID, personID) OUTPUT INSERTED.ID " +
                $"VALUES('{note.AuthorName}','{note.Title}','{note.Text}','{note.CreatedDate.ToString("yyyy-MM-dd HH:mm")}','{note.ExpiringDate.ToString("yyyy-MM-dd HH:mm")}',{note.HomeID},{note.PersonID})";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int noteKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return noteKey;
        }

        public static bool NoteTableRemove(Note note)
        {
            string sqlCMD = $"DELETE FROM Note WHERE ID={note.ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- CHORE -------------------------- */

        public static List<Chore> ChoreTableGetByID(int homeID)
        {
            string sqlCMD = $"SELECT * FROM Chore WHERE homeID='{homeID}'";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<Chore> chores = new List<Chore>();


            foreach (DataRow row in dataTable.Rows)
            {
                List<String> questions = new List<String>();
                if (row.Field<String>("question1") != "") questions.Add(row.Field<String>("question1"));
                if (row.Field<String>("question2") != "") questions.Add(row.Field<String>("question2"));
                if (row.Field<String>("question3") != "") questions.Add(row.Field<String>("question3"));

                Chore chore = new Chore(row.Field<int>("ID"), row.Field<String>("name"), row.Field<String>("type"), row.Field<String>("description"),
                    row.Field<String>("frequency"), questions, homeID);

                chores.Add(chore);

            }

            return chores;
        }

        public static int ChoreTableAdd(Chore chore)
        {
            string question1 = "";
            string question2 = "";
            string question3 = "";
            if(chore.Questions.Count > 2)
            {
                question1 = chore.Questions[0];
                question2 = chore.Questions[1];
                question3 = chore.Questions[2];
            }
            else if(chore.Questions.Count > 2)
            {
                question1 = chore.Questions[0];
                question2 = chore.Questions[1];
            }
            else if (chore.Questions.Count > 1)
            {
                question1 = chore.Questions[0];
            }

            if (!ConnectToDatabase()) return 0;

            string sqlCMD = $"INSERT INTO Chore(name, type, description, question1, question2, question3, frequency, homeID) OUTPUT INSERTED.ID " +
                $"VALUES('{chore.Name}','{chore.Type}','{chore.Description}','{question1}','{question2}','{question3}','{chore.Frequency}',{chore.HomeID})";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int choreKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return choreKey;
        }

        public static bool ChoreTableUpdate(Chore chore)
        {
            string question1 = "";
            string question2 = "";
            string question3 = "";
            if (chore.Questions.Count > 2)
            {
                question1 = chore.Questions[0];
                question2 = chore.Questions[1];
                question3 = chore.Questions[2];
            }
            else if (chore.Questions.Count > 2)
            {
                question1 = chore.Questions[0];
                question2 = chore.Questions[1];
            }
            else if (chore.Questions.Count > 1)
            {
                question1 = chore.Questions[0];
            }


            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE Chore SET name=@name, type=@type, description=@description, question1=@question1, question2=@question2, question3=@question3,frequency=@frequency homeID=@homeID WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@ID", chore.ID);
            command.Parameters.AddWithValue("@name", chore.Name);
            command.Parameters.AddWithValue("@type", chore.Type);
            command.Parameters.AddWithValue("@description", chore.Description);
            command.Parameters.AddWithValue("@frequency", chore.Frequency);
            command.Parameters.AddWithValue("@homeID", chore.HomeID);
            command.Parameters.AddWithValue("@question1", question1);
            command.Parameters.AddWithValue("@question2", question2);
            command.Parameters.AddWithValue("@question3", question3);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool ChoreTableRemove(Chore chore)
        {
            string sqlCMD = $"DELETE FROM Chore WHERE ID={chore.ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- HOUSEWORK -------------------------- */

        public static List<Housework> HouseworkTableGetByID(int homeID)
        {
            string sqlCMD = $"SELECT * FROM Housework WHERE homeID='{homeID}'";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<Housework> houseworks = new List<Housework>();
            List<Chore> chores = ChoreTableGetByID(homeID);

            foreach (DataRow row in dataTable.Rows)
            {
                List<String> answers = new List<String>();
                answers.Add(row.Field<String>("answer1"));
                answers.Add(row.Field<String>("answer2"));
                answers.Add(row.Field<String>("answer3"));
                int choreID = row.Field<int>("choreID");

                foreach (Chore chore in chores)
                {
                    if (chore.ID == choreID)
                    {
                        Housework housework = new Housework(answers, chore);
                        housework.IDh = row.Field<int>("ID");
                        houseworks.Add(housework);
                        break;
                    }
                }


            }

            return houseworks;
        }

        public static int HouseworkTableAdd(Housework housework)
        {
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            if (housework.Answers.Count > 2)
            {
                answer1 = housework.Answers[0];
                answer2 = housework.Answers[1];
                answer3 = housework.Answers[2];
            }
            else if (housework.Answers.Count > 2)
            {
                answer1 = housework.Answers[0];
                answer2 = housework.Answers[1];
            }
            else if (housework.Answers.Count > 1)
            {
                answer3 = housework.Answers[0];
            }


            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Housework(choreID, answer1, answer2, answer3,homeID) OUTPUT INSERTED.ID " +
                $"VALUES ({housework.ID}, '{answer1}', '{answer2}', '{answer3}', {housework.HomeID})";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int houseworkKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return houseworkKey;
        }

        public static bool HouseworkTableUpdate(Housework housework)
        {
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            if (housework.Answers.Count > 2)
            {
                answer1 = housework.Answers[0];
                answer2 = housework.Answers[1];
                answer3 = housework.Answers[2];
            }
            else if (housework.Answers.Count > 2)
            {
                answer1 = housework.Answers[0];
                answer2 = housework.Answers[1];
            }
            else if (housework.Answers.Count > 1)
            {
                answer3 = housework.Answers[0];
            }


            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE Housework SET answer1=@answer1, answer2=@answer2, answer3=@answer3 WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@answer1", answer1);
            command.Parameters.AddWithValue("@answer2", answer2);
            command.Parameters.AddWithValue("@answer3", answer3);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool HouseworkTableRemove(Housework housework)
        {
            string sqlCMD = $"DELETE FROM housework WHERE ID={housework.IDh}";
            return RemoveRow(sqlCMD);
        }

        public static bool HouseworkTableRemove(int ID)
        {
            string sqlCMD = $"DELETE FROM housework WHERE ID={ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- OCCASION -------------------------- */

        public static void OccasionTableGetByID(int homeID, CalendarEvent calendar)
        {

            string sqlCMD = $"SELECT * FROM Occasion where calendarID IN (SELECT calendarID From Home Where ID = {homeID})";
            DataTable dataTable = GetDataTable(sqlCMD);


            List<Housework> houseworks = HouseworkTableGetByID(homeID);
            List<Request> requests = RequestTableGetByID(homeID);
            List<Event> events = EventTableGetByID(homeID);
            


            foreach (DataRow row in dataTable.Rows)
            {
                if (row.Field<int?>("houseworkID") != null && row.Field<int?>("houseworkID") != 0)
                {
                    foreach (Housework housework in houseworks)
                    {
                        if (housework.IDh == row.Field<int>("houseworkID"))
                        {
                            calendar.AddOccasions(housework, row.Field<DateTime>("startdate"), row.Field<DateTime>("enddate"), GetPersonByID(row.Field<int>("personID")), row.Field<int>("ID"));
                        }
                    }
                }
                else if (row.Field<int?>("requestID") != null && row.Field<int?>("requestID") != 0)
                {
                    foreach (Request request in requests)
                    {
                        if (request.ID == row.Field<int>("requestID"))
                        {
                            calendar.AddOccasions(request, row.Field<DateTime>("startdate"), row.Field<DateTime>("enddate"), GetPersonByID(row.Field<int>("personID")), row.Field<int>("ID"));
                        }
                    }
                }
                else if (row.Field<int?>("eventID") != null && row.Field<int?>("eventID") != 0)
                {
                    foreach (Event @event in events)
                    {
                        if (@event.ID == row.Field<int>("eventID"))
                        {
                            calendar.AddOccasions(@event, row.Field<DateTime>("startdate"), row.Field<DateTime>("enddate"), GetPersonByID(row.Field<int>("personID")), row.Field<int>("ID"));
                        }
                    }
                }


            }


        }

        public static int OccasionTableAdd(List<object> occasion, int calendarID)
        {

            string occasionNameID = "";
            int occasionID = 0;
            if (occasion[0].GetType() == typeof(Housework))
            {
                occasionNameID = "houseworkID";
                occasionID = ((Housework)occasion[0]).IDh;
            }
            else if (occasion[0].GetType() == typeof(Request))
            {
                occasionNameID = "requestID";
                occasionID = ((Request)occasion[0]).ID;
            }
            else if (occasion[0].GetType() == typeof(BusyTime))
            {
                occasionNameID = "BusyTimeID";
                occasionID = ((BusyTime)occasion[0]).ID;
            }
            else if (occasion[0].GetType() == typeof(Event))
            {
                occasionNameID = "EventID";
                occasionID = ((Event)occasion[0]).ID;
            }
            string startdate = ((DateTime)occasion[1]).ToString("yyyy-MM-dd HH:mm");
            string enddate = ((DateTime)occasion[2]).ToString("yyyy-MM-dd HH:mm");


            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Occasion(calendarID, startdate, enddate, personID,{occasionNameID}) OUTPUT INSERTED.ID " +
                $"VALUES ({calendarID},'{startdate}','{enddate}',{((Person)occasion[3]).ID},{occasionID})";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int occasionKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return occasionKey;
        }

        public static bool OccasionTableUpdate(Housework housework)
        {
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            if (housework.Answers.Count > 2)
            {
                answer1 = housework.Answers[0];
                answer2 = housework.Answers[1];
                answer3 = housework.Answers[2];
            }
            else if (housework.Answers.Count > 2)
            {
                answer1 = housework.Answers[0];
                answer2 = housework.Answers[1];
            }
            else if (housework.Answers.Count > 1)
            {
                answer3 = housework.Answers[0];
            }


            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE Housework SET answer1=@answer1, answer2=@answer2, answer3=@answer3 WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@answer1", answer1);
            command.Parameters.AddWithValue("@answer2", answer2);
            command.Parameters.AddWithValue("@answer3", answer3);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool OccasionTableRemove(List<object> occasion)
        {
            string sqlCMD = $"DELETE FROM Occasion WHERE ID={occasion[4]}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- REQUEST -------------------------- */

        public static List<Request> RequestTableGetByID(int homeID)
        {

            string sqlCMD = $"SELECT * FROM Request WHERE homeID='{homeID}'";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<Request> requests = new List<Request>();


            foreach (DataRow row in dataTable.Rows)
            {
                Request request = new Request(row.Field<int>("ID"), row.Field<string>("Name"), row.Field<string>("Description"), row.Field<int>("homeID"), row.Field<int>("accepterID"), row.Field<string>("accepterName"));
                requests.Add(request);
            }

            return requests;
        }

        public static int RequestTableAdd(Request request)
        {
            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Request(name, description,homeID) OUTPUT INSERTED.ID " +
                $"VALUES ('{request.Name}', '{request.Description}', {request.HomeID})";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int requestKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return requestKey;
        }

        public static bool RequestTableUpdate(Request request)
        {

            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE Request SET name=@name, description=@description, accepterID = @accepterID, accepterName = @accepterName WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@name", request.Name);
            command.Parameters.AddWithValue("@description", request.Description);
            command.Parameters.AddWithValue("@accepterID", request.AccepterID);
            command.Parameters.AddWithValue("@accepterName", request.AccepterName);
            command.Parameters.AddWithValue("@ID", request.ID);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool RequestTableRemove(Request request)
        {
            string sqlCMD = $"DELETE FROM Request WHERE ID={request.ID}";
            return RemoveRow(sqlCMD);
        }

        public static bool RequestTableRemove(int ID)
        {
            string sqlCMD = $"DELETE FROM Request WHERE ID={ID} DELETE FROM Occasion WHERE requestID = {ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- EVENT -------------------------- */

        public static List<Event> EventTableGetByID(int homeID)
        {

            string sqlCMD = $"SELECT * FROM Event WHERE homeID='{homeID}'";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<Event> events = new List<Event>();


            foreach (DataRow row in dataTable.Rows)
            {
                Event @event = new Event(row.Field<int>("ID"), row.Field<string>("Name"), row.Field<string>("Type"), row.Field<string>("Description"), row.Field<int>("homeID"));
                events.Add(@event);
            }

            return events;
        }

        public static int EventTableAdd(Event @event)
        {

            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Event(name, type, description,homeID) OUTPUT INSERTED.ID " +
                $"VALUES ('{@event.Name}','{@event.Type}', '{@event.Description}', {@event.HomeID})";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int eventKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return eventKey;
        }

        public static bool EventTableUpdate(Event @event)
        {

            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE Event SET name=@name, description=@description, type = @type WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@name", @event.Name);
            command.Parameters.AddWithValue("@description", @event.Description);
            command.Parameters.AddWithValue("@type", @event.Type);
            command.Parameters.AddWithValue("@ID", @event.ID);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool EventTableRemove(Event @event)
        {
            string sqlCMD = $"DELETE FROM Event WHERE ID={@event.ID} DELETE FROM Occasion WHERE eventID = {@event.ID}";
            return RemoveRow(sqlCMD);
        }
        public static bool EventTableRemove(int ID)
        {
            string sqlCMD = $"DELETE FROM Event WHERE ID={ID} DELETE FROM Occasion WHERE eventID = {ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- BUSYTIME -------------------------- */

        public static List<BusyTime> BusyTimeTableGetByID(int personID)
        {
            
            string sqlCMD = $"SELECT * FROM BusyTime WHERE personID='{personID}'";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<BusyTime> busyTimes = new List<BusyTime>();
            

            foreach (DataRow row in dataTable.Rows)
            {
                BusyTime busyTime = new BusyTime(row.Field<int>("ID"), row.Field<string>("Name"), row.Field<string>("Type"), row.Field<string>("Description"), row.Field<string>("Frequency"), row.Field<int>("personID"), row.Field<TimeSpan>("startTime"), row.Field<TimeSpan>("endTime"));
                busyTimes.Add(busyTime);
            }


            return busyTimes;
        }

        public static List<BusyTime> BusyTimeTableGetByHomeID(int homeID)
        {

            string sqlCMD = $"SELECT * FROM BusyTime WHERE personID IN (Select ID from Person WHERE homeID = {homeID})";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<BusyTime> busyTimes = new List<BusyTime>();


            foreach (DataRow row in dataTable.Rows)
            {
                BusyTime busyTime = new BusyTime(row.Field<int>("ID"), row.Field<string>("Name"), row.Field<string>("Type"), row.Field<string>("Description"), row.Field<string>("Frequency"), row.Field<int>("personID"), row.Field<TimeSpan>("startTime"), row.Field<TimeSpan>("endTime"));
                busyTimes.Add(busyTime);
            }


            return busyTimes;
        }

        public static int BusyTimeTableAdd(BusyTime busyTime)
        {


            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO BusyTime(name, type, description,frequency,personID,startTime,endTime) OUTPUT INSERTED.ID " +
                $"VALUES ('{busyTime.Name}','{busyTime.Type}', '{busyTime.Description}','{busyTime.Frequency}', {busyTime.PersonID}, '{busyTime.StartTime}', '{busyTime.EndTime}')";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int busyTimeKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return busyTimeKey;
        }

        public static bool BusyTimeTableUpdate(BusyTime busyTime)
        {

            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE BusyTime SET name=@name, description=@description, type =@type, frequency =@frequency,startTime=@startTime,endTime =@endTime  WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@ID", busyTime.ID);
            command.Parameters.AddWithValue("@name", busyTime.Name);
            command.Parameters.AddWithValue("@description", busyTime.Description);
            command.Parameters.AddWithValue("@type", busyTime.Type);
            command.Parameters.AddWithValue("@frequency", busyTime.Frequency);
            command.Parameters.AddWithValue("@personID", busyTime.PersonID);
            command.Parameters.AddWithValue("@startTime", busyTime.StartTime);
            command.Parameters.AddWithValue("@endTime", busyTime.EndTime);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool BusyTimeTableRemove(BusyTime busyTime)
        {
            string sqlCMD = $"DELETE FROM BusyTime WHERE ID={busyTime.ID}";
            return RemoveRow(sqlCMD);
        }

        public static bool BusyTimeTableRemove(int ID)
        {
            string sqlCMD = $"DELETE FROM BusyTime WHERE ID={ID}";
            return RemoveRow(sqlCMD);
        }

        /* -------------------------- BUSYTIME -------------------------- */

        public static List<Bill> BillTableGetByID(int homeID)
        {

            string sqlCMD = $"SELECT * FROM Bill WHERE homeID='{homeID}'";
            DataTable dataTable = GetDataTable(sqlCMD);
            List<Bill> bills = new List<Bill>();


            foreach (DataRow row in dataTable.Rows)
            {
                Bill bill = new Bill(row.Field<int>("ID"), row.Field<string>("Name"), row.Field<string>("Type"), row.Field<int>("cost"), row.Field<string>("currency"), row.Field<DateTime>("paymentDue"), row.Field<int>("homeID"), row.Field<int>("frequency"));
                bills.Add(bill);
            }


            return bills;
        }

        public static int BillTableAdd(Bill bill)
        {

            string sqlFormattedDate = bill.PaymentDue.ToString("yyyy-MM-dd");
            if (!ConnectToDatabase()) return 0;
            string sqlCMD = $"INSERT INTO Bill(name, type, cost,currency,paymentDue,homeID,frequency) OUTPUT INSERTED.ID " +
                $"VALUES ('{bill.Name}','{bill.Type}', {bill.Cost},'{bill.Currency}', '{sqlFormattedDate}', {bill.HomeID},'{bill.Frequency}')";

            SqlCommand command = new SqlCommand(sqlCMD, connection);
            int billKey = (int)command.ExecuteScalar();

            DisconnectFromDatabase();
            return billKey;
        }

        public static bool BillTableUpdate(Bill bill)
        {

            if (!ConnectToDatabase()) return false;
            string sqlCMD = "UPDATE Bill SET name=@name, type =@type, cost =@cost,currency=@currency,paymentDue =@paymentDue,frequency =@frequency WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlCMD, connection);

            command.Parameters.AddWithValue("@ID", bill.ID);
            command.Parameters.AddWithValue("@name", bill.Name);
            command.Parameters.AddWithValue("@cost", bill.Cost);
            command.Parameters.AddWithValue("@type", bill.Type);
            command.Parameters.AddWithValue("@currency", bill.Currency);
            command.Parameters.AddWithValue("@homeID", bill.HomeID);
            command.Parameters.AddWithValue("@paymentDue", bill.PaymentDue);
            command.Parameters.AddWithValue("@frequency", bill.Frequency);

            command.ExecuteNonQuery();

            DisconnectFromDatabase();
            return true;
        }

        public static bool BillTableRemove(Bill bill)
        {
            string sqlCMD = $"DELETE FROM Bill WHERE ID={bill.ID}";
            return RemoveRow(sqlCMD);
        }



        /* ------------------------- MISC ----------------------*/

        public static void DatabaseErrorBox(string message)
        {
            string title = "Database Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
        }

        public static void WriteConfigParameter(string key, string value)
        {

            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                configuration.AppSettings.Settings[key].Value = value;
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch(Exception e)
            {
                DatabaseErrorBox(e.Message);
                
            }
        }
        public static string ReadConfigParameter(string key)
        {

            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                return configuration.AppSettings.Settings[key].Value;
            }
            catch (Exception e)
            {
                DatabaseErrorBox(e.Message);
                return null;
            }
        }



        public static string ReadConnectionConfig()
        {
            return Properties.Settings.Default.connectionPath;
        }

        public static bool CreateDatabase(string sqlScript, string connection)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connection);
                sqlConnection.Open();

                if(sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    List<string> sqlScripts = new List<string>();
                    sqlScripts.AddRange(Regex.Split(input: sqlScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase));

                    foreach (string script in sqlScripts)
                    {
                        if (!string.IsNullOrWhiteSpace(script))
                        {
                            SqlCommand sqlCommand = new SqlCommand(script, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    return true;

                }
                else
                {
                    DatabaseErrorBox("Couldn't connect to server");
                    return false;
                }

            }
            catch(Exception e)
            {
                if(e.HResult == -2146232060)
                {
                    return false;
                }
                DatabaseErrorBox(e.Message);

                return false;
            }
        }
    }
}

