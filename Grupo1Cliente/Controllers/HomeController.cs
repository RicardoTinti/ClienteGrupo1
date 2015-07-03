using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo1Cliente.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Corridas";

            //List<PrevisaoTempoModel> previsaoDoTempo = PrevisaoDoTempo.RecuperaPrevisaoDoTempo("Florianópolis");
            //return View(previsaoDoTempo);

            List<CorridaModel> corridas = Corridas.RecuperaCorridas();
            return View(corridas);
        }

        public ActionResult Details(int id)
        {
            DetalhesCorrida detalhes = Corridas.RecuperaDetalhesUmaCorrida(id);
            
            return View(detalhes);
        }

        private CorridaModel RetornaCorrida(int idCorrida)
        {
            foreach (CorridaModel c in Corridas.RecuperaCorridas())
            {
                if (c.id == Convert.ToString(idCorrida))
                    return c;
            }

            return null;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CorridaModel corrida)
        {
            Corridas.CadastraCorrida(corrida);

            List<CorridaModel> corridas = Corridas.RecuperaCorridas();

            return View("Index", corridas);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CorridaModel c = RetornaCorrida(id);

            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(CorridaModel corrida)
        {

            Corridas.AtualizaCorrida(corrida);

            List<CorridaModel> corridas = Corridas.RecuperaCorridas();

            return View("Index", corridas);
        }

        public ActionResult Delete(int id)
        {

            Corridas.ExcluiCorrida(id);

            List<CorridaModel> corridas = Corridas.RecuperaCorridas();

            return View("Index", corridas);
        }
    }
}
