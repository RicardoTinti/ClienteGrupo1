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


        public static CorredoresModel RecuperaCorredor(int id)
        {
            var url = "http://54.94.187.233/senairunner/rest//runners/" + id;
            var cliente = new WebClient();
            var corredoresJson = cliente.DownloadString(url);

            CorredoresModel model = JsonConvert.DeserializeObject<CorredoresModel>(corredoresJson);

            return model;
        }

        public static void CadastraCorredor(CorredoresModel corredor)
        {
            string json = JsonConvert.SerializeObject(corredor);
            var cliente = new WebClient();
            var url = "http://54.94.187.233/senairunner/rest//runners";

            cliente.UploadString(url, "POST", json);
        }

        public static void AtualizaCorredor(CorredoresModel corredor)
        {
            string json = JsonConvert.SerializeObject(corredor);
            var cliente = new WebClient();
            var url = "http://54.94.187.233/senairunner/rest/runners/" + corredor.id;

            cliente.UploadString(url, "PUT", json);
        }

        internal static void ExcluiCorredor(int id)
        {
            var cliente = new WebClient();
            var url = "http://54.94.187.233/senairunner/rest/runners/" + id;

            cliente.UploadString(url, "DELETE", "");
        }
    }
}