<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imenik.aspx.cs" Inherits="Telefonski_Imenik.TelImenik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Imenik</title>
     <link rel="stylesheet" type="text/css" href="StyleSheet1.css"/>
</head>
<body>
    <a href="Korisnicko Uputstvo.aspx" class="dugme">Korisnicko Uputstvo</a>
    <a href="Vazni Brojevi.aspx" class="dugme">Vazni Brojevi</a>
    
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Ime"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Prezime"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Adresa"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Izaberite...</asp:ListItem>
            <asp:ListItem>Backo Gradiste</asp:ListItem>
            <asp:ListItem>Becej</asp:ListItem>
            <asp:ListItem>Turija</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" Text="Mesto"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Broj telefona"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Trazi" OnClick="Button1_Click" style="height: 26px" />
        <asp:Table ID="Table1" runat="server" BorderColor="#66FF99" BorderStyle="Dotted" GridLines="Both">
        </asp:Table>
    </form>
</body>
</html>
