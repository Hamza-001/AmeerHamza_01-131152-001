namespace VP_Assignment2
{
    partial class MarkAttendance
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Semester :";
            // 
            // enteredValue
            // 
            this.enteredValue.Location = new System.Drawing.Point(172, 134);
            this.enteredValue.Name = "enteredValue";
            this.enteredValue.Size = new System.Drawing.Size(137, 20);
            this.enteredValue.TabIndex = 17;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(137, 214);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(117, 38);
            this.search.TabIndex = 18;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.search);
            this.Controls.Add(this.enteredValue);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "MarkAttendance";
            this.Text = "MarkAttendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enteredValue;
        private System.Windows.Forms.Button search;
    }
}