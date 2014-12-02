<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="webCrud.Account.Register" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div style="font-family:Arial">
<table style="border: 1px solid black">
    <tr>
        <td colspan="2">
            <b>User Registration</b>
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
            <asp:Label ID="Label1" runat="server" Text="Admin"></asp:Label>
        </td>    
        <td>
            <asp:CheckBox ID="CheckBox1" runat="server" />
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
                   
        </td>    
        <td>
            <asp:Button ID="btnRegister" runat="server" Text="Register" 
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