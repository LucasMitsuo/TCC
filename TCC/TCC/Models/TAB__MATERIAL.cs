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
    
    public partial class TAB__MATERIAL
    {
        public TAB__MATERIAL()
        {
            this.TAB_FORM_MAT = new HashSet<TAB_FORM_MAT>();
        }
    
        public int cod_material { get; set; }
        public string nom_material { get; set; }
        public string des_material { get; set; }
    
        public virtual ICollection<TAB_FORM_MAT> TAB_FORM_MAT { get; set; }
    }
}
