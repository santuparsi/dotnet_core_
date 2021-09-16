using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp(object sender, EventArgs e)
        {
            //add user details to user table in sql server sing Ado.net
            //Create user table with required colomns and add
            //new user to details to user table using Ado.net
            LoadGrid();
        }
        private void LoadGrid()
        {

        }
    }
}