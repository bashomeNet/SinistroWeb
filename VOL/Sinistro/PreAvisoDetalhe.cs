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
    
    public partial class PreAvisoDetalhe
    {
        public int cd_preavidtl { get; set; }
        public Nullable<int> cd_preavi { get; set; }
        public Nullable<int> cd_cam { get; set; }
        public string ds_val { get; set; }
        public Nullable<short> st_cri { get; set; }
        public string ds_msg { get; set; }
    
        public virtual PreAviso TB_PreAviso { get; set; }
        public virtual PreAvisoCampo TB_PreAvisoCampo { get; set; }
    }
}
