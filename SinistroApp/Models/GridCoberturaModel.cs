using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridCoberturaModel
    {
        public int idCob                { get; set; }
        public string dscCob            { get; set; }
        public string vlIsCob           { get; set; }
        public string estIndenizacaoCob { get; set; }
        public string ramoCob           { get; set; }
        public DateTime dtIniVigCob     { get; set; }
        public DateTime dtFimVigCob     { get; set; }
}
}