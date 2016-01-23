<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloPage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox runat="server" ID="NameInput"></asp:TextBox>
    <asp:Button Text="Send" runat="server" ID="SendButton" OnClick="SendButton_Click" />
    <h1 id="HelloWrapper" runat="server"></h1>
    <h1></h1>
</asp:Content>
