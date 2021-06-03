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
        //String nametext = "";
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            //nametext = tb_Name.Text;
            this.Hide();
            Form2 f = new Form2(tb_Name.Text, tb_Age.Text, Gender, tb_Address.Text, tb_ContactNo.Text, tb_Temperature.Text);
            //Form3 x = new Form3(nametext);
            f.Show();

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
