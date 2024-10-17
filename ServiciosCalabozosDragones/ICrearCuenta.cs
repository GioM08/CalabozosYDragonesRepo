using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosCalabozosDragones
{

    [ServiceContract]
    public interface ICrearCuenta
    {
        [OperationContract]
        void AgregarCuenta(Cuenta cuenta);


    }
    [DataContract]
    public class Cuenta
    { 
      
        [DataMember]
        public string Apodo { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Contrasena{get; set; }
    }
}