﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kwiaty.po.Models;

namespace Kwiaty.po.Controllers
{
    public class HomeController : Controller
    {
        OfertaModel oferta = OfertaModel.ExampleOffer();

        public IActionResult Index()
        {

            return View(oferta);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string JustText()
        {
            return "JUST TEXT HERE!";
        }
    }
}
