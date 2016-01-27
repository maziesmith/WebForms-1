<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Formview.aspx.cs" Inherits="Employees.WebForms.employees.Formview" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:FormView ID="EmployeesFormView" runat="server" ItemType="Northwind.Data.Employee"
        AllowPaging="true"
        OnPageIndexChanging="EmployeesFormView_PageIndexChanging">
        <ItemTemplate>
            Name:
            <asp:Literal runat="server" Text="<%#:  Item.FirstName %>"></asp:Literal>
            <asp:Literal runat="server" Text="<%#:  Item.LastName %>"></asp:Literal><br />
            Hire date:
            <asp:Literal runat="server" Text="<%#:  Item.HireDate %>"></asp:Literal><br />
            HomePhone:
            <asp:Literal runat="server" Text="<%#:  Item.HomePhone %>"></asp:Literal><br />
            Notes:
            <asp:Literal runat="server" Text="<%#:  Item.Notes %>"></asp:Literal><br />
            Title:
            <asp:Literal runat="server" Text="<%#:  Item.Title %>"></asp:Literal>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
