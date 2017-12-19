<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeavingSite.aspx.cs" Inherits="VulnerableApp._02_XSS.LeavingSite"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="header">
        <ul>
            <li><a id="registerLink" runat="server" href="~/Account/Register">Register</a></li>
            <li><a id="loginLink" runat="server" href="~/Account/Login">Log in</a></li>
        </ul>
    </div>

    <form id="form1" runat="server">
        <div class="content-wrapper">
            <p>You are now leaving this site - we're no longer responsible!</p>
            <p> <asp:Literal runat="server" ID="litLeavingTag" /></p>
        </div>
    </form>
</body>
</html>
