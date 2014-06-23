<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomStatusReportPage.aspx.cs" Inherits="SwenUI.RoomStatusReportPage" %>

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
                    <asp:Button ID="rsvbtn" runat="server" Text="Reservation" Width="156px" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="rmbtn" runat="server" Text="Room Status" Width="195px" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="paybtn" runat="server" Text="Payment" Width="154px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="rptbtn" runat="server" Text="Reports" Width="143px" />
                </td>
                <td>
                    <asp:Button ID="staffbtn" runat="server" Text="Staff Info" Width="168px" />
                </td>
            </tr>
        </table>
        <br />
        Room Status:<br />
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:BoundField HeaderText="Room Number" />
                <asp:BoundField HeaderText="Room Type" />
                <asp:BoundField HeaderText="Room Status" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Return to Home Page" />
    
    </div>
    </form>
</body>
</html>
