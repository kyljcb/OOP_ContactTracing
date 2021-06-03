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
    public partial class Form3 : Form
    {

        string tb_Name;

        public Form3()
        {
            InitializeComponent();
            
        }
        public Form3(String tb_Name)
        {
            InitializeComponent();

            this.tb_Name = tb_Name;

        }

        //public Form3(String nametext)
        //{
        //    InitializeComponent();

        //    // this.tb_Name = tb_Name;
        //    this.nametext = nametext;
        //}

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
           
               StreamReader sr = new StreamReader(Application.StartupPath + "\\Contact Tracing\\" + this.tb_Name + ".txt");
               Form.Text = sr.ReadToEnd();
                sr.Close();
        }
    }
}
