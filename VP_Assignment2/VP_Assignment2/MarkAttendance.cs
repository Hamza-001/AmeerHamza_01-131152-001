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
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            List<string> result =Profile.profile.searchSemester(Convert.ToInt32(enteredValue.Text));
            string[] data = result.ToArray();
            Boolean[] attendance = new Boolean[data.Length];
            int count = 0;
            if (result != null)
            {
                foreach (string line in data)
                {
                    string[] words = line.Split(' ');
                    if (MessageBox.Show(words[0] + " " + words[1] +" "+words[2] + " is Present?", "Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        attendance[count] = true;
                    }
                    else
                        attendance[count] = false;

                    count++;
                }
                Profile.profile.markAttendance(Convert.ToInt32(enteredValue.Text), attendance);
                MessageBox.Show("Attendance Marked Successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }

        }
    }
}
