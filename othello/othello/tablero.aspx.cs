using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Microsoft;
using System.Xml;
using System.Xml.Linq;
using System.Net;

namespace othello
{
    public partial class tablero : System.Web.UI.Page
    {
        public static string colorito = "";
        public static string fila = "";
        public static string columna = "";
        public static string estado = "falso";
        public static string colorturno = "";
        public static int con = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                System.Web.HttpPostedFile file = Request.Files["fUpload"];
                if (file != null && file.ContentLength > 0)
                {
                    cargar();
                }
            }

        }
        protected void btn_menu_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        //Fila1
        protected void A_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_1.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_1.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        //Fila2
        protected void A_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_2_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_2.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_2.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void A_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_3_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_3.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_3.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void A_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_4_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_4.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_4.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void A_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_5_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_5.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_5.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void A_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_6_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_6.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_6.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void A_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_7_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_7.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_7.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void A_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                A_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                A_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void B_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                B_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                B_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void C_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                C_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                C_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void D_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                D_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                D_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void E_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                E_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                E_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void F_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                F_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                F_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void G_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                G_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                G_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void H_8_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                H_8.BackColor = System.Drawing.Color.White; colorturno = "negro";
            }
            else
            {
                H_8.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            guardarxml();
            mensaje.Text = "Partida guardada exitosamente";
        }

        public void guardarxml()
        {
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement cabeza = new XElement("tablero");
            document.Add(cabeza);

            /*
            *Se guardan la posicion de las fichas cuando el color esta en blanco
            */
            if (A_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (A_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (A_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (A_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (A_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (A_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (A_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (A_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (B_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (B_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (B_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (B_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (B_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (B_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (B_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (B_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (C_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (C_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (C_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (C_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (C_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (C_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (C_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (C_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (D_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (D_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (D_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (D_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (D_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (D_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (D_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (D_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (E_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (E_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (E_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (E_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (E_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (E_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (E_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (E_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (F_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (F_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (F_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (F_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (F_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (F_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (F_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (F_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (G_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (G_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (G_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (G_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (G_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (G_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (G_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (G_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (H_1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (H_2.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (H_3.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (H_4.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (H_5.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (H_6.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (H_7.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (H_8.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            /*
             *Se guardan la posicion de las fichas cuando el color esta en negro
            */

            if (A_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (A_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (A_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (A_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (A_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (A_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (A_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (A_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (B_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (B_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (B_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (B_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (B_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (B_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (B_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (B_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (C_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (C_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (C_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (C_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (C_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (C_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (C_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (C_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (D_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (D_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (D_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (D_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (D_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (D_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (D_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (D_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (E_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (E_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (E_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (E_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (E_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (E_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (E_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (E_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (F_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (F_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (F_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (F_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (F_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (F_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (F_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (F_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (G_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (G_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (G_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (G_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (G_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (G_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (G_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (G_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (H_1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (H_2.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (H_3.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (H_4.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (H_5.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (H_6.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (H_7.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (H_8.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            XElement color = new XElement("siguienteTiro");
            color.Add(new XElement("color", colorturno)); cabeza.Add(color);
            document.Save(@"D:\Documentos\Año_2020_Universidad\SegundoSemestre\IPC2\Laboratorio\Proyecto\Othello\xml\partida_" + con + ".xml");
            con++;
        }

        //Limpiar el tablero
        protected void btn_limpiar_Click(object sender, EventArgs e)
        {
            A_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            A_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            B_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            B_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            C_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            C_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            D_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            D_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            E_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            E_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            F_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            F_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            G_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            G_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

            H_1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_4.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_5.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_6.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_7.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");
            H_8.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff9800");

        }


        //Cargar las fichas al tablero
        public void cargar()
        {
            string c = fUpload.FileName;
            string cadena = @"D:\Documentos\Año_2020_Universidad\SegundoSemestre\IPC2\Laboratorio\Proyecto\Othello\xml\" + c;
            XmlReader xmlreader = XmlReader.Create(cadena);


            while (xmlreader.Read())
            {
                if (xmlreader.IsStartElement())
                {
                    if (estado == "falso")
                    {
                        switch (xmlreader.Name.ToString())
                        {
                            case "color":
                                colorito = xmlreader.ReadString();
                                break;
                            case "fila":
                                fila = xmlreader.ReadString();
                                break;
                            case "columna":
                                columna = xmlreader.ReadString();
                                break;
                            case "siguienteTiro":
                                estado = "verdadero";
                                break;


                        }
                    }
                    else
                    {

                        switch (xmlreader.Name.ToString())
                        {
                            case "color":
                                colorturno = xmlreader.ReadString();
                                estado = "falso";
                                break;

                        }


                    }

                }

                if ((colorito == "blanco"))
                {
                    if ((fila == "1") && (columna == "A")) { A_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "A")) { A_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "A")) { A_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "A")) { A_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "A")) { A_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "A")) { A_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "A")) { A_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "A")) { A_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "B")) { B_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "B")) { B_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "B")) { B_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "B")) { B_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "B")) { B_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "B")) { B_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "B")) { B_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "B")) { B_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "C")) { C_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "C")) { C_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "C")) { C_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "C")) { C_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "C")) { C_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "C")) { C_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "C")) { C_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "C")) { C_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "D")) { D_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "D")) { D_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "D")) { D_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "D")) { D_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "D")) { D_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "D")) { D_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "D")) { D_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "D")) { D_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "E")) { E_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "E")) { E_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "E")) { E_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "E")) { E_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "E")) { E_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "E")) { E_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "E")) { E_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "E")) { E_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "F")) { F_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "F")) { F_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "F")) { F_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "F")) { F_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "F")) { F_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "F")) { F_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "F")) { F_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "F")) { F_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "G")) { G_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "G")) { G_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "G")) { G_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "G")) { G_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "G")) { G_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "G")) { G_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "G")) { G_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "G")) { G_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "H")) { H_1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "H")) { H_2.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "H")) { H_3.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "H")) { H_4.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "H")) { H_5.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "H")) { H_6.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "H")) { H_7.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "H")) { H_8.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }



                }
                else
                {
                    if ((fila == "1") && (columna == "A")) { A_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "A")) { A_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "A")) { A_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "A")) { A_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "A")) { A_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "A")) { A_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "A")) { A_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "A")) { A_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "B")) { B_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "B")) { B_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "B")) { B_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "B")) { B_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "B")) { B_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "B")) { B_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "B")) { B_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "B")) { B_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "C")) { C_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "C")) { C_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "C")) { C_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "C")) { C_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "C")) { C_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "C")) { C_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "C")) { C_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "C")) { C_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "D")) { D_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "D")) { D_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "D")) { D_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "D")) { D_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "D")) { D_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "D")) { D_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "D")) { D_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "D")) { D_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "E")) { E_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "E")) { E_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "E")) { E_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "E")) { E_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "E")) { E_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "E")) { E_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "E")) { E_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "E")) { E_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "F")) { F_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "F")) { F_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "F")) { F_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "F")) { F_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "F")) { F_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "F")) { F_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "F")) { F_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "F")) { F_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "G")) { G_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "G")) { G_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "G")) { G_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "G")) { G_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "G")) { G_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "G")) { G_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "G")) { G_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "G")) { G_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "H")) { H_1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "H")) { H_2.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "H")) { H_3.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "H")) { H_4.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "H")) { H_5.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "H")) { H_6.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "H")) { H_7.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "H")) { H_8.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                }


            }




        }
    }
}