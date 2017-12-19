<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="VulnerableApp._04_Insecure_Object_Ref.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/Site.css" rel="stylesheet" />
    <script src="../scripts/js/jquery-1.10.2.intellisense.js"></script>
    <script src="../scripts/js/jquery-1.10.2.js"></script>
    <script type="text/javascript">

        $(function () {

            $('#btn_getProductDetails').on('click', btn_click);
        });

        function btn_click() {

            //START FROM HERE!
            // valid param value from 1  to 168
            var param = 1;

            //PART 3 
            // use this if you want apply reference map with a guid
            //var param = $('#hiddenProductID').val();


            var dataIn = '{' + '"param":"' + param + '"}';
            $.ajax({
                url: "http://localhost:10647/CustomerService.svc/GetProductDetails",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                data: dataIn,
                dataType: "json",
                success: function (data) {
                    var product = data.d;
                    //get product details
                    $('#productID').text(product.ProductID);
                    $('#productName').text(product.ProductName);
                    $('#quantityXUnit').text(product.QuantityPerUnit);
                },
                error: function (error) {
                    alert("Error: " + error.Error);
                }
            });
        }

           
</script>
</head>
<body>
    <form id="form1" runat="server">

      <%--   PART 3--%>
       <%-- <input id="hiddenProductID" 
             type="hidden" 
             value="Initial Value" 
             runat="server" />--%>
    <div>
        <input id="btn_getProductDetails" type="button" value="Product Details" /><br />
        <h2>Product Details here</h2><br />
        <div>
            <div id="productID">ID</div>
            <div id="productName">Name</div>
            <div id="quantityXUnit">QxU</div>
        </div>
    </div>
    </form>
</body>
</html>
