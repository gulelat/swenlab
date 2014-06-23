<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainReportPage.aspx.cs" Inherits="SwenUI.MainReportPage" %>

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
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">For Room Status Report:</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">For Guest List Per Room:</td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">For Guest List of All Room:</td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">For Room Occupancy Report:</td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">For Housekeeping Report:</td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="Search" />
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
