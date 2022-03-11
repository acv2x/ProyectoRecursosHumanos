using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class NOMINAS_N
    {
        static NOMINAS_D nomD = new NOMINAS_D();

        public static void CrearNomina(Nominas nomi)
        {
            nomD.CrearNomina(nomi);
        }
        public static List<Nominas> MostrarNomina()
        {
            return nomD.MostrarNomina();
        }
        public static Nominas DetalleNom(int id)
        {
            return nomD.DetalleNom(id);
        }
        public static void EditarNom(Nominas nomi)
        {
            nomD.EditarNomina(nomi);
        }
        public static void EliminarNom(int id)
        {
            nomD.EliminarNomina(id);

        }
    }
}
