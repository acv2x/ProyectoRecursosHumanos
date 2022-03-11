using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CARGOS_N
    {
        static CARGOS_D cargdat = new CARGOS_D();
        public static void InsertarCargos(Cargos car)
        {
            cargdat.InsertarCargos(car);
        }
        public static List<Cargos> MostrarCargos()
        {
            return cargdat.MostrarCargo();
        }
        public static Cargos DetalleCargo(int id)
        {
            return cargdat.DetalleCargo(id);
        }
        public static void EditarCargo(Cargos car)
        {
            cargdat.EditarCargo(car);
        }
        public static void EliminarCargo(int id)
        {
            cargdat.EliminarCargo(id);
        }
    }
}
