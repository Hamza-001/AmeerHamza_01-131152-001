using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Student_Profile
{
    class Profile
    {     
        private string path;

        public Profile(string path)
        {
            this.path = path;


            if(File.Exists(this.path)==false)
            {
                createProfile();
            }
        }

        private void createProfile()
        {
            using (StreamWriter sw=File.CreateText(path))
            {
                sw.WriteLine("01-131152-001");
                sw.WriteLine("Ameer Hamza"); 
                sw.WriteLine(3.3f);
                sw.WriteLine(6);
                sw.WriteLine("SE");
                sw.WriteLine("Bahria University");
                sw.WriteLine("Absent");

                sw.WriteLine("01-131152-009");
                sw.WriteLine("Fiza Asif");
                sw.WriteLine(3.4f);
                sw.WriteLine(6);
                sw.WriteLine("SE");
                sw.WriteLine("Bahria University");
                sw.WriteLine("Absent");

                sw.WriteLine("01-131152-016");
                sw.WriteLine("Mishal Shahid");
                sw.WriteLine(3.6f);
                sw.WriteLine(6);
                sw.WriteLine("SE");
                sw.WriteLine("Bahria University");
                sw.WriteLine("Absent");

                sw.WriteLine("01-131152-036");
                sw.WriteLine("Sana Arooj");
                sw.WriteLine(3.8f);
                sw.WriteLine(6);
                sw.WriteLine("SE");
                sw.WriteLine("Bahria University");
                sw.WriteLine("Absent");

                sw.WriteLine("01-135226-011");
                sw.WriteLine("Huzaifa Sajjad");
                sw.WriteLine(3.9f);
                sw.WriteLine(6);
                sw.WriteLine("SE");
                sw.WriteLine("Bahria University");
                sw.WriteLine("Absent");

                sw.Close();
            }
            
        }

        public void insertRecord(string studentID, string name, float gpa, int semester, string dept, string uni)
        {
            StreamReader file = new StreamReader(path); 
            string line;
            bool flag = true;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(studentID) == true)
                {
                    Console.WriteLine("\tSorry, Student ID is already in use.");
                    flag = false;
                    break;
                }
            }
            file.Close();

            if (flag == true)
            {
                using (StreamWriter obj = File.AppendText(path)) 
                {
                    obj.WriteLine(studentID);
                    obj.WriteLine(name);
                    obj.WriteLine(gpa);
                    obj.WriteLine(semester);
                    obj.WriteLine(dept);
                    obj.WriteLine(uni);
                    obj.WriteLine("Absent");
                    obj.Close();
                }
            }
        }



        public void searchID(string studentID)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(studentID) == true)
                {
                    for(int i=0; i<5;i++) 
                    {
                        line +=" "+ file.ReadLine();
                    }
                    Console.WriteLine("\t" + line+"\n");
                    flag = true;
                    break;
                }
            }
            file.Close();

            if(flag==false)
            {
                Console.WriteLine("\tNo Match Found");
            }
        }


        public void searchName(string name)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;

            string temp=string.Empty;
            int counter = 1;

            while ((line = file.ReadLine()) != null)
            {
                temp += line + " ";
                
                if(counter % 7 == 0)   
                {
                    if (temp.Contains(name) == true)
                    {
                        Console.WriteLine("\t" + temp.Remove(temp.Length - 8) + "\n");
                        flag = true;
                        temp = string.Empty;
                    }
                    else
                        temp = string.Empty;
                    
                }
                counter++;       
            }
            file.Close();

            if (flag == false)
            {
                Console.WriteLine("\tNo Match Found");
            }
        }




        public void searchSemester(int semester)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;
            int totalStudents = 0;
            string temp = string.Empty;
            int counter = 1;

            while ((line = file.ReadLine()) != null)
            {
                temp += line + " ";

                if (counter % 7 == 0)
                {
                    if (temp.Contains(" "+semester.ToString()) == true)
                    {
                        Console.WriteLine("\t"+temp.Remove(temp.Length - 8)+"\n");
                        flag = true;
                        temp = string.Empty;
                        totalStudents++;
                    }
                    else
                        temp = string.Empty;
                }
                counter++;
            }
            file.Close();

            if (flag == false)
            {
                Console.WriteLine("\tNo Match Found\n");
            }
            Console.WriteLine("\tTotal Students Found: "+totalStudents+"\n");
        }


        public void deleteData(string ID)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;

            string temp = string.Empty;
            int counter = 1;

            List<string> modifiedData = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                temp += line + "\t";

                if (counter % 7 == 0)
                {
                    if (temp.Contains(ID) != true)
                    {
                        modifiedData.Add(temp);
                        flag = true;
                        temp = string.Empty;
                    }
                    else
                        temp = string.Empty;
                }
                counter++;
            }
            file.Close();            
                            
            if (flag == true)
            {
                string[] data = modifiedData.ToArray();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        string[] words = data[i].Split('\t');

                        for (int j = 0; j < words.Length - 1; j++)
                        {
                            sw.WriteLine(words[j]);
                        }
                    }
                    file.Close();
                    Console.WriteLine("\tRecord Deleted Sucessfully.\n");
                }
            }
            else
            {
                Console.WriteLine("\tNo Match Found\n");
            }
        }



        public void topList(int semester)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;
           
            string temp = string.Empty;
            int counter = 1;

            List<string> requiredData = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                temp += line + "\t";

                if (counter % 7 == 0)
                {
                    if (temp.Contains("\t"+semester.ToString()+"\t") == true)
                    {
                        requiredData.Add(temp.Remove(temp.Length - 8));
                        temp = string.Empty;
                        flag = true;
                    }
                    else
                        temp = string.Empty;
                }
                counter++;
            }
            file.Close();



            if (flag == true)
            {

                string[] data = requiredData.ToArray();
                float[] gpa = new float[data.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    string[] words = data[i].Split('\t');
                    gpa[i] = float.Parse(words[2]);
                }

                Array.Sort(gpa);
                counter = 0;

                for (int i = gpa.Length - 1; i > gpa.Length - 4; i--)
                {
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data[j].Contains("\t" + gpa[i].ToString() + "\t") == true)
                        {
                            Console.WriteLine(data[i] + "\n");
                            counter++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\tNo Match Found\n");
            }

        }


        public void markAttendance(int semester)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;
            char attendance;

            string temp = string.Empty;
            int counter = 1;

            List<string> requiredData = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                temp += line + "\t";

                if (counter % 7 == 0)
                {
                    if (temp.Contains("\t" + semester.ToString() + "\t") == true)
                    {
                        Console.WriteLine("\n\tPress A for Absent & P for Present: \n");
                        Console.WriteLine(temp);
                        attendance=Convert.ToChar( Console.ReadLine());
                        if(attendance=='a' || attendance=='A')
                        {
                            temp=temp.Replace("Present", "Absent");
                        }
                        else if (attendance=='p' || attendance=='P')
                        {
                            temp=temp.Replace("Absent", "Present");

                        }
                        else
                        {
                            Console.WriteLine("\t Invalid Choice!.");
                            System.Environment.Exit(-1);
                        }
                        requiredData.Add(temp);
                        temp = string.Empty;
                        flag = true;
                    }
                    else
                    {
                        requiredData.Add(temp);
                        temp = string.Empty;
                    }
                }
                counter++;
            }
            file.Close();



            if (flag == true)
            {

                string[] data = requiredData.ToArray();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        string[] words = data[i].Split('\t');

                        for (int j = 0; j < words.Length - 1; j++)
                        {
                            sw.WriteLine(words[j]);
                        }
                    }
                    file.Close();
                    Console.WriteLine("\tAttendance Marked Successfully\n");

                }
            }
            else
            {
                Console.WriteLine("\tNo Record Found of Particular Class.\n");
            }

            }


        public void viewAttendance(int semester)
        {
            StreamReader file = new StreamReader(path);
            string line;
            string temp = string.Empty;
            int counter = 1;

            while ((line = file.ReadLine()) != null)
            {
                temp += line + " ";

                if (counter % 7 == 0)
                {
                    if (temp.Contains(" " + semester.ToString() + " ") == true)
                    {
                        Console.WriteLine("\t"+temp+"\n");
                        temp = string.Empty;
                    }
                    else
                        temp = string.Empty;
                }
                counter++;
            }
            file.Close();
        }
    }
}
