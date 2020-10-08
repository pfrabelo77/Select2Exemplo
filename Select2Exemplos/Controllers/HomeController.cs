using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Select2Exemplos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> listaCarros = new List<SelectListItem>() {
                 new SelectListItem { Value = "1", Text = "Brasilia" },
                 new SelectListItem { Value = "2", Text = "Gol" },
                 new SelectListItem { Value = "3", Text = "Fiat 147" },
                 new SelectListItem { Value = "4", Text = "Passat" },
                 new SelectListItem { Value = "5", Text = "Parati" },
                 new SelectListItem { Value = "6", Text = "Monza" },
                 new SelectListItem { Value = "7", Text = "Voyage" },
                 new SelectListItem { Value = "8", Text = "Opala" },
                 new SelectListItem { Value = "9", Text = "Caravan" },
                 new SelectListItem { Value = "10", Text = "Fusca" },
                 new SelectListItem { Value = "11", Text = "Fiorino" },
                 new SelectListItem { Value = "12", Text = "Pampa" },
                 new SelectListItem { Value = "13", Text = "Chevete" },
                 new SelectListItem { Value = "14", Text = "Belina" },
                 new SelectListItem { Value = "15", Text = "Del Rey" },
                 new SelectListItem { Value = "16", Text = "Lada" },
                 new SelectListItem { Value = "17", Text = "Niva" },
                 new SelectListItem { Value = "18", Text = "Landau" },
                 new SelectListItem { Value = "19", Text = "Palio" },
                 new SelectListItem { Value = "20", Text = "Tempra" },
            };

            ViewBag.listaCarros = new SelectList(listaCarros, "Value", "Text");


            return View();
        }


        [HttpPost]
        public ActionResult Index(string id, List<string> id2)
        {
            if (!String.IsNullOrEmpty(id))
            {
                ViewBag.ResultadoId = id;
            }
            else {
                ViewBag.ResultadoId = "Nada escolhido";
            }

            if (id2 != null)
            {
                var str = String.Join(",", id2);
                ViewBag.ResultadoId2 = str;
            }
            else
            {
                ViewBag.ResultadoId2 = "Nada escolhido";
            }

            return View("Resultado");
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