using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AccesoDatos
{
    public class DaoRegistrarCuenta
    {
        public bool RegistrarCuenta(string apodo, string contrasena, string correo, string nombre)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                // Verificar apodo y correo
                if (VerificarCorreo(correo) || VerificarApodo(apodo))
                {
                    return false;  // Correo o apodo ya existen
                }
                else
                {
                    // Agregar nueva cuenta a la base de datos
                    var nuevaCuenta = new Cuenta()
                    {
                        apodo = apodo,
                        contrasena = contrasena,
                        correo = correo,
                        nombre = nombre
                    };

                    context.Cuenta.Add(nuevaCuenta);
                    context.SaveChanges(); 
                    return true; 
                }
            }
        }

        public bool VerificarCorreo(string correo)
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
        public bool VerificarApodo(string apodo)
        {
            using (var context = new CalabozosDragonesEntities())
            {

                if (context.Cuenta.Any(c => c.apodo == apodo))
                {
                    return true;  // apodo ya existe
                }
                else
                {
                    return false;
                }
            }

        }


    }
}
