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
    
    public partial class notificacion
    {
        public int idnotificacion { get; set; }
        public string nombrenotificacion { get; set; }
        public string descripcionnotificacion { get; set; }
        public string urlincidente { get; set; }
        public string repeticionnotificacion { get; set; }
        public Nullable<System.DateTime> fechadespliegue { get; set; }
    }
}
