<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="repeater.aspx.cs" Inherits="Employees.WebForms.employees.repeater" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:Repeater runat="server" ID="EmployeesRepeater"
        ItemType="Northwind.Data.Employee"
        SelectMethod="EmployeesRepeater_GetData">
        <HeaderTemplate>
            <table class="table table-striped table-hover">
            <tr>
                <th>First name</th>
                <th>Last name</th>
                <th>Title</th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.FirstName %></td>
                <td><%#: Item.LastName %></td>
                <td><%#: Item.Title %></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
