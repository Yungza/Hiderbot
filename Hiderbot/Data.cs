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

        Class class1 = new Class("1.A", new Dictionary<string, int> { { "Math", 1 }, { "English", 1 }, { "Czech", 2 }, { "German", 2 }, { "Pee", 1 } });
        Class class2 = new Class("1.B", new Dictionary<string, int> { { "Math", 2 }, { "English", 2 }, { "Czech", 2 }, { "Pee", 1 } });
        Class class3 = new Class("1.C", new Dictionary<string, int> { { "Math", 1 }, { "English", 1 }, { "Czech", 1 }, { "German", 2 }, { "Pee", 1 }, { "Geography", 1 } });

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

