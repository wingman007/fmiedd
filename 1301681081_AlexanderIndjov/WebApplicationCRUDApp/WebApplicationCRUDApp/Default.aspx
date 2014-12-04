<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationCRUDApp._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        CHOOSE FROM THE BUTTONS BELLOW</section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Button ID="BtnRetrieve" runat="server" OnClick="BtnRetrieve_Click" Text="Retrieve" />
    </asp:Content>
