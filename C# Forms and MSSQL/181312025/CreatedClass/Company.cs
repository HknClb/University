using System.Collections.Generic;
using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class Company : SqlProcessAdapter
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public string Name { get; set; }
        public List<CompanyAuthorizedPerson> AuthorizedPersons
        {
            get
            {
                ReadDataFromTable("SELECT * FROM AuthorizedPersonsTable WHERE CompanyID='" + id + "'");
                List<CompanyAuthorizedPerson> persons = new List<CompanyAuthorizedPerson>();
                CompanyAuthorizedPerson temple = new CompanyAuthorizedPerson();
                temple.AuthorizedPersonName = reader["AuthorizedPersonName"].ToString();
                temple.AuthorizedPersonSurname = reader["AuthorizedPersonSurname"].ToString();
                temple.AuthorizedPersonPhoneNumber = reader["AuthorizedPersonPhoneNumber"].ToString();
                persons.Add(temple);
                foreach (var item in reader)
                {
                    temple = new CompanyAuthorizedPerson();
                    temple.AuthorizedPersonName = reader["AuthorizedPersonName"].ToString();
                    temple.AuthorizedPersonSurname = reader["AuthorizedPersonSurname"].ToString();
                    temple.AuthorizedPersonPhoneNumber = reader["AuthorizedPersonPhoneNumber"].ToString();
                    persons.Add(temple);
                }
                StopConnections();
                return persons;
            }
        }

        public SqlDataReader AllCompanies
        {
            get { if(ReadDataFromTable("SELECT * FROM CompanyTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }

        public Company()
        {
            Name = null;
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }

        public bool SetByID(int id)
        {
            if (ReadDataFromTable("SELECT * FROM CompanyTable"))
            {
                bool isFind = false;
                if (id.Equals(reader["ID"]))
                {
                    this.id = id;
                    Name = reader["Name"].ToString();
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (id.Equals(reader["ID"]))
                        {
                            this.id = id;
                            Name = reader["Name"].ToString();
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
        public bool SetByName(string name)
        {
            if (ReadDataFromTable("SELECT * FROM CompanyTable"))
            {
                bool isFind = false;
                if (name.Equals(reader["Name"]))
                {
                    Name = name;
                    id = (int)reader["ID"];
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (name.Equals(reader["Name"]))
                        {
                            Name = name;
                            id = (int)reader["ID"];
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

        public bool AddCompanyToDatabase()
        {
            if (AddDataToTable("INSERT INTO CompanyTable (Name) VALUES ('" + Name + "')"))
                return true;
            return false;
        }

        public bool DeleteCompanyFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM CompanyTable WHERE ID='" + id + "'") && DeleteDataFromTable("DELETE FROM CompanyAuthorizedPersonTable WHERE CompanyID='" + 
                id + "'"))
                return true;
            return false;
        }
        public bool UpdateCompanyFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE CompanyTable SET Name='" + Name + "'" + " WHERE ID='" + id + "'"))
                return true;
            return false;
        }
    }
}