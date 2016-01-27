<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="listview.aspx.cs" Inherits="Employees.WebForms.employees.listview" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:ListView runat="server" ID="EmployeesListview"
        ItemType="Northwind.Data.Employee"
        SelectMethod="EmployeesListview_GetData"
        DataKeyNames="EmployeeID"
        OnSelectedIndexChanging="EmployeesListview_SelectedIndexChanging">
        <LayoutTemplate>
            <table class="table table-striped table-hover">
                <tr runat="server" id="itemplaceholder">
                    <th>First name</th>
                    <th>Last name</th>
                    <th>Title</th>
                </tr>
            </table>
            <asp:DataPager runat="server" PageSize="5" PagedControlID="EmployeesListview">
                <Fields>
                    <asp:NumericPagerField ButtonType="Link" />
                </Fields>
            </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.FirstName %></td>
                <td><%#: Item.LastName %></td>
                <td><%#: Item.Title %></td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
