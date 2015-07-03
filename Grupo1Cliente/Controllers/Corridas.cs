using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json;


namespace Grupo1Cliente.Controllers
{
    public class Corridas
    {
        public static List<CorridaModel> RecuperaCorridas()
        {
            List<CorridaModel> corridas = new List<CorridaModel>();


            var url = "http://54.94.187.233/senairunner/rest/runs";
            var cliente = new WebClient();
            var corridasJson = cliente.DownloadString(url);

            var model = JsonConvert.DeserializeObject<List<CorridaModel>>(corridasJson);

            foreach (CorridaModel c in model)
            {
                corridas.Add(c);
            }

            return corridas;
        }

        public static DetalhesCorrida RecuperaDetalhesUmaCorrida(int idCorrida)
        {
            var url = "http://54.94.187.233/senairunner/rest/runs/" + idCorrida + "/runners";
            var cliente = new WebClient();
            var corridaECorredores = cliente.DownloadString(url);

            DetalhesCorrida detalhes = JsonConvert.DeserializeObject<DetalhesCorrida>(corridaECorredores);

            return detalhes;
        }


        public static void CadastraCorrida(CorridaModel corrida)
        {
            string json = JsonConvert.SerializeObject(corrida);
            var cliente = new WebClient();
            var url = "http://54.94.187.233/senairunner/rest/runs";

            cliente.UploadString(url, "POST", json);
        }

        internal static void AtualizaCorrida(CorridaModel corrida)
        {
            string json = JsonConvert.SerializeObject(corrida);
            var cliente = new WebClient();
            var url = "http://54.94.187.233/senairunner/rest/runs/" + corrida.id;

            cliente.UploadString(url, "PUT", json);
        }

        internal static void ExcluiCorrida(int id)
        {
            var cliente = new WebClient();
            var url = "http://54.94.187.233/senairunner/rest/runs/" + id;

            cliente.UploadString(url, "DELETE", "");
        }
    }
}