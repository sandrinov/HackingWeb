<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="VulnerableApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 216px;
        }
        .auto-style2 {
            width: 368px;
        }
        .auto-style3 {
            width: 207px;
        }
        .auto-style4 {}
        .auto-style5 {
            width: 133px;
        }
        #btn_link_client {
            width: 241px;
        }
        #btn_sendHeader {
            width: 239px;
        }
        #btn_link_client0 {
            width: 241px;
        }
        #btn_leavingSite {
            width: 239px;
        }
    </style>
    <script src="scripts/js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            /*
             *          SQL INJECTION
             */
            $('#btn_link_client').on('click', function () {
                var categoryID = $('#txt_categoryID').val();
                var url = window.location.origin + '/01_Injection/ExecuteSQL.aspx?CategoryID=' + categoryID;
                window.location.href = url;
            });

            $('#btn_sendHeader').on('click', function () {
                var categoryID = $('#txt_categoryID').val();
                var url = window.location.origin + '/01_Injection/ExecuteSQL.aspx?CategoryID=' + categoryID;
                window.location.href = url;
            });

            /*
            *               X S S
            */
            $('#btn_leavingSite').on('click', function () {
                var newUrl = $('#txt_leavingSiteUrl').val();
                var url = window.location.origin + '/02_XSS/LeavingSite.aspx?Url=' + newUrl;
                window.location.href = url;
            });


        });// END $
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Injection</td>
                <td class="auto-style2">Navigate to /01_Injection/ExecuteSQL.aspx?CategoryID=</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_categoryID" runat="server" ClientIDMode="Static" CssClass="auto-style4" Width="174px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <input id="btn_link_client" type="button" value="Navigate (client side)" /></td>
                <td>
                    <asp:Button ID="btn_link" runat="server" OnClick="btn_link_Click" Text="Navigate (server side)" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Injection - Language header</td>
                <td class="auto-style2">Navigate to /01_Injection/CreativeHeaders</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_language" runat="server" ClientIDMode="Static" CssClass="auto-style4" Width="174px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <input id="btn_sendHeader" type="button" value="Send Language (client side)" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">XSS</td>
                <td class="auto-style2">Navigate to /02_LeavingSite.aspx?Url=</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_leavingSiteUrl" runat="server" ClientIDMode="Static" CssClass="auto-style4" Width="174px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <input id="btn_leavingSite" type="button" value="Navigate (client side)" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
