using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class PERMISOSController : Controller
    {
        // GET: PERMISOS
        public ActionResult Index()
        {
            return View();
        }

        // GET: PERMISOS/Details/5
        public ActionResult Details()
        {
            return View(PERMISOS_N.MostrarPermisos());
        }

        // GET: PERMISOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PERMISOS/Create
        [HttpPost]
        public ActionResult Create(Permisos perm )
        {
            PERMISOS_N.InsertarPermisos(perm);
            return RedirectToAction("Details");
        }

        // GET: PERMISOS/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: PERMISOS/Edit/5
        [HttpPost]
        public ActionResult Edit(Permisos perm)
        {
            PERMISOS_N.EditarPermiso(perm);
            return RedirectToAction("Details");
        }

        // GET: PERMISOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var perm = PERMISOS_N.DetallePermiso(id.Value);
                return View(perm);
            }
        }

        // POST: PERMISOS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            PERMISOS_N.EliminarPermiso(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetallePermiso(int id)
        {
            var detalleper = PERMISOS_N.DetallePermiso(id);
            return View(detalleper);
        }
    }
}
