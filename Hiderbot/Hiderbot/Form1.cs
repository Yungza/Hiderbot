using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*momentální funkcionalita kódu, aneb co přidal filip:
 * možnost klikat mezi formy 1,2(lze jich snadno přidat víc), komboboxy by si měly pamatovat svojí value i když překlikneš
 * nová class s názvem Data
 * propojení komboboxů -> když vybereš učitele v kb1 budou v kb2 pouze předměty co učí ten učitel
 * tlačítko na zavření formu
 * funkce, které udělá fullscreen(momentálně vypnutá)
 */
namespace Hiderbot
{
    public partial class Form1 : Form
    {
        public List<Teacher> teachers;
        public List<string> subjects;
        public static class ComboBoxValues
        {
            public static Dictionary<ComboBox, string> comboBoxValues { get; } = new Dictionary<ComboBox, string>();
        }
        public static class ComboBoxSelections
        {
            public static string SelectedTeacher { get; set; }
            public static string SelectedSubject { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            Data data = new Data();

            teachers = data.teachers;
            subjects = data.subjects;

            foreach (Teacher teacher in teachers)
            {
                comboBox1.Items.Add(teacher.Name);
            }
            foreach (string subject in subjects)
            {
                comboBox2.Items.Add(subject);
            }

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboBoxSelections.SelectedTeacher))
            {
                comboBox1.SelectedItem = ComboBoxSelections.SelectedTeacher;
            }

            if (!string.IsNullOrEmpty(ComboBoxSelections.SelectedSubject))
            {
                comboBox2.SelectedItem = ComboBoxSelections.SelectedSubject;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacherName = comboBox1.SelectedItem.ToString();
            ComboBoxSelections.SelectedTeacher = selectedTeacherName;

            Teacher selectedTeacher = null;

            foreach (Teacher teacher in teachers)
            {
                if (teacher.Name == selectedTeacherName)
                {                   
                    selectedTeacher = teacher;                   
                    break;
                }
            }
            if (selectedTeacher != null)
            {
                comboBox2.Items.Clear();
                foreach (string subject in selectedTeacher.Subjects)
                {
                    comboBox2.Items.Add(subject);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = comboBox2.SelectedItem.ToString();
            ComboBoxSelections.SelectedSubject = selectedSubject;

      
            List<Teacher> filteredTeachers = new List<Teacher>();
            foreach (Teacher teacher in teachers)
            {
                if (teacher.Subjects.Contains(selectedSubject))
                {
                    filteredTeachers.Add(teacher);
                }
            }

           
            comboBox1.Items.Clear();
            foreach (Teacher teacher in filteredTeachers)
            {
                comboBox1.Items.Add(teacher.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
    }
}

    


