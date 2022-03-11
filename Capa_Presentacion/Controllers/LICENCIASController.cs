using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class LICENCIASController : Controller
    {
        // GET: LICENCIAS
        public ActionResult Index()
        {
            return View();
        }

        // GET: LICENCIAS/Details/5
        public ActionResult Details()
        {
            return View(LICENCIAS_N.MostrarLicencias());
        }

        // GET: LICENCIAS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LICENCIAS/Create
        [HttpPost]
        public ActionResult Create(Licencias lice)
        {
            LICENCIAS_N.RegistrarLicencia(lice);
            return RedirectToAction("Details");
        }

        // GET: LICENCIAS/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: LICENCIAS/Edit/5
        [HttpPost]
        public ActionResult Edit(Licencias lice)
        {
            LICENCIAS_N.EditarLicencia(lice);
            return RedirectToAction("Details");
        }

        // GET: LICENCIAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var lice = LICENCIAS_N.DetalleLicencia(id.Value);
                return View(lice);
            }
        }

        // POST: LICENCIAS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            LICENCIAS_N.ElimminarLicencia(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleLicencias(int id)
        {
            var detallelicencia = LICENCIAS_N.DetalleLicencia(id);
            return View(detallelicencia);
        }
    }
}
