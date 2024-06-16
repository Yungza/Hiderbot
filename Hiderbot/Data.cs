using Hiderbot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Data
{
    public static List<string> teacherNames = new List<string>();
    public List<Class> classes = new List<Class>();

    public Data()
    {
        AddTeacher(new Teacher("Felbr", new List<string> { "Math", "German" }));
        AddTeacher(new Teacher("Jandova", new List<string> { "Czech", "History" }));
        AddTeacher(new Teacher("Chytil", new List<string> { "Pee" }));
        AddTeacher(new Teacher("Radzo", new List<string> { "English", "Geography" }));
        AddTeacher(new Teacher("Hobbs", new List<string> { "English", "German" }));

        Class class1 = new Class("1.A", new Dictionary<string, int> { { "Math", 6 }, { "English", 6 }, { "Czech", 6 }, { "German", 6 }, { "Pee", 6 } });
        Class class2 = new Class("1.B", new Dictionary<string, int> { { "Math", 10 }, { "English", 12 }, { "Czech", 6 }, { "Pee", 2 } });
        Class class3 = new Class("1.C", new Dictionary<string, int> { { "Math", 5 }, { "English", 5 }, { "Czech", 5 }, { "German", 5 }, { "Pee", 5 }, { "Geography", 5 } });

        classes.Add(class1);
        classes.Add(class2);
        classes.Add(class3);
    }

    private void AddTeacher(Teacher teacher)
    {
        if (!teacherNames.Contains(teacher.Name))
        {
            TeachersList.AddTeacher(teacher);
            teacherNames.Add(teacher.Name);
        }
    }
}

