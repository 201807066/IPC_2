using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace othello
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Params["men"] != null)
            {
                String men = Request.Params["men"];

                if(men == "1")
                {
                    lb_mensaje.Text = "Debe iniciar sesión";
                }
            }

        }

        protected void btn_inicio_Click(object sender, EventArgs e)
        {
            //Validacion de los campos de texto 
            if (txt_user.Text == ""| txt_contraseña.Text == "")
            {
                lb_mensaje.Text=("Debe llenar los campos solicitados");
                limpiar();

            }
            else
            {

                string usuario, contraseña;

                usuario = txt_user.Text;
                contraseña = txt_contraseña.Text;

                //Operacion op = new Operacion();
                Operacion op = new Operacion();
                if (op.IniciarSesion(usuario, contraseña))
                {
                    //Objeto para dejar inicada la sesión
                    Session["user"] = usuario;
                    Response.Redirect("menu.aspx");
                    
                }
                else
                {
                    lb_mensaje.Text = "Credenciales incorrectas, intentelo nuevamente";
                    limpiar();
                }
            }
        }

        private void limpiar()
        {
            txt_user.Text = "";
            txt_contraseña.Text = "";
        }
    }
}