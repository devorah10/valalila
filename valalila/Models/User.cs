using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace valalila.Models
{
    public class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public string address { get; set; }
        public string password { get; set; }
        public string gender { get; set; }


    }
}
