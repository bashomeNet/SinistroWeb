using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class OrgaoProdutorModel
    {
        public int CdOrgPrt     { get; set; }
        public int TpOrgPrt     { get; set; }
        public string NmOrgPrt  { get; set; }
        public int CdOrgPrtVin  { get; set; }
        public int TpOrgPrtVin  { get; set; }
        public int CdPes        { get; set; }
        public int NrSeqEnd     { get; set; }
    }
}