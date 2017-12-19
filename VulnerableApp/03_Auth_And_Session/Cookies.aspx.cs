using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp._03_Auth_And_Session
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cookiesList.InnerHtml += "<h1>" + "List of cookies" + ": </h1>";

            HttpCookieCollection allCookies = Request.Cookies;
            String[] allKeys = allCookies.AllKeys;

            foreach (String key in allKeys)
            {
                this.cookiesList.InnerHtml += "<b>" + key + ": </b>" + allCookies.Get(key).Value + "<br/>"; 
            }
        }
    }
}