using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosCalabozosDragones
{

    public partial class ImplementacionServicio : IGestionCuenta
    {

        public bool AgregarCuenta(Cuenta cuenta)
        {

            return (new DaoRegistrarCuenta().RegistrarCuenta(cuenta.Apodo, cuenta.Contrasena, cuenta.Correo, cuenta.Nombre));

        }

        public bool VerificarInicioSesion(Cuenta cuenta)
        {
            return (new DaoIniciarSesion().VerificarCuenta(cuenta.Correo, cuenta.Contrasena));
        }

    }
   

}
