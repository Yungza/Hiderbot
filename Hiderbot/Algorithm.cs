using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiderbot
{
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
        public static List<T> GetRandomValues<T>(this IList<T> list, int numberOfValues)
        {
            Random random = new Random();
            return list.OrderBy(x => random.Next()).Take(numberOfValues).ToList();
        }
    }

    public class Algorithm
    {
        List<Teacher> teachers = new List<Teacher>();
        List<Class> classes = new List<Class>();

        public Algorithm()
        {
            Data data = new Data();
            List<Teacher> teachers = new List<Teacher>();
        }

        public List<List<Period>> Generator(List<Teacher> teachers, List<Class> classes)
        {
            List<List<Period>> scheduleAll = new List<List<Period>>();
            List<List<string>> subjectsAll = new List<List<string>>();

            foreach (Class c in classes)
            {
                List<string> subjects = new List<string>();

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

            var subjectTeacher = new Dictionary<string, List<Teacher>>();

            foreach (var teacher in teachers)
            {
                foreach (var subject in teacher.Subjects)
                {
                    if (!subjectTeacher.ContainsKey(subject))
                    {
                        subjectTeacher[subject] = new List<Teacher>();
                    }
                    subjectTeacher[subject].Add(teacher);
                }
            }

            // Shuffle teachers for each subject group
            foreach (var key in subjectTeacher.Keys.ToList())
            {
                ListExtensions.Shuffle(subjectTeacher[key]);
            }

            // Assign periods
            foreach (var subjectList in subjectsAll)
            {
                List<Period> schedule = new List<Period>();

                foreach (var subject in subjectList)
                {
                    if (subjectTeacher.ContainsKey(subject))
                    {
                        var availableTeachers = subjectTeacher[subject];
                        foreach (var teacher in availableTeachers)
                        {
                            Period period = new Period(teacher, subject);
                            schedule.Add(period);
                            break; // Assign only one teacher per subject period
                        }
                    }
                }

                scheduleAll.Add(schedule);
            }

            return scheduleAll;
        }

        public int CalculateFitness(List<List<Period>> scheduleAll)
        {
            int fitness = 100;
            var teacherSchedule = new Dictionary<Teacher, HashSet<int>>();

            for (int i = 0; i < scheduleAll.Count; i++)
            {
                for (int j = 0; j < scheduleAll[i].Count; j++)
                {
                    Period period = scheduleAll[i][j];
                    Teacher teacher = period.Teacher;

                    if (!teacherSchedule.ContainsKey(teacher))
                    {
                        teacherSchedule[teacher] = new HashSet<int>();
                    }

                    // If the teacher is already scheduled for this time slot, it's a conflict
                    if (teacherSchedule[teacher].Contains(j))
                    {
                        fitness -= 10;
                    }
                    else
                    {
                        teacherSchedule[teacher].Add(j);
                    }
                }
            }

            return fitness;
        }

        public List<List<Period>> FindBestSchedule(List<Teacher> teachers, List<Class> classes, int iterations = 1000)
        {
            List<List<Period>> bestSchedule = null;
            int bestFitness = int.MinValue;

            for (int i = 0; i < iterations; i++)
            {
                List<List<Period>> currentSchedule = Generator(teachers, classes);
                int currentFitness = CalculateFitness(currentSchedule);

                if (currentFitness > bestFitness)
                {
                    bestFitness = currentFitness;
                    bestSchedule = currentSchedule;
                }
            }
            if (bestFitness != 100)
            {
                ThrowRandomBullshit(bestSchedule);
            }
            return bestSchedule;
        }

        public void Print(List<List<List<Period>>> weeklySchedule, List<Class> classes)
        {
            
                for (int dayIndex = 0; dayIndex < weeklySchedule.Count; dayIndex++)
                {
                    Console.WriteLine($"Day {dayIndex + 1}:");

                    List<List<Period>> daySchedule = weeklySchedule[dayIndex];

                    for (int classIndex = 0; classIndex < daySchedule.Count && classIndex < classes.Count; classIndex++)
                    {
                        Class currentClass = classes[classIndex];
                        List<Period> classSchedule = daySchedule[classIndex];

                        Console.WriteLine($"  Class {currentClass.ClassNumber}:");

                        foreach (var period in classSchedule)
                        {
                            Console.WriteLine($"    Teacher: {period.Teacher.Name}, Subject: {period.Subject}");
                        }
                    Console.WriteLine($"fitness: {CalculateFitness(weeklySchedule[classIndex])}");
                    }
                }
            
        }
            public static List<List<Period>> SplitDays(List<Period> list)
        {
            // Initialize random number generator
            Random random = new Random();

            // Determine the base size for each part
            int baseSize = list.Count / 5;
            int extraItems = list.Count % 5;

            // Create a list to hold the 5 parts
            List<List<Period>> result = new List<List<Period>>();

            // Initialize the 5 parts
            for (int i = 0; i < 5; i++)
            {
                result.Add(new List<Period>());
            }

            // Fill the parts with the base size
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < baseSize; j++)
                {
                    result[i].Add(list[index++]);
                }
            }

            for (int i = 0; i < extraItems; i++)
            {
                int randomIndex = random.Next(5);
                result[randomIndex].Add(list[index++]);
            }

            return result;
        }

        public List<List<Period>> ThrowRandomBullshit(List<List<Period>> scheduleAll)
        {
            Console.WriteLine(CalculateFitness(scheduleAll));
            Data data = new Data();
            Teacher schovanek = new Teacher("Schovy", new List<string> { "Sbstn" });
            var teacherScheduleMap = new Dictionary<Teacher, HashSet<int>>();
            Period blank = new Period(schovanek, "Sbstn");
            for (int i = 0; i < scheduleAll.Count; i++)
            {
                for (int j = 0; j < scheduleAll[i].Count; j++)
                {
                    Period period = scheduleAll[i][j];
                    Teacher teacher = period.Teacher;

                    if (!teacherScheduleMap.ContainsKey(teacher))
                    {
                        teacherScheduleMap[teacher] = new HashSet<int>();
                    }

                    // If the teacher is already scheduled for this time slot, it's a conflict
                    if (teacherScheduleMap[teacher].Contains(j))
                    {
                        scheduleAll[i].Insert(j, blank);
                    }
                    else
                    {
                        teacherScheduleMap[teacher].Add(j);
                    }
                }
            }

            return scheduleAll;
        }



        /*public void PrintAll(List<List<List<Period>>> scheduleAll) 
        {
            foreach(var a in  scheduleAll)
            {
                Console.WriteLine("day:");
                foreach(var b in a)
                {
                    Console.WriteLine("class:");
                    foreach(var c in b)
                    {
                        Console.WriteLine(c.Subject);
                    }
                }
            }    
        }
        */

        public List<List<List<Period>>> GenerateWeek(List<Teacher> teachers, List<Class> classes)
        {
            List<List<List<Period>>> weekSchedule = new List<List<List<Period>>>();
            List<List<List<Period>>> schedule = new List<List<List<Period>>>();
            List<List<Period>> week = FindBestSchedule(teachers, classes);
            List<List<Period>> day = new List<List<Period>>();
            
            foreach (var a in week)
            {
                day = SplitDays(a);
                schedule.Add(day);
            }
            for (int i = 0; i < schedule[0].Count; i++)
            {
                List<List<Period>> set = new List<List<Period>>();
                set.Add(schedule[0][i]);
                set.Add(schedule[1][i]);
                set.Add(schedule[2][i]);
                weekSchedule.Add(set);
            }
            

            Console.WriteLine(schedule.Count);
            return weekSchedule;
             
        }

    }
}