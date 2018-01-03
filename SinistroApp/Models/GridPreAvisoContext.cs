using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridPreAvisoContext
    {
        public List<GridPreAvisoModel> listaPreAvisos = new List<GridPreAvisoModel>();

        public GridPreAvisoContext()
        {
            //listaPreAvisos.Add(new GridPreAvisoModel
            //{
            //    //Grid Principal
            //    idPreAviso = 0,
            //    nmSinistrado = "Lucas Rios Marques",
            //    dtNascimento = Convert.ToDateTime("01/01/0001"),
            //    codAutorizacao = "S01111111",
            //    motNaoAtendimento = "Motivo 1",
            //    //Aba Detalhes
            //    nmTitular = "Abel Carlos da Silva Braga",
            //    grParentTitular = "Pai",
            //    contratoTitular = 1467,
            //    certificadoTitular = 651177,
            //    propostaTitular = 12345,
            //    dtSinistro = Convert.ToDateTime("01/01/2001"),
            //    csMortis = "Cirrose Hepática",
            //    svcRealizado = "Sim",
            //    telContato = "(21) 91919-1919",
            //    nmContato = "Fábio Farroco Braga", 
            //    grParentContato = "Filho",
            //    //Aba Críticas
            //    stEvento = "Sim",
            //    stCarencia = "Não",
            //    stAdimplencia = "Sim",
            //    stCertificado = "Ativo",
            //    tmpSeguro = "120 meses",
            //    //Aba Todos os Certificados
            //    contrato = 1467,
            //    certificado = 651187,
            //    //Aba Coberturas
            //    cobertura = "Cobertura 1",
            //    vlIs = Convert.ToDecimal("222,22"),
            //    ramo = "Ramo 2",
            //    estIndenizacao = "Estimativa 2",
            //    dtIniVigencia = Convert.ToDateTime("01/01/2001"),
            //    dtFimVigencia = Convert.ToDateTime("02/02/2022")
            //});
            //listaPreAvisos.Add(new GridPreAvisoModel
            //{
            //    //Grid Principal
            //    idPreAviso = 1,
            //    nmSinistrado = "Renato de Araújo Chaves",
            //    dtNascimento = Convert.ToDateTime("02/02/0002"),
            //    codAutorizacao = "S02222222",
            //    motNaoAtendimento = "Motivo 2",
            //    //Aba Detalhes
            //    nmTitular = "Henrique Adriano Buss",
            //    grParentTitular = "Irmão",
            //    contratoTitular = 1470,
            //    certificadoTitular = 913567,
            //    propostaTitular = 54321,
            //    dtSinistro = Convert.ToDateTime("02/02/2002"),
            //    csMortis = "Infarto do Miocárdio",
            //    svcRealizado = "Não",
            //    telContato = "(21) 92929-2929",
            //    nmContato = "Marlon Santos da Silva Barbosa",
            //    grParentContato = "Cunhado",
            //    //Aba Críticas
            //    stEvento = "Não",
            //    stCarencia = "Sim",
            //    stAdimplencia = "Não",
            //    stCertificado = "Inativo",
            //    tmpSeguro = "40 meses",
            //    //Aba Todos os Certificados
            //    contrato = 1470,
            //    certificado = 913568,
            //    //Aba Coberturas
            //    cobertura = "Cobertura 2",
            //    vlIs = Convert.ToDecimal("222,22"),
            //    ramo = "Ramo 2",
            //    estIndenizacao = "Estimativa 2",
            //    dtIniVigencia = Convert.ToDateTime("01/01/2001"),
            //    dtFimVigencia = Convert.ToDateTime("02/02/2022")
            //});
            //listaPreAvisos.Add(new GridPreAvisoModel
            //{
            //    //Grid Principal
            //    idPreAviso = 2,
            //    nmSinistrado = "Wellington Pereira Rodrigues",
            //    dtNascimento = Convert.ToDateTime("03/03/0003"),
            //    codAutorizacao = "S03333333",
            //    motNaoAtendimento = "Motivo 3",
            //    //Aba Detalhes
            //    nmTitular = "Richard Candido Coelho",
            //    grParentTitular = "Filho",
            //    contratoTitular = 1232,
            //    certificadoTitular = 11234,
            //    propostaTitular = 12123,
            //    dtSinistro = Convert.ToDateTime("01/01/2001"),
            //    csMortis = "Insuficiência Renal",
            //    svcRealizado = "Sim",
            //    telContato = "(21) 93939-3939",
            //    nmContato = "Marcus Wendel Valle da Silva",
            //    grParentContato = "Irmão",
            //    //Aba Críticas
            //    stEvento = "Sim",
            //    stCarencia = "Não",
            //    stAdimplencia = "Sim",
            //    stCertificado = "Ativo",
            //    tmpSeguro = "60 meses",
            //    //Aba Todos os Certificados
            //    contrato = 1232,
            //    certificado = 12136,
            //    //Aba Coberturas
            //    cobertura = "Cobertura 2",
            //    vlIs = Convert.ToDecimal("222,22"),
            //    ramo = "Ramo 2",
            //    estIndenizacao = "Estimativa 2",
            //    dtIniVigencia = Convert.ToDateTime("01/01/2001"),
            //    dtFimVigencia = Convert.ToDateTime("02/02/2022")
            //});
        }
    }
}