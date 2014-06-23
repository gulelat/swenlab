<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="SwenUI.StaffPage" %>

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
            width: 260px;
        }
        .auto-style7
        {
            width: 259px;
        }
        .auto-style8
        {
            width: 257px;
        }
        .auto-style9
        {
            width: 256px;
        }
        .auto-style10
        {
            width: 257px;
            height: 40px;
        }
        .auto-style11
        {
            height: 40px;
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
                    <asp:Button ID="staffbtn" runat="server" Text="Staff Info" Width="168px" OnClick="staffbtn_Click" />
                </td>
            </tr>
        </table>
        <br />
        Search Staff:
        <asp:TextBox ID="staffnotbx" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblSuccesful" runat="server"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="Button2" runat="server" Text="Create Staff" Width="259px" OnClick="Button2_Click" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button3" runat="server" Text="Edit Staff Info" Width="256px" OnClick="Button3_Click" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Delete Staff" Width="293px" OnClick="Button4_Click" />
                </td>
            </tr>
        </table>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">Staff Number:</td>
                <td>
                    <asp:Label ID="lblstaffno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Staff Full Name:</td>
                <td>
                    <asp:TextBox ID="staffnametbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Date of Birth:</td>
                <td>
                    <asp:Label ID="lbldob" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Bank Account Number:</td>
                <td>
                    <asp:Label ID="lblbankno" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Contact Number:</td>
                <td>
                    <asp:TextBox ID="contatbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Home Address:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="homeaddtbx" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Duty Type:</td>
                <td>
                    <asp:TextBox ID="dutytbx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Username:</td>
                <td>
                    <asp:TextBox ID="usernametbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">Password:</td>
                <td>
                    <asp:TextBox ID="passtbx" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button5" runat="server" Text="Return to Home Page" OnClick="Button5_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
