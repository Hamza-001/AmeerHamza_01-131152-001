using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment2
{
    public partial class InsertRecord : Form
    {

        public InsertRecord()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void InsertRecord_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (studentID.Text != null && name.Text != null && gpa.Text != null && semester.Text != null && dept.Text != null)
            {
                
                if( Profile.profile.insertRecord(studentID.Text.ToString(), name.Text.ToString(), float.Parse(gpa.Text), Int32.Parse(semester.Text), dept.Text.ToString(), uni.Text.ToString()) )
                {
                    MessageBox.Show("Record has been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }

            }
            else
                MessageBox.Show("Form is incomplete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gpa_TextChanged(object sender, EventArgs e)
        {
            if(float.Parse(gpa.Text)< 0.0 || float.Parse(gpa.Text) > 4.0)
            {
                MessageBox.Show("Invalid GPA. GPA should be between range (0.0 to 4.0)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void semester_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(semester.Text) < 0 || Convert.ToInt32(semester.Text) > 10)
            {
                MessageBox.Show("Invalid Semester. Semester should be between range (0 to 10)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }
    }
}
