using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class DEPARTAMENTOSController : Controller
    {
        // GET: DEPARTAMENTOS
        public ActionResult Index()
        {
            return View();
        }

        // GET: DEPARTAMENTOS/Details/5
        public ActionResult Details()
        {
            return View(DEPARTAMENTOS_N.MostrarDepartamentos());
        }

        // GET: DEPARTAMENTOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DEPARTAMENTOS/Create
        [HttpPost]
        public ActionResult Create(Departamentos depar)
        {
            DEPARTAMENTOS_N.InsertarDepartamentos(depar);
            return RedirectToAction("Details");
        }

        // GET: DEPARTAMENTOS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DEPARTAMENTOS/Edit/5
        [HttpPost]
        public ActionResult Edit(Departamentos dpto)
        {
            DEPARTAMENTOS_N.EditarDPTO(dpto);
            return RedirectToAction("Details");
        }

        // GET: DEPARTAMENTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var dptodet = DEPARTAMENTOS_N.DetalleDPTO(id.Value);
                return View(dptodet);
            }
        }

        // POST: DEPARTAMENTOS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DEPARTAMENTOS_N.EliminarDPTO(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleDPTO(int id)
        {
            var dpto = DEPARTAMENTOS_N.DetalleDPTO(id);
            return View(dpto);
        }
    }
}
