using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VulnerableApp.ORM
{
    [DataContract]
    public class ServiceProduct
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string QuantityPerUnit { get; set; }
        public ServiceProduct()
        {

        }
        public ServiceProduct(Product p)
        {
            this.ProductID = p.ProductID;
            this.ProductName = p.ProductName;
            this.QuantityPerUnit = p.QuantityPerUnit;
        }
    }

}