﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPProject
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            moviesList.DataSource = DBOperations.ConnObject.getAllMovies();
            ListViewBanner.DataSource = DBOperations.ConnObject.getAllMovies();
            moviesList.DataBind();
            ListViewBanner.DataBind();
        }
    }
}