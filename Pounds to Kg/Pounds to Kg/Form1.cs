using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pounds_to_Kg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textweight.Text);
            double result = 0.0;

            if (radiokg.Checked)
            {
                result = weight * 2.205;
                textBox1.Text = "Anser is " + result + " pounds";
            }
            else
            if(radiolbs.Checked)
            {
                result = weight / 2.205;
                textBox1.Text = "Anser is " + result + " kilograms";
            }



            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textweight.Text = "";
            textBox1.Text = "";

            radiokg.Checked = false;
            radiolbs.Checked = false;
        }
    }
}
