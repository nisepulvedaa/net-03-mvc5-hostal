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
    
    public partial class ORDEN_PEDIDO
    {
        public int ID_ORDEN_PEDIDO { get; set; }
        public Nullable<int> ID_PROVEEDOR { get; set; }
        public string PRODUCTOS_CODIGOS { get; set; }
        public Nullable<int> CANTIDAD_PRODUCTO { get; set; }
        public int CODIGO_ORDEN_PEDIDO { get; set; }
    
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}