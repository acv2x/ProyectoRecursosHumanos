using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class SALIDAEMP_N
    {
        static SALIDAEMP_D salidasdatos = new SALIDAEMP_D();

        public static void InsertarSALIDAEMP(Salidas sal)
        {
            salidasdatos.InsertarSALIDAEMP(sal);

        }
        public static List<Salidas> MostrarSalidas()
        {
            return salidasdatos.MostrarSalidas();
        }
        public static Salidas DetalleSalida(int id)
        {
            return salidasdatos.DetalleSalidas(id);
        }
        public static void EditarSalida(Salidas sal)
        {
            salidasdatos.EditarSalida(sal);
        }
        public static void EliminarSALIDA(int id)
        {
            salidasdatos.EliminarSalida(id);
        }
    }
}
