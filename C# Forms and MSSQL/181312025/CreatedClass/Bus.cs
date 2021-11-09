using System;
using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class Bus : SqlProcessAdapter
    {
        private string oldPlate;
        private string plate;
        private byte setCount = 0;
        public string Plate { get => plate; set { plate = value; if (setCount < 2) { setCount++; oldPlate = plate; } } }
        public Company OwnedCompany { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public DateTime YearOfProduction { get; set; }
        public Bus()
        {
            OwnedCompany = new Company();
            Plate = Mark = Model = null;
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }
        public SqlDataReader AllBuses
        {
            get { if (ReadDataFromTable("SELECT * FROM BusesTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }
        public bool SetByPlate(string plate)
        {
            if (ReadDataFromTable("SELECT * FROM BusesTable"))
            {
                bool isFind = false;
                if (plate.Equals(reader["Plate"]))
                {
                    this.Plate = plate;
                    Mark = reader["Mark"].ToString();
                    Model = reader["Model"].ToString();
                    YearOfProduction = DateTime.Parse(reader["YearOfProduction"].ToString());
                    OwnedCompany.SetByID(int.Parse(reader["CompanyID"].ToString()));
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (plate.Equals(reader["Plate"]))
                        {
                            this.Plate = plate;
                            Mark = reader["Mark"].ToString();
                            Model = reader["Model"].ToString();
                            YearOfProduction = DateTime.Parse(reader["YearOfProduction"].ToString());
                            OwnedCompany.SetByID(int.Parse(reader["CompanyID"].ToString()));
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

        public bool AddBusToDatabase()
        {
            if (AddDataToTable("INSERT INTO BusesTable (Plate, Mark, Model, CompanyID, YearOfProduction) VALUES ('"
                + Plate + "', '" + Mark + "', '" + Model + "', '" + OwnedCompany.Id + "', '" + YearOfProduction.ToString("yyyy.MM.dd") + "')"))
                return true;
            return false;
        }
        public bool DeleteBusFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM BusesTable WHERE Plate='" + Plate + "'"))
                return true;
            return false;
        }
        public bool UpdateBusFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE BusesTable SET Plate='" + Plate + "', Mark='" + Mark + "', Model='" + Model + "', YearOfProduction='" + 
                YearOfProduction.ToString("yyyy.MM.dd") + "', CompanyID='" + OwnedCompany.Id + "'" + " WHERE Plate='"
                + oldPlate + "'"))
                return true;
            return false;
        }
    }
}
