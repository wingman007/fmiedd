<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="webCrud.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h1>Create</h1>
     <script "javascript" type="text/javascript">

         function empty() {
             document.getElementById("username").value = "";
             document.getElementById("password").value = "";
             document.getElementById("email").value = "";
           
             return true;
         }

    </script>
    <div>


        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username" AssociatedControlID="TextBox1"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password" AssociatedControlID="TextBox2"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email" AssociatedControlID="TextBox3"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click"/>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
       
    </div>
    

</asp:Content>