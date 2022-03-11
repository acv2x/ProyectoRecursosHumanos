using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Servicio
{
    public class SERVICIOS_S
    {
        static ProyectoASPEntities contexto = new ProyectoASPEntities();

        public static List<Empleados_Activos_Result> EmpleadosActivosBusca(string nombre,Nullable <int> departamento)
        {
            return contexto.Empleados_Activos(nombre, departamento).ToList();
        }
        public static List<Empleados_Inactivos_Result> EmpleadosInactivosBusca()
        {
            return contexto.Empleados_Inactivos().ToList();
        }
        public static List<PROC_Departamento_Result> MostrarDepartamentosBusca()
        {
            return contexto.PROC_Departamento().ToList();
        }
        public static List<PROC_Cargos_Result> MostrarCargosBusca()
        {
            return contexto.PROC_Cargos().ToList();
        }
        public static List<Proc_SalidasMES_Result> SalidaEmpMes(string mes)
        {
            using(var basededatos = new ProyectoASPEntities())
            {
                return basededatos.Proc_SalidasMES(mes).ToList();
            }
        }
        public static List<PROC_EMPLEADOporMES_Result> EntradasEmpMes(string mes)
        {
            return contexto.PROC_EMPLEADOporMES(mes).ToList();
        }
        public static List<Proc_PermisosEMP_Result> PermisosEmpleadoBusca(string id)
        {
            return contexto.Proc_PermisosEMP(Convert.ToString(id)).ToList();
        }
        public static List<BuscaNomina_Result> BuscarNomina(string año, string mes)
        {
            return contexto.BuscaNomina(año, mes).ToList();
        }
    }
}
