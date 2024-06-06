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
            FunctionsCSV.LoadCsvToDataGridView(dataGridViewSchedule, @"C:\Users\tobia\Documents\GitHub\Hiderbot\Hiderbot\Schedule.CSV");
            /*List<List<List<Period>>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            algorithm.Print(schedule, data.classes);
            DisplaySchedule(schedule, data.classes);
            */
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

        private void button1_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            Algorithm algorithm = new Algorithm();
            List<List<Period>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            algorithm.Print(schedule, data.classes);
            FunctionsCSV.LoadCsvToDataGridView(dataGridViewSchedule, @"C:\Users\tobia\Documents\GitHub\Hiderbot\Hiderbot\Schedule.CSV");
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

tobi : 



*/
