using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp.Injection
{
    public partial class CreativeHeaders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTheLanguage();
        }

        private void GetTheLanguage()
        {
            var language = HttpContext.Current.Request.UserLanguages[0];
            lblLanguage.Text = "The browser language is: " + language;
        }
    }
}