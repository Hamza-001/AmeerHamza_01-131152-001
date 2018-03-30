namespace VP_Assignment2
{
    partial class ViewAttendance
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
            this.search = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Semester :";
            // 
            // enteredValue
            // 
            this.enteredValue.Location = new System.Drawing.Point(128, 36);
            this.enteredValue.Name = "enteredValue";
            this.enteredValue.Size = new System.Drawing.Size(140, 20);
            this.enteredValue.TabIndex = 12;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(287, 34);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 13;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(24, 88);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(338, 249);
            this.resultBox.TabIndex = 14;
            this.resultBox.UseCompatibleStateImageBehavior = false;
            this.resultBox.View = System.Windows.Forms.View.List;
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.enteredValue);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enteredValue;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListView resultBox;
    }
}