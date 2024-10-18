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

    public class ImplementacionServicio : ICrearCuenta
    {

        public bool AgregarCuenta(Cuenta cuenta)
        {

            return (new DaoCuenta().RegistrarCuenta(cuenta.Apodo, cuenta.Contrasena, cuenta.Correo));
                
        }

    }
}
