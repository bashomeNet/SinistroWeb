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
    
    public partial class PreAvisoHistoricoJson
    {
        public int cd_cmn { get; set; }
        public Nullable<int> cd_preavihis { get; set; }
        public string ds_Json { get; set; }
    
        public virtual PreAvisoHistorico TB_PreAvisoHistorico { get; set; }
    }
}
