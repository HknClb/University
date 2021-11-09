using System;
using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class Driver : SqlProcessAdapter
    {
        public Driver()
        {
            Contact = new ContactInformation();
            Company = new Company();
            identity = Name = Surname = null;
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }

        private string identity;
        private string oldIdentity;
        byte setCount = 0;
        public string Identity
        {
            get => identity;
            set
            {
                identity = value;
                if (setCount++ < 2)
                    oldIdentity = identity;
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Company Company { get; set; }
        public DateTime BirthDate { get; set; }
        public ContactInformation Contact { get; set; }
        public SqlDataReader AllDrivers
        {
            get { if (ReadDataFromTable("SELECT * FROM DriversTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }
        public bool SetByIdentity(string identity)
        {
            if (ReadDataFromTable("SELECT * FROM DriversTable"))
            {
                bool isFind = false;
                if (identity.Equals(reader["Identity"]))
                {
                    this.Identity = identity;
                    Name = reader["Name"].ToString();
                    Surname = reader["Surname"].ToString();
                    BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
                    Company.SetByID(int.Parse(reader["CompanyID"].ToString()));
                    Contact.SetByID(int.Parse(reader["ContactInformationID"].ToString()));
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (identity.Equals(reader["Identity"]))
                        {
                            this.Identity = identity;
                            Name = reader["Name"].ToString();
                            Surname = reader["Surname"].ToString();
                            BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
                            Company.SetByID(int.Parse(reader["CompanyID"].ToString()));
                            Contact.SetByID(int.Parse(reader["ContactInformationID"].ToString()));
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

        public bool AddDriverToDatabase()
        {
            if (Contact.AddContactInformationToDatabase())
            {
                ReadDataFromTable("SELECT * FROM ContactInformationTable WHERE PhoneNumber='" + Contact.PhoneNumber + "'");
                Contact.Id = (int)reader["ID"];
                StopConnections();
                if (AddDataToTable("INSERT INTO DriversTable ([Identity], Name, Surname, CompanyID, BirthDate, ContactInformationID) VALUES ('"
                + Identity + "', '" + Name + "', '" + Surname + "', '" + Company.Id + "', '" + BirthDate.ToString("yyyy.MM.dd") + "', '" + Contact.Id + "')"))
                    return true;
            }
            return false;
        }
        public bool DeleteDriverFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM DriversTable WHERE [Identity]='" + Identity + "'") && Contact.DeleteContactInformationFromDatabase())
                return true;
            return false;
        }
        public bool UpdateDriverFromDatabase()
        {
            if (Contact.UpdateContactInformationFromDatabase() && UpdateDataFromTable("UPDATE DriversTable SET [Identity]='" + Identity + "', Name='" + Name + "', Surname='" + Surname +
            "', BirthDate='" + BirthDate.ToString("yyyy.MM.dd") + "', CompanyID='" + Company.Id + "'" + " WHERE [Identity]='" + oldIdentity
            + "'"))
                return true;
            return false;
        }
    }
}
