using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class Operacion
    {
       
        public bool InsertPersona(string usuario, string nombre, string apellido, string contraseña, string fecha_nac, string correo, string pais)
        {
            Conexion cn = new Conexion();

            try
            {
                string sql = "INSERT INTO Jugador VALUES('"+usuario+"' , '"+nombre+"' , '"+apellido+"', '"+contraseña+"', '"+ fecha_nac + "' , '"+correo+"', '"+pais+"')";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch(Exception)
            {
                return false;
            }

        }

        public bool IniciarSesion(string usuario, string contraseña)
        {
            Conexion cn = new Conexion();

            try
            {
                string sql = "SELECT * FROM Jugador WHERE Usuario = '"+ usuario +"' AND Contraseña = '"+ contraseña +"'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt.Rows.Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
