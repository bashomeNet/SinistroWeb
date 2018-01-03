using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class ItemMenuModel
    {
        public string Id { get; set; }
        public string Texto { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string CssClass { get; set; }
    }
}