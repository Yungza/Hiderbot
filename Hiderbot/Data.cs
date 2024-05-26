using Hiderbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Data
{
    public List<Teacher> teachers = new List<Teacher>();
    public List<Class> classes = new List<Class>();
    public Data()
    {
        // Step 2: Create a new Teacher object
        Teacher teacher1 = new Teacher("Felbr", new List<string> { "Math", "German" });

        // Step 3: Add the teacher to the list
        teachers.Add(teacher1);

        Teacher teacher2 = new Teacher("Jandova", new List<string> { "Czech", "History" });
        Teacher teacher3 = new Teacher("Chytil", new List<string> { "Pee" });
        Teacher teacher4 = new Teacher("Radzo", new List<string> { "English", "Geography" });
        Teacher teacher5 = new Teacher("Hobbs", new List<string> { "English", "German" });

        // Add the rest of the teachers
        teachers.Add(teacher2);
        teachers.Add(teacher3);
        teachers.Add(teacher4);
        teachers.Add(teacher5);

        Class class1 = new Class("1.A", new Dictionary<string, int> { { "Math", 1 }, { "English", 1 }, {"Czech", 2 }, { "German", 2 }, { "Pee", 1 } });
        Class class2 = new Class("1.B", new Dictionary<string, int> { { "Math", 2 }, { "English", 2 }, { "Czech", 2 }, { "Pee", 1 } });
        Class class3 = new Class("1.C", new Dictionary<string, int> { { "Math", 1 }, { "English", 1 }, { "Czech", 1 }, { "German", 2 }, { "Pee", 1 }, {"Geography", 1 } });

        classes.Add(class1);
        classes.Add(class2);
        classes.Add(class3);    
    }
}
