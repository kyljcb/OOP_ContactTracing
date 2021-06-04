
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
            this.label_ContactNo = new System.Windows.Forms.Label();
            this.label_BodyTemp = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(105, 24);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(416, 30);
            this.tb_Name.TabIndex = 0;
            // 
            // tb_Age
            // 
            this.tb_Age.Location = new System.Drawing.Point(599, 24);
            this.tb_Age.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(90, 30);
            this.tb_Age.TabIndex = 1;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(105, 126);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(584, 111);
            this.tb_Address.TabIndex = 2;
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.Location = new System.Drawing.Point(134, 262);
            this.tb_ContactNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(293, 30);
            this.tb_ContactNo.TabIndex = 3;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(105, 72);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(70, 27);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.CheckedChanged += new System.EventHandler(this.rb_Male_CheckedChanged);
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(196, 72);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(88, 27);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            this.rb_Female.CheckedChanged += new System.EventHandler(this.rb_Female_CheckedChanged);
            // 
            // tb_Temperature
            // 
            this.tb_Temperature.Location = new System.Drawing.Point(198, 315);
            this.tb_Temperature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Temperature.Name = "tb_Temperature";
            this.tb_Temperature.Size = new System.Drawing.Size(95, 30);
            this.tb_Temperature.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(18, 28);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(67, 23);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "Name: ";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Age.Location = new System.Drawing.Point(538, 28);
            this.label_Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(52, 23);
            this.label_Age.TabIndex = 8;
            this.label_Age.Text = "Age: ";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(18, 75);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(79, 23);
            this.label_Gender.TabIndex = 9;
            this.label_Gender.Text = "Gender: ";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(18, 126);
            this.label_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(84, 23);
            this.label_Address.TabIndex = 10;
            this.label_Address.Text = "Address: ";
            // 
            // label_ContactNo
            // 
            this.label_ContactNo.AutoSize = true;
            this.label_ContactNo.Location = new System.Drawing.Point(18, 270);
            this.label_ContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ContactNo.Name = "label_ContactNo";
            this.label_ContactNo.Size = new System.Drawing.Size(105, 23);
            this.label_ContactNo.TabIndex = 11;
            this.label_ContactNo.Text = "Contact No.";
            // 
            // label_BodyTemp
            // 
            this.label_BodyTemp.AutoSize = true;
            this.label_BodyTemp.Location = new System.Drawing.Point(18, 315);
            this.label_BodyTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BodyTemp.Name = "label_BodyTemp";
            this.label_BodyTemp.Size = new System.Drawing.Size(168, 23);
            this.label_BodyTemp.TabIndex = 12;
            this.label_BodyTemp.Text = "Body Temperature: ";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(571, 370);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(118, 33);
            this.btn_Next.TabIndex = 13;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 416);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label_BodyTemp);
            this.Controls.Add(this.label_ContactNo);
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
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label_ContactNo;
        private System.Windows.Forms.Label label_BodyTemp;
        private System.Windows.Forms.TextBox tb_Temperature;
        private System.Windows.Forms.Button btn_Next;
    }
}

