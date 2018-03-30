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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            if(byEnroll.Checked == true && enteredValue.Text != null)
            {
                List<string> result = Profile.profile.searchID(enteredValue.Text.ToString());
                foreach(string line in result)
                {
                    resultBox.Items.Add(line);
                }
            }
            else if (byName.Checked == true && enteredValue.Text != null)
            {
                List<string> result = Profile.profile.searchName(enteredValue.Text.ToString());
                foreach (string line in result)
                {
                    resultBox.Items.Add(line);
                }
                
            }
            else if (bySemester.Checked == true && enteredValue.Text != null)
            {
                List<string> result = Profile.profile.searchSemester(Convert.ToInt32(enteredValue.Text));
                foreach (string line in result)
                {
                    resultBox.Items.Add(line);
                }
;
            }
            else
                MessageBox.Show("Incomplete Infromation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
