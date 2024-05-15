using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
    internal class Data
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<string> subjects = new List<string>();

        public Data()
        {
            subjects.Add("Mathematics");
            subjects.Add("Czech");
            subjects.Add("History");
            subjects.Add("English");
            teachers.Add(new Teacher("Jandova", new List<string> { subjects[1], subjects[2] } ));
            teachers.Add(new Teacher("Felbr", new List<string> { subjects[0] }));
        }
    }
}
