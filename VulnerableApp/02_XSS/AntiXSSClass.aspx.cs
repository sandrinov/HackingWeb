using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security.AntiXss;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerableApp._02_XSS
{
    public partial class AntiXSSClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_html_Click(object sender, EventArgs e)
        {
            String s = this.txt_1.Text;
            this.txt_2.Text = AntiXssEncoder.HtmlEncode(s, true);
            //this.txt_2.Text = AntiXssEncoder.HtmlEncode(s, false);
        }

        protected void btn_formUrl_Click(object sender, EventArgs e)
        {
            String s = this.txt_1.Text;
            this.txt_2.Text = AntiXssEncoder.HtmlFormUrlEncode(s);
        }

        protected void btn_xml_Click(object sender, EventArgs e)
        {
            String s = this.txt_1.Text;
            this.txt_2.Text = AntiXssEncoder.XmlEncode(s);
        }

        protected void btn_css_Click(object sender, EventArgs e)
        {
            String s = this.txt_1.Text;
            this.txt_2.Text = AntiXssEncoder.CssEncode(s);
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_1.Text = "";
            this.txt_2.Text = "";
        }
    }
}