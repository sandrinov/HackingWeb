<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogOnUserControl.ascx.cs" Inherits="MyBankIsDifferent.Views.Shared.LogOnUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%: Page.User.Identity.Name %></b>!
        [ <%: Html.ActionLink("Log Off", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Log On", "LogOn", "Account") %> ]
<%
    }
%>