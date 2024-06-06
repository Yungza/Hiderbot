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
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CreateTeacher
            // 
            this.button_CreateTeacher.Location = new System.Drawing.Point(906, 547);
            this.button_CreateTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CreateTeacher.Name = "button_CreateTeacher";
            this.button_CreateTeacher.Size = new System.Drawing.Size(344, 43);
            this.button_CreateTeacher.TabIndex = 0;
            this.button_CreateTeacher.Text = "New teacher";
            this.button_CreateTeacher.UseVisualStyleBackColor = true;
            this.button_CreateTeacher.Click += new System.EventHandler(this.button_CreateTeacher_Click);
            // 
            // button_TeacherList
            // 
            this.button_TeacherList.Location = new System.Drawing.Point(906, 594);
            this.button_TeacherList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TeacherList.Name = "button_TeacherList";
            this.button_TeacherList.Size = new System.Drawing.Size(344, 41);
            this.button_TeacherList.TabIndex = 1;
            this.button_TeacherList.Text = "Show existing teachers";
            this.button_TeacherList.UseVisualStyleBackColor = true;
            this.button_TeacherList.Click += new System.EventHandler(this.button_TeacherList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(900, 600);
            this.dataGridViewSchedule.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(906, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(906, 84);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(344, 43);
            this.button_help.TabIndex = 5;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TeacherList);
            this.Controls.Add(this.button_CreateTeacher);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateTeacher;
        private System.Windows.Forms.Button button_TeacherList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_help;
    }
}

