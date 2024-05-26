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

            List<List<string>> subjects = algorithm.Generator(data.teachers, data.classes);

            algorithm.Print(subjects, data.classes);

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
                if (teacher.Subjects[1] != null && teacher.Subjects[1] != "")
                {
                    list += ", " + teacher.Subjects[1];
                }
                list += "\n";
                
            }
            MessageBox.Show(list);
        }
    }
}
