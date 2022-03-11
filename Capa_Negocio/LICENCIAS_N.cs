using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class LICENCIAS_N
    {
        static LICENCIAS_D licenciadatos = new LICENCIAS_D();
        public static void RegistrarLicencia(Licencias lic)
        {
            licenciadatos.RegistrarLicencia(lic);
        }
        public static List<Licencias> MostrarLicencias()
        {
            return licenciadatos.MostrarLicencias();
        }
        public static Licencias DetalleLicencia(int id)
        {
            return licenciadatos.DetalleLicencia(id);
        }
        public static void EditarLicencia(Licencias lice)
        {
            licenciadatos.EditarLicencia(lice);
        }
        public static void ElimminarLicencia(int id)
        {
            licenciadatos.EliminarLicencia(id);
        }
    }
}
