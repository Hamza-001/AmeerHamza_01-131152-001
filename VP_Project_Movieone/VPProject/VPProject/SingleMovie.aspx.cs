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
            if(Session["userID"]==null)
            {
                GridView1.Visible = false;
            }
            else
            {
                GridView1.Visible = true;
                GridView1.SelectedIndex = 1;
            }
            if (!IsPostBack)
            {
                movieID = int.Parse(Request.QueryString["id"].ToString());

                dataView.DataSource = DBOperations.ConnObject.getMovieDetails(movieID);
                dataView.DataBind();
                ratingCount.Text = DBOperations.ConnObject.getRating(movieID).ToString();
                totalReviewsLabel.Text = DBOperations.ConnObject.getReviewCount(movieID).ToString();
            }
            
        }

      
    }
}