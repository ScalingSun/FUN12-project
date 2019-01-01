using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUN12
{
    class Login
    {
        private string Username;
        private string password;
        public void connection()
        {
            new SQLConnection();
        }

        public Login(string UserName, string Password)
        {
            connection();
            
            Username = UserName;
            password = Password;
            
        }
    }
}
