using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgram
{
    public class Activity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int maxMembers { get; set; }

        public Activity(int id, string name, int maxMembers)
        {
            this.id = id;
            this.name = name;
            this.maxMembers = maxMembers;
        }
    }
}
