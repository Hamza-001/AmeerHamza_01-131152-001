using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPProject
{
    public partial class MovieSiteMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userID"] == null)
            {
                usernameLabel.Text = "Anonymous";
                loginModalLink.Visible = true;
                signoutButton.Visible = false;
                
            }
            else
            {
                usernameLabel.Text = DBOperations.ConnObject.getUsername(Session["userID"].ToString());
                loginModalLink.Visible = false;
                signoutButton.Visible = true;

            }
        }

        protected void loginButtton_Click(object sender, EventArgs e)
        {
            if(DBOperations.ConnObject.loginAuthentication(textUserEmail.Text.ToString(),textLoginPassword.Text.ToString()))
            {
                Session["userID"] = DBOperations.ConnObject.getUserID(textUserEmail.Text.ToString());
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("Login Failed");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            if (DBOperations.ConnObject.registerUser(textName.Text.ToString(), textEmail.Text.ToString(), textPassword.Text.ToString()))
            {
                Session["userID"] = DBOperations.ConnObject.getUserID(textUserEmail.Text.ToString());
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("Registration Failed");
            }
        }

        protected void signoutButton_Click(object sender, EventArgs e)
        {
            Session["userID"] = null;
            Response.Redirect("~/Home.aspx");
        }
    }
}