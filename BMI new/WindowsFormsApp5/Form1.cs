using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            textHeight.Text = "";
            textWeight.Text = "";
            textBMI.Text = "";

            radioKilograms.Checked = false;
            radioPounds.Checked = false;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textWeight.Text);
            double height = Convert.ToDouble(textHeight.Text);
            double result = 0.0;

            string result2;

            if (radioKilograms.Checked)
            {
                result = weight / (height * height);
            }
            else
            if (radioPounds.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }
          





            textBMI.Text = "YOUR BMI IS: " + result.ToString("#.#");


            /*
             * Underweight = <18.5
             * Healthy weight = 18.5 - 24.9
             * Overweight = 25-29.9
             * Obesity = >30
             */
        }
    }
}
