
namespace OOP_ContactTracing
{
    partial class Form3
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
            this.btn_ReadFile = new System.Windows.Forms.Button();
            this.Form = new System.Windows.Forms.TextBox();
            this.btn_Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ReadFile.Location = new System.Drawing.Point(203, 392);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(116, 46);
            this.btn_ReadFile.TabIndex = 0;
            this.btn_ReadFile.Text = "Show";
            this.btn_ReadFile.UseVisualStyleBackColor = true;
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadFile_Click);
            // 
            // Form
            // 
            this.Form.Location = new System.Drawing.Point(12, 12);
            this.Form.Multiline = true;
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(776, 356);
            this.Form.TabIndex = 1;
            // 
            // btn_Done
            // 
            this.btn_Done.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Done.Location = new System.Drawing.Point(453, 392);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(116, 46);
            this.btn_Done.TabIndex = 2;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.btn_ReadFile);
            this.Name = "Form3";
            this.Text = "Final check";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ReadFile;
        private System.Windows.Forms.TextBox Form;
        private System.Windows.Forms.Button btn_Done;
    }
}