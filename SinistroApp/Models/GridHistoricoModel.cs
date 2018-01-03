using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridHistoricoModel
    {
        public int idHist               { get; set; }
        public DateTime dtGeracaoHist   { get; set; }
        public decimal valorHist        { get; set; }
        public string descHist          { get; set; }
        public DateTime dtPgHist        { get; set; }
        public string stPg              { get; set; }
        public string usuarioHist       { get; set; }
        public string acaoJudicialHist  { get; set; }
    }
}