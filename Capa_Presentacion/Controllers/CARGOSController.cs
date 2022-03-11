using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class CARGOSController : Controller
    {
        // GET: CARGOS
        public ActionResult Index()
        {
            return View();
        }

        // GET: CARGOS/Details/5
        public ActionResult Details()
        {
            return View(CARGOS_N.MostrarCargos());
        }

        // GET: CARGOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CARGOS/Create
        [HttpPost]
        public ActionResult Create(Cargos car)
        {
            CARGOS_N.InsertarCargos(car);
            return RedirectToAction("Details");
        }

        // GET: CARGOS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CARGOS/Edit/5
        [HttpPost]
        public ActionResult Edit(Cargos car)
        {
            CARGOS_N.EditarCargo(car);
            return RedirectToAction("Details");
        }

        // GET: CARGOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var car = CARGOS_N.DetalleCargo(id.Value);
                return View(car);
            }
        }

        // POST: CARGOS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            CARGOS_N.EliminarCargo(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleCargo(int id)
        {
            var cargo = CARGOS_N.DetalleCargo(id);
            return View(cargo);
        }
    }
}
