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
    
    public partial class DETALLE_COMEDORES
    {
        public int ID_DETALLE_COMEDOR { get; set; }
        public Nullable<int> ID_COMEDOR { get; set; }
        public Nullable<int> ID_HUESPED { get; set; }
        public Nullable<int> ID_EMPLEADO { get; set; }
        public Nullable<int> ID_MENU { get; set; }
        public Nullable<System.DateTime> FECHA_SOLICITUD { get; set; }
        public Nullable<decimal> ESTADO_USADO { get; set; }
    
        public virtual COMEDORES COMEDORES { get; set; }
        public virtual EMPLEADOS EMPLEADOS { get; set; }
        public virtual HUESPED HUESPED { get; set; }
        public virtual MENU MENU { get; set; }
    }
}