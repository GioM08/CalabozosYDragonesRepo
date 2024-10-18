using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AccesoDatos
{
    public class DaoCuenta
    {
        public bool RegistrarCuenta(string apodo, string contrasena, string correo)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                // Verificar si el correo ya está registrado
                if (context.Cuenta.Any(c => c.correo == correo))
                {
                    return false;  // Correo ya existe
                }
                else
                {
                    // Agregar nueva cuenta a la base de datos
                    var nuevaCuenta = new Cuenta()
                    {
                        apodo = apodo,
                        contrasena = contrasena,
                        correo = correo
                    };

                    context.Cuenta.Add(nuevaCuenta);
                    context.SaveChanges(); 
                    return true; 
                }
            }
        }

        public bool VerificarCuenta(string correo)
        {
            using (var context = new CalabozosDragonesEntities())
            {

                if (context.Cuenta.Any(c => c.correo == correo))
                {
                    return true;  // Correo ya existe
                }
                else
                {
                    return false;
                }
            }

        }


    }
}
