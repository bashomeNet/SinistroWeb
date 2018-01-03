using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridIndenizacaoContext
    {
        public List<GridIndenizacaoModel> listaIndenizacoes = new List<GridIndenizacaoModel>();

        public GridIndenizacaoContext()
        {
            listaIndenizacoes.Add(new GridIndenizacaoModel
            {
                idInd = 0,
                bancoInd = "Banco 1",
                agenciaInd = "Agência 1",
                contaInd = "11111-1",
                //dtVencimentoInd = Convert.ToDateTime("01/01/0001"),
                dtVencimentoInd = "01/01/0001",
                codIndenizacaoInd = 1,
                situacaoInd = "Situação 1",
                coberturaInd = "Cobertura 1",
                beneficiarioInd = "Beneficiário 1",
                //valTotalInd = Convert.ToDecimal("111,11")
                valTotalInd = "111,11"
            });
            listaIndenizacoes.Add(new GridIndenizacaoModel
            {
                idInd = 1,
                bancoInd = "Banco 2",
                agenciaInd = "Agência 2",
                contaInd = "22222-2",
                //dtVencimentoInd = Convert.ToDateTime("02/02/0002"),
                dtVencimentoInd = "02/02/0002",
                codIndenizacaoInd = 2,
                situacaoInd = "Situação 2",
                coberturaInd = "Cobertura 2",
                beneficiarioInd = "Beneficiário 2",
                //valTotalInd = Convert.ToDecimal("222,22")
                valTotalInd = "222,22"
            });
            listaIndenizacoes.Add(new GridIndenizacaoModel
            {
                idInd = 2,
                bancoInd = "Banco 3",
                agenciaInd = "Agência 3",
                contaInd = "33333-3",
                //dtVencimentoInd = Convert.ToDateTime("03/03/0003"),
                dtVencimentoInd = "03/03/0003",
                codIndenizacaoInd = 3,
                situacaoInd = "Situação 3",
                coberturaInd = "Cobertura 3",
                beneficiarioInd = "Beneficiário 3",
                //valTotalInd = Convert.ToDecimal("333,33")
                valTotalInd = "333,33"
            });
        }
    }
}