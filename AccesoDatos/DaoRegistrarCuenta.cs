using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Remoting;



namespace AccesoDatos
{
    public class DaoRegistrarCuenta
    {
        public string RegistrarCuenta(string apodo, string contrasena, string correo, string nombre, int idfoto)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                if (VerificarCorreo(correo))
                {
                    return "correoRepetido";
                }

                if (VerificarApodo(apodo))
                {
                    return "apodoRepetido";
                }

                // Agregar nueva cuenta a la base de datos
                var nuevaCuenta = new Cuenta()
                {
                    apodo = apodo,
                    contrasena = contrasena,
                    correo = correo,
                    nombre = nombre,
                    idFoto = idfoto
                };

                context.Cuenta.Add(nuevaCuenta);
                context.SaveChanges();
                return "guardadoExito";
            }
        }
        public string ModificarCuenta(string NuevoApodo, string NuevoNombre, int NuevoIdFoto, string correo)
        {
            using (var contexto = new CalabozosDragonesEntities())
            {
                // Obtener la cuenta que se quiere modificar
                var cuenta = contexto.Cuenta.FirstOrDefault(c => c.correo == correo);

               

              
                if (cuenta.apodo != NuevoApodo && VerificarApodo(NuevoApodo))
                {
                    return "apodoRepetido";
                }
                

                cuenta.apodo = NuevoApodo;
                cuenta.nombre = NuevoNombre;
                cuenta.idFoto = NuevoIdFoto;
                
                
                contexto.SaveChanges();
                return "cambiosGuardados";
            }
        }

        public Cuenta ObtenerCuentaPorCredenciales(string correo, string contrasena)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                // Buscar la cuenta que coincida con el NuevoCorreo y la contraseña
                var cuenta = context.Cuenta
                                    .FirstOrDefault(c => c.correo == correo && c.contrasena == contrasena);
                return cuenta; // Retorna el objeto Cuenta o null si no se encuentra
            }
        }

        public bool VerificarCorreo(string correo)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                return context.Cuenta.Any(c => c.correo == correo);
            }
        }

        public bool VerificarApodo(string apodo)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                return context.Cuenta.Any(c => c.apodo == apodo);
            }
        }
    }
    
}
