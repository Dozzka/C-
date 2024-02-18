namespace Chat
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
            this.View3 = new System.Windows.Forms.RichTextBox();
            this.To2 = new System.Windows.Forms.Button();
            this.To1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // View3
            // 
            this.View3.Location = new System.Drawing.Point(20, 150);
            this.View3.Name = "View3";
            this.View3.Size = new System.Drawing.Size(694, 212);
            this.View3.TabIndex = 11;
            this.View3.Text = "";
            // 
            // To2
            // 
            this.To2.Location = new System.Drawing.Point(582, 19);
            this.To2.Name = "To2";
            this.To2.Size = new System.Drawing.Size(132, 23);
            this.To2.TabIndex = 10;
            this.To2.Tag = "To2";
            this.To2.Text = "To2";
            this.To2.UseVisualStyleBackColor = true;
            this.To2.Click += new System.EventHandler(this.button_Click);
            // 
            // To1
            // 
            this.To1.Location = new System.Drawing.Point(408, 18);
            this.To1.Name = "To1";
            this.To1.Size = new System.Drawing.Size(131, 23);
            this.To1.TabIndex = 9;
            this.To1.Tag = "To1";
            this.To1.Text = "To1";
            this.To1.UseVisualStyleBackColor = true;
            this.To1.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 380);
            this.Controls.Add(this.View3);
            this.Controls.Add(this.To2);
            this.Controls.Add(this.To1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox View3;
        private System.Windows.Forms.Button To2;
        private System.Windows.Forms.Button To1;
        private System.Windows.Forms.TextBox textBox1;
    }
}