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
            this.SuspendLayout();
            // 
            // button_CreateTeacher
            // 
            this.button_CreateTeacher.Location = new System.Drawing.Point(656, 306);
            this.button_CreateTeacher.Name = "button_CreateTeacher";
            this.button_CreateTeacher.Size = new System.Drawing.Size(132, 54);
            this.button_CreateTeacher.TabIndex = 0;
            this.button_CreateTeacher.Text = "New teacher";
            this.button_CreateTeacher.UseVisualStyleBackColor = true;
            this.button_CreateTeacher.Click += new System.EventHandler(this.button_CreateTeacher_Click);
            // 
            // button_TeacherList
            // 
            this.button_TeacherList.Location = new System.Drawing.Point(656, 387);
            this.button_TeacherList.Name = "button_TeacherList";
            this.button_TeacherList.Size = new System.Drawing.Size(132, 51);
            this.button_TeacherList.TabIndex = 1;
            this.button_TeacherList.Text = "Show existing teachers";
            this.button_TeacherList.UseVisualStyleBackColor = true;
            this.button_TeacherList.Click += new System.EventHandler(this.button_TeacherList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_TeacherList);
            this.Controls.Add(this.button_CreateTeacher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CreateTeacher;
        private System.Windows.Forms.Button button_TeacherList;
    }
}

