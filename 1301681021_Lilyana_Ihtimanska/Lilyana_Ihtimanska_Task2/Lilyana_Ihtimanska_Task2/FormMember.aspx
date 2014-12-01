<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMember.aspx.cs" Inherits="Lilyana_Ihtimanska_Task2.FormMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style17 {
            width: 227px;
            height: 24px;
        }
        .auto-style18 {
            width: 313px;
            height: 24px;
        }
        .auto-style19 {
            width: 245px;
            height: 24px;
        }
        .auto-style20 {
            width: 300px;
            font-weight: 700;
            text-decoration: underline;
            height: 24px;
        }
        .auto-style5 {
            width: 227px;
        }
        .auto-style3 {
            width: 313px;
        }
        .auto-style4 {
            width: 245px;
        }
        .auto-style6 {
            width: 300px;
            }
        #form2 {
            text-align: center;
        }
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnShow" runat="server" BackColor="#9999FF" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="Black" Height="37px" OnClick="btnShow_Click" Text="Show Users :)" Width="150px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogOut" runat="server" BackColor="#CCFFFF" Font-Bold="True" Height="28px" OnClick="btnLogOut_Click" style="text-align: right" Text="Logout" Width="69px" />
        <br />
        <br />
        <table align="center" class="auto-style1" width="250px">
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="lblUser" runat="server" Font-Bold="True" Font-Underline="True" style="font-size: large" Text="User_ID" Visible="False"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:Label ID="lblname" runat="server" Font-Bold="True" Font-Underline="True" style="font-size: large" Text="Username" Visible="False"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="lblPass" runat="server" Font-Bold="True" Font-Underline="True" style="font-size: large" Text="Password" Visible="False"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:Label ID="lblmail" runat="server" Font-Bold="True" Font-Underline="True" style="font-size: large" Text="Email" Visible="False"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:Label ID="lrole" runat="server" Text="Role" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblId" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblUsername" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblPassword" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblemail" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblrole" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
