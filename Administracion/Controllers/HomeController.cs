﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cliente()
        {
            return View();
        }

        public ActionResult ModoDePago()
        {
            return View();
        }
        public ActionResult Proveedor()
        {
            return View();
        }
        public ActionResult Factura()
        {
            return View();
        }
        public ActionResult Producto()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}