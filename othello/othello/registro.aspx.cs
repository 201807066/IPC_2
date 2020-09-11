using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Biblioteca;

namespace othello
{
    public partial class registro : System.Web.UI.Page
    {
        protected void btn_registro_Click(object sender, EventArgs e)
        {

            if(txt_nombre.Text == "" | txt_apellido.Text == "" | txt_user.Text == "" | txt_contraseña.Text == "" | txt_fecha.Text == "" | drop_pais.Text == "País" | txt_correo.Text == "")
            {
                Label1.Text = "Debe llenar todos los campos solicitados";
                limpiar();
            }
            else
            {
                string usuario, nombre, apellido, contraseña, fecha_nac, correo, pais;

                usuario = txt_user.Text;
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                contraseña = txt_contraseña.Text;
                fecha_nac = txt_fecha.Text;
                correo = txt_correo.Text;
                pais = drop_pais.Text;

                Operacion op = new Operacion();

                if (op.InsertPersona(usuario, nombre, apellido, contraseña, fecha_nac, correo, pais))
                {
                    MessageBox.Show("Jugador registrado correctamente");
                    Label1.Text = "Jugador registrado correctamente";
                    Response.Redirect("login.aspx");
                    limpiar();
                }
                else
                {
                    Label1.Text = "Error de registro, intentelo nuevamente";
                    limpiar();
                }
            }

            

        }

        private void limpiar()
        {
            txt_user.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_contraseña.Text = "";
            txt_fecha.Text = "";
            txt_correo.Text = "";
            drop_pais.Text = "País";

        }
    }
}