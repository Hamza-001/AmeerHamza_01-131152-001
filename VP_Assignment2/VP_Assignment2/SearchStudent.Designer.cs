namespace VP_Assignment2
{
    partial class SearchStudent
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
            this.enteredValue = new System.Windows.Forms.TextBox();
            this.byName = new System.Windows.Forms.RadioButton();
            this.byEnroll = new System.Windows.Forms.RadioButton();
            this.bySemester = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Value :";
            // 
            // enteredValue
            // 
            this.enteredValue.Location = new System.Drawing.Point(111, 41);
            this.enteredValue.Name = "enteredValue";
            this.enteredValue.Size = new System.Drawing.Size(130, 20);
            this.enteredValue.TabIndex = 1;
            // 
            // byName
            // 
            this.byName.AutoSize = true;
            this.byName.Location = new System.Drawing.Point(109, 75);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(68, 17);
            this.byName.TabIndex = 2;
            this.byName.TabStop = true;
            this.byName.Text = "By Name";
            this.byName.UseVisualStyleBackColor = true;
            // 
            // byEnroll
            // 
            this.byEnroll.AutoSize = true;
            this.byEnroll.Location = new System.Drawing.Point(183, 75);
            this.byEnroll.Name = "byEnroll";
            this.byEnroll.Size = new System.Drawing.Size(89, 17);
            this.byEnroll.TabIndex = 3;
            this.byEnroll.TabStop = true;
            this.byEnroll.Text = "By Enrollment";
            this.byEnroll.UseVisualStyleBackColor = true;
            // 
            // bySemester
            // 
            this.bySemester.AutoSize = true;
            this.bySemester.Location = new System.Drawing.Point(281, 75);
            this.bySemester.Name = "bySemester";
            this.bySemester.Size = new System.Drawing.Size(84, 17);
            this.bySemester.TabIndex = 4;
            this.bySemester.TabStop = true;
            this.bySemester.Text = "By Semester";
            this.bySemester.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Type";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(281, 39);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(84, 23);
            this.search.TabIndex = 6;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(27, 114);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(338, 235);
            this.resultBox.TabIndex = 7;
            this.resultBox.UseCompatibleStateImageBehavior = false;
            this.resultBox.View = System.Windows.Forms.View.List;
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bySemester);
            this.Controls.Add(this.byEnroll);
            this.Controls.Add(this.byName);
            this.Controls.Add(this.enteredValue);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(210, 210);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enteredValue;
        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.RadioButton byEnroll;
        private System.Windows.Forms.RadioButton bySemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListView resultBox;
    }
}