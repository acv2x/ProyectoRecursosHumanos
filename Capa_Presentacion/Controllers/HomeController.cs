﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mantenimiento()
        {
            return View();
        }
        public ActionResult Procesos()
        {
            return View();
        }
        public ActionResult Informes()
        {
            return View();
        }
    }
}