using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class CompanyAuthorizedPerson : SqlProcessAdapter
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public string AuthorizedPersonName { get; set; }
        public string AuthorizedPersonSurname { get; set; }
        public string AuthorizedPersonPhoneNumber { get; set; }
        public Company Company { get; set; }

        public SqlDataReader AllAuthorizedPerson
        {
            get { if (ReadDataFromTable("SELECT * FROM CompanyAuthorizedPersonTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }

        public CompanyAuthorizedPerson()
        {
            Company = new Company();
            AuthorizedPersonName = AuthorizedPersonSurname = AuthorizedPersonPhoneNumber = null;
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }

        public bool SetByID(int id)
        {
            if (ReadDataFromTable("SELECT * FROM CompanyAuthorizedPersonTable"))
            {
                bool isFind = false;
                if (id.Equals(reader["ID"]))
                {
                    this.id = id;
                    AuthorizedPersonName = reader["AuthorizedPersonName"].ToString();
                    AuthorizedPersonSurname = reader["AuthorizedPersonSurname"].ToString();
                    AuthorizedPersonPhoneNumber = reader["AuthorizedPersonPhoneNumber"].ToString();
                    Company.SetByID(int.Parse(reader["CompanyID"].ToString()));
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (id.Equals(reader["ID"]))
                        {
                            this.id = id;
                            AuthorizedPersonName = reader["AuthorizedPersonName"].ToString();
                            AuthorizedPersonSurname = reader["AuthorizedPersonSurname"].ToString();
                            AuthorizedPersonPhoneNumber = reader["AuthorizedPersonPhoneNumber"].ToString();
                            Company.SetByID(int.Parse(reader["CompanyID"].ToString()));
                            isFind = true;
                            break;
                        }
                    }
                }
                StopConnections();
                return isFind;
            }
            else
                return false;
        }

        public bool AddAuthorizedPersonToDatabase()
        {
            if (AddDataToTable("INSERT INTO CompanyAuthorizedPersonTable (AuthorizedPersonName, AuthorizedPersonSurname, AuthorizedPersonPhoneNumber, CompanyID) VALUES ('"
                + AuthorizedPersonName + "', '" + AuthorizedPersonSurname + "', '" + AuthorizedPersonPhoneNumber + "', '" + Company.Id + "')"))
                return true;
            return false;
        }

        public bool DeleteAuthorizedPersonFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM CompanyAuthorizedPersonTable WHERE ID='" + id + "'"))
                return true;
            return false;
        }
        public bool UpdateAuthorizedPersonFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE CompanyAuthorizedPersonTable SET AuthorizedPersonName='" + AuthorizedPersonName + "', AuthorizedPersonSurname='" + AuthorizedPersonSurname 
                + "', AuthorizedPersonPhoneNumber='" + AuthorizedPersonPhoneNumber + "'" + " WHERE ID='" + id + "'"))
                return true;
            return false;
        }
    }
}
