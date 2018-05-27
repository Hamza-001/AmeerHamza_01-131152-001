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
                string connString = ConfigurationManager.ConnectionStrings["connect"].ToString();
                sqlConn = new SqlConnection(connString);
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
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.Parameters.AddWithValue("@email", userEmail);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    if (sqlCommand.ExecuteScalar().ToString() != null)
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
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.Parameters.AddWithValue("@name", name);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@password", password);
                   
                    if (sqlCommand.ExecuteNonQuery().ToString() == "1")
                        return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string getUsername(string userID)
        {
            string name = null;
            try
            {
                if (IsConnect())
                {
                    string query = "select name from [dbo].[users] where id= @id";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.Parameters.AddWithValue("@id", userID);
                    name = sqlCommand.ExecuteScalar().ToString();
                    return name;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return name;
        }

        public int getUserID(string email)
        {
            int id =0;
            try
            {
                if (IsConnect())
                {
                    string query = "select id from [dbo].[users] where email= @email";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    id = int.Parse(sqlCommand.ExecuteScalar().ToString());
                    return id;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        public float getRating(int movieID)
        {
            float rating=0f;
            try
            {
                if (IsConnect())
                {
                    string query = "select AVG(rating) from [dbo].[MovieReview] where movie_id= @id";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.Parameters.AddWithValue("@id", movieID);
                    rating = float.Parse(sqlCommand.ExecuteScalar().ToString());
                    return rating;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rating;
        }

        public void updateRating(float newRating, int movieID)
        {
              
        }


        public int getReviewCount(int movieID)
        {
            int counter = 0;
            try
            {
                if (IsConnect())
                {
                    string query = "select count(*) from [dbo].[MovieReview] where movie_id= @id";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    sqlCommand.Parameters.AddWithValue("@id", movieID);
                    counter = int.Parse(sqlCommand.ExecuteScalar().ToString());
                    return counter;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return counter;
        }


        public DataTable getAllMovies()
        {
            DataTable movieDataTable = new DataTable();
           try
            {
                if (IsConnect())
                {
                    string query = "select * from Movies;";
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConn);
                    sqlAdapter.Fill(movieDataTable);
                    return movieDataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return movieDataTable;
        }


        public DataTable getMovieDetails(int movieID)
        {
            DataTable movieDataTable = new DataTable();
            try
            {
                if (IsConnect())
                {
                    string query = "select * from Movies where id='"+movieID+"';";
                    //SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                    //sqlCommand.Parameters.AddWithValue("@id", movieID);

                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConn);
                    sqlAdapter.Fill(movieDataTable);
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
