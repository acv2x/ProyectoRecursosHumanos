using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class DEPARTAMENTOS_N
    {
        static DEPARTAMENTOS_D departamentoD = new DEPARTAMENTOS_D();

        public static void InsertarDepartamentos(Departamentos depar)
        {
            departamentoD.InsertarDepartamentos(depar);
        }
        public static List<Departamentos> MostrarDepartamentos()
        {
            return departamentoD.MostrarDepartamentos();
        }
        public static Departamentos DetalleDPTO(int id)
        {
            return departamentoD.DetalleDPTO(id);
        }
        public static void EditarDPTO(Departamentos dpto)
        {
            departamentoD.EditarDPTO(dpto);
        }
        public static void EliminarDPTO(int id)
        {
            departamentoD.EliminarDPTO(id);
        }
    }
}
