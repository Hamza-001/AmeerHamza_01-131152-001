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

        protected void reviewButton_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Write("Login to write reviews!");
            else
            {

                Response.Redirect("~/SingleMovie.aspx");
            }
        }
    }
}