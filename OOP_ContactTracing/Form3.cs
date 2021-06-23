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
        // code to access variable from form2
        public Form3(String tb_Name)
        {
            InitializeComponent();
            this.tb_Name = tb_Name;
        }
        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
           // code to write the text file from previous form.
             StreamReader sr = new StreamReader(Application.StartupPath + "\\Contact Tracing\\" + this.tb_Name + ".txt");
             Form.Text = sr.ReadToEnd();
             sr.Close();
        }
        private void btn_Done_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the application
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // exit application when pressing the "x" button. 
        }
    }
}
