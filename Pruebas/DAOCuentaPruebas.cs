using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pruebas
{
    public class DAOCuentaPruebas
    {
        [Theory]
        [InlineData("Gio", "12345", "gio@gmail.com", false)]
        [InlineData("Lio", "9877", "lio@gmail.com",  true)]
        public void AgregarCuentaPrueba(string apodo, string contrasena, string correo, bool valorEsperado)
        {
            using (var context = new CalabozosDragonesEntities())
            {



                var nuevaCuenta = new Cuenta()
                {
                    apodo = "Gio",
                    contrasena = "12345",
                    correo = "gio@gmail.com"
                };

                context.Cuenta.Add(nuevaCuenta);
                context.SaveChanges();

                bool var = new DaoCuenta().RegistrarCuenta(apodo, contrasena, correo);
                context.Cuenta.Remove(nuevaCuenta);
                context.SaveChanges();
                var todosLosRegistros = context.Cuenta.ToList();
                context.Cuenta.RemoveRange(todosLosRegistros);
                context.SaveChanges();

                Assert.Equal(valorEsperado,var);
                

            }
            

        }
    }
}
