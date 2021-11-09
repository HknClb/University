using System;
using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class Logs : SqlProcessAdapter
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public User AuthorizedUser { get; set; }
        public string ProcessInformation { get; set; }
        public DateTime ProcessTime { get; set; }

        public Logs(User user)
        {
            this.AuthorizedUser = user;
            ProcessInformation = null;
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
            ProcessTime = DateTime.Now;
        }

        ~Logs()
        {
            StopConnections();
        }

        public bool AddLogToDatabase()
        {
            if (AddDataToTable("INSERT INTO LogsTable (UserID, ProcessInformation, ProcessTime) VALUES ('" + AuthorizedUser.Id + "', '" + ProcessInformation + "', '" + 
               ProcessTime.ToString("yyyy.MM.dd hh:mm:ss") + "')"))
                return true;
            return false;
        }

        public SqlDataReader AllLogs
        {
            get { ReadDataFromTable("SELECT * FROM LogsTable"); return reader; }
            set { if (value == null) StopConnections(); }
        }
    }
}
