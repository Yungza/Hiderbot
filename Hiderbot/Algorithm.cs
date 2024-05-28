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
        const int DaysInWeek = 5;
        public Algorithm()
        {
            Data data = new Data();
        }

        public List<List<List<Period>>> Generator(List<Teacher> teachers, List<Class> classes)
        {
            List<List<List<Period>>> weeklySchedule = new List<List<List<Period>>>();

            // Initialize the schedule for the entire week
            for (int day = 0; day < DaysInWeek; day++)
            {
                weeklySchedule.Add(new List<List<Period>>());
                for (int classIndex = 0; classIndex < classes.Count; classIndex++)
                {
                    weeklySchedule[day].Add(new List<Period>());
                }
            }

            // Create a mapping of subjects to teachers
            var subjectTeacherMap = new Dictionary<string, List<Teacher>>();
            foreach (var teacher in teachers)
            {
                foreach (var subject in teacher.Subjects)
                {
                    if (!subjectTeacherMap.ContainsKey(subject))
                    {
                        subjectTeacherMap[subject] = new List<Teacher>();
                    }
                    subjectTeacherMap[subject].Add(teacher);
                }
            }

            // Shuffle teachers for each subject
            foreach (var key in subjectTeacherMap.Keys.ToList())
            {
                ListExtensions.Shuffle(subjectTeacherMap[key]);
            }

            // Schedule classes for each day
            for (int day = 0; day < DaysInWeek; day++)
            {
                foreach (var classItem in classes)
                {
                    var subjects = classItem.Requirement.SelectMany(r => Enumerable.Repeat(r.Key, r.Value)).ToList();
                    ListExtensions.Shuffle(subjects);

                    for (int periodIndex = 0; periodIndex < subjects.Count; periodIndex++)
                    {
                        var subject = subjects[periodIndex];
                        if (subjectTeacherMap.ContainsKey(subject))
                        {
                            var availableTeachers = subjectTeacherMap[subject].ToList();

                            foreach (var teacher in availableTeachers)
                            {
                                // Check if the teacher is available for this period
                                if (IsTeacherAvailable(teacher, weeklySchedule, day, periodIndex))
                                {
                                    weeklySchedule[day][classes.IndexOf(classItem)].Add(new Period(teacher, subject));
                                    break; // Assign only one teacher per subject period
                                }
                            }
                        }
                    }
                }
            }

            return weeklySchedule;
        }
        private bool IsTeacherAvailable(Teacher teacher, List<List<List<Period>>> schedule, int day, int periodIndex)
        {
            foreach (var periods in schedule[day])
            {
                if (periods.Count > periodIndex && periods[periodIndex].Teacher == teacher)
                {
                    return false;
                }
            }
            return true;
        }
        public int CalculateFitness(List<List<List<Period>>> schedule)
        {
            int fitness = 100;
            var teacherScheduleMap = new Dictionary<Teacher, Dictionary<int, HashSet<int>>>();

            for (int day = 0; day < schedule.Count; day++)
            {
                for (int classIndex = 0; classIndex < schedule[day].Count; classIndex++)
                {
                    for (int periodIndex = 0; periodIndex < schedule[day][classIndex].Count; periodIndex++)
                    {
                        Period period = schedule[day][classIndex][periodIndex];
                        Teacher teacher = period.Teacher;

                        if (!teacherScheduleMap.ContainsKey(teacher))
                        {
                            teacherScheduleMap[teacher] = new Dictionary<int, HashSet<int>>();
                        }

                        if (!teacherScheduleMap[teacher].ContainsKey(day))
                        {
                            teacherScheduleMap[teacher][day] = new HashSet<int>();
                        }

                        // If the teacher is already scheduled for this period on this day, it's a conflict
                        if (teacherScheduleMap[teacher][day].Contains(periodIndex))
                        {
                            fitness -= 10;
                        }
                        else
                        {
                            teacherScheduleMap[teacher][day].Add(periodIndex);
                        }
                    }
                }
            }

            return fitness;
        }

        public List<List<List<Period>>> FindBestSchedule(List<Teacher> teachers, List<Class> classes, int iterations = 1000)
        {
            List<List<List<Period>>> bestSchedule = null;
            int bestFitness = int.MinValue;

            for (int i = 0; i < iterations; i++)
            {
                List<List<List<Period>>> currentSchedule = Generator(teachers, classes);
                int currentFitness = CalculateFitness(currentSchedule);

                if (currentFitness > bestFitness)
                {
                    bestFitness = currentFitness;
                    bestSchedule = currentSchedule;
                }
            }

            return bestSchedule;
        }



        public void Print(List<List<List<Period>>> schedule, List<Class> classes)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            for (int day = 0; day < schedule.Count; day++)
            {
                Console.WriteLine($"{daysOfWeek[day]}:");

                for (int classIndex = 0; classIndex < schedule[day].Count; classIndex++)
                {
                    Console.WriteLine($"  Class {classes[classIndex].ClassNumber}:");

                    foreach (var period in schedule[day][classIndex])
                    {
                        Console.WriteLine($"    Teacher: {period.Teacher.Name}, Subject: {period.Subject}");
                    }
                }
            }

            Console.WriteLine($"The fitness is: {CalculateFitness(schedule)}");
        }
    }
}
