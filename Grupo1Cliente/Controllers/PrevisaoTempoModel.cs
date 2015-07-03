using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grupo1Cliente.Controllers
{
    public class PrevisaoTempoModel
    {
        public DateTime data { get; set; }
        public string temperaturaDia { get; set; }
        public string temperaturaTarde { get; set; }
        public string temperaturaNoite { get; set; }
    }
}