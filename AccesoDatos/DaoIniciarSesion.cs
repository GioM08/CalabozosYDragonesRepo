using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DaoIniciarSesion
    {
        public bool VerificarCuenta(string correo, string contrasena)
        {
            using (var context = new CalabozosDragonesEntities())
            {

                if (context.Cuenta.Any(c => c.correo == correo && c.contrasena== contrasena))
                {
                    return true;  // Se encontro una coincidencia
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
