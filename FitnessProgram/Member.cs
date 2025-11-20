using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgram
{
    public class Member
    {
        public int id { get; set; }
        public string name { get; set; }
        public char gender { get; set; }
        //public string password;

        public Member(int id, string name, char gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
        }
    }
}
