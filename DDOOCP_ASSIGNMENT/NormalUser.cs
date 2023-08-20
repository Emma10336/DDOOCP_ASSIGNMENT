using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DDOOCP_ASSIGNMENT
{
    internal class Normal : User
    {
        private string address;
        private string city;
        private string country;
        private string post_code;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string PostCode
        {
            get { return post_code; }
            set { post_code = value; }
        }

    }
}
