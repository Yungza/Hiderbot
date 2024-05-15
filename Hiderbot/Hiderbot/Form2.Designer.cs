namespace Hiderbot
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
            this.button2_1 = new System.Windows.Forms.Button();
            this.exit2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2_1
            // 
            this.button2_1.Location = new System.Drawing.Point(12, 9);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(75, 23);
            this.button2_1.TabIndex = 0;
            this.button2_1.Text = "<--";
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.button2_1_Click);
            // 
            // exit2
            // 
            this.exit2.Location = new System.Drawing.Point(91, 9);
            this.exit2.Name = "exit2";
            this.exit2.Size = new System.Drawing.Size(28, 23);
            this.exit2.TabIndex = 5;
            this.exit2.Text = "x";
            this.exit2.UseVisualStyleBackColor = true;
            this.exit2.Click += new System.EventHandler(this.exit2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 678);
            this.Controls.Add(this.exit2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2_1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2_1;
        private System.Windows.Forms.Button exit2;
        private System.Windows.Forms.Button button1;
    }
}