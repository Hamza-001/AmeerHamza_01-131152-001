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
    public partial class ViewAttendance : Form
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void search_Click_1(object sender, EventArgs e)
        {
            resultBox.Items.Clear();
            List<string> result = Profile.profile.viewAttendance(Convert.ToInt32(enteredValue.Text));
            foreach (string line in result)
            {
                resultBox.Items.Add(line);
            }
        }
    }
}
