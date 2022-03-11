using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class EMPLEADOS_N
    {
        static EMPLEADOS_D empleD = new EMPLEADOS_D();

        public static void InsertarEmpleado(Empleados emple)
        {
            empleD.InsertarEmpleado(emple);
        }
        public static List<Empleados> MostrarEmpleado()
        {
            return empleD.MostrarEmpleado();
        }
        public static Empleados DetalleEMP(int id)
        {
            return empleD.DetalleEMP(id);
        }
        public static void EditarEmp(Empleados emp)
        {
            empleD.EditarEmp(emp);
        }
        public static void EliminarEMP(int id)
        {
            empleD.EliminarEMP(id);

        }
    }
}
