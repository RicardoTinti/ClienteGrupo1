using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace Grupo1Cliente.Controllers
{
    public class Corredores
    {

        public static List<CorredoresModel> RecuperaCorredores()
        {
            List<CorredoresModel> corredores = new List<CorredoresModel>();


            var url = "http://54.94.187.233/senairunner/rest/runners";
            var cliente = new WebClient();
            var corredoresJson = cliente.DownloadString(url);

            var model = JsonConvert.DeserializeObject<List<CorredoresModel>>(corredoresJson);

            foreach (CorredoresModel c in model)
            {
                corredores.Add(c);
            }

            return corredores;
        }

    }
}