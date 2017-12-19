using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;
using VulnerableApp.ORM;

namespace VulnerableApp
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CustomerService
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]


        // PART 1 - insecure
        public VulnerableApp.ORM.ServiceProduct GetProductDetails(int param)
        {


            // Add your operation implementation here
            var productID = param;
            var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            var dc = new NorthwindClassesDataContext(connString);

            Product product = dc.Products.Where(p => p.ProductID == productID).FirstOrDefault();

            return new ServiceProduct(product);

        }

        //// PART 2 - Secure
        //public VulnerableApp.ORM.ServiceProduct GetProductDetails(int param)
        //{
        //    Product product = new Product() {ProductID=0, ProductName = "You do not have succficient privileges to get details", QuantityPerUnit = "" };
        //    if (CanCurrentUserAccessProductDetails())
        //    {
        //        // Add your operation implementation here
        //        var productID = param;
        //        var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
        //        var dc = new NorthwindClassesDataContext(connString);

        //        product = dc.Products.Where(p => p.ProductID == productID).FirstOrDefault();

        //    }

        //    return new ServiceProduct(product);

        //}

        // PART 3 - Secure with indirect reference map
        //public VulnerableApp.ORM.ServiceProduct GetProductDetails(Guid param)
        //{
        //    Product product = new Product() { ProductID = 0, ProductName = "You do not have succficient privileges to get details", QuantityPerUnit = "" };
        //    if (CanCurrentUserAccessProductDetails())
        //    {
        //        // Add your operation implementation here
        //        var productID = VulnerableApp.HelperClasses.IndirectReferenceMap.GetDirectReference(param);
        //        var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
        //        var dc = new NorthwindClassesDataContext(connString);

        //        product = dc.Products.Where(p => p.ProductID == productID).FirstOrDefault();

        //    }

        //    return new ServiceProduct(product);

        //}


        private bool CanCurrentUserAccessProductDetails()
        {
            // part 2
            //return ServiceSecurityContext.Anonymous.PrimaryIdentity.IsAuthenticated;

            //part 3
            return true;
        }

        [OperationContract]
        [WebGet]
        public VulnerableApp.ORM.ServiceProduct GetProductDetailsWithGet(int param)
        {
            // Add your operation implementation here
            return new VulnerableApp.ORM.ServiceProduct() { ProductID = 1, ProductName = "product", QuantityPerUnit = "Kg" };



        }

        // Add more operations here and mark them with [OperationContract]
    }
}
