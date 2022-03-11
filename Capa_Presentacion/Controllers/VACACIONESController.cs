using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class VACACIONESController : Controller
    {
        // GET: VACACIONES
        public ActionResult Index()
        {
            return View();
        }

        // GET: VACACIONES/Details/5
        public ActionResult Details()
        {
            return View(VACACIONES_N.MostrarVacaciones());
        }

        // GET: VACACIONES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VACACIONES/Create
        [HttpPost]
        public ActionResult Create(Vacaciones vaca)
        {
            VACACIONES_N.InsertarVacaciones(vaca);
            return RedirectToAction("Details");
        }

        // GET: VACACIONES/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: VACACIONES/Edit/5
        [HttpPost]
        public ActionResult Edit(Vacaciones vaca)
        {
            VACACIONES_N.EditarVacaciones(vaca);
            return RedirectToAction("Details");
        }

        // GET: VACACIONES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var vaca = VACACIONES_N.DetalleVacaciones(id.Value);
                return View(vaca);
            }
        }

        // POST: VACACIONES/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            VACACIONES_N.EliminarVacaciones(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleVAC(int id)
        {
            var detallevac = VACACIONES_N.DetalleVacaciones(id);
            return View(detallevac);
        }
    }
}
