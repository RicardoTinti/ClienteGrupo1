using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Grupo1Cliente.Models;

namespace Grupo1Cliente.Controllers
{

    [HandleError]
    public class CorredoresController : Controller
    {

        public ActionResult Index()
        {
            ViewData["Message"] = "Corredores";

            List<CorredoresModel> corredores = Corredores.RecuperaCorredores();
            return View(corredores);
        }

        public ActionResult Details(int id)
        {
            CorredoresModel corredor = Corredores.RecuperaCorredor(id);

            return View(corredor);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CorredoresModel corredor)
        {
            Corredores.CadastraCorredor(corredor);

            List<CorredoresModel> corredores = Corredores.RecuperaCorredores();

            return View("Index", corredores);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CorredoresModel c = RetornaCorredor(id);

            return View(c);
        }

        private CorredoresModel RetornaCorredor(int id)
        {
            foreach (CorredoresModel c in Corredores.RecuperaCorredores())
            {
                if (c.id == Convert.ToString(id))
                    return c;
            }

            return null;
        }

        [HttpPost]
        public ActionResult Edit(CorredoresModel corredor)
        {

            Corredores.AtualizaCorredor(corredor);

            List<CorredoresModel> corredores = Corredores.RecuperaCorredores();

            return View("Index", corredores);
        }

        public ActionResult Delete(int id)
        {

            Corredores.ExcluiCorredor(id);

            List<CorredoresModel> corredores = Corredores.RecuperaCorredores();

            return View("Index", corredores);
        }

    }
}
