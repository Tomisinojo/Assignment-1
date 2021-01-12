using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        private double amount = 0; // conversion value to convert from
        private double convAmount = 0; // conversion result value
        private int selection = 0; // which radio button - 1 for first, 2 for second... 0 unchecked, send message to user
        private int conversion = 0; // 1 for lengths, 2 for weights, 3 for currency, 4 for temperatures

        public Form1()
        {
            InitializeComponent();
            numUpDown1.DecimalPlaces = 2; // allow 2 decimal places for drop-down
            numUpDown1.Increment = 0.01M; // increment in 1s in 2 decimal places
            numUpDown1.Value = 1; // set 1 as default value
        }
        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn1.Checked == true)
            {
                selection = 1;
            }
        }

        private void radioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn2.Checked == true)
            {
                selection = 2;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            switch (conversion) // which conversion to make
            {
                case 1: // length - cm and inches
                    switch (selection)
                    {
                        case 1:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = amount * 0.393701;
                            lbl1.Text = amount + " cm  = " + Convert.ToString(convAmount) + " inches";
                            break;
                        case 2:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = amount * 2.54;
                            lbl1.Text = amount + " inches = " + Convert.ToString(convAmount) + " cm";
                            break;
                        default:
                            MessageBox.Show("Please make a selection!", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            break;
                    }
                    break;
                case 2: // weight - pounds and kg
                    switch (selection)
                    {
                        case 1:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = amount * 0.453592;
                            lbl1.Text = amount + " kg  = " + Convert.ToString(convAmount) + " lbs";
                            break;
                        case 2:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = amount * 2.20462;
                            lbl1.Text = amount + " lbs = " + Convert.ToString(convAmount) + " kg";
                            break;
                        default:
                            MessageBox.Show("Please make a selection!", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            break;
                    }
                    break;
                case 3: // currency - GBP and euro
                    switch (selection)
                    {
                        case 1:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = amount * 0.86;
                            lbl1.Text = "€" + amount + " = £" + Convert.ToString(convAmount);
                            break;
                        case 2:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = amount * 1.16;
                            lbl1.Text = "£" + amount + " = €" + Convert.ToString(convAmount); ;
                            break;
                        default:
                            MessageBox.Show("Please make a selection!", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            break;
                    }
                    break;
                case 4: // temperature - celsius and fahrenheit
                    switch (selection)
                    {
                        case 1:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = (amount * (9.0 / 5)) + 32;
                            lbl1.Text = amount + "\u00b0C = " + Convert.ToString(convAmount) + "\u00b0F";
                            break;
                        case 2:
                            amount = Convert.ToDouble(numUpDown1.Value);
                            convAmount = (5.0 / 9) * (amount - 32);
                            lbl1.Text = amount + "\u00b0F = " + Convert.ToString(convAmount) + "\u00b0C";
                            break;
                        default:
                            MessageBox.Show("Please make a selection!", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            break;
                    }
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            conversion = 0;
            lbl1.Text = "";
            numUpDown1.Value = 1;
        }

        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioBtn1.Text = "Centimetres to Inches";
            radioBtn2.Text = "Inches to Centimetres";
            pnl1.Visible = true;
            conversion = 1;
        }

        private void weightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioBtn1.Text = "Pounds to Kilograms";
            radioBtn2.Text = "Kilograms to Pounds";
            pnl1.Visible = true;
            conversion = 2;
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioBtn1.Text = "Euro to GBP";
            radioBtn2.Text = "GBP to Euro";
            pnl1.Visible = true;
            conversion = 3;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioBtn1.Text = "Celsius to Fahrenheit";
            radioBtn2.Text = "Fahrenheit to Celsius";
            pnl1.Visible = true;
            conversion = 4;
        }
    }
}
