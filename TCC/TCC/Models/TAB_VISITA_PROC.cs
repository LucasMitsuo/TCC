//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAB_VISITA_PROC
    {
        public int cod_vis_proc { get; set; }
        public int cod_visita { get; set; }
        public int cod_procedimento { get; set; }
    
        public virtual TAB_PROCEDIMENTO TAB_PROCEDIMENTO { get; set; }
        public virtual TAB_VISITA TAB_VISITA { get; set; }
    }
}