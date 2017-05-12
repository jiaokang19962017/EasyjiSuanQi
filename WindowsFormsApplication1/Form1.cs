using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btn1 = textBox1.Text;
            string btn2 = textBox2.Text;
            int s1, s2;
            s1 = Convert.ToInt32(btn1);
            s2 = Convert.ToInt32(btn2);
            textBox3.Text = Convert.ToString(s1+s2);
        }
    }
}
