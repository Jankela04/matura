<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="B9.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css"/>
    <title>CD Katalog</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
	        <p>CD Katalog</p>
	    </div>

        <br />

	    <br />
        <br />
        <br />
        <br />

	    <asp:Button ID="Button1" runat="server" Text="Katalog" Width="139px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Korisničko uputstvo" Width="168px" OnClick="Button2_Click" />

       
        <br />
        <br />

       
        <asp:Label ID="Label1" runat="server" Text="Izvodjac:"></asp:Label>

        

        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 90px" Width="263px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Naziv albuma:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 59px" Width="264px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Zanr:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" style="margin-left: 8px" Width="132px">
            <asp:ListItem>Izaberi...</asp:ListItem>
            <asp:ListItem>Rok</asp:ListItem>
            <asp:ListItem>Metal</asp:ListItem>
            <asp:ListItem>Hip hop</asp:ListItem>
            <asp:ListItem>Tehno</asp:ListItem>
            <asp:ListItem>Narodna muzika</asp:ListItem>
            <asp:ListItem>Turbo-folk</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Godina izdanja:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" style="margin-left: 54px" Width="132px">
            <asp:ListItem>Izaberi...</asp:ListItem>
            <asp:ListItem>1978</asp:ListItem>
            <asp:ListItem>1985</asp:ListItem>
            <asp:ListItem>1990</asp:ListItem>
            <asp:ListItem>1992</asp:ListItem>
            <asp:ListItem>1995</asp:ListItem>
            <asp:ListItem>2001</asp:ListItem>
            <asp:ListItem>2005</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Izdavacka kuca:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 47px" Width="266px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Trazi" />
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid" GridLines="Both">
        </asp:Table>

        

    </form>
</body>
</html>
