using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Form1 : Form
    {
        List<double> values;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                values = new List<double>();
            }
            void ShowValues()
            {
                listvalues.Items.Clear();

                for (int i = 0; i < values.Count; i++)
                    listvalues.Items.Add(values[i]);

                listvalues.Text = values.Count.ToString();
            }

        }

        private void buttonclr_Click(object sender, EventArgs e)
        {
            values.Clear();
            listvalues.Items.Clear();
            textBox1.Text = "";
            textsum.Text = "";
            textmean.Text = "";
            textmedian.Text = "";
            textstd.Text = "";
            textvar.Text= "" ;
            textBox1.Focus();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            double sum = 0.0;
            double mean = 0.0;
            double variance = 0.0;
            double std = 0.0;
            double median = 0.0;

            if (textBox1.Text.Length ==0)
            {
                MessageBox.Show("You must enter a value!");
                return;
            }

            try
            {
                value = double.Parse(textBox1.Text);
                values.Add(value);

                ShowValues();
                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid");
            }

            for (int i = 0; i < values.Count; i++)
                sum += values[i];
            mean = sum / values.Count;
            // median
            values.Sort();

            // odd values
            if ((values.Count % 2) == 0)
            {
                double midIndex = values.Count / 2;
                median = (values[(int)(midIndex - 0.5)] +
                    values[(int)(midIndex + 0.5)]) / 2;
            }
            else
                median = values[values.Count / 2];

           


            textsum.Text = sum.ToString("F");
            textmean.Text = mean.ToString("F");
            textmedian.Text = median.ToString("F");
        }

        private void ShowValues()
        {
            throw new NotImplementedException();
        }
    }
}
