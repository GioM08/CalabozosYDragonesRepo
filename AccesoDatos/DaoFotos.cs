using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AccesoDatos
{
    public class DaoFotos
    {
        public string ObtenerRuta(int id)
        {
            using (var context = new CalabozosDragonesEntities())
            {
                
                var foto = context.RecursoFoto.FirstOrDefault(f => f.id == id);

                // Si se encuentra la foto, devuelve su ruta
                if (foto != null)
                {
                    return foto.ruta;
                }
                else
                {
                    // Retorna un valor nulo o un mensaje en caso de que no se encuentre
                    return null;
                }
            }
        }
    }

}