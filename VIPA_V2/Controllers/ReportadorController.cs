using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIPA_V2.Models;
using VIPA_V2.Transfer;

namespace VIPA_V2.Controllers
{
    public class ReportadorController : ApiController
    {
        [HttpGet]
        [Route("api/Cliente/ListarReportador")] //DR 10/07/2021: Ok
        public IEnumerable<ReportadorDT2> ListarReportador()
        {
            return reportador.ListarReportador();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Reportador/Login")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public bool Login([FromBody] loginreportadorform request) 
        {
            //Function to save data in the DB
            var cor = request.correoreportador;
            var con = request.contraseñareportador;
            return reportador.LoginReportador(cor, con);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Reportador/RegistroReportador")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public bool RegistroReportador([FromBody] reportador request)
        {
            //Function to save data in the DB
            return reportador.IngresarReportador(request);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Reportador/CuentaVerificada")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public bool CuentaVerificada([FromBody] cuentaverificada request)
        {
            //Function to save data in the DB
            return reportador.CuentaVerificada(request);
        }
    }
}
