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
    
    public partial class TAB_FORM
    {
        public TAB_FORM()
        {
            this.TAB_DIAGNOSTICO = new HashSet<TAB_DIAGNOSTICO>();
            this.TAB_FORM_MAT = new HashSet<TAB_FORM_MAT>();
            this.TAB_FORM_PROC_ENF = new HashSet<TAB_FORM_PROC_ENF>();
        }
    
        public int cod_form { get; set; }
        public int cod_paciente { get; set; }
    
        public virtual ICollection<TAB_DIAGNOSTICO> TAB_DIAGNOSTICO { get; set; }
        public virtual ICollection<TAB_FORM_MAT> TAB_FORM_MAT { get; set; }
        public virtual ICollection<TAB_FORM_PROC_ENF> TAB_FORM_PROC_ENF { get; set; }
        public virtual TAB_PACIENTE TAB_PACIENTE { get; set; }
    }
}
