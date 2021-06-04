using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OOP_ContactTracing
{
    public partial class Form2 : Form
    {
        // strings for question
        String Q1 = "";
        String Q2 = "";
        String Q3 = "";
        String Q4 = "";
        String Q5 = "";

        // string for variables used in form1
        string tb_Name, tb_Age, Gender, tb_Address, tb_ContactNo, tb_Temperature;

       
        public Form2()
        {
            InitializeComponent();
          
        }

        // used to acces form1 variables
        public Form2(String tb_Name, String tb_Age, String Gender, String tb_Address, String tb_ContactNo, String tb_Temperature)
        {
            InitializeComponent();

            this.tb_Name = tb_Name;
            this.tb_Age = tb_Age;
            this.Gender = Gender;
            this.tb_Address = tb_Address;
            this.tb_ContactNo = tb_ContactNo;
            this.tb_Temperature = tb_Temperature;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // assigns text to textboxes
            tb_Q1.Text = "Have you visited any affected geographic area / country within the last 30 days?";
            tb_Q2.Text = "Have you attended a mass gathering, party or reunion with relatives or friends within the last 30 days?";
            tb_Q3.Text = "Have you been in close contact with a COVID-19 positive patient?";
            tb_Q4.Text = "Have you been in close contact with a person under investigation (PUI)?";
            tb_Q5.Text = "Do you have any flu-like / respiratory symptoms? (eg. fever, cough, runny nose, sore throat, headache, shortness of breath.)";
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // code to write the inputs into a text file.
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contact Tracing\\" + this.tb_Name + ".txt");
            sw.WriteLine("Name: "  + this.tb_Name);
            sw.WriteLine("Age: " + this.tb_Age);
            sw.WriteLine("Gender: " + this.Gender);
            sw.WriteLine("Address: " + this.tb_Address);
            sw.WriteLine("Contact No.: "  + this.tb_ContactNo);
            sw.WriteLine("Body Temperature: " + this.tb_Temperature);
            sw.WriteLine(tb_Q1.Text + " " + Q1);
            sw.WriteLine(tb_Q2.Text + " " + Q2);
            sw.WriteLine(tb_Q3.Text + " " + Q3);
            sw.WriteLine(tb_Q4.Text + " " + Q4);
            sw.WriteLine(tb_Q5.Text + " " + Q5);
            sw.Close();

            Form3 f = new Form3(tb_Name);

            this.Hide();
            f.Show();
        }
        private void cb_Q1Yes_CheckedChanged(object sender, EventArgs e)
        {
            Q1 = "Yes";

        }

        private void cb_Q1No_CheckedChanged(object sender, EventArgs e)
        {
            Q1 = "No";
        }

        private void cb_Q2Yes_CheckedChanged(object sender, EventArgs e)
        {
            Q2 = "Yes";
        }

        private void cb_Q2No_CheckedChanged(object sender, EventArgs e)
        {
            Q2 = "No";
        }

        private void cb_Q3Yes_CheckedChanged(object sender, EventArgs e)
        {
            Q3 = "Yes";

        }

        private void cb_Q3No_CheckedChanged(object sender, EventArgs e)
        {
            Q3 = "No";
        }

        private void cb_Q4Yes_CheckedChanged(object sender, EventArgs e)
        {
            Q4 = "Yes";
        }

        private void cb_Q4No_CheckedChanged(object sender, EventArgs e)
        {
            Q4 = "No";
        }

        private void cb_Q5Yes_CheckedChanged(object sender, EventArgs e)
        {
            Q5 = "Yes";
        }

        private void cb_Q5No_CheckedChanged(object sender, EventArgs e)
        {
            Q5 = "No";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // exit application when pressing the "x" button. 
        }

    }
}
