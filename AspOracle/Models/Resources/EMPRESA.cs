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
    
    public partial class EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA()
        {
            this.HUESPED = new HashSet<HUESPED>();
            this.USUARIOS = new HashSet<USUARIOS>();
        }
    
        public int ID_EMPRESA { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string RUT_EMPRESA { get; set; }
        public string DV_RUT_EMPRESA { get; set; }
        public string CORREO_EMPRESA { get; set; }
        public string DIRECCION_EMPRESA { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public string NOMBRE_REPRESENTANTE { get; set; }
        public string APELLIDO_REPRESENTANTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HUESPED> HUESPED { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}
