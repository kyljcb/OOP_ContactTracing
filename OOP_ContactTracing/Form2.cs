using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ContactTracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_Q1.Text = "Have you visited any affected geographic area / country within the last 30 days?";
            tb_Q2.Text = "Have you attended a mass gathering, party or reunion with relatives or friends within the last 30 days?";
            tb_Q3.Text = "Have you been in close contact with a COVID-19 positive patient?";
            tb_Q4.Text = "Have you been in close contact with a person under investigation (PUI)?";
            tb_Q5.Text = "Do you have any flu-like / respiratory symptoms? (eg. fever, cough, runny nose, sore throat, headache, shortness of breath.)";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
