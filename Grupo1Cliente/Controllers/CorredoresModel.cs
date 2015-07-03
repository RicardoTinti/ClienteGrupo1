using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Grupo1Cliente.Controllers
{
    public class CorredoresModel
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string data_nasc { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string status { get; set; }
        public string data_cadastro { get; set; }

    }


}