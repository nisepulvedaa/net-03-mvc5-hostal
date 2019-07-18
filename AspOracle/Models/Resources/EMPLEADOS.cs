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
    
    public partial class EMPLEADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADOS()
        {
            this.DETALLE_COMEDORES = new HashSet<DETALLE_COMEDORES>();
            this.DETALLE_HABITACIONES = new HashSet<DETALLE_HABITACIONES>();
        }
    
        public int ID_EMPLEADO { get; set; }
        public string NOMBRE_EMPLEADO { get; set; }
        public string APELLIDO_EMPLEADO { get; set; }
        public Nullable<int> TELEFONO_EMPLEADO { get; set; }
        public string CORREO_EMPLEADO { get; set; }
        public Nullable<int> EDAD_EMPLEADO { get; set; }
        public string DIRECCION_EMPLEADO { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public Nullable<int> PERFILES_USUARIOS_ID_PERFIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_COMEDORES> DETALLE_COMEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_HABITACIONES> DETALLE_HABITACIONES { get; set; }
        public virtual PERFILES_USUARIOS PERFILES_USUARIOS { get; set; }
    }
}