using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp._03_Auth_And_Session
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var username = Session["Username"];
            lblUsername.Text += username == null ? "Unknown" : username.ToString();
        }
    }
}