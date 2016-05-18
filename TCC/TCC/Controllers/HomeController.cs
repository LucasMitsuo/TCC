﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.Models;

namespace TCC.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult SalvarResposta(Pessoa pessoa)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(Pessoa pessoa)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

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
    }
}