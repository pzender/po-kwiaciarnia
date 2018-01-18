using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kwiaty.po.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kwiaty.po.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutProduct()
        {
            var Produkt = new ProduktModel(99.99, "Example", "This is an example product");
            return View(Produkt);
        }

        public IActionResult CurrentOrder()
        {
            return View();
        }

        public IActionResult FinalizeOrder()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }

    }
}