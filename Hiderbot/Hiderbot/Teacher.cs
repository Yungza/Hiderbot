using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Subjects> Subjects { get; set; }
        public Teacher(string name, string surname, List<Subjects> subjects)
        {
            Name = name;
            Surname = surname;
            Subjects = subjects;
        }
    }
}
