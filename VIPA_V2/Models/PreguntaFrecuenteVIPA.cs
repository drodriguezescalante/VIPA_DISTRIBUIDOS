using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;

namespace VIPA_V2.Models
{
    public partial class preguntafrecuente
    {
        public static IEnumerable<PreguntaFrecuenteDT> ListarPreguntasFrecuentes()
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();
            var list = from b in db.preguntafrecuentes.ToList()
                       select new PreguntaFrecuenteDT()
                       {
                           numeropregunta = b.numeropregunta,
                           descripcionpregunta = b.descripcionpregunta,
                           descripcionrespuesta = b.descripcionrespuesta
                       };
            return list;
        }
    }
}