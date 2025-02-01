using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_de_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gfa.Text = ((1.8 * double.Parse(gcel.Text)) + 32).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gcel.Text = ((double.Parse(gfa.Text) - 32) / 1.8).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gfa.Text = ""; gcel.Text = "";
            MessageBox.Show("se recetearon los valores de los textbox");
        }

        private void gcel_TextChanged(object sender, EventArgs e)
        {

        }

        private void gfa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
