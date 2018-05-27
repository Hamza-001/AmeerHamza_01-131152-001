using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VPProject
{
    public class MovieRating 
    {
        float rating;
        public MovieRating()
        {
            rating = 0f;
        }

        public void calculateNewRating(float newRating, int movieID)
        {
            rating = ( (newRating + DBOperations.ConnObject.getRating( movieID)) / DBOperations.ConnObject.getReviewCount(movieID) );
            DBOperations.ConnObject.updateRating(rating, movieID);

        }
    }
}
