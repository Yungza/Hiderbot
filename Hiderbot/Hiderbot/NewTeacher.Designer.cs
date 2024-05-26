namespace Hiderbot
{
    partial class NewTeacher
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
            this.textBox_NewTeacerName = new System.Windows.Forms.TextBox();
            this.textBox_NewTeacherSubject1 = new System.Windows.Forms.TextBox();
            this.textBox_NewTeacherSubject2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_NewTeacherInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_NewTeacerName
            // 
            this.textBox_NewTeacerName.Location = new System.Drawing.Point(157, 23);
            this.textBox_NewTeacerName.Name = "textBox_NewTeacerName";
            this.textBox_NewTeacerName.Size = new System.Drawing.Size(100, 26);
            this.textBox_NewTeacerName.TabIndex = 0;
            // 
            // textBox_NewTeacherSubject1
            // 
            this.textBox_NewTeacherSubject1.Location = new System.Drawing.Point(157, 92);
            this.textBox_NewTeacherSubject1.Name = "textBox_NewTeacherSubject1";
            this.textBox_NewTeacherSubject1.Size = new System.Drawing.Size(100, 26);
            this.textBox_NewTeacherSubject1.TabIndex = 1;
            // 
            // textBox_NewTeacherSubject2
            // 
            this.textBox_NewTeacherSubject2.Location = new System.Drawing.Point(157, 163);
            this.textBox_NewTeacherSubject2.Name = "textBox_NewTeacherSubject2";
            this.textBox_NewTeacherSubject2.Size = new System.Drawing.Size(100, 26);
            this.textBox_NewTeacherSubject2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primary subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secondary subject";
            // 
            // button_NewTeacherInput
            // 
            this.button_NewTeacherInput.Location = new System.Drawing.Point(293, 83);
            this.button_NewTeacherInput.Name = "button_NewTeacherInput";
            this.button_NewTeacherInput.Size = new System.Drawing.Size(117, 50);
            this.button_NewTeacherInput.TabIndex = 6;
            this.button_NewTeacherInput.Text = "Create";
            this.button_NewTeacherInput.UseVisualStyleBackColor = true;
            this.button_NewTeacherInput.Click += new System.EventHandler(this.button_NewTeacherInput_Click);
            // 
            // NewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 247);
            this.Controls.Add(this.button_NewTeacherInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NewTeacherSubject2);
            this.Controls.Add(this.textBox_NewTeacherSubject1);
            this.Controls.Add(this.textBox_NewTeacerName);
            this.Name = "NewTeacher";
            this.Text = "NewTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NewTeacerName;
        private System.Windows.Forms.TextBox textBox_NewTeacherSubject1;
        private System.Windows.Forms.TextBox textBox_NewTeacherSubject2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_NewTeacherInput;
    }
}