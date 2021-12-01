using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;

namespace VIPA_V2.Models
{
    public partial class BusquedaReporte
    {
        //placa y vehiculo listado
        public static IEnumerable<BusquedaReporteEspecificoDT> ListarBusquedaReporte()
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();
            var list = from b in db.reportes.ToList()
                       select new BusquedaReporteEspecificoDT()
                       {
                           nombredistrito = b.nombredistrito,
                           idplacavehiculo = b.idplacavehiculo
                       };
            return list;
        }

        //listado de reportes
        public static IEnumerable<ListadoReportesDT> ListadoDeReportes()
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();
            var list = from b in db.reportes.ToList()
                       select new ListadoReportesDT()
                       {
                           urlvideo = b.idurlvideo,
                           idreporte=b.idreporte,
                           nombredistrito = b.nombredistrito,
                           tiporeporte = new TipoReporteResponse()
                           {
                               reportenombre = b.tiporeporte.reportenombre
                           },
                           fechareporte = (DateTime)b.fechacreacion
                       };

            return list;
        }
        //busqueda de reporte de acuerdo al nombre de distrito
        public static BusquedaDistritoDT listarbusquedad(string nombredistrito)
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();

            var obj = db.reportes.Select(b => new BusquedaDistritoDT()
            {
                urlvideo = b.idurlvideo,
                nombredistrito = b.nombredistrito,

                tiporeporte = new TipoReporteResponse()
                {
                    reportenombre = b.tiporeporte.reportenombre
                },
                fechareporte = (DateTime)b.fechacreacion
            }).SingleOrDefault(b => b.nombredistrito == nombredistrito);
            if (obj == null) obj = new BusquedaDistritoDT { nombredistrito = "no se encuentra" };
            return obj;
        }
        //busqueda de reporte de acuerdo a la placa
        public static IEnumerable<BusquedaReporteEspecificoDT> listarbusquedap(string idplacavehiculo)
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();

            var list = from b in db.reportes.Where(t => t.idplacavehiculo == idplacavehiculo)
                       select new BusquedaReporteEspecificoDT()
                       {
                           idreporte = b.idreporte,
                           urlvideo = b.idurlvideo,
                           nombredistrito = b.nombredistrito,
                           idplacavehiculo = b.idplacavehiculo,
                           idurlgps = b.idurlgps,
                           tiporeporte = new TipoReporteResponse()
                           {
                               reportenombre = b.tiporeporte.reportenombre
                           },
                           fechareporte = (DateTime)b.fechacreacion,
                       };

                if (list == null) {
                BusquedaReporteEspecificoDT obj = new BusquedaReporteEspecificoDT();
                obj.idplacavehiculo = "No se encontró la placa";    
            }

            return list;
        }
    }
}
