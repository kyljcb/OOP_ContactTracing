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
            this.Hide(); // hides form1
            Form2 f = new Form2(tb_Name.Text, tb_Age.Text, Gender, tb_Address.Text, tb_ContactNo.Text, tb_Temperature.Text);
            f.Show();//shows form2
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // exit application when pressing the "x" button. 
        }
    }
}
