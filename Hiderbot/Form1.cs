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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hiderbot
{
    public partial class Form1 : Form
    {
        List <Teacher> teachers = new List <Teacher> ();
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Schedule.CSV"); //stackoverflow for path
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
            
            try
            {
                List<List<Period>> schedule = algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
                //algorithm.Print(schedule, data.classes);
                FunctionsCSV.SaveScheduleToCsv(schedule, filePath);
                FunctionsCSV.LoadCsvToDataGridView(dataGridViewSchedule, filePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Select export folder first");
                throw;
            }
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
                "Press start to start the algorithm" +
                "The default finished schedule filepath is you documents folder" +
                "Enjoy our app, if you happen to find any bugs, let us know!");
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
