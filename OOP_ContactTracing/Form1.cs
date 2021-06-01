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
    public partial class Form1 : Form
    {
        String Gender = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            //StreamWriter outputFile;
            //outputFile = File.AppendText("Output.txt");
            //outputFile.WriteLine(label_Name.Text + tb_Name.Text);
            //outputFile.Close();

            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contact Tracing\\" + tb_Name.Text + ".txt");
            sw.WriteLine(label_Name.Text + tb_Name.Text);
            sw.WriteLine(label_Age.Text + tb_Age.Text);
            sw.WriteLine(label_Gender.Text + Gender);
            sw.WriteLine(label_Address.Text + tb_Address.Text);
            sw.WriteLine(label_ContactNo.Text + ": " + tb_ContactNo.Text);
            sw.WriteLine(label_BodyTemp.Text + tb_Temperature.Text);
            sw.Close();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";

        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";

        }
    }
}
