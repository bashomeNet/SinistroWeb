using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridDespesasContext
    {
        public List<GridDespesasModel> listaDespesas = new List<GridDespesasModel>();

        public GridDespesasContext()
        {
            listaDespesas.Add(new GridDespesasModel
            {
                idDesp = 0,
                bancoDesp = "Banco 1",
                agenciaDesp = "Agência 1",
                contaDesp = "11111-1",
                dtVencimentoDesp = Convert.ToDateTime("01/01/0001"),
                codIndenizacaoDesp = 1,
                situacaoDesp = "Situação 1",
                coberturaDesp = "Cobertura 1",
                beneficiarioDesp = "Beneficiário 1",
                valTotalDesp = Convert.ToDecimal("111,11")
            });
            listaDespesas.Add(new GridDespesasModel
            {
                idDesp = 1,
                bancoDesp = "Banco 2",
                agenciaDesp = "Agência 2",
                contaDesp = "22222-2",
                dtVencimentoDesp = Convert.ToDateTime("02/02/0002"),
                codIndenizacaoDesp = 2,
                situacaoDesp = "Situação 2",
                coberturaDesp = "Cobertura 2",
                beneficiarioDesp = "Beneficiário 2",
                valTotalDesp = Convert.ToDecimal("222,22")
            });
            listaDespesas.Add(new GridDespesasModel
            {
                idDesp = 2,
                bancoDesp = "Banco 3",
                agenciaDesp = "Agência 3",
                contaDesp = "33333-3",
                dtVencimentoDesp = Convert.ToDateTime("03/03/0003"),
                codIndenizacaoDesp = 3,
                situacaoDesp = "Situação 3",
                coberturaDesp = "Cobertura 3",
                beneficiarioDesp = "Beneficiário 3",
                valTotalDesp = Convert.ToDecimal("333,33")
            });
        }
    }
}