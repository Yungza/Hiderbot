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

            List<string> output = new List<string> ();

            //List<List<Period>> subjects =  algorithm.Generator(data.teachers, data.classes);

            //algorithm.Print(subjects, data.classes);
            List<List<Period>> schedule =  algorithm.FindBestSchedule(TeachersList.teachersList, data.classes);
            algorithm.Print(schedule, data.classes, output);
            listBox1.Items.Add("1.A:");
            foreach (string line in output)
            {
                listBox1.Items.Add(line);
            }
            Console.WriteLine(listBox1.Items[1]);
            listBox1.Items.Insert(8, "1.B:");
            listBox1.Items.Insert(16, "1.C");
            
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
