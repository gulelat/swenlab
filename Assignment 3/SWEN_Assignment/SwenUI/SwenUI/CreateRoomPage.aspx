<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateRoomPage.aspx.cs" Inherits="SwenUI.CreateRoomPage" %>

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
        </style>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td style="text-align: center">
                    <h1>Delonix Regia Hotel Management System</h1>
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
                    &nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="lblSuccessful" runat="server"></asp:Label>
        <br />
        Please enter the new room information below:<br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Room Number:</td>
                <td>
                    <asp:TextBox ID="rnotbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Room Type:</td>
                <td>
                    <asp:TextBox ID="rttbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Number of beds:</td>
                <td>
                    <asp:TextBox ID="nobtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Type of beds:</td>
                <td>
                    <asp:TextBox ID="tobtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Current Room Status:</td>
                <td>
                    <asp:TextBox ID="rstbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Room Class:</td>
                <td>
                    <asp:TextBox ID="rctbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Room Rate:</td>
                <td>
                    <asp:TextBox ID="rrtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="createroombtn" runat="server" Text="Create New Room" OnClick="createroombtn_Click" />
        <br />
        <br />
        <asp:Button ID="rtnhomebtn" runat="server" OnClick="rtnhomebtn_Click" Text="Return to Home Page" />
        <br />
    
    </div>
    </form>
</body>
</html>
