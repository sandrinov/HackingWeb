using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp._02_XSS
{
    public partial class LeavingSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BeInsecure();
            UseWellFormedUri();
        }

        private void UseWellFormedUri()
        {
            var newUrl = Request.QueryString["Url"];
            if (!Uri.IsWellFormedUriString(newUrl, UriKind.Absolute))
            {
                litLeavingTag.Text = "An invalid URL has been specified.";
                return;
            }
        }

        private void BeInsecure()
        {
            var newUrl = Request.QueryString["Url"];
            var tagString = "<a href=" + newUrl + ">continue</a>";
            litLeavingTag.Text = tagString;
        }
    }
}