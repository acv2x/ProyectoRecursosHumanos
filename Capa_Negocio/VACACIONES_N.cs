using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class VACACIONES_N
    {
        static VACACIONES_D vacaciones = new VACACIONES_D();

        public static void InsertarVacaciones(Vacaciones vaca)
        {
            vacaciones.InsertarVacaciones(vaca);
        }
        public static List<Vacaciones> MostrarVacaciones()
        {
            return vacaciones.MostrarVacaciones();
        }
        public static Vacaciones DetalleVacaciones(int id)
        {
            return vacaciones.DetalleVacaciones(id);
        }
        public static void EditarVacaciones(Vacaciones vaca)
        {
            vacaciones.EditarVacaciones(vaca);
        }
        public static void EliminarVacaciones(int id)
        {
            vacaciones.EliminarVacaciones(id);
        }
    }
}
