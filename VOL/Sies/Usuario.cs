//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sinaf.VOL.Sies
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public string cdusuari { get; set; }
        public string nmusuari { get; set; }
        public System.DateTime dtcadast { get; set; }
        public System.DateTime dtdesati { get; set; }
        public short cdnivalc { get; set; }
        public short stusuari { get; set; }
        public string cdsnhsis { get; set; }
        public string cdsnhsis01 { get; set; }
        public string cdsnhsis02 { get; set; }
        public string cdsnhsis03 { get; set; }
        public string cdsnhsis04 { get; set; }
        public string cdsnhsis05 { get; set; }
        public string cdsnhsis06 { get; set; }
        public string cdsnhsis07 { get; set; }
        public string cdsnhsis08 { get; set; }
        public string cdsnhsis09 { get; set; }
        public string cdsnhsis10 { get; set; }
        public string cdsnhsis11 { get; set; }
        public Nullable<System.DateTime> dtatu { get; set; }
        public Nullable<int> cdorgprt { get; set; }
        public Nullable<short> tporgprt { get; set; }
        public string nrmatricula { get; set; }
    
        public virtual OrgaoProdutor OrgaoProdutor { get; set; }
    }
}
