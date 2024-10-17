using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosCalabozosDragones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ImplementacionServicio : ICrearCuenta
    {
        public void AgregarCuenta(Cuenta cuenta)
        {
            Console.WriteLine("Usuario añadido" + cuenta.Apodo);
        }

        
        
    }
}
