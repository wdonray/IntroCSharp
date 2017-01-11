namespace WindowsForms
{
    partial class Form1
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
            this.Raise = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Lower = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Raise
            // 
            this.Raise.Location = new System.Drawing.Point(96, 45);
            this.Raise.Name = "Raise";
            this.Raise.Size = new System.Drawing.Size(100, 23);
            this.Raise.TabIndex = 0;
            this.Raise.Text = "Raise";
            this.Raise.UseVisualStyleBackColor = true;
            this.Raise.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(96, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Lower
            // 
            this.Lower.Location = new System.Drawing.Point(96, 116);
            this.Lower.Name = "Lower";
            this.Lower.Size = new System.Drawing.Size(100, 23);
            this.Lower.TabIndex = 2;
            this.Lower.Text = "Lower";
            this.Lower.UseVisualStyleBackColor = true;
            this.Lower.Click += new System.EventHandler(this.Lower_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(96, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 60);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Lower);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Raise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Raise;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Lower;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

