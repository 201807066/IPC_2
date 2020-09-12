using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace othello
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String usuario = Session["user"].ToString();
                //Sesion conectada
                lb_bienvenida.Text = usuario;
            }
            catch (Exception ex)
            {
                /*Redirigir a inicio de sesion*/
                Response.Redirect("login.aspx?men=1");
            }
        }
        protected void btn_cerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("login.aspx");
        }

        protected void btn_uno_Click(object sender, EventArgs e)
        {
            Response.Redirect("tablero.aspx");
        }
    }
}