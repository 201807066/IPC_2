<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="othello.WebForm2" %>

<!DOCTYPE html>

<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="menu/css/estilos.css">
</head>
<body>

	<form id="form1" runat="server">
     <asp:Button ID="btn_cerrar" runat="server" OnClick="btn_cerrar_Click" Text="Cerrar Sesión" CssClass="submit-btn" />
	 <asp:Label ID="lb_bienvenida" runat="server" BorderStyle="None" Font-Bold="True" Font-Size="Large" ForeColor="#003300"></asp:Label>
    <asp:Image ID="Image1" runat="server" Cssclass="centro" src="menu/img/title.png" />


    <div class="main">

        <asp:Button ID="btn_uno" runat="server" CssClass="uno" Text="" OnClick="btn_uno_Click" />
        <asp:Button ID="btn_dos" runat="server" CssClass="dos" Text="" />
        <asp:Button ID="btn_torneo" runat="server" CssClass="torneo" Text="" />
        <asp:Button ID="btn_reporte" runat="server" CssClass="reporte" Text="" />

	</div>

    </form>

</body>
</html>
