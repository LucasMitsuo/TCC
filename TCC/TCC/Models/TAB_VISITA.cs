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
    
    public partial class TAB_VISITA
    {
        public TAB_VISITA()
        {
            this.TAB_VISITA_PROC = new HashSet<TAB_VISITA_PROC>();
        }
    
        public int cod_visita { get; set; }
        public int cod_paciente { get; set; }
        public System.DateTime dat_visita { get; set; }
        public string des_status { get; set; }
        public int cod_profissional { get; set; }
        public string des_periodicidade { get; set; }
        public string des_obs { get; set; }
    
        public virtual TAB_PACIENTE TAB_PACIENTE { get; set; }
        public virtual TAB_PROFISSIONAL TAB_PROFISSIONAL { get; set; }
        public virtual ICollection<TAB_VISITA_PROC> TAB_VISITA_PROC { get; set; }
    }
}