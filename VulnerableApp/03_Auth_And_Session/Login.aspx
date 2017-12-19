<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VulnerableApp._03_Auth_And_Session.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/Site.css" rel="stylesheet" />
</head>
<body class="newStyle1">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="pnlLoginForm" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Username:</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"  Width="207px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password" Width="207px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Button" Width="161px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel><br /><br />
        <asp:Panel ID="pnlLoginSuccessful" runat="server" Visible="false">
            Login Successful!<br />
            <a href="Page2.aspx">Page 2</a>
        </asp:Panel>
    </form>
</body>
</html>
