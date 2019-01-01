using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUN12
{
    public class User
    {
        public int id { get;  set; }
        public string username { get;  set; }
        public string password { get;  set; }
        public string firstname { get;  set; }
        public string lastname { get;  set; }
        public User(int id, string username, string password, string firstname, string lastname)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
        }

    }
}

