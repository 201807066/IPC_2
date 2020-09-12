<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tablero.aspx.cs" Inherits="othello.tablero" %>

<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Tablero</title>
    <link rel="stylesheet" type="text/css" href="tablero/estilos/estilos.css">
</head>
<body>

	<form id="form1" runat="server">
		<div>
			<asp:Image ID="Image1" runat="server" Cssclass="centro" src="menu/img/title.png" />
			<asp:Button ID="btn_menu" runat="server" CssClass="btn_menu" OnClick="btn_menu_Click" Text="" />
		</div>

		<div id="main">
			<div class="bloque negro flotar"></div>
			<div class="bloque verde flotar">A</div>
			<div class="bloque verde flotar">B</div>
			<div class="bloque verde flotar">C</div>
			<div class="bloque verde flotar">D</div>
			<div class="bloque verde flotar">E</div>
			<div class="bloque verde flotar">F</div>
			<div class="bloque verde flotar">G</div>
			<div class="bloque verde flotar">H</div>

			<!--Fila 1-->
			<div class="bloque verde flotar">1</div>
			<div class="bloque color flotar"><asp:Button ID="A_1" runat="server" CssClass="btn_redondo" OnClick="A_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_1" runat="server" CssClass="btn_redondo" OnClick="B_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_1" runat="server" CssClass="btn_redondo" OnClick="C_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_1" runat="server" CssClass="btn_redondo" OnClick="D_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_1" runat="server" CssClass="btn_redondo" OnClick="E_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_1" runat="server" CssClass="btn_redondo" OnClick="F_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_1" runat="server" CssClass="btn_redondo" OnClick="G_1_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_1" runat="server" CssClass="btn_redondo" OnClick="H_1_Click" /></div>

			<!--Fila 2-->
			<div class="bloque verde flotar">2</div>
			<div class="bloque color flotar"><asp:Button ID="A_2" runat="server" CssClass="btn_redondo" OnClick="A_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_2" runat="server" CssClass="btn_redondo" OnClick="B_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_2" runat="server" CssClass="btn_redondo" OnClick="C_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_2" runat="server" CssClass="btn_redondo" OnClick="D_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_2" runat="server" CssClass="btn_redondo" OnClick="E_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_2" runat="server" CssClass="btn_redondo" OnClick="F_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_2" runat="server" CssClass="btn_redondo" OnClick="G_2_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_2" runat="server" CssClass="btn_redondo" OnClick="H_2_Click" /></div>

			<!--Fila 3-->
			<div class="bloque verde flotar">3</div>
			<div class="bloque color flotar"><asp:Button ID="A_3" runat="server" CssClass="btn_redondo" OnClick="A_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_3" runat="server" CssClass="btn_redondo" OnClick="B_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_3" runat="server" CssClass="btn_redondo" OnClick="C_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_3" runat="server" CssClass="btn_redondo" OnClick="D_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_3" runat="server" CssClass="btn_redondo" OnClick="E_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_3" runat="server" CssClass="btn_redondo" OnClick="F_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_3" runat="server" CssClass="btn_redondo" OnClick="G_3_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_3" runat="server" CssClass="btn_redondo" OnClick="H_3_Click" /></div>

			<!--Fila 4-->
			<div class="bloque verde flotar">4</div>
			<div class="bloque color flotar"><asp:Button ID="A_4" runat="server" CssClass="btn_redondo" OnClick="A_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_4" runat="server" CssClass="btn_redondo" OnClick="B_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_4" runat="server" CssClass="btn_redondo" OnClick="C_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_4" runat="server" CssClass="btn_redondo" OnClick="D_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_4" runat="server" CssClass="btn_redondo" OnClick="E_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_4" runat="server" CssClass="btn_redondo" OnClick="F_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_4" runat="server" CssClass="btn_redondo" OnClick="G_4_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_4" runat="server" CssClass="btn_redondo" OnClick="H_4_Click" /></div>

			<!--Fila 5-->
			<div class="bloque verde flotar">5</div>
			<div class="bloque color flotar"><asp:Button ID="A_5" runat="server" CssClass="btn_redondo" OnClick="A_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_5" runat="server" CssClass="btn_redondo" OnClick="B_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_5" runat="server" CssClass="btn_redondo" OnClick="C_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_5" runat="server" CssClass="btn_redondo" OnClick="D_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_5" runat="server" CssClass="btn_redondo" OnClick="E_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_5" runat="server" CssClass="btn_redondo" OnClick="F_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_5" runat="server" CssClass="btn_redondo" OnClick="G_5_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_5" runat="server" CssClass="btn_redondo" OnClick="H_5_Click" /></div>

			<!--Fila 6-->
			<div class="bloque verde flotar">6</div>
			<div class="bloque color flotar"><asp:Button ID="A_6" runat="server" CssClass="btn_redondo" OnClick="A_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_6" runat="server" CssClass="btn_redondo" OnClick="B_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_6" runat="server" CssClass="btn_redondo" OnClick="C_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_6" runat="server" CssClass="btn_redondo" OnClick="D_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_6" runat="server" CssClass="btn_redondo" OnClick="E_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_6" runat="server" CssClass="btn_redondo" OnClick="F_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_6" runat="server" CssClass="btn_redondo" OnClick="G_6_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_6" runat="server" CssClass="btn_redondo" OnClick="H_6_Click" /></div>

			<!--Fila 7-->
			<div class="bloque verde flotar">7</div>
			<div class="bloque color flotar"><asp:Button ID="A_7" runat="server" CssClass="btn_redondo" OnClick="A_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_7" runat="server" CssClass="btn_redondo" OnClick="B_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_7" runat="server" CssClass="btn_redondo" OnClick="C_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_7" runat="server" CssClass="btn_redondo" OnClick="D_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_7" runat="server" CssClass="btn_redondo" OnClick="E_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_7" runat="server" CssClass="btn_redondo" OnClick="F_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_7" runat="server" CssClass="btn_redondo" OnClick="G_7_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_7" runat="server" CssClass="btn_redondo" OnClick="H_7_Click" /></div>

			<!--Fila 8-->
			<div class="bloque verde flotar">8</div>
			<div class="bloque color flotar"><asp:Button ID="A_8" runat="server" CssClass="btn_redondo" OnClick="A_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="B_8" runat="server" CssClass="btn_redondo" OnClick="B_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="C_8" runat="server" CssClass="btn_redondo" OnClick="C_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="D_8" runat="server" CssClass="btn_redondo" OnClick="D_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="E_8" runat="server" CssClass="btn_redondo" OnClick="E_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="F_8" runat="server" CssClass="btn_redondo" OnClick="F_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="G_8" runat="server" CssClass="btn_redondo" OnClick="G_8_Click" /></div>
			<div class="bloque color flotar"><asp:Button ID="H_8" runat="server" CssClass="btn_redondo" OnClick="H_8_Click" /></div>
			
			<asp:Button ID="btn_cargar" runat="server" Text="" CssClass="cargar" />
            <asp:Button ID="btn_guardar" runat="server" Text="" CssClass="guardar" />
            <asp:Button ID="btn_limpiar" runat="server" Text="" CssClass="limpiar" />
		</div>


    </form>

</body>
</html>