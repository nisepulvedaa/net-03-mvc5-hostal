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
    
    public partial class USUARIOS
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string APELLIDO_USUARIO { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string ESTADO_PASSWORD { get; set; }
        public Nullable<int> ID_PERFIL { get; set; }
        public int EMPRESA_ID_EMPRESA { get; set; }
        public int PERFILES_USUARIOS_ID_PERFIL { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual PERFILES_USUARIOS PERFILES_USUARIOS { get; set; }
    }
}