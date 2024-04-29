using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    internal class Autentikasi
    {
        public bool Login(string username, string password)
        {
            return username == "admin" && password == "1234";
        }
    }
}
