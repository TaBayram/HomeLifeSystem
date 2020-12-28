using System;
using System.Data.SqlClient;
using System.Threading;

namespace DatabaseCreator
{
    class Program
    {
        static SqlConnection connection;
        static void Main(string[] args)
        {
            string path1 = "Server=";
            string path2 = ";Trusted_Connection=True;";
            Console.WriteLine("Please enter your server name: ");
            string sName = Console.ReadLine();
            Console.WriteLine("Please enter the database name [Default: HomeLife]: ");
            string dName = Console.ReadLine();

            string mainPath = "Server=" + sName + ";Trusted_Connection=True;";
            connection = new SqlConnection(mainPath);

            string databasePath = "Server=" + sName + ";Database=" + dName + ";Trusted_Connection=True;";

            try
            {
                
                connection.Open();

                string sqlCMD = "Create Database "+dName;
                Console.WriteLine("Progress");
                if (!ExecuteNonQuery(sqlCMD)) return;
                else
                {
                    connection = new SqlConnection(databasePath);
                    connection.Open();
                    

                    sqlCMD = @"CREATE TABLE [dbo].[Bill](
	                            [ID] [int] IDENTITY(100,1) NOT NULL,
	                            [name] [nvarchar](50) NOT NULL,
	                            [type] [nvarchar](50) NOT NULL,
	                            [cost] [int] NOT NULL,
	                            [currency] [nvarchar](50) NOT NULL,
	                            [paymentDue] [date] NOT NULL,
	                            [homeID] [int] NOT NULL,
	                            [frequency] [int] NOT NULL,
                             CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
                            (
	                            [ID] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                            ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    

                    sqlCMD = @"CREATE TABLE [dbo].[BusyTime](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [name] [nvarchar](16) NOT NULL,
	                        [type] [nvarchar](32) NOT NULL,
	                        [description] [nvarchar](64) NOT NULL,
	                        [frequency] [nvarchar](20) NOT NULL,
	                        [personID] [int] NOT NULL,
	                        [startTime] [time](7) NOT NULL,
	                        [endTime] [time](7) NOT NULL,
                         CONSTRAINT [PK_BusyTime] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[CalendarEvent](
	                        [ID] [int] IDENTITY(1000,2) NOT NULL,
	                        [homeID] [int] NULL,
	                        [personID] [int] NULL,
                         CONSTRAINT [PK_CalendarEvent] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);


                    sqlCMD = @"CREATE TABLE [dbo].[Chore](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [name] [nvarchar](16) NOT NULL,
	                        [type] [nvarchar](32) NOT NULL,
	                        [description] [nvarchar](64) NOT NULL,
	                        [question1] [nvarchar](32) NULL,
	                        [question2] [nvarchar](32) NULL,
	                        [question3] [nvarchar](32) NULL,
	                        [frequency] [nvarchar](32) NOT NULL,
	                        [homeID] [int] NOT NULL,
                            CONSTRAINT [PK_Chore] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Event](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [name] [nvarchar](16) NOT NULL,
	                        [type] [nvarchar](32) NOT NULL,
	                        [description] [nvarchar](64) NOT NULL,
	                        [homeID] [int] NOT NULL,
                         CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Home](
	                        [ID] [int] IDENTITY(1000,1) NOT NULL,
	                        [name] [nvarchar](32) NOT NULL,
	                        [address] [nvarchar](128) NULL,
	                        [calendarID] [int] NULL,
	                        [creatorID] [int] NULL,
                         CONSTRAINT [PK_Home] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Housework](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [answer1] [nvarchar](64) NULL,
	                        [answer2] [nvarchar](64) NULL,
	                        [answer3] [nvarchar](64) NULL,
	                        [choreID] [int] NOT NULL,
	                        [homeID] [int] NOT NULL,
                            CONSTRAINT [PK_Housework] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Note](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [author] [nvarchar](32) NOT NULL,
	                        [title] [nvarchar](32) NOT NULL,
	                        [text] [nvarchar](128) NOT NULL,
	                        [createdDate] [datetime] NOT NULL,
	                        [expiringDate] [datetime] NOT NULL,
	                        [homeID] [int] NULL,
	                        [personID] [int] NULL,
                         CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Occasion](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [calendarID] [int] NOT NULL,
	                        [startdate] [datetime] NOT NULL,
	                        [enddate] [datetime] NOT NULL,
	                        [personID] [int] NOT NULL,
	                        [houseworkID] [int] NULL,
	                        [requestID] [int] NULL,
	                        [eventID] [int] NULL,
                         CONSTRAINT [PK_Occasion] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Person](
	                        [ID] [int] IDENTITY(1000,1) NOT NULL,
	                        [nickname] [nvarchar](50) NOT NULL,
	                        [name] [nvarchar](50) NOT NULL,
	                        [surname] [nvarchar](50) NOT NULL,
	                        [gender] [nvarchar](50) NOT NULL,
	                        [birthday] [datetime] NOT NULL,
	                        [password] [nvarchar](50) NOT NULL,
	                        [homeID] [int] NULL,
                         CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Request](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [name] [nvarchar](16) NOT NULL,
	                        [description] [nvarchar](64) NOT NULL,
	                        [accepterID] [int] NULL,
	                        [accepterName] [nvarchar](50) NULL,
	                        [homeID] [int] NOT NULL,
                         CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"CREATE TABLE [dbo].[Room](
	                        [ID] [int] IDENTITY(100,1) NOT NULL,
	                        [name] [nvarchar](32) NOT NULL,
	                        [type] [nvarchar](32) NOT NULL,
	                        [homeID] [int] NOT NULL,
                         CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
                        (
	                        [ID] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                        ) ON [PRIMARY]";
                    ExecuteNonQuery(sqlCMD);

                    sqlCMD = @"ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_homeID]  DEFAULT ((0)) FOR [homeID]
                            
                            ALTER TABLE [dbo].[Request] ADD  CONSTRAINT [DF_Request_acccepterID]  DEFAULT ((0)) FOR [accepterID]
                            
                            ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Home]
                            
                            ALTER TABLE [dbo].[BusyTime]  WITH CHECK ADD  CONSTRAINT [FK_BusyTime_Person] FOREIGN KEY([personID])
                            REFERENCES [dbo].[Person] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[BusyTime] CHECK CONSTRAINT [FK_BusyTime_Person]
                            
                            ALTER TABLE [dbo].[CalendarEvent]  WITH CHECK ADD  CONSTRAINT [FK_CalendarEvent_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[CalendarEvent] CHECK CONSTRAINT [FK_CalendarEvent_Home]
                            
                            ALTER TABLE [dbo].[CalendarEvent]  WITH CHECK ADD  CONSTRAINT [FK_CalendarEvent_Person] FOREIGN KEY([personID])
                            REFERENCES [dbo].[Person] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[CalendarEvent] CHECK CONSTRAINT [FK_CalendarEvent_Person]
                            
                            ALTER TABLE [dbo].[Chore]  WITH CHECK ADD  CONSTRAINT [FK_Chore_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Chore] CHECK CONSTRAINT [FK_Chore_Home]
                            
                            ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Home]
                            
                            ALTER TABLE [dbo].[Housework]  WITH CHECK ADD  CONSTRAINT [FK_Housework_Chore] FOREIGN KEY([choreID])
                            REFERENCES [dbo].[Chore] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Housework] CHECK CONSTRAINT [FK_Housework_Chore]
                            
                            ALTER TABLE [dbo].[Housework]  WITH CHECK ADD  CONSTRAINT [FK_Housework_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            
                            ALTER TABLE [dbo].[Housework] CHECK CONSTRAINT [FK_Housework_Home]
                            
                            ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK_Note_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK_Note_Home]
                            
                            ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK_Note_Person] FOREIGN KEY([personID])
                            REFERENCES [dbo].[Person] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK_Note_Person]
                            
                            ALTER TABLE [dbo].[Occasion]  WITH CHECK ADD  CONSTRAINT [FK_Occasion_CalendarEvent] FOREIGN KEY([calendarID])
                            REFERENCES [dbo].[CalendarEvent] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Occasion] CHECK CONSTRAINT [FK_Occasion_CalendarEvent]
                            
                            ALTER TABLE [dbo].[Person]  WITH NOCHECK ADD  CONSTRAINT [FK_Person_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE SET NULL
                            
                            ALTER TABLE [dbo].[Person] NOCHECK CONSTRAINT [FK_Person_Home]
                            
                            ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Home]
                            
                            ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Home] FOREIGN KEY([homeID])
                            REFERENCES [dbo].[Home] ([ID])
                            ON DELETE CASCADE
                            
                            ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Home]
                            ";
                    ExecuteNonQuery(sqlCMD);

                    Console.WriteLine("Database Created!");

                    Console.WriteLine(databasePath);

                    Console.WriteLine("Copy this path and change the connectionPath in HomeLifeSystem.exe.config");

                    Console.ReadLine();


                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }


         }

        static int progress = 0;
        static int maxProgress = 13;
        private static bool ExecuteNonQuery(string sqlCMD)
        {
            try
            {
                SqlCommand command = new SqlCommand(sqlCMD, connection);
                int i = command.ExecuteNonQuery();
                updateBar(progress++);
                Thread.Sleep(50);
                if (i == 0) return false;
                return true;

            }
            catch (SqlException e)
            {
                if(e.Number == 1801)
                {
                    Console.WriteLine("Database already exists!");
                    return false;
                }

                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
           
        }
        private static void updateBar(int i)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("Progress: [");
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            for (int j = 0; j < maxProgress-i; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine("]");
            
        }
    }
}
