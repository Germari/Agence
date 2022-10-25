﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agence_Practical_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Con_desempenho()
        {
            ViewBag.Message = "Desempenho";

            return View();
        }
        public ActionResult Con_desempenho_aba_cliente()
        {
            ViewBag.Message = "Desempenho Aba Cliente";

            return View();
        }
    }
}