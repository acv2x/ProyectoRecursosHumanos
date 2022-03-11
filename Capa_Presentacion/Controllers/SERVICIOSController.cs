using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Servicio;

namespace Capa_Presentacion.Controllers
{
    public class SERVICIOSController : Controller
    {
        // GET: SERVICIOS
        public ActionResult EmpleadosActivo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResultadosEmpAc(string nombre, Nullable <int> departamentos)
        {
            return View(SERVICIOS_S.EmpleadosActivosBusca(nombre, departamentos));
        }
        //GET EMPLEADOS INACTIVOS
        public ActionResult EmpleadosInactivos()
        {
            return View(SERVICIOS_S.EmpleadosInactivosBusca());
        }
        public ActionResult DepartamentosLista()
        {
            return View(SERVICIOS_S.MostrarDepartamentosBusca());
        }
        public ActionResult CargosLista()
        {
            return View(SERVICIOS_S.MostrarCargosBusca());
        }
        public ActionResult SalidaEmpleadosMes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SalidaEmpleadosMesResultados(string mes)
        {
            return View(SERVICIOS_S.SalidaEmpMes(mes));
        }
        public ActionResult EntradaEmpleadosMes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EntradaEmpleadosMesresultado(string mes)
        {
            return View(SERVICIOS_S.EntradasEmpMes(mes));
        }
        public ActionResult PermisosEmpBusca()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PermisosEmpBuscaresultado(string id)
        {
            return View(SERVICIOS_S.PermisosEmpleadoBusca(id));
        }
        public ActionResult NominaBuscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NominaBuscarResultado(string anio, string mes)
        {
            return View(SERVICIOS_S.BuscarNomina(anio, mes));
        }

    }
}