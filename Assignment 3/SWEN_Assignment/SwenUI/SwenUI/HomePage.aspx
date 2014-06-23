<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SwenUI.HomePage" %>

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
            width: 122px;
        }
        .auto-style3
        {
            width: 194px;
        }
        .auto-style4
        {
            width: 145px;
        }
        .auto-style5
        {
            width: 148px;
        }
        .auto-style6
        {
            width: 178px;
        }
    </style>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
    <div style="text-align: left">
    
        <table class="auto-style1">
            <tr>
                <td style="text-align: center">
                    <h1>Delonix Regia Hotel Management System<asp:Button ID="logoutbtn" runat="server" OnClick="logoutbtn_Click" Text="Logout" />
                    </h1>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="rsvbtn" runat="server" Text="Reservation" Width="156px" OnClick="rsvbtn_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="rmbtn" runat="server" Text="Room Status" Width="195px" OnClick="rmbtn_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="paybtn" runat="server" Text="Payment" Width="154px" OnClick="paybtn_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="rptbtn" runat="server" Text="Reports" Width="143px" OnClick="rptbtn_Click" />
                </td>
                <td>
                    <asp:Button ID="staffbtn" runat="server" Text="Staff Info" Width="168px" Visible="False" OnClick="staffbtn_Click" />
                </td>
            </tr>
        </table>
        <br />
        Welcome: <asp:Label ID="lbluser" runat="server"></asp:Label>
        <br />
        <br />
        Your Profile:
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Refresh" />
        <br />
        <asp:Label ID="lblupdated" runat="server"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Staff Number:</td>
                <td>
                    <asp:Label ID="lblstaffnum" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Staff Name:</td>
                <td>
                    <asp:TextBox ID="staffnametbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Date of Birth:</td>
                <td>
                    <asp:TextBox ID="dobtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Bank Account Number:</td>
                <td>
                    <asp:TextBox ID="banktbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Contact Number:</td>
                <td>
                    <asp:TextBox ID="conttbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Duty Type:</td>
                <td>
                    <asp:Label ID="lblduty" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Home Address:</td>
                <td>
                    <asp:TextBox ID="hometbx" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Username:</td>
                <td>
                    <asp:TextBox ID="usertbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Password:</td>
                <td>
                    <asp:TextBox ID="pwtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
