<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsCrudLocalDb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container">
        <h1>
            Login

        </h1>
        <div class="form-group col-sm-5">
        <p>
            <asp:Label Text="Username" runat="server" CssClass="control-label" />
            <asp:TextBox ID="UserName" runat="server" CssClass="form-control"></asp:TextBox></p>
        <p>
            <asp:Label Text="Password" runat="server" CssClass="control-label" />
            <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></p>
        <div class="checkbox">
            
            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />
        </div>
        <p>
            <asp:Button ID="LoginButton" runat="server" Text="Login" CssClass="btn btn-primary btn-lg pull-right " OnClick="LoginButton_Click" /> </p>
        <p>
            <asp:Label ID="InvalidCredentialsMessage" runat="server" ForeColor="Red" Text="Your username or password is invalid. Please try again."
                Visible="False"></asp:Label> </p>
        </div>
    </div>
</asp:Content>