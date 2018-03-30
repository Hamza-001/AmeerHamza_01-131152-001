namespace VP_Assignment2
{
    partial class InsertRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.gpa = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.TextBox();
            this.uni = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GPA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "University :";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(155, 40);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(157, 20);
            this.studentID.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(155, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 20);
            this.name.TabIndex = 7;
            // 
            // gpa
            // 
            this.gpa.Location = new System.Drawing.Point(155, 136);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(157, 20);
            this.gpa.TabIndex = 8;
            this.gpa.TextChanged += new System.EventHandler(this.gpa_TextChanged);
            // 
            // semester
            // 
            this.semester.Location = new System.Drawing.Point(155, 184);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(157, 20);
            this.semester.TabIndex = 9;
            this.semester.TextChanged += new System.EventHandler(this.semester_TextChanged);
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(155, 234);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(157, 20);
            this.dept.TabIndex = 10;
            // 
            // uni
            // 
            this.uni.Enabled = false;
            this.uni.Location = new System.Drawing.Point(155, 282);
            this.uni.Name = "uni";
            this.uni.Size = new System.Drawing.Size(157, 20);
            this.uni.TabIndex = 11;
            this.uni.Text = "Bahria University";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.Control;
            this.submit.Location = new System.Drawing.Point(133, 326);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(111, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // InsertRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.uni);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.gpa);
            this.Controls.Add(this.name);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertRecord";
            this.Text = "Insert Record";
            this.Load += new System.EventHandler(this.InsertRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox gpa;
        private System.Windows.Forms.TextBox semester;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox uni;
        private System.Windows.Forms.Button submit;
    }
}