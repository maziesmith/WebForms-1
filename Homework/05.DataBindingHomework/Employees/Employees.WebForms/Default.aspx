<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Employees.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="EmplaoyeesGridView"
        AutoGenerateColumns="false"
        DataKeyNames="EmployeeID"
        SelectMethod="EmplaoyeesGridView_GetData"
        AllowPaging="True"
        OnSelectedIndexChanged="EmplaoyeesGridView_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="true" />
            <asp:BoundField DataField="FirstName" HeaderText="First name" />
            <asp:BoundField DataField="LastName" HeaderText="Last name" />
        </Columns>
    </asp:GridView>
</asp:Content>



