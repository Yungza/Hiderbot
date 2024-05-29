using Hiderbot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiderbot
{
    public partial class Form1 : Form
    {
        List <Teacher> teachers = new List <Teacher> ();
        public Form1()
        {
            InitializeComponent();
            Data data = new Data();
            Algorithm algorithm = new Algorithm();
            List<List<Period>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            algorithm.Print(schedule, data.classes);


            /*List<List<List<Period>>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            algorithm.Print(schedule, data.classes);
            DisplaySchedule(schedule, data.classes);
            */
        }
        private void DisplaySchedule(List<List<List<Period>>> schedule, List<Class> classes)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            List<ListBox> listBoxes = new List<ListBox> { listBox1, listBox2, listBox3, listBox4, listBox5 };

            for (int day = 0; day < schedule.Count; day++)
            {
                listBoxes[day].Items.Clear();
                listBoxes[day].Items.Add(daysOfWeek[day] + ":");

                for (int classIndex = 0; classIndex < schedule[day].Count; classIndex++)
                {
                    listBoxes[day].Items.Add("  Class " + classes[classIndex].ClassNumber + ":");
                    foreach (var period in schedule[day][classIndex])
                    {
                        listBoxes[day].Items.Add($"    {period.Subject} : {period.Teacher.Name}");
                    }
                }
            }
        }

        private void button_CreateTeacher_Click(object sender, EventArgs e)
        {
            NewTeacher newTeacher = new NewTeacher();
            newTeacher.Show();
        }

        private void button_TeacherList_Click(object sender, EventArgs e)
        {
            string list = "";
            foreach (Teacher teacher in TeachersList.teachersList)
            {
                list += teacher.Name + ": " + teacher.Subjects[0];
                if (teacher.Subjects.Count > 1)
                {
                    if (teacher.Subjects[1] != null && teacher.Subjects[1] != "")
                    {
                        list += ", " + teacher.Subjects[1];
                    }
                }
                list += "\n";
                
            }
            MessageBox.Show(list);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
/*
Credits:
Filip : coding and visionary

Honza : coding 

Bára : ฅ^•ﻌ•^ฅ

David : HiderBot™, pure sexappeal, mustache





.
.
.

tobi : pijavice(did nothing but complained)



*/
