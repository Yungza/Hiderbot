using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        public List<System.Windows.Forms.ComboBox> comboBoxes;
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

            // Initialize comboBoxes list
            comboBoxes = new List<System.Windows.Forms.ComboBox>();

            // Add all ComboBoxes to the list dynamically
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBoxes.Add(comboBox);

                    // Tag the ComboBox with the index of its related ComboBox
                    int relatedIndex = (i % 2 == 0) ? i + 1 : i - 1;
                    if (relatedIndex >= 0 && relatedIndex < this.Controls.Count && this.Controls[relatedIndex] is System.Windows.Forms.ComboBox relatedComboBox)
                    {
                        comboBox.Tag = relatedComboBox;
                    }

                    // Populate the ComboBox
                    if (i % 2 == 0) // Even index, fill with teachers
                    {
                        foreach (Teacher teacher in teachers)
                        {
                            comboBox.Items.Add(teacher.Name);
                        }
                    }
                    else // Odd index, fill with subjects
                    {
                        foreach (string subject in subjects)
                        {
                            comboBox.Items.Add(subject);
                        }
                    }

                    // Attach the event handler
                    comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;                    comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Any additional initialization can go here
        }
        /*private void GeneralComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            var relatedComboBox = comboBox.Tag as System.Windows.Forms.ComboBox;

            if (comboBox == null || relatedComboBox == null)
            {
                return;
            }

            if (comboBox.SelectedItem == null)
            {
                relatedComboBox.Items.Clear();
                return;
            }

            if (teachers.Any(t => t.Name == comboBox.SelectedItem.ToString())) // Teacher ComboBox
            {
                string selectedTeacherName = comboBox.SelectedItem.ToString();
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
                    relatedComboBox.Items.Clear();
                    foreach (string subject in selectedTeacher.Subjects)
                    {
                        relatedComboBox.Items.Add(subject);
                    }
                }
            }
            else if (subjects.Contains(comboBox.SelectedItem.ToString())) // Subject ComboBox
            {
                string selectedSubject = comboBox.SelectedItem.ToString();
                ComboBoxSelections.SelectedSubject = selectedSubject;

                List<Teacher> filteredTeachers = new List<Teacher>();
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.Subjects.Contains(selectedSubject))
                    {
                        filteredTeachers.Add(teacher);
                    }
                }

                relatedComboBox.Items.Clear();
                foreach (Teacher teacher in filteredTeachers)
                {
                    relatedComboBox.Items.Add(teacher.Name);
                }
            }
        }
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacherName = "aa";
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
            foreach (System.Windows.Forms.ComboBox comboBox in comboBoxes)
            {
                string value = comboBox.SelectedItem?.ToString();
                MessageBox.Show($"Selected value in ComboBox '{comboBox.Name}': {value}");
            }
        }
    

    private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    


