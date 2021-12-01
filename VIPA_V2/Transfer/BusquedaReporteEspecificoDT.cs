using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class BusquedaReporteEspecificoDT
    {
        public string idreporte { get; set; }
        public string idplacavehiculo { get; set; }
        public string nombredistrito { get; set; }
        public string urlvideo { get; set; }
        public string idurlgps { get; set; }
        public TipoReporteResponse tiporeporte { get; set; }
        public DateTime fechareporte { get; set; }
    }
}