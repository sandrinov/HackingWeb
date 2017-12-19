<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TracePage.aspx.cs" Inherits="VulnerableApp._06_Misconfiguration.TracePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        username:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        password:
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
