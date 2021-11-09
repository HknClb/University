using System;
using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class PeronRentel : SqlProcessAdapter
    {
        public PeronRentel()
        {
            RentedPeron = new Peron();
            Bus = new Bus();
            BusDriver = new Driver();
            Company = new Company();
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }

        private int id;
        public int Id { get => id; set => id = value; }
        public Peron RentedPeron { get; set; }
        public Bus Bus { get; set; }
        public Driver BusDriver { get; set; }
        public Company Company { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
        public byte Tenancy { get; set; }
        public double Payment { get; set; }
        public SqlDataReader AllRentel
        {
            get { if (ReadDataFromTable("SELECT * FROM PeronRentelTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }

        public bool SetByID(int id)
        {
            if (ReadDataFromTable("SELECT * FROM PeronRentelTable"))
            {
                bool isFind = false;
                if (id.Equals(reader["ID"]))
                {
                    this.Id = id;
                    RentedPeron.SetByID((int)reader["PeronID"]);
                    Bus.SetByPlate(reader["BusPlate"].ToString());
                    BusDriver.SetByIdentity(reader["DriverIdentity"].ToString());
                    Company.SetByID((int)reader["CompanyID"]);
                    EnterTime = (DateTime)reader["EnterTime"];
                    if (!reader["ExitTime"].ToString().Equals(""))
                        ExitTime = (DateTime)reader["ExitTime"];
                    Tenancy = (byte)reader["Tenancy"];
                    Payment = Tenancy * RentedPeron.UnitPrice;
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (id.Equals(reader["ID"]))
                        {
                            this.Id = id;
                            RentedPeron.SetByID((int)reader["PeronID"]);
                            Bus.SetByPlate(reader["BusPlate"].ToString());
                            BusDriver.SetByIdentity(reader["DriverIdentity"].ToString());
                            Company.SetByID((int)reader["CompanyID"]);
                            EnterTime = (DateTime)reader["EnterTime"];
                            if (!reader["ExitTime"].ToString().Equals(""))
                                ExitTime = (DateTime)reader["ExitTime"];
                            Tenancy = (byte)reader["Tenancy"];
                            Payment = Tenancy * RentedPeron.UnitPrice;
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
        public SqlDataReader GetActiveRent()
        {
            if (ReadDataFromTable("SELECT * FROM PeronRentelTable WHERE ExitTime IS NULL")) return reader; return null;
        }
        public SqlDataReader GetPasiveRent()
        {
            if (ReadDataFromTable("SELECT * FROM PeronRentelTable WHERE ExitTime IS NOT NULL")) return reader; return null;
        }
        public bool ExitBus()
        {
            ExitTime = DateTime.Now;
            if (UpdateDataFromTable("UPDATE PeronRentelTable SET ExitTime='" + ExitTime.ToString("yyyy.MM.dd HH:mm:ss") + "'" + " WHERE ID='" + Id + "'"))
                return true;
            return false;
        }
        public bool AddPeronRentelToDatabase()
        {
            if (AddDataToTable("INSERT INTO PeronRentelTable (PeronID, BusPlate, DriverIdentity, CompanyID, EnterTime, Tenancy, Payment) VALUES ('"
                + RentedPeron.Id + "', '" + Bus.Plate + "', '" + BusDriver.Identity + "', '" + Company.Id + "', '" + EnterTime.ToString("yyyy.MM.dd HH:mm:ss") + "', '" + Tenancy +
                "', '" + Payment + "')"))
                return true;
            return false;
        }
        public bool DeletePeronRentelFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM PeronRentelTable WHERE ID='" + Id + "'"))
                return true;
            return false;
        }
        public bool UpdatePeronRentelFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE PeronRentelTable SET PeronID='" + RentedPeron.Id + "', BusPlate='" + Bus.Plate + "', DriverIdentity='" + BusDriver.Identity +
                "', CompanyID='" + Company.Id + "', EnterTime='" + EnterTime.ToString("yyyy.MM.dd HH:mm:ss") + "', Tenancy='" + Tenancy + "', Payment='" + Payment + "'" +
                " WHERE ID='" + Id + "'"))
                return true;
            return false;
        }
    }
}
