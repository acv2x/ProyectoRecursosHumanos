using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class SALIDASController : Controller
    {
        // GET: SALIDAS
        public ActionResult Index()
        {
            return View();
        }

        // GET: SALIDAS/Details/5
        public ActionResult Details()
        {
            return View(SALIDAEMP_N.MostrarSalidas());
        }

        // GET: SALIDAS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SALIDAS/Create
        [HttpPost]
        public ActionResult Create(Salidas sal)
        {
            SALIDAEMP_N.InsertarSALIDAEMP(sal);
            return RedirectToAction("Details");
        }

        // GET: SALIDAS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SALIDAS/Edit/5
        [HttpPost]
        public ActionResult Edit(Salidas sal)
        {
            SALIDAEMP_N.EditarSalida(sal);
            return RedirectToAction("Details");
        }

        // GET: SALIDAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var sal = SALIDAEMP_N.DetalleSalida(id.Value);
                return View(sal);
            }
        }

        // POST: SALIDAS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            SALIDAEMP_N.EliminarSALIDA(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleSALIDA(int id)
        {
            var detalledpto = SALIDAEMP_N.DetalleSalida(id);
            return View(detalledpto);
        }
    }
}
