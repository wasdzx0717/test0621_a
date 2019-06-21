using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0621_gitPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "OK !";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "OK 2 !";
            //master changed...
            //button2 changed...
        }
    }
}
