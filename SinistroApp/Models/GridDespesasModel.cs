using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridDespesasModel
    {
        public int idDesp                   { get; set; }
        public string bancoDesp             { get; set; }
        public string agenciaDesp           { get; set; }
        public string contaDesp             { get; set; }
        public DateTime dtVencimentoDesp    { get; set; }
        public int codIndenizacaoDesp       { get; set; }
        public string situacaoDesp          { get; set; }
        public string coberturaDesp         { get; set; }
        public string beneficiarioDesp      { get; set; }
        public decimal valTotalDesp         { get; set; }
    }
}