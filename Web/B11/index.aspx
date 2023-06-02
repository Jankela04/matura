<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="B11.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Почетна</title>
    <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="glow">Туристичка агенција "Планинар"</h1>
			<center>
				<a class="button" href="index.aspx" style="background-color: #8fa832;">Почетна</a>
				<a class="button" href="O_autoru.aspx">О аутору</a>
				<a class="button" href="Uputstvo.aspx">Упутство</a>
		
			<br/><br/><br/>
		
			<div class="w3-container w3-blue">
			  <p>Изаберите град<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack = "true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="DropDownList1_TextChanged">
                  <asp:ListItem Value="Beograd"></asp:ListItem>
                  <asp:ListItem Value="Novi Sad"></asp:ListItem>
                  <asp:ListItem Value="Jagodina"></asp:ListItem>
                  <asp:ListItem Value="Subotica"></asp:ListItem>
                  <asp:ListItem Value="Sombor"></asp:ListItem>
                  <asp:ListItem Value="Loznica"></asp:ListItem>
                  <asp:ListItem Value="Vrbas"></asp:ListItem>
                  <asp:ListItem Value="Zrenjanin"></asp:ListItem>
                  <asp:ListItem Value="Novi Pazar"></asp:ListItem>
                  <asp:ListItem Value="Topola"></asp:ListItem>
                  </asp:DropDownList>
                  &nbsp;&nbsp;&nbsp;
                  <asp:Literal runat="server" ID="txtRenderOnme" EnableViewState="false"></asp:Literal>
                </p>
                <br />
                <iframe runat="server" id="prognoza" src="https://naslovi.net/vremenska-prognoza/beograd" name="Prognoza" height="400px" width="700px" frameborder="0" marginheight="20" marginwidth="35" scrolling="auto"></iframe>
			  
			</div>

			</center>
	
			<div class="footer">
				<p>Copyright © Техничка школа Бечеј</p>
			</div>
        </div>
    </form>
</body>
</html>
