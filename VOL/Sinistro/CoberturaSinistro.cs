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
    
    public partial class CoberturaSinistro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoberturaSinistro()
        {
            this.IndenizacaoSinistro = new HashSet<IndenizacaoSinistro>();
        }
    
        public int cdaviso { get; set; }
        public short cdcobsin { get; set; }
        public short cdramosg { get; set; }
        public short cdsubram { get; set; }
        public Nullable<short> cdprodut { get; set; }
        public Nullable<short> cdcob { get; set; }
        public Nullable<int> cditeseg { get; set; }
        public int cdconseg { get; set; }
        public string nmdesc { get; set; }
        public System.DateTime dtcad { get; set; }
        public System.DateTime dtatu { get; set; }
        public System.DateTime dtlib { get; set; }
        public System.DateTime dtencerr { get; set; }
        public decimal vltotindeniz { get; set; }
        public decimal vlpago { get; set; }
        public short qtcarencia { get; set; }
        public short qtdest { get; set; }
        public short qtdprorrog { get; set; }
        public short stsituacao { get; set; }
        public short indmaj { get; set; }
        public Nullable<short> cdverbas { get; set; }
        public decimal vlis { get; set; }
        public decimal pcaplicada { get; set; }
        public Nullable<int> cddoenca { get; set; }
        public Nullable<short> cdgrupo { get; set; }
        public decimal pcporcentagem { get; set; }
        public Nullable<decimal> vldiaria { get; set; }
        public Nullable<System.DateTime> dtinibenef { get; set; }
        public Nullable<decimal> vlpctfraobr { get; set; }
        public Nullable<short> qtfranquia { get; set; }
        public Nullable<short> qtmaxdiaria { get; set; }
    
        public virtual AvisoSinistro AvisoSinistro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndenizacaoSinistro> IndenizacaoSinistro { get; set; }
    }
}
