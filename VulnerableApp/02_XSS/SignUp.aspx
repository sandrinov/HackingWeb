<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="VulnerableApp._02_XSS.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblSignupComplete" runat="server" ForeColor="#009933" Font-Bold="True"></asp:Label><br />
       <fieldset>
    <legend>Personalia:</legend>
        Firstname: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br/><br />
        LastName: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br/><br />
        
        <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" />

  </fieldset>
    </div>
    </form>
</body>
</html>
