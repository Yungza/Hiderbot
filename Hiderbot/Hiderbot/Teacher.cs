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
        public Timetable Timetable { get; set; }
        public string Subject { get; set; }
        public Teacher(string name, string surname, Timetable timeTable)
        {
            Name = name;
            Surname = surname;
            Timetable = timeTable;
        }
    }
}
