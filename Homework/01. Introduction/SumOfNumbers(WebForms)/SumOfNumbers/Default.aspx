<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SumOfNumbers._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Sum of two numbers</h1>
        <div class="form-group">
            <label>x:</label>
            <asp:TextBox ID="FirstNumber" runat="server" Width="90px" Height="45px" />
            <asp:RangeValidator ValidationGroup="sum_group" Type="Double" Display="Dynamic" ControlToValidate="FirstNumber" ErrorMessage="Invalid number" runat="server" />
            <span> + </span>
            <asp:TextBox ID="SecondNumber" runat="server" Width="90px" Height="45px" />
            <asp:RangeValidator ValidationGroup="sum_group" Type="Double" Display="Dynamic" ControlToValidate="SecondNumber" ErrorMessage="Invalid number" runat="server" />
            <span> = </span>
            <asp:TextBox ID="Result" runat="server" Width="90px" Height="40px" />
        </div>
        <div class="form-group">
            <asp:Button ID="Btn_Calculate" OnClick="Btn_Calculate_Click" class="btn btn-primary btn-lg" runat="server" Text="Sum" />
            <asp:ValidationSummary ID="error_group" ValidationGroup="sum_grop" runat="server" DisplayMode="BulletList" ShowSummary="true"/>
        </div>
    </div>
</asp:Content>
