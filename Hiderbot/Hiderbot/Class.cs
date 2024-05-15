using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
    internal class Class
    {
        public string ClassNumber { get; set; }
        public Timetable Timetable { get; set; }

        public Class (string classNumber, Timetable timeTable)
        {
            ClassNumber = classNumber;
            Timetable = timeTable;
        }


    }
}
