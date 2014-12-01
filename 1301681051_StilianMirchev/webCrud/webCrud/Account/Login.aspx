<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="webCrud.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div style="font-family:Arial">
<table style="border: 1px solid black">
    <tr>
        <td colspan="2">
            <b>User Login</b>
        </td>
    </tr>
    <tr>
        <td>
            User Name
        </td>    
        <td>
            :<asp:TextBox ID="txtUserName" runat="server">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorusername" 
            runat="server" ErrorMessage="User Name required" Text="*"
            ControlToValidate="txtUserName" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </td>    
    </tr>
    <tr>
        <td>
            Password
        </td>    
        <td>
            :<asp:TextBox ID="txtPassword" TextMode="Password" runat="server">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" 
            runat="server" ErrorMessage="Password required" Text="*"
            ControlToValidate="txtPassword" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </td>    
    </tr>
    <tr>
        <td>
            &nbsp;</td>    
        <td>
            &nbsp;</td>    
    </tr>
    <tr>
        <td>
            &nbsp;</td>    
        <td>
            &nbsp;</td>    
    </tr>
    <tr>
        <td>
                   
            <asp:Label ID="Label1" runat="server" Text="Remember me"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" />
                   
        </td>    
        <td>
            <asp:Button ID="btnRegister" runat="server" Text="Login" 
            onclick="btnRegister_Click"/>
        </td>    
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red">
            </asp:Label>
        </td>    
    </tr>
    <tr>
        <td colspan="2">
            <asp:ValidationSummary ID="ValidationSummary1" ForeColor="Red" runat="server" />
        </td>    
    </tr>
</table>
</div>
</asp:Content>
