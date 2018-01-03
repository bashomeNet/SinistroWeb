using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridLibIndenizModel
    {
        public int nrProtocoloInd       { get; set; }
        public int nrIndenizacaoInd     { get; set; }
        public string coberturaInd      { get; set; }
        public string beneficiarioInd   { get; set; }
        public decimal valTotalInd      { get; set; }
        public int qtdParcelasInd       { get; set; }
        public DateTime dtVencimentoInd { get; set; }
        public string meioPgInd         { get; set; }
    }
}