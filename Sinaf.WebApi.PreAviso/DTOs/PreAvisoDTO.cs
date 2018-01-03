using Sinaf.VOL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinaf.WebApi.PreAviso.DTOs
{
    public class PreAvisoDTO
    {

        [Required(ErrorMessage ="Empresa vazio")]
        [DataType(DataType.Currency,ErrorMessage ="Tipo de dado inválido")]
        public int Empresa { get; set; }

        [Required(ErrorMessage = "Empresa vazio")]
        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]
        public int Sucursal { get; set; }

        [Required(ErrorMessage = "Nome do Sinistrado vazio")]
        [DataType(DataType.Text,ErrorMessage ="Tipo de dado inválido")]
        public string Nome_do_Sinistrado { get; set; }

        [Required(ErrorMessage = "Data de nascimento do sinistrado vazio")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de Data Inválido")]
        public DateTime Data_de_nascimento_do_sinistrado { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Nome do titular do seguro vazio")]
        public string Nome_do_titular_do_seguro { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Certificado do titular vazio")]
        public int Certificado_do_titular { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Grau de parentesco do titular vazio")]
        public int Grau_de_parentesco_do_titular { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Contrato do sinistrado vazio")]
        public int Contrato_do_sinistrado { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Certificado do sinistrado vazio")]
        public int Certificado_do_sinistrado { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Proposta do sinistrado vazio")]
        public int Proposta_do_sinistrado { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Tipo de dado inválido")]
        [Required(ErrorMessage = "Cod Autorização vazio")]
        public string Cod_Autorizacao { get; set; }


        [Required(ErrorMessage = "Data evento vazio")]
        [DataType(DataType.DateTime,ErrorMessage ="Formato de Data Invalido")]
        public DateTime Data_evento { get; set; }

        [Required(ErrorMessage = "Data comunicação sinistro vazio")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de Data Invalido")]
        public DateTime Data_comunicacao_sinistro { get; set; }

        //Lista de Causas Mortes
        [Required(ErrorMessage = "Lista de Causa Mortis vazio")]
        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]

        public Object[] Lista_de_Causa_Mortis { get; set; }

        [Required(ErrorMessage = "Situação de realização do servico vazio")]
        [DataType(DataType.Currency, ErrorMessage = "Tipo de dado inválido")]

        public int? Situacao_de_realizacao_do_servico { get; set; }

        [Required(ErrorMessage = "Motivo do não atendimento vazio")]
        [DataType(DataType.Text, ErrorMessage = "Tipo de dado inválido")]

        public string Motivo_do_nao_atendimento { get; set; }

        public List<Contato> Lista_de_contato { get; set; }

    }
}