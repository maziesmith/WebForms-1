<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cars._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <fieldset>
            <legend>Legend</legend>
            <div class="form-group">
                <label for="ProducerInput" class="col-lg-2 control-label">Producer</label>
                <div class="col-lg-10">
                    <asp:DropDownList class="form-control" ID="ProducerInput" runat="server" AutoPostBack="true"
                        DataTextField="Name"
                        SelectMethod="GetProducers"
                        OnSelectedIndexChanged="ProducerInput_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label for="ModelInput" class="col-lg-2 control-label">Model</label>
                <div class="col-lg-10">
                    <asp:DropDownList class="form-control" ID="ModelInput" runat="server"
                        DataTextField="Name">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label for="EngineRadioButtons" class="col-lg-2 control-label">Engine type</label>
                <div class="col-lg-10">
                    <asp:RadioButtonList runat="server" ID="EngineRadioButtons"
                        DataTextField="Name"
                        SelectMethod="GetEngines">
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="form-group">
                <label for="ExtrasCheckBoxList" class="col-lg-2 control-label">Extras</label>
                <div class="col-lg-10">
                    <asp:CheckBoxList runat="server" ID="ExtrasCheckBoxList"
                        DataTextField="Name"
                        SelectMethod="GetExtras">
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-10 col-lg-offset-2">
                    <asp:Button runat="server" OnClick="Submit" class="btn btn-primary" Text="Submit"/>
                    <button type="reset" class="btn btn-default">Cancel</button>
                </div>
            </div>
        </fieldset>
        <div class="alert alert-dismissible alert-success">
            <asp:Literal runat="server" ID="Result"></asp:Literal>
        </div>
    </div>
</asp:Content>
