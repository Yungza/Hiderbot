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
        public List<Subjects> Subjects { get; set; }

        public Class (string classNumber, List<Subjects> subjects)
        {
            ClassNumber = classNumber;
            Subjects = subjects;
        }


    }
}
