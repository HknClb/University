using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025.CreatedClass
{
    class SqlProcessAdapter
    {
        protected string ServerName;
        protected string DatabaseName;
        protected SqlConnection connection;
        protected SqlCommand command;
        protected SqlDataReader reader;
        private bool Connect()
        {
            try
            {
                connection = new SqlConnection("Data Source=" + ServerName + "; Initial Catalog=" + DatabaseName + "; Integrated Security=True; Connect Timeout=30;" +
                    " Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanına Bağlanılamadı!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }

        protected void StopConnections()
        {
            if (reader != null && !reader.IsClosed)
                reader.Close();
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        protected bool ReadDataFromTable(string Command)
        {
            Connect();
            try
            {
                command = new SqlCommand(Command, connection);
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Okunamadı!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopConnections();
                return false;
            }
            reader.Read();
            if (reader.HasRows)
                return true;
            StopConnections();
            return false;
        }
        protected bool AddDataToTable(string Command)
        {
            Connect();
            try
            {
                command = new SqlCommand(Command, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Eklenemedi!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        protected bool UpdateDataFromTable(string Command)
        {
            Connect();
            try
            {
                command = new SqlCommand(Command, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Güncellenemedi!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
        }

        protected bool DeleteDataFromTable(string Command)
        {
            Connect();
            try
            {
                command = new SqlCommand(Command, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Silinemedi!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
        }
    }
}
