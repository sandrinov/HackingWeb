<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AntiXSSClass.aspx.cs" Inherits="VulnerableApp._02_XSS.AntiXSSClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: "Segoe UI";
            font-size: 48px;
            font-weight: normal;
        }
        .auto-style2 {}
        .auto-style4 {
            width: 383px;
        }
        .auto-style5 {
            width: 157px;
        }
        .auto-style6 {
            width: 383px;
            height: 102px;
        }
        .auto-style7 {
            width: 157px;
            height: 102px;
        }
        .auto-style8 {
            height: 102px;
        }
        .auto-style9 {}
        .auto-style10 {}
        .auto-style11 {}
        .auto-style12 {}
        .auto-style13 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong class="newStyle1">AntiXssEncoder Class</strong><br />
        <br />
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <hr />
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">
                    <asp:TextBox ID="txt_1" runat="server" CssClass="auto-style2" Height="212px" TextMode="MultiLine" Width="346px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btn_html" runat="server" CssClass="auto-style9" OnClick="btn_html_Click" Text="HTML Encode" Width="203px" />
                    <br />
                    <br />
                    <asp:Button ID="btn_formUrl" runat="server" CssClass="auto-style11" OnClick="btn_formUrl_Click" Text="HTML Form Url Encode" Width="201px" />
                    <br />
                    <br />
                    <asp:Button ID="btn_xml" runat="server" CssClass="auto-style10" OnClick="btn_xml_Click" Text="XML Encode" Width="201px" />
                    <br />
                    <br />
                    <asp:Button ID="btn_css" runat="server" CssClass="auto-style12" OnClick="btn_css_Click" Text="CSS Encode" Width="198px" />
                    <br />
                    <br />
                    <asp:Button ID="btn_clear" runat="server" CssClass="auto-style13" OnClick="btn_clear_Click" Text="Clear" Width="196px" />
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txt_2" runat="server" CssClass="auto-style2" Height="212px" TextMode="MultiLine" Width="346px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
