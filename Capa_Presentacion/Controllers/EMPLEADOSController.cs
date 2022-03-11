using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class EMPLEADOSController : Controller
    {
        // GET: EMPLEADOS
        public ActionResult Index()
        {
            return View();
        }

        // GET: EMPLEADOS/Details/5
        public ActionResult Details()
        {
            return View(EMPLEADOS_N.MostrarEmpleado());
        }

        // GET: EMPLEADOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPLEADOS/Create
        [HttpPost]
        public ActionResult Create(Empleados emple)
        {
            EMPLEADOS_N.InsertarEmpleado(emple);
            return RedirectToAction("Details");
        }

        // GET: EMPLEADOS/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: EMPLEADOS/Edit/5
        [HttpPost]
        public ActionResult Edit(Empleados emp)
        {
            EMPLEADOS_N.EditarEmp(emp);
            return RedirectToAction("Details");

        }

        // GET: EMPLEADOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var empleadodele = EMPLEADOS_N.DetalleEMP(id.Value);
                return View(empleadodele);
            }
        }

        // POST: EMPLEADOS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            EMPLEADOS_N.EliminarEMP(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleEMP(int id)
        {
            var emp = EMPLEADOS_N.DetalleEMP(id);
            return View(emp);

        }
    }
}
