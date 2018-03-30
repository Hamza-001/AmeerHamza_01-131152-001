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
    public partial class TopStudents : Form
    {

        public TopStudents()
        {
            InitializeComponent();
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TopStudents_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            string []output= Profile.profile.topList(Convert.ToInt32(semester.Text));
            if (output != null)
            {
                if (output[0] != null)
                    first.Text = output[0];
                if (output[1] != null)
                    second.Text = output[1];
                if (output[2] != null)
                    third.Text = output[2];
            }
        }
    }
}
