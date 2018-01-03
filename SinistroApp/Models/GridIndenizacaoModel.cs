using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridIndenizacaoModel
    {
        public int idInd                { get; set; }
        public string bancoInd          { get; set; }
        public string agenciaInd        { get; set; }
        public string contaInd          { get; set; }
        public string dtVencimentoInd   { get; set; }
        public int codIndenizacaoInd    { get; set; }
        public string situacaoInd       { get; set; }
        public string coberturaInd      { get; set; }
        public string beneficiarioInd   { get; set; }
        public string valTotalInd       { get; set; }
    }
}