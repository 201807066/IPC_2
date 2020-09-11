<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="othello.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="Inicio de secion/css/estilos.css">
</head>
<body>


	<div class="container">
		<div class="form-box">
		<h1 class="text">Inicio de sesión OTHELLO</h1>

			<!--Formulario para el inicio de sesion-->
			<form id="login" runat="server">
				<br />
				<br />
                <asp:TextBox ID="txt_user" runat="server" placeholder="Nombre de usuario" CssClass="input-field"></asp:TextBox>
				<asp:TextBox ID="txt_contraseña" runat="server" placeholder="Contraseña" CssClass="input-field" TextMode="Password"></asp:TextBox>
				<br />
					<asp:Label ID="lb_mensaje" runat="server"></asp:Label>
                <asp:Button ID="btn_inicio" runat="server" CssClass="submit-btn" Text="Iniciar sesión" OnClick="btn_inicio_Click" />
                
            </form>

			<div class="connect">
				<p>
					<a href="registro.aspx">Crear cuenta</a>
				</p>
			</div>
			
		</div>
	</div>

</body>
</html>