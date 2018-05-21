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

         public bool loginAuthentication(string username,string password)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "SELECT * FROM [dbo].[login] where username='" + username + "' and password='" + password + "';";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);

                    string output = cmd.ExecuteScalar().ToString();

                    if (output == "-1")
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public bool registerUser(string tableValues)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "insert into [dbo].[users] values (" + tableValues + ");";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);

                    string output = cmd.ExecuteNonQuery().ToString();
                    if (output == "1")
                        return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
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
