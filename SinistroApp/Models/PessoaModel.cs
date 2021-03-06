﻿using System;
using System.ComponentModel;

namespace SinistroApp.Models
{
    public class PessoaModel
    {
        [DisplayName("Código Pessoa")]
        public int cdpes { get; set; }
        [DisplayName("Tipo Pessoa")]
        public int tppes { get; set; }
        [DisplayName("CPF/CGC")]
        public string nrcgccpf { get; set; }
        [DisplayName("Nome")]
        public string nmpes { get; set; }
        public DateTime dtcad { get; set; }
        [DisplayName("Data Nascimento")]
        public DateTime dtnas { get; set; }
        [DisplayName("Sexo")]
        public int tpsex { get; set; }

    }
}