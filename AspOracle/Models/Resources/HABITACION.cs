//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspOracle.Models.Resources
{
    using System;
    using System.Collections.Generic;
    
    public partial class HABITACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HABITACION()
        {
            this.DETALLE_HABITACIONES = new HashSet<DETALLE_HABITACIONES>();
        }
    
        public int ID_HABITACION { get; set; }
        public string NOMBRE_HABITACION { get; set; }
        public string TIPO_CAMA_HABITACION { get; set; }
        public string ACCESORIOS_HABITACION { get; set; }
        public Nullable<int> VALOR_HABITACION { get; set; }
        public Nullable<int> E_ID_ESTADO_HABITACION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_HABITACIONES> DETALLE_HABITACIONES { get; set; }
        public virtual ESTADO_HABITACION ESTADO_HABITACION { get; set; }
    }
}