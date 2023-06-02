<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uputstvo.aspx.cs" Inherits="B9.Uputstvo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" type="text/css"/>
    <title>Uputstvo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
	        <p>Korisničko uputstvo</p>
	    </div>

        <br />

	    <br />
        <br />
        <br />
        <br />

	    <asp:Button ID="Button1" runat="server" Text="Katalog" Width="139px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Korisničko uputstvo" Width="168px" OnClick="Button2_Click" />

        <div>
            <h1>Pretraga se vrsi unosom odabranih podataka u teksutalna polja odnosno odabirom u padajucoj listi.</h1>
            <br />
            <h1>Posle unosa podataka pritisnite na dugme 'Trazi' kako bi zapoceli pretragu.</h1>
        </div>
    </form>
</body>
</html>
