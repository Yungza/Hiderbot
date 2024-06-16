using Hiderbot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hiderbot
{
    public partial class Form1 : Form
    {
        List<Teacher> teachers = new List<Teacher>();
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Schedule.csv"); //stackoverflow for path
        public Form1()
        {
            InitializeComponent();
            Data data = new Data();
            Algorithm algorithm = new Algorithm();
            /*
            List<List<Period>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            algorithm.Print(schedule, data.classes);
            FunctionsCSV.LoadCsvToDataGridView(dataGridViewSchedule, @"C:\Users\tobia\Documents\GitHub\Hiderbot\Hiderbot\Schedule.CSV");*/
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
            List<List<List<Period>>> weekSchedule = algorithm.GenerateWeek(TeachersList.teachersList, data.classes);
            List<List<Period>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            FunctionsCSV.SaveScheduleToCsv(weekSchedule, filePath);
            FunctionsCSV.LoadCsvToDataGridView(dataGridViewSchedule, filePath);

            //algorithm.Print(weekSchedule, data.classes);
        }

        private void button_ExportFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a folder where to save the schedule";
            string folderPath = null;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath = fbd.SelectedPath;
            }
            if (folderPath != null)
            {
                filePath = folderPath + "/Schedule.csv";
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to HiderBot! Gymvod's best schedule generator" +
                "\nPress start to start the algorithm" +
                "\nEach row has the schedule for one day for a given class" +
                "\nThe default schedule filepath is your documents folder" +
                "\nThe programe always imports/exports using the file \"Schedule.csv\"" +
                "\nGenerating a new schedule automatically overwrites the old one" +
                "\nEnjoy our app, if you happen to find any bugs, let us know!" +
                "");
        }

        private void button_saveFromGridView_Click(object sender, EventArgs e)
        {
            FunctionsCSV.SaveDataGridViewToCsv(dataGridViewSchedule, filePath);
        }

        private void button_loadTableFromCSV_Click(object sender, EventArgs e)
        {
            FunctionsCSV.LoadCsvToDataGridView(dataGridViewSchedule, filePath);
        }

        private void button_rickroll_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(); // credit https://tpforums.org/forum/archive/index.php/t-1524.html and others
            psi.CreateNoWindow = true;
            psi.UseShellExecute = true;
            psi.FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(psi);
        }
    }

}
/*
Credits:
Filip : coding and visionary

Honza : coding 

tobi : UI, display, csv

Bára : ฅ^•ﻌ•^ฅ

David : HiderBot™, pure sexappeal, mustache

*/
