using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOOCP_ASSIGNMENT
{
    internal class User
    {
        private string userID;
        private string name;
        private string surname;
        private string email;
        private string phone;
        private string password;
        private string user_role;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserRole
        {
            get { return user_role; }
            set { user_role = value; }
        }
    }
}
