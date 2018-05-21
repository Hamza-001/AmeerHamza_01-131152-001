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

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(DBOperations.ConnObject.loginAuthentication(txtUsername.ToString(),txtPassword.ToString()))
            {
                Session["user"] = txtUsername.ToString();
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("Login Failed");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {

            string insertValues = "'" + textName + "','" + textEmail + "','" + textPassword + "'";
            if (DBOperations.ConnObject.registerUser(insertValues))
            {
                usernameLabel.Text = textName.ToString();
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("Registration Failed");
            }
        }
    }
}