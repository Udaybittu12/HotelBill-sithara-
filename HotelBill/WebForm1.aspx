<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HotelBill.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>
</head>
<body>
    <form id="from1" runat="server">
        <h1>Welcome To HOTEL SITHARA</h1>
    <asp:Label ID="Label1" runat="server" Text="Customer Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Room Type"></asp:Label>
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="s" AutoPostBack="true" Text="AC" OnCheckedChanged="RadioButton1_CheckedChanged" />
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="s" AutoPostBack="true" Text="NON AC" OnCheckedChanged="RadioButton2_CheckedChanged" /><br />
    <asp:Panel ID="Panel1" runat="server" Visible="False">
     <asp:Label ID="Label3" runat="server" Text="Services"></asp:Label><br />
    <asp:CheckBox ID="CheckBox1" runat="server" Text="Wifi" /><br />
    <asp:CheckBox ID="CheckBox2" runat="server" Text="Hot Water" /><br />
    <asp:CheckBox ID="CheckBox3" runat="server" Text="Tv" /><br />
    <asp:CheckBox ID="CheckBox4" runat="server" Text="Extra Bed" /><br />
    </asp:Panel>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Food"></asp:Label>
    <asp:RadioButton ID="RadioButton3" runat="server" Text="With Meals" GroupName="k" />
    <asp:RadioButton ID="RadioButton4" runat="server" Text="Without Meals" GroupName="k" /><br />
    <asp:Label ID="Label4" runat="server" Text="Number Of Days"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Bill Amount"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
        <br />
        click here for << <asp:Button ID="Button2" runat="server" Text="All CUstomer Details" BorderStyle="Ridge" BorderColor="Black" OnClick="Button2_Click"  />
        <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
        </form>
</body>
</html>
