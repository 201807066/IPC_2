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
    }
}