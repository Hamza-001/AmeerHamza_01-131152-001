using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.SessionState;
using System.Configuration;

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

         public bool login(string username,string password)
        {
            try
            {
                if (IsConnect())
                {
                    string query = "SELECT * FROM [dbo].[login] where username='" + username + "' and password='" + password + "';";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);

                    string output = cmd.ExecuteScalar().ToString();

                    if (output == "1")
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

    }
}
