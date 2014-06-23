<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomStatusPage.aspx.cs" Inherits="SwenUI.RoomStatusPage" %>

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
            width: 129px;
            text-align: right;
        }
        .auto-style7
        {
            width: 129px;
            text-align: right;
            height: 23px;
        }
        .auto-style8
        {
            height: 23px;
        }
        .auto-style9
        {
            width: 217px;
        }
        .auto-style10
        {
            width: 196px;
        }
        .auto-style11
        {
            width: 185px;
        }
        .auto-style12
        {
            width: 126px;
            text-align: right;
        }
        .auto-style13
        {
            width: 125px;
            text-align: right;
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
        <br />
        Search Room Number:
        <asp:TextBox ID="rmnotbx" runat="server"></asp:TextBox>
        <asp:Button ID="rmnobtn" runat="server" Text="Search" OnClick="rmnobtn_Click" />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="rsvcreatebtn" runat="server" Text="Create Reservation" Width="216px" OnClick="rsvcreatebtn_Click" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="rmeditbtn" runat="server" Text="Edit Room Status" Width="192px" OnClick="rmeditbtn_Click" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="rmdelbtn" runat="server" Text="Delete Room" Width="183px" OnClick="rmdelbtn_Click" />
                </td>
                <td>
                    <asp:Button ID="rmcreatebtn" runat="server" Text="Create Room" Width="212px" OnClick="rmcreatebtn_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="lblSuccessful" runat="server"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Room ID:</td>
                <td>
                    <asp:Label ID="lblroomid" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Room Number:</td>
                <td>
                    <asp:Label ID="lblroomno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Room Type:</td>
                <td>
                    <asp:Label ID="lblroomtype" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Number of beds:</td>
                <td>
                    <asp:Label ID="lblnumbed" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Type of beds:</td>
                <td>
                    <asp:Label ID="lblbedtype" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Room Class:</td>
                <td class="auto-style8">
                    <asp:Label ID="lblclass" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style12">Room Rate:</td>
                <td>
                    <asp:Label ID="lblroomrate" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">Room Status:</td>
                <td>
                    <asp:TextBox ID="roomstattbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="rtnhmbtn" runat="server" Text="Return to Home Page" OnClick="rtnhmbtn_Click" />
    
    </div>
    </form>
</body>
</html>
