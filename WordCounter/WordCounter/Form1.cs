using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = textBox1.Text.Trim();
            MessageBox.Show("Number of words:" + CountWords(words));    

        }

        private int CountWords(string words)
        {
            string[] allWords = words.Split(' ');
            return allWords.Length;

        }


    }
}
