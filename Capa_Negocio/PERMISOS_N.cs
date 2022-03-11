using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class PERMISOS_N
    {
        static PERMISOS_D permcapdatos = new PERMISOS_D();
        public static void InsertarPermisos(Permisos perm)
        {
            permcapdatos.CrearPermiso(perm);
        }
        public static List<Permisos> MostrarPermisos()
        {
            return permcapdatos.MostrarPermiso();
        }
        public static Permisos DetallePermiso(int id)
        {
            return permcapdatos.DetallePermiso(id);
        }
        public static void EditarPermiso(Permisos per)
        {
            permcapdatos.EditarPermiso(per);
        }
        public static void EliminarPermiso(int id)
        {
            permcapdatos.EliminarPermisos(id);
        }
    }
}
