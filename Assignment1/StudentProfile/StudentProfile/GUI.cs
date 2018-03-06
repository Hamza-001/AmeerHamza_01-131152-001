using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Profile
{
    class GUI
    {
        public void header()
        {
            Console.WriteLine("\t\t\t -------------------------------");
            Console.WriteLine("\t\t\t|                               |");
            Console.WriteLine("\t\t\t|\tSTUDENT PROFILE\t\t|");
            Console.WriteLine("\t\t\t|                               |");
            Console.WriteLine("\t\t\t -------------------------------\n\n");

        }

        public void mainMenu()
        {
            Console.Clear();
            header();
            Console.WriteLine("\t\t1) Insert Record \t 2) Search Student\n");
            Console.WriteLine("\t\t3) Delete Record \t 4) List Top 3 Student of Class\n");
            Console.WriteLine("\t\t5) Mark Attendance \t 6) View Attendance\n");
        }

        public void searchMenu()
        {
            Console.Clear();
            header();
            Console.WriteLine("\t1) Search by ID\n");
            Console.WriteLine("\t2) Search by Name\n");
            Console.WriteLine("\t3) Search by Semester\n");
        }



    }
}
