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
        OfertaModel oferta = OfertaModel.ExampleOffer();
        KlientModel klient = new KlientModel();

        public IActionResult Index()
        {
         
            return View(oferta);
        }

        public IActionResult AboutProduct(int Id)
        {

            return View(oferta.ProduktyWOfercie[Id]);
        }

        public IActionResult CurrentOrder()
        {
            return View(klient);
        }

        public IActionResult FinalizeOrder()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }

        public IActionResult SetEmail()
        {
            klient.Email = "AAAAAAAAAAAAAAA@ex.com";
            return CurrentOrder();
        }
    }
}