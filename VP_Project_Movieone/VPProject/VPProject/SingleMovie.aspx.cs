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
        int movieID;

        protected void Page_Load(object sender, EventArgs e)
        {
            // movieID = int.Parse(Request.QueryString["id"].ToString());

            //dataView.DataSource = DBOperations.ConnObject.getMovieDetails(movieID);
            //dataView.DataBind();
            //ratingCount.Text = DBOperations.ConnObject.getRating(movieID).ToString();
            //totalReviewsLabel.Text = DBOperations.ConnObject.getReviewCount(movieID).ToString();
        }

        protected void reviewButton_Click(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
            {
                Response.Redirect("~/home.aspx");
                Response.Write("Only Registered Users are allowed to write review!.");
            }
            else
            {

                Response.Redirect("~/home.aspx");
            }
        }
    }
}