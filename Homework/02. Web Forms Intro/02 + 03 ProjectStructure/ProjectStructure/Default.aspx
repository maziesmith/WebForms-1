<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectStructure._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <% 
        this.FromAspxCode.InnerHtml = "Hello, ASP.NET from aspx code";
    %>
    <h1 id="FromAspxCode" runat="server"></h1>
    <h1 id="FromCSharpCode" runat="server"></h1>
    <h1 id="Location" runat="server"></h1>
    <br />
    <h1>Refresh the page to dump all the events!!!</h1>
    <div runat="server" id="CheckpointsContainer">
    </div>
</asp:Content>
