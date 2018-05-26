using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.SessionState;
using System.Configuration;
using System.Data;

namespace VPProject
{
    public class DBOperations 
    {

        private SqlConnection sqlConn = null;

        private static DBOperations connection;

        public static DBOperations ConnObject
        {
            get
            {
                if (connection == null)
                    connection = new DBOperations();
                return connection;
            }
        }


        private DBOperations()
        {

        }

        public bool IsConnect()
        {
            if (sqlConn == null)
            {
                string connstring = ConfigurationManager.ConnectionStrings["connect"].ToString();
                sqlConn = new SqlConnection(connstring);
                sqlConn.Open();
            }
            return true;
        }

         public bool loginAuthentication(string userEmail,string password)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "SELECT * FROM [dbo].[users] where email=@email and password=@password";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                    cmd.Parameters.AddWithValue("@email", userEmail);
                    cmd.Parameters.AddWithValue("@password", password);

                    if (cmd.ExecuteScalar().ToString() != null)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Source.ToString();
            }
            return false;
        }

        public bool registerUser(string name, string email, string password)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "insert into [dbo].[users] values (@name,@email,@password);";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                   
                    if (cmd.ExecuteNonQuery().ToString() == "1")
                        return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string getUsername(string email)
        {
            string name = null;
            try
            {
                if (IsConnect())
                {
                    string query = "select name from [dbo].[users] where email= @email";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                    cmd.Parameters.AddWithValue("@email", email);
                    name = cmd.ExecuteScalar().ToString();
                    return name;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return name;
        }



        public DataTable getMovies()
        {
            DataTable movieDataTable = new DataTable();
           try
            {
                if (IsConnect())
                {
                    string query = "select * from Movies;";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
                    sda.Fill(movieDataTable);
                    return movieDataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return movieDataTable;
        }



    }
}
