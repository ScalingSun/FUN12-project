using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FUN12
{
    class Person
    {
        public int id { get; set; }
        public string Username { get;  set; }
       public string Password { get;  set; }
       public string FirstName { get;  set; }
       public string LastName { get;  set; }

        public Person()
        {

        }

      public string data()
        {
            return Username;
        }
        public void RegisterQuery(string UserName, string Password, string FirstName, string LastName)
        {
            SQLConnection register = new SQLConnection();
           
            using (SqlCommand command = new SqlCommand("INSERT INTO [User](UserName, Password, FirstName, LastName) VALUES(@UserName , @Password, @FirstName, @LastName)", register.conn))
            {
                register.conn.Open();
                command.Parameters.Add(new SqlParameter("UserName", UserName));
                command.Parameters.Add(new SqlParameter("Password", Password));
                command.Parameters.Add(new SqlParameter("FirstName", FirstName));
                command.Parameters.Add(new SqlParameter("LastName", LastName));
                command.ExecuteNonQuery();
                register.conn.Close();
            }
        }

        public User LoginQuery(string UserName, string Password)
        {
            SQLConnection login = new SQLConnection();
            using (SqlCommand LOGIN = new SqlCommand("SELECT * FROM [User] WHERE @UserName = UserName AND @Password = Password", login.conn))
            {
                login.conn.Open();
                LOGIN.Parameters.Add(new SqlParameter("UserName", UserName));
                LOGIN.Parameters.Add(new SqlParameter("Password", Password));
                SqlDataReader reader = LOGIN.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                List<User> UserData = new List<User>();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    string password = reader.GetString(2); 
                    string firstname = reader.GetString(3);
                    string Lastname = reader.GetString(4);
                    
                    return new User(id, username, password, firstname, Lastname);
                }
                return null;
            }
        }
        public List<Lend> UserLend(int userID)
        {
            List<Lend> PersonLend = new List<Lend>();
            SQLConnection Lend = new SQLConnection();
            using (SqlCommand connection = new SqlCommand("SELECT * FROM Lend WHERE UserID = @id", Lend.conn))
            {
                Lend.conn.Open();
                connection.Parameters.Add(new SqlParameter("id", userID));
                connection.ExecuteNonQuery();


                SqlDataReader reader = connection.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                while (reader.Read())
                {

                    int id = reader.GetInt32(0);
                    int productID = reader.GetInt32(1);
                    DateTime startdatum = reader.GetDateTime(2);
                    DateTime einddatum = reader.GetDateTime(3);
                    Lend test = new Lend(id, productID, startdatum, einddatum);
                    PersonLend.Add(test);
                }
                Lend.conn.Close();

                return PersonLend;

            }
        }
    }
}
