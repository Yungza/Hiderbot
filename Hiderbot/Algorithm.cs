using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiderbot
{
    //stolen from chat gpt(prompt: how to randomize a list?)
    public static class ListExtensions
    {
        public static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    public class Algorithm
    {


        List<Teacher> teachers = new List<Teacher>();
        List<Class> classes = new List<Class>();

        public Algorithm()
        {
            Data data = new Data();
            teachers = data.teachers;
        }

        public List<List<string>> Generator(List<Teacher> teachers, List<Class> classes)
        {
            List<List<Period>> scheduleAll = new List<List<Period>>();
            List<Period> schedule = new List<Period>(); 
            List<List<string>> subjectsAll = new List<List<string>>();

            foreach (Class c in classes)
            {
                List<string> subjects = new List<string>();

                // Loop through the Requirement dictionary of the class
                foreach (var subject in c.Requirement)
                {
                    string subjectName = subject.Key;
                    int subjectCount = subject.Value;

                    // Add the subject name to the subjects list the number of times it is required
                    for (int i = 0; i < subjectCount; i++)
                    {
                        subjects.Add(subjectName);
                    }
                }

                // Add the subjects list to the subjectsAll list
                ListExtensions.Shuffle(subjects);
                subjectsAll.Add(subjects);
            }
            foreach (List<string> s in subjectsAll)
            {
                foreach (var subject in s)
                {
                    ListExtensions.Shuffle(teachers);
                    foreach(Teacher t in teachers)
                    {
                        foreach(string x in t.Subjects)
                        {
                            if(x == subject)
                            {
                                Period period = new Period(t, subject);
                                schedule.Add(period);
                            }
                        }
                    }
                }
            }
            return subjectsAll;
        }
        
            


        public void Print(List<List<string>> subjectsAll, List<Class> classes)
        {
            for (int i = 0; i < subjectsAll.Count; i++)
            {
                Console.WriteLine($"Class {classes[i].ClassNumber}: {string.Join(", ", subjectsAll[i])}");
            }
        }
        

    }
}
