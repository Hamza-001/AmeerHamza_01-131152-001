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
    public partial class Main : Form
    {
        
        //public Main()
        //{
        //    InitializeComponent();
        //    obj = new Profile(path);
        //}
        public Main(string path)
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewAttendance form = new ViewAttendance();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertRecord form = new InsertRecord();
            form.ShowDialog();
        }

       

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            DeleteRecord form = new DeleteRecord();
            form.ShowDialog();
        }

        private void topStudents_Click(object sender, EventArgs e)
        {
            
            TopStudents form = new TopStudents();
            form.ShowDialog();
        }

        private void searchStudent_Click(object sender, EventArgs e)
        {
            SearchStudent form = new SearchStudent();
            form.ShowDialog();
        }

        private void markAttendance_Click(object sender, EventArgs e)
        {
            MarkAttendance form = new MarkAttendance();
            form.ShowDialog();
        }
    }
}
