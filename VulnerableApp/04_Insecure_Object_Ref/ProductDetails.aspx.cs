using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace VulnerableApp._04_Insecure_Object_Ref
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // PART 3 
            //int productID = 1;
            //Guid guid = HelperClasses.IndirectReferenceMap.GetIndirectReference(productID);

            //this.hiddenProductID.Value = guid.ToString();


        }
    }
}