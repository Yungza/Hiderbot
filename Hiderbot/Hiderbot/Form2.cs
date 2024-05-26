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
    public partial class Form2 : Form
    {
        private void button2_1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void exit2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        public Form2()
        {
            InitializeComponent();
            //SetFormFullScreen();
        }


        private void SetFormFullScreen()
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;
            // Hide the window borders
            this.FormBorderStyle = FormBorderStyle.None;


        }
    }
}
