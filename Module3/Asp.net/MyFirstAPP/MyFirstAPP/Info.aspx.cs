using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstAPP
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Event-Handler
        protected void Greet(object sender, EventArgs e)
        {
            //get textbox value
            string name = txtName.Text;
            //set value to lable
            lblmsg.Text = "Hello " + name;
        }
    }
}