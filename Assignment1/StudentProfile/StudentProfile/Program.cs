using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI guiObj = new GUI();
            Profile obj = new Profile(args[0]);

            string ID, name, dept, uni = string.Empty;
            int semester = 0;
            float gpa = 0.0f;
            

            int choice;
            char select;
            do
            {
                Console.Clear();
                guiObj.mainMenu();
                Console.Write("\n\tSelect option (1-6): ");
                choice = Convert.ToInt32(Console.ReadLine());
                
                if (choice == 1)
                {

                    Console.Write("\tID: ");
                    ID = Convert.ToString(Console.ReadLine());
                    Console.Write("\tName: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("\tGPA: ");
                    gpa = float.Parse(Console.ReadLine());
                    if (gpa < 0.0 || gpa > 4.0)
                    {
                        Console.WriteLine("\nInvalid GPA\n");
                        System.Environment.Exit(1);
                    }
                    Console.Write("\tSemester: ");
                    semester = int.Parse(Console.ReadLine());
                    if (semester > 10 || semester <= 0)
                    {
                        Console.WriteLine("\nInvalid Semester\n");
                        System.Environment.Exit(2);
                    }
                    Console.Write("\tDepartment: ");
                    dept = Convert.ToString(Console.ReadLine());
                    Console.Write("\tUniversity: ");
                    uni = Convert.ToString(Console.ReadLine());
                    obj.insertRecord(ID, name,gpa, semester, dept, uni);
                }

                else if (choice == 2)
                {
                    int option;
                    guiObj.searchMenu();
                    Console.Write("\n\tChoose option (1 to 3): ");
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {  
                        Console.Write("\tEnter Student ID: ");
                        ID = Convert.ToString(Console.ReadLine());
                        obj.searchID(ID); 
                    }
                    else if (option == 2)
                    {
                        Console.Write("\tEnter Student Name: ");
                        name = Convert.ToString(Console.ReadLine());
                        obj.searchName(name);
                    }
                    else if (option == 3)
                    {
                        Console.Write("\tEnter Semester: ");
                        semester = int.Parse(Console.ReadLine());
                        obj.searchSemester(semester);
                    }
                    else
                            Console.WriteLine("\tInvalid selection.\n");
                }

                else if (choice == 3)
                {
                    Console.Write("\tEnter Student ID:");
                    ID = Convert.ToString(Console.ReadLine());
                    obj.deleteData(ID);
                }
                else if (choice == 4)
                {
                    Console.Write("\tEnter Semester Number:");
                    semester = Convert.ToInt32(Console.ReadLine());
                    obj.topList(semester);
                }
                else if (choice == 5)
                {
                    Console.Write("\tEnter Semester Number:");
                    semester = Convert.ToInt32(Console.ReadLine());
                    obj.markAttendance(semester);
                }
                else if (choice == 6)
                {
                    Console.Write("\tEnter Semester Number:");
                    semester = Convert.ToInt32(Console.ReadLine());
                    obj.viewAttendance(semester);
                }
                else
                {
                    Console.WriteLine("\n\tInvalid Selection.");
                }
                Console.Write("Do you want to continue (Y/N) : ");
                select = Convert.ToChar(Console.ReadLine());
            } while (select == 'Y' || select == 'y');
        }
    }
}
