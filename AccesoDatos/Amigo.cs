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
    
    public partial class Amigo
    {
        public Amigo()
        {
            this.ListaAmigos = new HashSet<ListaAmigos>();
        }
    
        public int id { get; set; }
        public string apoco { get; set; }
        public string rolJugado { get; set; }
    
        public virtual ICollection<ListaAmigos> ListaAmigos { get; set; }
    }
}
