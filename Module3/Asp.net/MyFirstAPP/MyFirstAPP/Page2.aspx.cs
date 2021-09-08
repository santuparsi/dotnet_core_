using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstAPP
{
    public partial class Page2 : System.Web.UI.Page
    {
        //Load Handler
        protected void Page_Load(object sender, EventArgs e)
        {
            //read query string values
            string name = Request.QueryString["uname"]; 
            lblmsg.Text = name;
        }
    }
}