<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="SwenUI.PaymentPage" %>

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
        Search Reservation Number:
        <asp:TextBox ID="shgtbx" runat="server"></asp:TextBox>
        <asp:Button ID="shgbtn" runat="server" Text="Search" OnClick="shgbtn_Click" />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Hotel Room Number:</td>
                <td>
                    <asp:Label ID="lblrmno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Room Type:</td>
                <td>
                    <asp:Label ID="lblrmtype" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Guest First Name:</td>
                <td>
                    <asp:Label ID="lblgname" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Guest Last Name:</td>
                <td>
                    <asp:Label ID="lblgnamel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">NRIC:</td>
                <td>
                    <asp:Label ID="lblnric" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Number of Adult Guests:</td>
                <td>
                    <asp:Label ID="lblagno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Number of Children Guests:</td>
                <td>
                    <asp:Label ID="lblcgno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Contact Number:</td>
                <td class="auto-style9">
                    <asp:Label ID="lblcno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Email Address:</td>
                <td>
                    <asp:Label ID="lblem" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Home Address:</td>
                <td>
                    <asp:Label ID="lblhma" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Postal Code:</td>
                <td>
                    <asp:Label ID="lblpc" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Country:</td>
                <td>
                    <asp:Label ID="lblc" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Method of Payment:</td>
                <td class="auto-style11">
                    <asp:Label ID="lblpm" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Credit Card Number:</td>
                <td>
                    <asp:Label ID="lblcrno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Name of Credit Card Holder:</td>
                <td>
                    <asp:Label ID="lblcrname" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Expiry Date of Credit Card:</td>
                <td>
                    <asp:Label ID="lblexp" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Check-in Date:</td>
                <td>
                    <asp:Label ID="lblcid" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Check-out Date: </td>
                <td>
                    <asp:Label ID="lblcod" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Room Rate:</td>
                <td>
                    <asp:Label ID="lblrr" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return to Home Page" />
        <br />
    
    </div>
    </form>
</body>
</html>
