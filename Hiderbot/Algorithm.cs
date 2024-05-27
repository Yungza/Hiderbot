﻿using System;
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
        }

        public List<List<Period>> Generator(List<Teacher> teachers, List<Class> classes)
        {
            List<List<Period>> scheduleAll = new List<List<Period>>();
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

            var subjectTeacherMap = new Dictionary<string, List<Teacher>>();

            // Prepare a map of subjects to teachers
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

            // Shuffle teachers for each subject group
            foreach (var key in subjectTeacherMap.Keys.ToList())
            {
                ListExtensions.Shuffle(subjectTeacherMap[key]);
            }

            // Assign periods
            foreach (var subjectList in subjectsAll)
            {
                List<Period> schedule = new List<Period>();

                foreach (var subject in subjectList)
                {
                    if (subjectTeacherMap.ContainsKey(subject))
                    {
                        var availableTeachers = subjectTeacherMap[subject];
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
            var teacherScheduleMap = new Dictionary<Teacher, HashSet<int>>();

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
                        fitness -= 10;
                    }
                    else
                    {
                        teacherScheduleMap[teacher].Add(j);
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

            return bestSchedule;
        }



        public void Print(List<List<Period>> scheduleAll, List<Class> classes, List<string> output)
        {
            for (int i = 0; i < scheduleAll.Count; i++)
            {
                Console.WriteLine($"Class {classes[i].ClassNumber}:");
                foreach (var period in scheduleAll[i])
                {
                    Console.WriteLine($"  Teacher: {period.Teacher.Name}, Subject: {period.Subject}");
                    output.Add($"{period.Subject} : {period.Teacher.Name}");


                }
            }
            Console.WriteLine($" The fitness is: {CalculateFitness(scheduleAll)}");
        }



    }
}