using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class UsuarioModel
    {
        public int IdUsuario            { get; set; }
        public string NmUsuario         { get; set; }
        public DateTime DtNascimento    { get; set; }
        public string Email             { get; set; }
    }
}