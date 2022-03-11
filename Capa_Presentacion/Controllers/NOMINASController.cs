using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;
using Capa_Entidad;

namespace Capa_Presentacion.Controllers
{
    public class NOMINASController : Controller
    {
        // GET: NOMINAS
        public ActionResult Index()
        {
            return View();
        }

        // GET: NOMINAS/Details/5
        public ActionResult Details()
        {
            return View(NOMINAS_N.MostrarNomina());
        }

        // GET: NOMINAS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NOMINAS/Create
        [HttpPost]
        public ActionResult Create(Nominas nom)
        {
            NOMINAS_N.CrearNomina(nom);
            return RedirectToAction("Details");
        }

        // GET: NOMINAS/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: NOMINAS/Edit/5
        [HttpPost]
        public ActionResult Edit(Nominas nom)
        {
            NOMINAS_N.EditarNom(nom);
            return RedirectToAction("Details");
        }

        // GET: NOMINAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                var nomina = NOMINAS_N.DetalleNom(id.Value);
                return View(nomina);
            }
        }

        // POST: NOMINAS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            NOMINAS_N.EliminarNom(id);
            return RedirectToAction("Details");
        }
        public ActionResult DetalleNomina(int id)
        {
            var nomina = NOMINAS_N.DetalleNom(id);
            return View(nomina);
        }
    }
}
