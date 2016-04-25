using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Core
{
    public class User
    {
        public string Name { set; get; }
        public string Lastname { set; get; }
        public int number { get; }

        public User(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

        public User()
        {
            
        }


    }
}
