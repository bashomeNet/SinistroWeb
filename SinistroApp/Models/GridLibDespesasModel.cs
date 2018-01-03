using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridLibDespesasModel
    {
        public int nrProtocoloDesp          { get; set; }
        public int nrIndenizacaoDesp        { get; set; }
        public string coberturaDesp         { get; set; }
        public string beneficiarioDesp      { get; set; }
        public decimal valTotalDesp         { get; set; }
        public int qtdParcelasDesp          { get; set; }
        public DateTime dtVencimentoDesp    { get; set; }
        public string meioPgDesp            { get; set; }
    }
}