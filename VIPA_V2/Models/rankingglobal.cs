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
    
    public partial class rankingglobal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rankingglobal()
        {
            this.estadoperfilrankings = new HashSet<estadoperfilranking>();
        }
    
        public int nivelraking { get; set; }
        public string nombrenivelranking { get; set; }
        public string descripcionnivelranking { get; set; }
        public Nullable<int> puntosmaximos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estadoperfilranking> estadoperfilrankings { get; set; }
    }
}
