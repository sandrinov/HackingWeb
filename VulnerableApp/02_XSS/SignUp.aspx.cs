using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp._02_XSS
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //NoEncoding();  // 1
            //ServerEncoding();  //2
            UglyJSEncoding();  //3
            
           
        }

        private void UglyJSEncoding()
        {
            var name = Server.HtmlEncode(txtFirstName.Text) + " " + Server.HtmlEncode(txtLastName.Text);
            var message = "Thank you " + name;
            var alertScript = "<script>alert('" + message + "');</script>";
            ClientScript.RegisterClientScriptBlock(GetType(), "ThankYou", alertScript);
        }

        private void ServerEncoding()
        {
            var name = Server.HtmlEncode(txtFirstName.Text) + " " + Server.HtmlEncode(txtLastName.Text);
            var message = "Thank you " + name;
            lblSignupComplete.Text = message;
        }

        private void NoEncoding()
        {
            var name = txtFirstName.Text + " " + txtLastName.Text;
            var message = "Thank you " + name;
            lblSignupComplete.Text = message;
        }
    }
}