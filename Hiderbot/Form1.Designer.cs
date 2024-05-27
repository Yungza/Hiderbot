namespace Hiderbot
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
            this.button_CreateTeacher = new System.Windows.Forms.Button();
            this.button_TeacherList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_CreateTeacher
            // 
            this.button_CreateTeacher.Location = new System.Drawing.Point(916, 496);
            this.button_CreateTeacher.Name = "button_CreateTeacher";
            this.button_CreateTeacher.Size = new System.Drawing.Size(132, 54);
            this.button_CreateTeacher.TabIndex = 0;
            this.button_CreateTeacher.Text = "New teacher";
            this.button_CreateTeacher.UseVisualStyleBackColor = true;
            this.button_CreateTeacher.Click += new System.EventHandler(this.button_CreateTeacher_Click);
            // 
            // button_TeacherList
            // 
            this.button_TeacherList.Location = new System.Drawing.Point(916, 556);
            this.button_TeacherList.Name = "button_TeacherList";
            this.button_TeacherList.Size = new System.Drawing.Size(132, 51);
            this.button_TeacherList.TabIndex = 1;
            this.button_TeacherList.Text = "Show existing teachers";
            this.button_TeacherList.UseVisualStyleBackColor = true;
            this.button_TeacherList.Click += new System.EventHandler(this.button_TeacherList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(41, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 424);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(268, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(221, 424);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(495, 35);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(221, 424);
            this.listBox3.TabIndex = 5;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(722, 35);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(221, 424);
            this.listBox4.TabIndex = 6;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Location = new System.Drawing.Point(947, 35);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(221, 424);
            this.listBox5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 615);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TeacherList);
            this.Controls.Add(this.button_CreateTeacher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateTeacher;
        private System.Windows.Forms.Button button_TeacherList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
    }
}

