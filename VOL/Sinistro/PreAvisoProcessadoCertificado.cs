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
    
    public partial class PreAvisoProcessadoCertificado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreAvisoProcessadoCertificado()
        {
            this.TB_PreAvisoProcessadoCobertura = new HashSet<PreAvisoProcessadoCobertura>();
        }
    
        public int cd_preavicer { get; set; }
        public Nullable<int> cd_preavihis { get; set; }
        public Nullable<int> cd_ctt { get; set; }
        public Nullable<int> cd_emi { get; set; }
        public Nullable<int> nr_cer { get; set; }
        public Nullable<short> cd_pdt { get; set; }
        public Nullable<short> nr_seqpla { get; set; }
        public Nullable<System.DateTime> dt_inivigpla { get; set; }
    
        public virtual PreAvisoHistorico TB_PreAvisoHistorico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreAvisoProcessadoCobertura> TB_PreAvisoProcessadoCobertura { get; set; }
    }
}
