//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades.ConexionBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class RelacionesTablas_BD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RelacionesTablas_BD()
        {
            this.RelacionCamposTablas_BD = new HashSet<RelacionCamposTablas_BD>();
        }
    
        public int RelacionID { get; set; }
        public int TablaBaseID { get; set; }
        public int TablaRelacionada { get; set; }
        public string Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacionCamposTablas_BD> RelacionCamposTablas_BD { get; set; }
        public virtual Tablas_BD Tablas_BD { get; set; }
    }
}
