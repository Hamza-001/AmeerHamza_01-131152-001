using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace VPProject
{
    public partial class SingleMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }
        private void ReadFromDB()
        {
            //DataTable ds = new DataTable();
            //try
            //{
            //    cmd = conn.CreateCommand();
            //    cmd.CommandText = "SELECT *FROM Article";
            //    cmd.ExecuteNonQuery();
            //    SqlDataAdapter adap = new SqlDataAdapter(cmd);
            //    adap.Fill(ds);
            //}
            }
        //protected void btnSendMessage_Click(object sender, EventArgs e)
        //{
        //    String name = txtName.Text.ToString();
        //    String phone = txtPhone.Text.ToString();
        //    String email = txtEmail.Text.ToString();
        //    String message = txtMessage.InnerText.ToString();

        //    String ConnectionString = @"Data Source=.;Initial Catalog=movieone;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    SqlConnection conn = new SqlConnection(ConnectionString);
        //    conn.Open();

        //    SqlCommand cmd = conn.CreateCommand();
        //    String query = "INSERT INTO [dbo].[usercomment] ([username],[comments],[date])VALUES('"+name+"','"+message+"','11-06-2018');";
        //    cmd.CommandText = (query);
        //    cmd.ExecuteNonQuery();
            
                   
        //}
    }
}