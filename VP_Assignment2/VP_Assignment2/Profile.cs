using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VP_Assignment2
{
    class Profile
    {
        private string path;

        private static Profile obj;

        public static Profile profile
        {
            get
            {
                if (obj == null)
                    obj = new Profile();
                return obj;
            }
        }

        private Profile()
        {
            this.path = "Data.txt";


            if (File.Exists(this.path) == false)
            {
                createProfile();
            }
        }

        private void createProfile()
        {
            using (StreamWriter sw = File.CreateText(path))
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

        public Boolean insertRecord(string studentID, string name, float gpa, int semester, string dept, string uni)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = true;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(studentID) == true)
                {
                    MessageBox.Show("Sorry, Student ID is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
            return flag;
        }



        public List<string> searchID(string studentID)
        {
            StreamReader file = new StreamReader(path);
            string line;
            List<string> result = new List<string>();
            
            bool flag = false;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(studentID) == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        line += " " + file.ReadLine();
                    }
                    result.Add( line );
                    flag = true;
                    break;
                }
            }
            file.Close();

            if (flag == false)
            {
                MessageBox.Show("Invalid Search Value OR No such Data Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }


        public List<string> searchName(string name)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;
            List<string> result = new List<string>();

            string temp = string.Empty;
            int counter = 1;

            while ((line = file.ReadLine()) != null)
            {
                temp += line + " ";

                if (counter % 7 == 0)
                {
                    if (temp.Contains(name) == true)
                    {
                        result.Add(temp.Remove(temp.Length - 8));
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
                MessageBox.Show("Invalid Search Value OR No such Data Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }




        public List<string> searchSemester(int semester)
        {
            StreamReader file = new StreamReader(path);
            string line;
            bool flag = false;
            int totalStudents = 0;
            string temp = string.Empty;
            int counter = 1;
            List<string> result = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                temp += line + " ";

                if (counter % 7 == 0)
                {
                    if (temp.Contains(" " + semester.ToString()) == true)
                    {
                        result.Add( temp.Remove(temp.Length - 8) );
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
                MessageBox.Show("Invalid Search Value OR No such Data Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Total Students Found: " + totalStudents, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return result;
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
                    MessageBox.Show("Record Deleted Sucessfully.", "Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No match found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public string[] topList(int semester)
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
                    if (temp.Contains("\t" + semester.ToString() + "\t") == true)
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


            string[] result = new string[3];
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
                            result[counter] = data[i];
                            Console.WriteLine(data[i] + "\n");
                            counter++;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("No match found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }


        public void markAttendance(int semester, bool [] attendance)
        {
            StreamReader file = new StreamReader(path);
            string line;
            Boolean flag = false;

            string temp = string.Empty;
            int counter = 1;
            int index = 0;

            List<string> requiredData = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                temp += line + "\t";

                if (counter % 7 == 0)
                {
                    if (temp.Contains("\t" + semester.ToString() + "\t") == true)
                    {
                        
                        if (attendance[index]==true)
                        {
                            temp = temp.Replace("Absent", "Present");
                        }
                        else
                        {
                            temp = temp.Replace("Present", "Absent");
                        }
                       
                        requiredData.Add(temp);
                        temp = string.Empty;
                        flag = true;
                        index++;
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
                   
            }
        }



        public List<string> viewAttendance(int semester)
        {
            StreamReader file = new StreamReader(path);
            string line;
            string temp = string.Empty;
            int counter = 1;
            Boolean flag = false;
            List<string> result = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                temp += line + " ";

                if (counter % 7 == 0)
                {
                    if (temp.Contains(" " + semester.ToString() + " ") == true)
                    {
                        result.Add(temp );
                        temp = string.Empty;
                        flag = true;
                    }
                    else
                        temp = string.Empty;
                }
                counter++;
            }
            file.Close();
            if (flag == false)
            {
                MessageBox.Show("Invalid Search Value OR No Such Data Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
