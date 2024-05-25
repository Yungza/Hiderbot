using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
    internal class Period
    {
        public Teacher Teacher { get; set; }
        public string Subject { get; set; }
        public Period(Teacher Teacher, string Subject)
        {
            this.Teacher = Teacher;
            this.Subject = Subject;
        }
    }
}
