using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class ContactInformation : SqlProcessAdapter
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public string Address { get; set; }
        public string PhoneNumber{ get; set; }
        public string RelativeName{ get; set; }
        public string RelativeSurname{ get; set; }
        public string RelativePhoneNumber{ get; set; }
        public ContactInformation()
        {
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }
        public SqlDataReader AllContact
        {
            get { if (ReadDataFromTable("SELECT * FROM ContactInformationTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }

        public bool SetByID(int id)
        {
            if (ReadDataFromTable("SELECT * FROM ContactInformationTable"))
            {
                bool isFind = false;
                if (id.Equals(reader["ID"]))
                {
                    this.Id = id;
                    Address = reader["Address"].ToString();
                    PhoneNumber = reader["PhoneNumber"].ToString();
                    RelativeName = reader["RelativeName"].ToString();
                    RelativeSurname = reader["RelativeSurname"].ToString();
                    RelativePhoneNumber = reader["RelativePhoneNumber"].ToString();
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (id.Equals(reader["ID"]))
                        {
                            this.Id = id;
                            Address = reader["Address"].ToString();
                            PhoneNumber = reader["PhoneNumber"].ToString();
                            RelativeName = reader["RelativeName"].ToString();
                            RelativeSurname = reader["RelativeSurname"].ToString();
                            RelativePhoneNumber = reader["RelativePhoneNumber"].ToString();
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
        public bool AddContactInformationToDatabase()
        {
            if (AddDataToTable("INSERT INTO ContactInformationTable (Address, PhoneNumber, RelativeName, RelativeSurname, RelativePhoneNumber) VALUES ('"
                + Address + "', '" + PhoneNumber + "', '" + RelativeName + "', '" + RelativeSurname + "', '" + RelativePhoneNumber + "')"))
                return true;
            return false;
        }
        public bool DeleteContactInformationFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM ContactInformationTable WHERE ID='" + Id + "'"))
                return true;
            return false;
        }
        public bool UpdateContactInformationFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE ContactInformationTable SET Address='" + Address + "', PhoneNumber='" + PhoneNumber + "', RelativeName='" + RelativeName +
                "', RelativeSurname='" + RelativeSurname + "', RelativePhoneNumber='" + RelativePhoneNumber + "'" + " WHERE ID='" + Id + "'"))
                return true;
            return false;
        }
    }
}
