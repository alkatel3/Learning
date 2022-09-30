using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int valye))
            {
                algorithm.Items.Add(valye);
                label1.Text += " " + valye;
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            algorithm.Sort();
            foreach(var valye in algorithm.Items)
            {
                label2.Text += " " + valye;
            }
        }
    }
}
