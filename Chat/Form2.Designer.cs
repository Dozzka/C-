namespace Chat
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
            this.View2 = new System.Windows.Forms.RichTextBox();
            this.To3 = new System.Windows.Forms.Button();
            this.To1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // View2
            // 
            this.View2.Location = new System.Drawing.Point(20, 150);
            this.View2.Name = "View2";
            this.View2.Size = new System.Drawing.Size(694, 212);
            this.View2.TabIndex = 7;
            this.View2.Text = "";
            // 
            // To3
            // 
            this.To3.Location = new System.Drawing.Point(582, 19);
            this.To3.Name = "To3";
            this.To3.Size = new System.Drawing.Size(132, 23);
            this.To3.TabIndex = 6;
            this.To3.Tag = "To3";
            this.To3.Text = "To3";
            this.To3.UseVisualStyleBackColor = true;
            this.To3.Click += new System.EventHandler(this.button_Click);
            // 
            // To1
            // 
            this.To1.Location = new System.Drawing.Point(408, 18);
            this.To1.Name = "To1";
            this.To1.Size = new System.Drawing.Size(131, 23);
            this.To1.TabIndex = 5;
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
            this.textBox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 380);
            this.Controls.Add(this.View2);
            this.Controls.Add(this.To3);
            this.Controls.Add(this.To1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox View2;
        private System.Windows.Forms.Button To3;
        private System.Windows.Forms.Button To1;
        private System.Windows.Forms.TextBox textBox1;
    }
}