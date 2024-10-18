using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
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
        bool AgregarCuenta(Cuenta cuenta);


    }
    [DataContract]
    public class Cuenta
    { 
        private String apodo;
        private String correo;
        private String contrasena;
      
        [DataMember]
        public string Apodo { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Contrasena{get; set; }
    }
}