using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class reportador
    {
        public static bool LoginReportador(string correoreportador, string contraseñareportador)
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();

            var e = (from p in db.reportadors
                     where p.correoreportador == correoreportador && p.contraseñareportador == contraseñareportador
                     select p).Any();
            if (e)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IEnumerable<ReportadorDT2> ListarReportador()
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();
            var list = from b in db.reportadors.ToList()
                       select new ReportadorDT2()
                       {
                           idreportador = b.idreportador,
                           aliasusuario = b.aliasusuario,
                           perfilvisible = b.perfilvisible,
                           nombrereportador = b.nombrereportador,
                           apellidosreportador = b.apellidosreportador,
                           correoreportador = b.correoreportador,
                           contraseñareportador = b.contraseñareportador,
                           idestadoperfil = b.idestadoperfil,
                           verificacionperfil = b.verificacionperfil
                       };
            return list;
        }

        public static bool IngresarReportador(reportador rep)
        {
            try
            {
                using (var context = new vipa_databaseEntities2())
                {
                    context.reportadors.Add(rep);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool CuentaVerificada(cuentaverificada cue)
        {
            try
            {
                using (var context = new vipa_databaseEntities2())
                {
                    context.cuentaverificadas.Add(cue);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static ReportadorDT ObtenerReportador(string id)
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();
            var obj = db.reportadors.Select(b =>
            new ReportadorDT()
            {
                idreportador = b.idreportador,
                aliasusuario = b.aliasusuario,
                perfilvisible = b.perfilvisible,
                nombrereportador = b.nombrereportador,
                apellidosreportador = b.apellidosreportador,
                correoreportador = b.correoreportador,
            }).SingleOrDefault(b => b.idreportador == id);
            return obj;
        }

        public static ReportadorDT ActualizarPerfil(string id, ReportadorDT r)
        {
            vipa_databaseEntities2 db = new vipa_databaseEntities2();
            reportador obj = db.reportadors.SingleOrDefault(m => m.idreportador == id);

            obj.aliasusuario = r.aliasusuario;
            obj.perfilvisible = r.perfilvisible;
            obj.nombrereportador = r.nombrereportador;
            obj.apellidosreportador = r.apellidosreportador;
            obj.correoreportador = r.correoreportador;

            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return ObtenerReportador(id);
        }
    }
}