using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_by_Hale
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);

            double sum = text1 + text2;

            textBox3.Text = sum.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);

            double sum = text1 - text2;

            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);

            double sum = text1 / text2;

            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);

            double sum = text1*+ text2;

            textBox3.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
