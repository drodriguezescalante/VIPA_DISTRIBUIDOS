//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIPA_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reportador
    {
        public string idreportador { get; set; }
        public string aliasusuario { get; set; }
        public string perfilvisible { get; set; }
        public string nombrereportador { get; set; }
        public string apellidosreportador { get; set; }
        public string correoreportador { get; set; }
        public string contraseñareportador { get; set; }
        public string idestadoperfil { get; set; }
        public string verificacionperfil { get; set; }
    
        public virtual cuentaverificada cuentaverificada { get; set; }
    }
}
