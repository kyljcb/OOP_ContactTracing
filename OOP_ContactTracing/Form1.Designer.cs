
namespace OOP_ContactTracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_ContactNo = new System.Windows.Forms.TextBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.tb_Temperature = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(84, 21);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(334, 27);
            this.tb_Name.TabIndex = 0;
            // 
            // tb_Age
            // 
            this.tb_Age.Location = new System.Drawing.Point(479, 21);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(125, 27);
            this.tb_Age.TabIndex = 1;
            this.tb_Age.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(84, 97);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(660, 27);
            this.tb_Address.TabIndex = 2;
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.Location = new System.Drawing.Point(107, 134);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(235, 27);
            this.tb_ContactNo.TabIndex = 3;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(84, 63);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(63, 24);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(157, 63);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(78, 24);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // tb_Temperature
            // 
            this.tb_Temperature.Location = new System.Drawing.Point(157, 175);
            this.tb_Temperature.Name = "tb_Temperature";
            this.tb_Temperature.Size = new System.Drawing.Size(125, 27);
            this.tb_Temperature.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(14, 24);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(56, 20);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "Name: ";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(430, 24);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(43, 20);
            this.label_Age.TabIndex = 8;
            this.label_Age.Text = "Age: ";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(14, 63);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(64, 20);
            this.label_Gender.TabIndex = 9;
            this.label_Gender.Text = "Gender: ";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(14, 104);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(69, 20);
            this.label_Address.TabIndex = 10;
            this.label_Address.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Body Temperature: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.tb_Temperature);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.tb_ContactNo);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.tb_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_ContactNo;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox textbox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Temperature;
    }
}

