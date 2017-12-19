using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp._03_Auth_And_Session
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            // Assume successful authentication against an account source...
            Session["Username"] = username;
            pnlLoginForm.Visible = false;
            pnlLoginSuccessful.Visible = true;

        }
    }
}