using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class PermissaoModel
    {
        public string Cdusuari { get; set; }
        public string Cdnivalc { get; set; }
        public string Cdmodsis { get; set; }
        public string Cdprosis { get; set; }
        public string Inaprova { get; set; }
        public string Inatuali { get; set; }
        public string Inexclui { get; set; }
        public string Inefetiv { get; set; }
        public string Inconsul { get; set; }
        public string Innaoaut { get; set; }
        public string Tipoacesso { get; set; }
    }
}