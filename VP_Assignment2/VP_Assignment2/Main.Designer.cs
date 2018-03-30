namespace VP_Assignment2
{
    partial class Main
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
            this.insertRecord = new System.Windows.Forms.Button();
            this.searchStudent = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.markAttendance = new System.Windows.Forms.Button();
            this.topStudents = new System.Windows.Forms.Button();
            this.viewAttendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertRecord
            // 
            this.insertRecord.Location = new System.Drawing.Point(102, 167);
            this.insertRecord.Name = "insertRecord";
            this.insertRecord.Size = new System.Drawing.Size(113, 35);
            this.insertRecord.TabIndex = 0;
            this.insertRecord.Text = "Insert Record";
            this.insertRecord.UseVisualStyleBackColor = true;
            this.insertRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(257, 167);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(113, 35);
            this.searchStudent.TabIndex = 1;
            this.searchStudent.Text = "Search Student";
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Location = new System.Drawing.Point(414, 168);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(113, 34);
            this.deleteRecord.TabIndex = 2;
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // markAttendance
            // 
            this.markAttendance.Location = new System.Drawing.Point(257, 255);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(113, 37);
            this.markAttendance.TabIndex = 3;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = true;
            this.markAttendance.Click += new System.EventHandler(this.markAttendance_Click);
            // 
            // topStudents
            // 
            this.topStudents.Location = new System.Drawing.Point(102, 256);
            this.topStudents.Name = "topStudents";
            this.topStudents.Size = new System.Drawing.Size(113, 34);
            this.topStudents.TabIndex = 4;
            this.topStudents.Text = "Top Students";
            this.topStudents.UseVisualStyleBackColor = true;
            this.topStudents.Click += new System.EventHandler(this.topStudents_Click);
            // 
            // viewAttendance
            // 
            this.viewAttendance.Location = new System.Drawing.Point(414, 253);
            this.viewAttendance.Name = "viewAttendance";
            this.viewAttendance.Size = new System.Drawing.Size(113, 37);
            this.viewAttendance.TabIndex = 5;
            this.viewAttendance.Text = "View Attendance";
            this.viewAttendance.UseVisualStyleBackColor = true;
            this.viewAttendance.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Profile";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAttendance);
            this.Controls.Add(this.topStudents);
            this.Controls.Add(this.markAttendance);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.insertRecord);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Main";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertRecord;
        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button markAttendance;
        private System.Windows.Forms.Button topStudents;
        private System.Windows.Forms.Button viewAttendance;
        private System.Windows.Forms.Label label1;
    }
}

