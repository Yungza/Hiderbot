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
            this.button_ExportFolderSelect = new System.Windows.Forms.Button();
            this.button_saveFromGridView = new System.Windows.Forms.Button();
            this.button_loadTableFromCSV = new System.Windows.Forms.Button();
            this.button_rickroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CreateTeacher
            // 
            this.button_CreateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_CreateTeacher.Location = new System.Drawing.Point(766, 481);
            this.button_CreateTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_CreateTeacher.Name = "button_CreateTeacher";
            this.button_CreateTeacher.Size = new System.Drawing.Size(84, 35);
            this.button_CreateTeacher.TabIndex = 0;
            this.button_CreateTeacher.Text = "New teacher";
            this.button_CreateTeacher.UseVisualStyleBackColor = true;
            this.button_CreateTeacher.Click += new System.EventHandler(this.button_CreateTeacher_Click);
            // 
            // button_TeacherList
            // 
            this.button_TeacherList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_TeacherList.Location = new System.Drawing.Point(854, 483);
            this.button_TeacherList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TeacherList.Name = "button_TeacherList";
            this.button_TeacherList.Size = new System.Drawing.Size(84, 33);
            this.button_TeacherList.TabIndex = 1;
            this.button_TeacherList.Text = "Show existing";
            this.button_TeacherList.UseVisualStyleBackColor = true;
            this.button_TeacherList.Click += new System.EventHandler(this.button_TeacherList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(11, 28);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(750, 488);
            this.dataGridViewSchedule.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(766, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_help
            // 
            this.button_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_help.Location = new System.Drawing.Point(766, 68);
            this.button_help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(84, 35);
            this.button_help.TabIndex = 5;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_ExportFolderSelect
            // 
            this.button_ExportFolderSelect.Location = new System.Drawing.Point(766, 108);
            this.button_ExportFolderSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ExportFolderSelect.Name = "button_ExportFolderSelect";
            this.button_ExportFolderSelect.Size = new System.Drawing.Size(172, 35);
            this.button_ExportFolderSelect.TabIndex = 6;
            this.button_ExportFolderSelect.Text = "Select folder";
            this.button_ExportFolderSelect.UseVisualStyleBackColor = true;
            this.button_ExportFolderSelect.Click += new System.EventHandler(this.button_ExportFolderSelect_Click);
            // 
            // button_saveFromGridView
            // 
            this.button_saveFromGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_saveFromGridView.Location = new System.Drawing.Point(766, 148);
            this.button_saveFromGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_saveFromGridView.Name = "button_saveFromGridView";
            this.button_saveFromGridView.Size = new System.Drawing.Size(84, 35);
            this.button_saveFromGridView.TabIndex = 7;
            this.button_saveFromGridView.Text = "Save table";
            this.button_saveFromGridView.UseVisualStyleBackColor = true;
            this.button_saveFromGridView.Click += new System.EventHandler(this.button_saveFromGridView_Click);
            // 
            // button_loadTableFromCSV
            // 
            this.button_loadTableFromCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_loadTableFromCSV.Location = new System.Drawing.Point(854, 148);
            this.button_loadTableFromCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_loadTableFromCSV.Name = "button_loadTableFromCSV";
            this.button_loadTableFromCSV.Size = new System.Drawing.Size(84, 35);
            this.button_loadTableFromCSV.TabIndex = 8;
            this.button_loadTableFromCSV.Text = "Load table";
            this.button_loadTableFromCSV.UseVisualStyleBackColor = true;
            this.button_loadTableFromCSV.Click += new System.EventHandler(this.button_loadTableFromCSV_Click);
            // 
            // button_rickroll
            // 
            this.button_rickroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_rickroll.Location = new System.Drawing.Point(854, 68);
            this.button_rickroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rickroll.Name = "button_rickroll";
            this.button_rickroll.Size = new System.Drawing.Size(84, 35);
            this.button_rickroll.TabIndex = 9;
            this.button_rickroll.Text = "Video tutorial";
            this.button_rickroll.UseVisualStyleBackColor = true;
            this.button_rickroll.Click += new System.EventHandler(this.button_rickroll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.button_rickroll);
            this.Controls.Add(this.button_loadTableFromCSV);
            this.Controls.Add(this.button_saveFromGridView);
            this.Controls.Add(this.button_ExportFolderSelect);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TeacherList);
            this.Controls.Add(this.button_CreateTeacher);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(964, 594);
            this.MinimumSize = new System.Drawing.Size(964, 594);
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
        private System.Windows.Forms.Button button_ExportFolderSelect;
        private System.Windows.Forms.Button button_saveFromGridView;
        private System.Windows.Forms.Button button_loadTableFromCSV;
        private System.Windows.Forms.Button button_rickroll;
    }
}

