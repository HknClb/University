using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class Peron : SqlProcessAdapter
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public byte Number { get; set; }
        public double UnitPrice { get; set; }

        public SqlDataReader AllPerons
        {
            get { if(ReadDataFromTable("SELECT * FROM PeronsTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }

        public Peron()
        {
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }

        public bool SetByID(int id)
        {
            if (ReadDataFromTable("SELECT * FROM PeronsTable"))
            {
                bool isFind = false;
                if (id.Equals(reader["ID"]))
                {
                    this.id = id;
                    Number = (byte)reader["Number"];
                    UnitPrice = double.Parse(reader["UnitPrice"].ToString());
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (id.Equals(reader["ID"]))
                        {
                            this.id = id;
                            Number = (byte)reader["Number"];
                            UnitPrice = double.Parse(reader["UnitPrice"].ToString());
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

        public bool SetByNumber(byte number)
        {
            if (ReadDataFromTable("SELECT * FROM PeronsTable"))
            {
                bool isFind = false;
                if (number.Equals(reader["Number"]))
                {
                    this.Number = number;
                    Id = (int)reader["ID"];
                    UnitPrice = double.Parse(reader["UnitPrice"].ToString());
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (number.Equals(reader["Number"]))
                        {
                            this.Number = number;
                            Id = (int)reader["ID"];
                            UnitPrice = double.Parse(reader["UnitPrice"].ToString());
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
        public bool AddPeronToDatabase()
        {
            if (AddDataToTable("INSERT INTO PeronsTable (Number, UnitPrice) VALUES ('" + Number + "', '" + UnitPrice + "')"))
                return true;
            return false;
        }

        public bool UpdatePeronFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE PeronsTable SET Number='" + Number + "', UnitPrice='" + UnitPrice  + "'" + " WHERE ID='" + id + "'"))
                return true;
            return false;
        }

        public bool DeletePeronFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM PeronsTable WHERE ID='" + id + "'"))
                return true;
            return false;
        }
    }
}
