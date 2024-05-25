using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
    public class Class
    {
        public string ClassNumber { get; set; }
        public Dictionary<string, int> Requirement { get; set; }

        public Class (string classNumber, Dictionary<string, int> requirement)
        {
            ClassNumber = classNumber;
            Requirement = requirement;
        }


    }
}
