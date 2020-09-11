using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class ClsLogin
    {
        public static bool IniciarSesion(string user, string contraseña)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            var query = context.Jugador.Where(p => p.Usuario == user && p.Contraseña == contraseña).Select(p => p);

        }
    }
}
