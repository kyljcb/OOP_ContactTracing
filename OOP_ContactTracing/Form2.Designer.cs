
namespace OOP_ContactTracing
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Q1 = new System.Windows.Forms.TextBox();
            this.tb_Q2 = new System.Windows.Forms.TextBox();
            this.tb_Q3 = new System.Windows.Forms.TextBox();
            this.tb_Q4 = new System.Windows.Forms.TextBox();
            this.tb_Q5 = new System.Windows.Forms.TextBox();
            this.label_Yes = new System.Windows.Forms.Label();
            this.label_No = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_Q1Yes = new System.Windows.Forms.CheckBox();
            this.cb_Q1No = new System.Windows.Forms.CheckBox();
            this.cb_Q2Yes = new System.Windows.Forms.CheckBox();
            this.cb_Q3Yes = new System.Windows.Forms.CheckBox();
            this.cb_Q4Yes = new System.Windows.Forms.CheckBox();
            this.cb_Q5Yes = new System.Windows.Forms.CheckBox();
            this.cb_Q2No = new System.Windows.Forms.CheckBox();
            this.cb_Q3No = new System.Windows.Forms.CheckBox();
            this.cb_Q4No = new System.Windows.Forms.CheckBox();
            this.cb_Q5No = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Q1
            // 
            this.tb_Q1.Location = new System.Drawing.Point(12, 45);
            this.tb_Q1.Multiline = true;
            this.tb_Q1.Name = "tb_Q1";
            this.tb_Q1.Size = new System.Drawing.Size(498, 59);
            this.tb_Q1.TabIndex = 0;
            // 
            // tb_Q2
            // 
            this.tb_Q2.Location = new System.Drawing.Point(12, 110);
            this.tb_Q2.Multiline = true;
            this.tb_Q2.Name = "tb_Q2";
            this.tb_Q2.Size = new System.Drawing.Size(498, 59);
            this.tb_Q2.TabIndex = 1;
            // 
            // tb_Q3
            // 
            this.tb_Q3.Location = new System.Drawing.Point(11, 175);
            this.tb_Q3.Multiline = true;
            this.tb_Q3.Name = "tb_Q3";
            this.tb_Q3.Size = new System.Drawing.Size(498, 40);
            this.tb_Q3.TabIndex = 2;
            this.tb_Q3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_Q4
            // 
            this.tb_Q4.Location = new System.Drawing.Point(11, 221);
            this.tb_Q4.Multiline = true;
            this.tb_Q4.Name = "tb_Q4";
            this.tb_Q4.Size = new System.Drawing.Size(498, 40);
            this.tb_Q4.TabIndex = 5;
            // 
            // tb_Q5
            // 
            this.tb_Q5.Location = new System.Drawing.Point(12, 267);
            this.tb_Q5.Multiline = true;
            this.tb_Q5.Name = "tb_Q5";
            this.tb_Q5.Size = new System.Drawing.Size(498, 62);
            this.tb_Q5.TabIndex = 6;
            // 
            // label_Yes
            // 
            this.label_Yes.AutoSize = true;
            this.label_Yes.Location = new System.Drawing.Point(567, 19);
            this.label_Yes.Name = "label_Yes";
            this.label_Yes.Size = new System.Drawing.Size(30, 20);
            this.label_Yes.TabIndex = 7;
            this.label_Yes.Text = "Yes";
            // 
            // label_No
            // 
            this.label_No.AutoSize = true;
            this.label_No.Location = new System.Drawing.Point(628, 19);
            this.label_No.Name = "label_No";
            this.label_No.Size = new System.Drawing.Size(29, 20);
            this.label_No.TabIndex = 8;
            this.label_No.Text = "No";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(567, 392);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_Q1Yes
            // 
            this.cb_Q1Yes.AutoSize = true;
            this.cb_Q1Yes.Location = new System.Drawing.Point(567, 63);
            this.cb_Q1Yes.Name = "cb_Q1Yes";
            this.cb_Q1Yes.Size = new System.Drawing.Size(18, 17);
            this.cb_Q1Yes.TabIndex = 20;
            this.cb_Q1Yes.UseVisualStyleBackColor = true;
            this.cb_Q1Yes.CheckedChanged += new System.EventHandler(this.cb_Q1Yes_CheckedChanged);
            // 
            // cb_Q1No
            // 
            this.cb_Q1No.AutoSize = true;
            this.cb_Q1No.Location = new System.Drawing.Point(628, 63);
            this.cb_Q1No.Name = "cb_Q1No";
            this.cb_Q1No.Size = new System.Drawing.Size(18, 17);
            this.cb_Q1No.TabIndex = 21;
            this.cb_Q1No.UseVisualStyleBackColor = true;
            this.cb_Q1No.CheckedChanged += new System.EventHandler(this.cb_Q1No_CheckedChanged);
            // 
            // cb_Q2Yes
            // 
            this.cb_Q2Yes.AutoSize = true;
            this.cb_Q2Yes.Location = new System.Drawing.Point(567, 131);
            this.cb_Q2Yes.Name = "cb_Q2Yes";
            this.cb_Q2Yes.Size = new System.Drawing.Size(18, 17);
            this.cb_Q2Yes.TabIndex = 22;
            this.cb_Q2Yes.UseVisualStyleBackColor = true;
            this.cb_Q2Yes.CheckedChanged += new System.EventHandler(this.cb_Q2Yes_CheckedChanged);
            // 
            // cb_Q3Yes
            // 
            this.cb_Q3Yes.AutoSize = true;
            this.cb_Q3Yes.Location = new System.Drawing.Point(567, 181);
            this.cb_Q3Yes.Name = "cb_Q3Yes";
            this.cb_Q3Yes.Size = new System.Drawing.Size(18, 17);
            this.cb_Q3Yes.TabIndex = 23;
            this.cb_Q3Yes.UseVisualStyleBackColor = true;
            this.cb_Q3Yes.CheckedChanged += new System.EventHandler(this.cb_Q3Yes_CheckedChanged);
            // 
            // cb_Q4Yes
            // 
            this.cb_Q4Yes.AutoSize = true;
            this.cb_Q4Yes.Location = new System.Drawing.Point(567, 227);
            this.cb_Q4Yes.Name = "cb_Q4Yes";
            this.cb_Q4Yes.Size = new System.Drawing.Size(18, 17);
            this.cb_Q4Yes.TabIndex = 24;
            this.cb_Q4Yes.UseVisualStyleBackColor = true;
            this.cb_Q4Yes.CheckedChanged += new System.EventHandler(this.cb_Q4Yes_CheckedChanged);
            // 
            // cb_Q5Yes
            // 
            this.cb_Q5Yes.AutoSize = true;
            this.cb_Q5Yes.Location = new System.Drawing.Point(567, 295);
            this.cb_Q5Yes.Name = "cb_Q5Yes";
            this.cb_Q5Yes.Size = new System.Drawing.Size(18, 17);
            this.cb_Q5Yes.TabIndex = 25;
            this.cb_Q5Yes.UseVisualStyleBackColor = true;
            this.cb_Q5Yes.CheckedChanged += new System.EventHandler(this.cb_Q5Yes_CheckedChanged);
            // 
            // cb_Q2No
            // 
            this.cb_Q2No.AutoSize = true;
            this.cb_Q2No.Location = new System.Drawing.Point(628, 131);
            this.cb_Q2No.Name = "cb_Q2No";
            this.cb_Q2No.Size = new System.Drawing.Size(18, 17);
            this.cb_Q2No.TabIndex = 26;
            this.cb_Q2No.UseVisualStyleBackColor = true;
            this.cb_Q2No.CheckedChanged += new System.EventHandler(this.cb_Q2No_CheckedChanged);
            // 
            // cb_Q3No
            // 
            this.cb_Q3No.AutoSize = true;
            this.cb_Q3No.Location = new System.Drawing.Point(628, 181);
            this.cb_Q3No.Name = "cb_Q3No";
            this.cb_Q3No.Size = new System.Drawing.Size(18, 17);
            this.cb_Q3No.TabIndex = 27;
            this.cb_Q3No.UseVisualStyleBackColor = true;
            this.cb_Q3No.CheckedChanged += new System.EventHandler(this.cb_Q3No_CheckedChanged);
            // 
            // cb_Q4No
            // 
            this.cb_Q4No.AutoSize = true;
            this.cb_Q4No.Location = new System.Drawing.Point(628, 227);
            this.cb_Q4No.Name = "cb_Q4No";
            this.cb_Q4No.Size = new System.Drawing.Size(18, 17);
            this.cb_Q4No.TabIndex = 28;
            this.cb_Q4No.UseVisualStyleBackColor = true;
            this.cb_Q4No.CheckedChanged += new System.EventHandler(this.cb_Q4No_CheckedChanged);
            // 
            // cb_Q5No
            // 
            this.cb_Q5No.AutoSize = true;
            this.cb_Q5No.Location = new System.Drawing.Point(628, 295);
            this.cb_Q5No.Name = "cb_Q5No";
            this.cb_Q5No.Size = new System.Drawing.Size(18, 17);
            this.cb_Q5No.TabIndex = 29;
            this.cb_Q5No.UseVisualStyleBackColor = true;
            this.cb_Q5No.CheckedChanged += new System.EventHandler(this.cb_Q5No_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_Q5No);
            this.Controls.Add(this.cb_Q4No);
            this.Controls.Add(this.cb_Q3No);
            this.Controls.Add(this.cb_Q2No);
            this.Controls.Add(this.cb_Q5Yes);
            this.Controls.Add(this.cb_Q4Yes);
            this.Controls.Add(this.cb_Q3Yes);
            this.Controls.Add(this.cb_Q2Yes);
            this.Controls.Add(this.cb_Q1No);
            this.Controls.Add(this.cb_Q1Yes);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label_No);
            this.Controls.Add(this.label_Yes);
            this.Controls.Add(this.tb_Q5);
            this.Controls.Add(this.tb_Q4);
            this.Controls.Add(this.tb_Q3);
            this.Controls.Add(this.tb_Q2);
            this.Controls.Add(this.tb_Q1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Q1;
        private System.Windows.Forms.TextBox tb_Q2;
        private System.Windows.Forms.TextBox tb_Q3;
        private System.Windows.Forms.TextBox tb_Q4;
        private System.Windows.Forms.TextBox tb_Q5;
        private System.Windows.Forms.Label label_Yes;
        private System.Windows.Forms.Label label_No;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.CheckBox cb_Q1Yes;
        private System.Windows.Forms.CheckBox cb_Q1No;
        private System.Windows.Forms.CheckBox cb_Q2Yes;
        private System.Windows.Forms.CheckBox cb_Q3Yes;
        private System.Windows.Forms.CheckBox cb_Q4Yes;
        private System.Windows.Forms.CheckBox cb_Q5Yes;
        private System.Windows.Forms.CheckBox cb_Q2No;
        private System.Windows.Forms.CheckBox cb_Q3No;
        private System.Windows.Forms.CheckBox cb_Q4No;
        private System.Windows.Forms.CheckBox cb_Q5No;
        private System.Windows.Forms.TextBox textBox1;
    }
}