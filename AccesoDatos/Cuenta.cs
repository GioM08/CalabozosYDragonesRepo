//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta
    {
        public Cuenta()
        {
            this.ListaAmigos = new HashSet<ListaAmigos>();
        }
    
        public int id { get; set; }
        public string apodo { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public Nullable<int> idFoto { get; set; }
        public Nullable<int> idSala { get; set; }
    
        public virtual RecursoFoto RecursoFoto { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual ICollection<ListaAmigos> ListaAmigos { get; set; }
    }
}
