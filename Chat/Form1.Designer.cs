namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.To2 = new System.Windows.Forms.Button();
            this.To3 = new System.Windows.Forms.Button();
            this.View1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 0;
            // 
            // To2
            // 
            this.To2.Location = new System.Drawing.Point(400, 24);
            this.To2.Name = "To2";
            this.To2.Size = new System.Drawing.Size(131, 23);
            this.To2.TabIndex = 1;
            this.To2.Tag = "To2";
            this.To2.Text = "To2";
            this.To2.UseVisualStyleBackColor = true;
            this.To2.Click += new System.EventHandler(this.button_Click);
            // 
            // To3
            // 
            this.To3.Location = new System.Drawing.Point(574, 25);
            this.To3.Name = "To3";
            this.To3.Size = new System.Drawing.Size(132, 23);
            this.To3.TabIndex = 2;
            this.To3.Tag = "To3";
            this.To3.Text = "To3";
            this.To3.UseVisualStyleBackColor = true;
            this.To3.Click += new System.EventHandler(this.button_Click);
            // 
            // View1
            // 
            this.View1.Location = new System.Drawing.Point(12, 156);
            this.View1.Name = "View1";
            this.View1.Size = new System.Drawing.Size(694, 212);
            this.View1.TabIndex = 3;
            this.View1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 380);
            this.Controls.Add(this.View1);
            this.Controls.Add(this.To3);
            this.Controls.Add(this.To2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button To2;
        private System.Windows.Forms.Button To3;
        private System.Windows.Forms.RichTextBox View1;
    }
}

