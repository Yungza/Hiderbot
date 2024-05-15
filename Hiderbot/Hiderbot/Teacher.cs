using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
        public Teacher(string name, List<string> subjects)
        {
            Name = name;
            Subjects = subjects;
        }
    }
}
