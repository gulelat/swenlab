<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateReservationPage.aspx.cs" Inherits="SwenUI.CreateReservationPage" %>

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
            width: 182px;
            text-align: right;
        }
        .auto-style8
        {
            width: 182px;
            text-align: right;
            height: 23px;
        }
        .auto-style9
        {
            height: 23px;
        }
        .auto-style10
        {
            width: 182px;
            text-align: right;
            height: 26px;
        }
        .auto-style11
        {
            height: 26px;
        }
    </style>
</head>
<body style="background-color: #00FFFF">
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
        <asp:Label ID="lblsuccesscreate" runat="server"></asp:Label>
        <asp:Label ID="lblpaycreated" runat="server"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Reservation Number:</td>
                <td>
                    <asp:TextBox ID="rsv2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Hotel Room Number:</td>
                <td>
                    <asp:TextBox ID="rm2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Guest First Name:</td>
                <td>
                    <asp:TextBox ID="gf2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Guest Last Name:</td>
                <td>
                    <asp:TextBox ID="gl2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">NRIC:</td>
                <td>
                    <asp:TextBox ID="nric2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Number of Adult Guests:</td>
                <td>
                    <asp:TextBox ID="adg1tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Number of Children Guests:</td>
                <td>
                    <asp:TextBox ID="ch1tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Contact Number:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="cnt1tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Email Address:</td>
                <td>
                    <asp:TextBox ID="email2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Home Address:</td>
                <td>
                    <asp:TextBox ID="home2tbx" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Postal Code:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="post2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Country:</td>
                <td>
                    <asp:TextBox ID="co2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Method of Payment:</td>
                <td>
                    <asp:DropDownList ID="meth2ddl" runat="server">
                        <asp:ListItem>Credit Card</asp:ListItem>
                        <asp:ListItem>Cash</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Credit Card Number:</td>
                <td>
                    <asp:TextBox ID="cred2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Name of Credit Card Holder:</td>
                <td>
                    <asp:TextBox ID="holder2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Expiry Date of Credit Card:</td>
                <td>
                    <asp:TextBox ID="exp2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Check-in Date:</td>
                <td>
                    <asp:TextBox ID="ci2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Check-out Date: </td>
                <td>
                    <asp:TextBox ID="cho2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Additional Remarks:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="add2tbx" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Indication of Late:</td>
                <td>
                    <asp:TextBox ID="ind2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Room Class:</td>
                <td>
                    <asp:TextBox ID="class2tbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:Button ID="rsvcreatebtn" runat="server" Text="Create" OnClick="rsvcreatebtn_Click" />
        <br />
        <br />
        <asp:Button ID="rtnhmbtn" runat="server" Text="Return to Home Page" OnClick="rtnhmbtn_Click" />
    
    </div>
    </form>
</body>
</html>
