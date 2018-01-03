using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinaf.VOL.DTOs
{
    public class PreAviso
    {
        public int Empresa { get; set; }

        public int Sucursal { get; set; }

        public string Nome_do_Sinistrado{get;set;}

        public DateTime Data_de_nascimento_do_sinistrado { get; set; }

        public string Nome_do_titular_do_seguro { get; set; }

        public int Certificado_do_titular { get; set; }

        public int Grau_de_parentesco_do_titular { get; set; }

        public int Contrato_do_sinistrado { get; set; }

        public int Certificado_do_sinistrado { get; set; }

        public int Proposta_do_sinistrado { get; set; }

        public string Cod_Autorizacao { get; set; }

        public DateTime Data_evento { get; set; }

        public DateTime Data_comunicacao_sinistro { get; set; }

        //Lista de Causas Mortes
       public Object[] Lista_de_Causa_Mortis { get; set; }
        
        public int? Situacao_de_realizacao_do_servico { get; set; }

        public string Motivo_do_nao_atendimento { get; set; }

        //public List<Contato> Lista_de_contato { get; set; }
        public Object[] Lista_de_contato { get; set; }



    }

    public class Contato
    {

        public string Telefone_do_contato { get; set; }

        public string Nome_do_contato { get; set; }

        public int Grau_de_parentesco_do_contato { get; set; }


        public override string ToString()
        {
            return  string.Format("{0} / {1} / {2}", Nome_do_contato, Telefone_do_contato, Grau_de_parentesco_do_contato.ToString());
        }


    }

    //public struct PreAvisoCampoKeys
    //{
    //    public const int Cod_Nome = 1;
    //}
}