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
        public Form1()
        {
            InitializeComponent();
            LoadTeachers();
            Console.ReadKey();
        }
        void LoadTeachers()
        {
            string content = Resources.Teachers;
            using (StreamReader reader = new StreamReader(content))
            {
                string line = reader.ReadLine();
                string[] things = line.Split(',');
                foreach (string thing in things)
                {
                    Console.WriteLine(thing);
                }
            }
        }
    }
}
