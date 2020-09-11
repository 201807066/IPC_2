<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="othello.registro" %>

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
		<div class="form-box2">
		<h1 class="text">Registrate OTHELLO</h1>

			<!--Formulario para el inicio de sesion-->
			<form id="login" runat="server">
				<asp:TextBox ID="txt_nombre" runat="server" placeholder="Nombre" CssClass="input-field"></asp:TextBox>
				<asp:TextBox ID="txt_apellido" runat="server" placeholder="Apellido" CssClass="input-field"></asp:TextBox>
                <asp:TextBox ID="txt_user" runat="server" placeholder="Nombre de usuario" CssClass="input-field"></asp:TextBox>
				<asp:TextBox ID="txt_contraseña" runat="server" placeholder="Contraseña" CssClass="input-field" TextMode="Password"></asp:TextBox>
				<asp:TextBox ID="txt_fecha" runat="server" placeholder="Fecha" CssClass="input-field"></asp:TextBox>
				<asp:DropDownList ID="drop_pais" runat="server"  CssClass="input-field">
					<asp:ListItem>País</asp:ListItem>
                    <asp:ListItem>Afganistán</asp:ListItem>
                    <asp:ListItem>Albanial</asp:ListItem>
                    <asp:ListItem>Alemania</asp:ListItem>
					<asp:ListItem>Andorra</asp:ListItem>
					<asp:ListItem>Angola</asp:ListItem>
					<asp:ListItem>Antigua y Barbuda</asp:ListItem>
					<asp:ListItem>Arabia Saudita</asp:ListItem>
					<asp:ListItem>Argelia</asp:ListItem>
					<asp:ListItem>Argentina</asp:ListItem>
					<asp:ListItem>Armenia</asp:ListItem>
					<asp:ListItem>Australia</asp:ListItem>
					<asp:ListItem>Austria</asp:ListItem>
					<asp:ListItem>Azerbaiyán</asp:ListItem>
					<asp:ListItem>Bahamas</asp:ListItem>
					<asp:ListItem>Bangladés</asp:ListItem>
					<asp:ListItem>Barbados</asp:ListItem>
					<asp:ListItem>Baréin</asp:ListItem>
					<asp:ListItem>Bélgica</asp:ListItem>
					<asp:ListItem>Belice</asp:ListItem>
					<asp:ListItem>Bielorrusia</asp:ListItem>
					<asp:ListItem>Birmania</asp:ListItem>
					<asp:ListItem>Bolivia</asp:ListItem>
					<asp:ListItem>Bosnia y Herzegovina</asp:ListItem>
					<asp:ListItem>Botsuana</asp:ListItem>
					<asp:ListItem>Brasil</asp:ListItem>
					<asp:ListItem>Brunéi</asp:ListItem>
					<asp:ListItem>Bulgaria</asp:ListItem>
					<asp:ListItem>Burkina Faso</asp:ListItem>
					<asp:ListItem>Burundi</asp:ListItem>
					<asp:ListItem>Bután</asp:ListItem>
					<asp:ListItem>Cabo Verde</asp:ListItem>
					<asp:ListItem>Camboya</asp:ListItem>
					<asp:ListItem>Camerún</asp:ListItem>
					<asp:ListItem>Canadá</asp:ListItem>
					<asp:ListItem>Catar</asp:ListItem>
					<asp:ListItem>Chad</asp:ListItem>
					<asp:ListItem>Chile</asp:ListItem>
					<asp:ListItem>China</asp:ListItem>
					<asp:ListItem>Chipre</asp:ListItem>
					<asp:ListItem>Ciudad del Vaticano</asp:ListItem>
					<asp:ListItem>Colombia</asp:ListItem>
					<asp:ListItem>Comoras</asp:ListItem>
					<asp:ListItem>Corea del Norte</asp:ListItem>
					<asp:ListItem>Corea del Sur</asp:ListItem>
					<asp:ListItem>Costa de Marfil</asp:ListItem>
					<asp:ListItem>Costa Rica</asp:ListItem>
					<asp:ListItem>Croacia</asp:ListItem>
					<asp:ListItem>Cuba</asp:ListItem>
					<asp:ListItem>Dinamarca</asp:ListItem>
					<asp:ListItem>Dominica</asp:ListItem>
					<asp:ListItem>Ecuador</asp:ListItem>
					<asp:ListItem>Egipto</asp:ListItem>
					<asp:ListItem>El Salvador</asp:ListItem>
					<asp:ListItem>Emiratos Árabes Unidos</asp:ListItem>
					<asp:ListItem>Eritrea</asp:ListItem>
					<asp:ListItem>Eslovaquia</asp:ListItem>
					<asp:ListItem>Eslovenia</asp:ListItem>
					<asp:ListItem>España</asp:ListItem>
					<asp:ListItem>Estados Unidos</asp:ListItem>
					<asp:ListItem>Estonia</asp:ListItem>
					<asp:ListItem>Etiopía</asp:ListItem>
					<asp:ListItem>Filipinas</asp:ListItem>
					<asp:ListItem>Finlandia</asp:ListItem>
					<asp:ListItem>Fiyi</asp:ListItem>
					<asp:ListItem>Francia</asp:ListItem>
					<asp:ListItem>Gabón</asp:ListItem>
					<asp:ListItem>Georgia</asp:ListItem>
					<asp:ListItem>Ghana</asp:ListItem>
					<asp:ListItem>Granada</asp:ListItem>
					<asp:ListItem>Grecia</asp:ListItem>
					<asp:ListItem>Guatemala</asp:ListItem>
					<asp:ListItem>Guyana</asp:ListItem>
					<asp:ListItem>Guinea</asp:ListItem>
					<asp:ListItem>Guinea ecuatorial</asp:ListItem>
					<asp:ListItem>Guinea-Bisáu</asp:ListItem>
					<asp:ListItem>Haití</asp:ListItem>
					<asp:ListItem>Honduras</asp:ListItem>
					<asp:ListItem>Hungría</asp:ListItem>
					<asp:ListItem>India</asp:ListItem>
					<asp:ListItem>Indonesia</asp:ListItem>
					<asp:ListItem>Irak</asp:ListItem>
					<asp:ListItem>Irán</asp:ListItem>
					<asp:ListItem>Irlanda</asp:ListItem>
					<asp:ListItem>Islandia</asp:ListItem>
					<asp:ListItem>Islas Marshall</asp:ListItem>
					<asp:ListItem>Islas Salomón</asp:ListItem>
					<asp:ListItem>Israel</asp:ListItem>
					<asp:ListItem>Italia</asp:ListItem>
					<asp:ListItem>Jamaica</asp:ListItem>
					<asp:ListItem>Japón</asp:ListItem>
					<asp:ListItem>Jordania</asp:ListItem>
					<asp:ListItem>Kazajistán</asp:ListItem>
					<asp:ListItem>Kenia</asp:ListItem>
					<asp:ListItem>Kirguistán</asp:ListItem>
					<asp:ListItem>Kiribati</asp:ListItem>
					<asp:ListItem>Kuwait</asp:ListItem>
					<asp:ListItem>Laos</asp:ListItem>
					<asp:ListItem>Lesoto</asp:ListItem>
					<asp:ListItem>Letonia</asp:ListItem>
					<asp:ListItem>Líbano</asp:ListItem>
					<asp:ListItem>Liberia</asp:ListItem>
					<asp:ListItem>Libia</asp:ListItem>
					<asp:ListItem>Liechtenstein</asp:ListItem>
					<asp:ListItem>Lituania</asp:ListItem>
					<asp:ListItem>Luxemburgo</asp:ListItem>
					<asp:ListItem>Macedonia del Norte</asp:ListItem>
					<asp:ListItem>Madagascar</asp:ListItem>
					<asp:ListItem>Malasia</asp:ListItem>
					<asp:ListItem>Malaui</asp:ListItem>
					<asp:ListItem>Maldivas</asp:ListItem>
					<asp:ListItem>Malí</asp:ListItem>
					<asp:ListItem>Malta</asp:ListItem>
					<asp:ListItem>Marruecos</asp:ListItem>
					<asp:ListItem>Mauricio</asp:ListItem>
					<asp:ListItem>Mauritania</asp:ListItem>
					<asp:ListItem>México</asp:ListItem>
					<asp:ListItem>Micronesia</asp:ListItem>
					<asp:ListItem>Moldavia</asp:ListItem>
					<asp:ListItem>Mónaco</asp:ListItem>
					<asp:ListItem>Mongolia</asp:ListItem>
					<asp:ListItem>Montenegro</asp:ListItem>
					<asp:ListItem>Mozambique</asp:ListItem>
					<asp:ListItem>Namibia</asp:ListItem>
					<asp:ListItem>Nauru</asp:ListItem>
					<asp:ListItem>Nepal</asp:ListItem>
					<asp:ListItem>Nicaragua</asp:ListItem>
					<asp:ListItem>Níger</asp:ListItem>
					<asp:ListItem>Nigeria</asp:ListItem>
					<asp:ListItem>Noruega</asp:ListItem>
					<asp:ListItem>Nueva Zelanda</asp:ListItem>
					<asp:ListItem>Omán</asp:ListItem>
					<asp:ListItem>Países Bajos</asp:ListItem>
					<asp:ListItem>Pakistán</asp:ListItem>
					<asp:ListItem>Palaos</asp:ListItem>
					<asp:ListItem>Panamá</asp:ListItem>
					<asp:ListItem>Papúa Nueva Guinea</asp:ListItem>
					<asp:ListItem>Paraguay</asp:ListItem>
					<asp:ListItem>Perú</asp:ListItem>
					<asp:ListItem>Polonia</asp:ListItem>
					<asp:ListItem>Portugal</asp:ListItem>
					<asp:ListItem>Reino Unido</asp:ListItem>
					<asp:ListItem>República Centroafricana</asp:ListItem>
					<asp:ListItem>República Checa</asp:ListItem>
					<asp:ListItem>República del Congo</asp:ListItem>
					<asp:ListItem>República Democrática del Congo</asp:ListItem>
					<asp:ListItem>República Dominicana</asp:ListItem>
					<asp:ListItem>Ruanda</asp:ListItem>
					<asp:ListItem>Rumanía</asp:ListItem>
					<asp:ListItem>Rusia</asp:ListItem>
					<asp:ListItem>Samoa</asp:ListItem>
					<asp:ListItem>San Cristóbal y Nieves</asp:ListItem>
					<asp:ListItem>San Marino</asp:ListItem>
					<asp:ListItem>San Vicente y las Granadinas</asp:ListItem>
					<asp:ListItem>Santa Lucía</asp:ListItem>
					<asp:ListItem>Santo Tomé y Príncipe</asp:ListItem>
					<asp:ListItem>Senegal</asp:ListItem>
					<asp:ListItem>Serbia</asp:ListItem>
					<asp:ListItem>Seychelles</asp:ListItem>
					<asp:ListItem>Sierra Leona</asp:ListItem>
					<asp:ListItem>Singapur</asp:ListItem>
					<asp:ListItem>Siria</asp:ListItem>
					<asp:ListItem>Somalia</asp:ListItem>
					<asp:ListItem>Sri Lanka</asp:ListItem>
					<asp:ListItem>Suazilandia</asp:ListItem>
					<asp:ListItem>Sudáfrica</asp:ListItem>
					<asp:ListItem>Sudán</asp:ListItem>
					<asp:ListItem>Sudán del Sur</asp:ListItem>
					<asp:ListItem>Suecia</asp:ListItem>
					<asp:ListItem>Suiza</asp:ListItem>
					<asp:ListItem>Surinam</asp:ListItem>
					<asp:ListItem>Tailandia</asp:ListItem>
					<asp:ListItem>Tanzania</asp:ListItem>
					<asp:ListItem>Tayikistán</asp:ListItem>
					<asp:ListItem>Timor Oriental</asp:ListItem>
					<asp:ListItem>Togo</asp:ListItem>
					<asp:ListItem>Tonga</asp:ListItem>
					<asp:ListItem>Trinidad y Tobago</asp:ListItem>
					<asp:ListItem>Túnez</asp:ListItem>
					<asp:ListItem>Turkmenistán</asp:ListItem>
					<asp:ListItem>Turquía</asp:ListItem>
					<asp:ListItem>Tuvalu</asp:ListItem>
					<asp:ListItem>Ucrania</asp:ListItem>
					<asp:ListItem>Uganda</asp:ListItem>
					<asp:ListItem>Uruguay</asp:ListItem>
					<asp:ListItem>Uzbekistán</asp:ListItem>
					<asp:ListItem>Vanuatu</asp:ListItem>
					<asp:ListItem>Venezuela</asp:ListItem>
					<asp:ListItem>Vietnam</asp:ListItem>
					<asp:ListItem>Yemen</asp:ListItem>
					<asp:ListItem>Yibuti</asp:ListItem>
					<asp:ListItem>Zambia</asp:ListItem>
					<asp:ListItem>Zimbabue</asp:ListItem>
                </asp:DropDownList>
				<asp:TextBox ID="txt_correo" runat="server" placeholder="Correo" CssClass="input-field" TextMode="Email"></asp:TextBox>


                <asp:Label ID="Label1" runat="server"></asp:Label>


                <asp:Button ID="btn_registro" runat="server" CssClass="submit-btn" Text="Registrarse" OnClick="btn_registro_Click" />
            </form>

			
		</div>
	</div>

</body>
</html>
