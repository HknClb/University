using System;
using System.Data.SqlClient;

namespace _181312025.CreatedClass
{
    class User : SqlProcessAdapter
    {
        public enum AuthorityEnum
        {
            notAssigned,
            admin,
            terminal
        }
        private int id;
        public int Id { get => id; set => id = value; }
        public string UserName { get; set; }
        public string Password { get; set; }
        private AuthorityEnum authority;
        public AuthorityEnum Authority
        {
            get => authority;
            set
            {
                if (authority.Equals(AuthorityEnum.notAssigned))
                    authority = value;
            }
        }
        public SqlDataReader AllUsers
        {
            get { if(ReadDataFromTable("SELECT * FROM UsersTable")) return reader; return null; }
            set { if (value == null) StopConnections(); }
        }

        public User()
        {
            authority = AuthorityEnum.notAssigned;
            UserName = Password = null;
            id = -1;
            DatabaseName = "DatabaseOfTheFinalProject";
            ServerName = "DESKTOP-072PCRQ";
        }

        ~User()
        {
            StopConnections();
        }

        public bool SetByID(int id)
        {
            if (ReadDataFromTable("SELECT * FROM UsersTable"))
            {
                bool isFind = false;
                if (id.Equals(reader["ID"]))
                {
                    this.id = id;
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    authority = (User.AuthorityEnum)Enum.Parse(typeof(User.AuthorityEnum), reader["Authority"].ToString());
                    isFind = true;
                }
                if (!isFind)
                {
                    foreach (var item in reader)
                    {
                        if (id.Equals(reader["ID"]))
                        {
                            this.id = id;
                            UserName = reader["UserName"].ToString();
                            Password = reader["Password"].ToString();
                            authority = (User.AuthorityEnum)Enum.Parse(typeof(User.AuthorityEnum), reader["Authority"].ToString());
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

        public bool UpdateAuthorityByAdmin(User user, AuthorityEnum authority)
        {
            if (user.Authority == AuthorityEnum.admin)
                this.authority = authority;
            else
                return false;
            return true;
        }

        public bool CheckAndSetUser(string inputUserName, string inputPassword)
        {
            if (ReadDataFromTable("SELECT * FROM UsersTable"))
            {
                bool isFind = false;
                if (inputUserName.Equals(reader["UserName"].ToString()) && inputPassword.Equals(reader["Password"]))
                {
                    id = Convert.ToInt32(reader["ID"]);
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    authority = (User.AuthorityEnum)Enum.Parse(typeof(User.AuthorityEnum), reader["Authority"].ToString());
                    isFind = true;
                }
                foreach (var item in reader)
                {
                    if (!isFind && inputUserName.Equals(reader["UserName"].ToString()) && inputPassword.Equals(reader["Password"]))
                    {
                        id = Convert.ToInt32(reader["ID"]);
                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        authority = (User.AuthorityEnum)Enum.Parse(typeof(User.AuthorityEnum), reader["Authority"].ToString());
                        isFind = true;
                        break;
                    }
                }
                StopConnections();
                return isFind;
            }
            else
                return false;
        }

        public bool AddUserToDatabase()
        {
            if (AddDataToTable("INSERT INTO UsersTable (UserName, Password, Authority) VALUES ('" + UserName + "', '" + Password + "', '" + authority.ToString() + "')"))
                return true;
            return false;
        }

        public bool DeleteUserFromDatabase()
        {
            if (DeleteDataFromTable("DELETE FROM UsersTable WHERE ID='" + id + "'"))
                return true;
            return false;
        }
        public bool UpdateUserFromDatabase()
        {
            if (UpdateDataFromTable("UPDATE UsersTable SET UserName='" + UserName + "', Password='" + Password + "', Authority='" + authority.ToString() + "'"
                + " WHERE ID='" + id + "'"))
                return true;
            return false;
        }
    }
}
