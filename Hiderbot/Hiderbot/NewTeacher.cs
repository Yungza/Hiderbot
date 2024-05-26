using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiderbot
{
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void button_NewTeacherInput_Click(object sender, EventArgs e)
        {
            string name = textBox_NewTeacerName.Text;
            List <string> subjects = new List<string>();
            subjects.Add(textBox_NewTeacherSubject1.Text);
            subjects.Add(textBox_NewTeacherSubject2.Text);
            Teacher newTeacher = new Teacher(name, subjects);
            TeachersList.AddTeacher(newTeacher);
            this.Close();
        }
    }
}
