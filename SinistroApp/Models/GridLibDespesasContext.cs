using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridLibDespesasContext
    {
        public List<GridLibDespesasModel> listLibDespesas = new List<GridLibDespesasModel>();

        public GridLibDespesasContext()
        {
            listLibDespesas.Add(new GridLibDespesasModel
            {
                nrProtocoloDesp = 1,
                nrIndenizacaoDesp = 1,
                coberturaDesp = "Cobertura 1",
                beneficiarioDesp = "Beneficiário 1",
                valTotalDesp = Convert.ToDecimal("111,11"),
                qtdParcelasDesp = 11,
                dtVencimentoDesp = Convert.ToDateTime("01/01/0001"),
                meioPgDesp = "Débito"
            });
            listLibDespesas.Add(new GridLibDespesasModel
            {
                nrProtocoloDesp = 2,
                nrIndenizacaoDesp = 2,
                coberturaDesp = "Cobertura 2",
                beneficiarioDesp = "Beneficiário 2",
                valTotalDesp = Convert.ToDecimal("222,22"),
                qtdParcelasDesp = 12,
                dtVencimentoDesp = Convert.ToDateTime("02/02/0002"),
                meioPgDesp = "Crédito"
            });
            listLibDespesas.Add(new GridLibDespesasModel
            {
                nrProtocoloDesp = 3,
                nrIndenizacaoDesp = 3,
                coberturaDesp = "Cobertura 3",
                beneficiarioDesp = "Beneficiário 3",
                valTotalDesp = Convert.ToDecimal("333,33"),
                qtdParcelasDesp = 13,
                dtVencimentoDesp = Convert.ToDateTime("03/03/0003"),
                meioPgDesp = "Boleto"
            });
        }
    }
}