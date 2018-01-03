using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridPreAvisoModel
    {
        //Grid Principal
        public int idPreAviso           { get; set; }
        public string nmSinistrado      { get; set; }
        public DateTime dtNascimento    { get; set; }
        public string codAutorizacao    { get; set; }
        public string motNaoAtendimento { get; set; }
        //Aba Detalhes
        public string nmTitular         { get; set; }
        public string grParentTitular   { get; set; }
        public int contratoTitular      { get; set; }
        public int certificadoTitular   { get; set; }
        public int propostaTitular      { get; set; }
        public DateTime dtSinistro      { get; set; }
        public string csMortis          { get; set; }
        public string svcRealizado      { get; set; }
        public string telContato        { get; set; }
        public string nmContato         { get; set; }
        public string grParentContato   { get; set; }
        //Aba Críticas
        public string stEvento          { get; set; }
        public string stCarencia        { get; set; }
        public string stAdimplencia     { get; set; }
        public string stCertificado     { get; set; }
        public string tmpSeguro         { get; set; }
        //Aba Todos os Certificados
        public int contrato             { get; set; }
        public int certificado          { get; set; }
        //Aba Coberturas
        public string cobertura         { get; set; }
        public decimal vlIs             { get; set; }
        public string ramo              { get; set; }
        public string estIndenizacao    { get; set; }
        public DateTime dtIniVigencia   { get; set; }
        public DateTime dtFimVigencia   { get; set; }
    }
}