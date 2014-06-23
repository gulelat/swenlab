<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchReservation.aspx.cs" Inherits="SwenUI.SearchReservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            text-align: center;
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
            width: 100%;
        }
        .auto-style7
        {
            width: 172px;
        }
        .auto-style8
        {
            width: 176px;
        }
        .auto-style9
        {
            width: 172px;
            height: 23px;
        }
        .auto-style10
        {
            height: 23px;
        }
    </style>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
    <div>
    
                    <h1 class="auto-style1">Delonix Regia Hotel Management System</h1>
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
                    <asp:Button ID="rptbtn" runat="server" Text="Reports" Width="143px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
&nbsp;Enter Reservtion Number:
        <asp:TextBox ID="rsvnotbx" runat="server"></asp:TextBox>
        <asp:Button ID="rsvnobtn" runat="server" OnClick="rsvnobtn_Click" Text="Search" />
        <br />
        <asp:Button ID="srbtn" runat="server" OnClick="srbtn_Click" Text="Search for Room" />
        <asp:Button ID="dlbtn" runat="server" OnClick="dlbtn_Click" Text="Delete Reservation" />
        <asp:Button ID="updbtn" runat="server" OnClick="updbtn_Click" Text="Update Reservation" />
        <br />
        <asp:Label ID="lblUnsuccessful" runat="server"></asp:Label>
                    <asp:Label ID="lblpaycompleted" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblSuccessful" runat="server"></asp:Label>
                    <asp:Label ID="lblpayfailed" runat="server"></asp:Label>
        <br />
        <br />
        Reservation Details:<br />
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">Guest First Name:</td>
                <td>
                    <asp:TextBox ID="gfnametbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Guest Last Name:</td>
                <td>
                    <asp:TextBox ID="glnametbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">NRIC:</td>
                <td>
                    <asp:TextBox ID="nrictbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Room Number Booked:</td>
                <td>
                    <asp:TextBox ID="roomtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Room Class:</td>
                <td>
                    <asp:TextBox ID="classtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Contact Number:</td>
                <td>
                    <asp:TextBox ID="cntbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Email Address:</td>
                <td>
                    <asp:TextBox ID="emailtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Country:</td>
                <td>
                    <asp:TextBox ID="ctbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Home Address:</td>
                <td>
                    <asp:TextBox ID="hometbx" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Postal Code:</td>
                <td>
                    <asp:TextBox ID="postaltbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Check-in Date:</td>
                <td>
                    <asp:TextBox ID="citbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Check-out Date:</td>
                <td>
                    <asp:TextBox ID="cotbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Method of Payment:</td>
                <td>
                    <asp:DropDownList ID="paymentddl" runat="server">
                        <asp:ListItem>Credit Card</asp:ListItem>
                        <asp:ListItem>Cash</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Indication of Late Check:</td>
                <td>
                    <asp:TextBox ID="indtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Additional Remarks:</td>
                <td>
                    <asp:TextBox ID="addrtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
                    <table class="auto-style6">
                        <tr>
                            <td class="auto-style9">Number of Children Guests:</td>
                            <td class="auto-style10">
                                <asp:TextBox ID="childtbx" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Number of Adult Guests:</td>
                            <td>
                                <asp:TextBox ID="adulttbx" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <br />
        <br />
        Payment Details:<br />
        <table class="auto-style6">
            <tr>
                <td class="auto-style8">Credit Card Number:</td>
                <td>
                    <asp:TextBox ID="cardnotbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Credit Card Holder Name:</td>
                <td>
                    <asp:TextBox ID="holdertbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Expiry Date:</td>
                <td>
                    <asp:TextBox ID="exptbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return to Home Page" />
        <br />
    
    </div>
    </form>
</body>
</html>
