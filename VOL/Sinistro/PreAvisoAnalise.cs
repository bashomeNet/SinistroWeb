//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sinaf.VOL.Sinistro
{
    using System;
    using System.Collections.Generic;
    
    public partial class PreAvisoAnalise
    {
        public int cd_ana { get; set; }
        public Nullable<int> cd_preavihis { get; set; }
        public Nullable<int> cd_cam { get; set; }
        public string ds_val { get; set; }
        public Nullable<short> st_dve { get; set; }
    
        public virtual PreAvisoHistorico TB_PreAvisoHistorico { get; set; }
        public virtual PreAvisoCampo TB_PreAvisoCampo { get; set; }
    }
}
