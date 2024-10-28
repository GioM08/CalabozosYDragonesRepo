using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosCalabozosDragones
{

    public partial class ImplementacionServicio : IGestionCuenta
    {

        public string AgregarCuenta(Cuenta cuenta)
        {

            return new DaoRegistrarCuenta().RegistrarCuenta(cuenta.Apodo, cuenta.Contrasena, cuenta.Correo, cuenta.Nombre, cuenta.IdFoto);

        }

        public Cuenta ObtenerCuenta(string correo, string contrasena)
        {
            var daoCuenta = new DaoRegistrarCuenta();
            var cuenta = daoCuenta.ObtenerCuentaPorCredenciales(correo, contrasena);

            if (cuenta != null)
            {
                // Convertir la entidad Cuenta a un DTO para devolver
                return new Cuenta
                {
                    Correo = cuenta.correo,
                    Apodo = cuenta.apodo,
                    IdFoto = (int)cuenta.idFoto
                };
            }

            return null; 
        }

        public string ModificarCuenta(Cuenta cuentaModificacion, Cuenta cuenta)
        {
            var daoCuenta = new DaoRegistrarCuenta();
            return daoCuenta.ModificarCuenta(cuentaModificacion.Apodo, cuentaModificacion.Nombre, cuentaModificacion.IdFoto, cuenta.Correo);

        }
    

        public string ObtenerFoto(Foto foto)
        {
            throw new NotImplementedException();
        }

        public string ObtenerRuta(int idFoto)
        {
            return new DaoFotos().ObtenerRuta(idFoto);
        }

        public bool VerificarInicioSesion(Cuenta cuenta)
        {
            return (new DaoIniciarSesion().VerificarCuenta(cuenta.Correo, cuenta.Contrasena));
        }

        
    }
   

}
