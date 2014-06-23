<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SwenUI.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            font-size: medium;
        }
    </style>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
    <div style="text-align: center; height: 187px">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <h1>Delonix Regia Hotel Management System</h1>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblfail" runat="server"></asp:Label>
        <br />
        Username: 
        <asp:TextBox ID="usertbx" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="pwtbx" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="loginbtn" runat="server" Text="Login" OnClick="loginbtn_Click" />
    
    </div>
    </form>
</body>
</html>
