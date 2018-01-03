using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridLibIndenizContext
    {
        public List<GridLibIndenizModel> listLibIndenizacoes = new List<GridLibIndenizModel>();

        public GridLibIndenizContext()
        {
            listLibIndenizacoes.Add(new GridLibIndenizModel
            {
                nrProtocoloInd = 1,
                nrIndenizacaoInd = 1,
                coberturaInd = "Cobertura 1",
                beneficiarioInd = "Beneficiário 1",
                valTotalInd = Convert.ToDecimal("111,11"),
                qtdParcelasInd = 11,
                dtVencimentoInd = Convert.ToDateTime("01/01/0001"),
                meioPgInd = "Débito"
            });
            listLibIndenizacoes.Add(new GridLibIndenizModel
            {
                nrProtocoloInd = 2,
                nrIndenizacaoInd = 2,
                coberturaInd = "Cobertura 2",
                beneficiarioInd = "Beneficiário 2",
                valTotalInd = Convert.ToDecimal("222,22"),
                qtdParcelasInd = 12,
                dtVencimentoInd = Convert.ToDateTime("02/02/0002"),
                meioPgInd = "Crédito"
            });
            listLibIndenizacoes.Add(new GridLibIndenizModel
            {
                nrProtocoloInd = 3,
                nrIndenizacaoInd = 3,
                coberturaInd = "Cobertura 3",
                beneficiarioInd = "Beneficiário 3",
                valTotalInd = Convert.ToDecimal("333,33"),
                qtdParcelasInd = 13,
                dtVencimentoInd = Convert.ToDateTime("03/03/0003"),
                meioPgInd = "Boleto"
            });
        }
    }
}