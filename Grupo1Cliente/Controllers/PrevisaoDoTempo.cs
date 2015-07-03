using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace Grupo1Cliente.Controllers
{
    public static class PrevisaoDoTempo
    {

        public static List<PrevisaoTempoModel> RecuperaPrevisaoDoTempo(string cidade)
        {
            List<PrevisaoTempoModel> previsaoTempo = new List<PrevisaoTempoModel>();

            var url = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + cidade + ",Brazil&cnt=15";
            var cliente = new WebClient();
            var previsao = cliente.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PrevisaoDoTempoModelJson));
          using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(previsao)))
          {
             var weatherData = (PrevisaoDoTempoModelJson)serializer.ReadObject(ms);
          
                foreach(List l in weatherData.list)
                {
                    previsaoTempo.Add(new PrevisaoTempoModel(){data = new DateTime(1970,1,1,0,0,0).AddSeconds(l.dt), temperaturaDia = Convert.ToString(l.temp.morn),
                    temperaturaTarde = Convert.ToString(l.temp.eve), temperaturaNoite = Convert.ToString(l.temp.night)});
                }
          }

            return previsaoTempo;
        }

    }
}