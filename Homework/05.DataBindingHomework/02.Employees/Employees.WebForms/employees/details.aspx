<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="details.aspx.cs" Inherits="Employees.WebForms.employees.details" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button runat="server" ID="BackButton" OnClick="BackButton_Click" Text="Back"/>
    <asp:DetailsView runat="server" ID="EmployeeDetailsView" SelectMethod="EmployeeDetailsView_GetItem">
    </asp:DetailsView>
</asp:Content>
