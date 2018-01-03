using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridHistoricoContext
    {
        public List<GridHistoricoModel> listaHistoricos = new List<GridHistoricoModel>();

        public GridHistoricoContext()
        {
            listaHistoricos.Add(new GridHistoricoModel
            {
                idHist = 0,
                dtGeracaoHist = Convert.ToDateTime("01/01/1901"),
                valorHist = Convert.ToDecimal("111,11"),
                descHist = "Descrição 1",
                dtPgHist = Convert.ToDateTime("01/01/2001"),
                stPg = "Pendente",
                usuarioHist = "Usuário 1",
                acaoJudicialHist = " - "
            });
            listaHistoricos.Add(new GridHistoricoModel
            {
                idHist = 0,
                dtGeracaoHist = Convert.ToDateTime("02/02/1902"),
                valorHist = Convert.ToDecimal("222,22"),
                descHist = "Descrição 2",
                dtPgHist = Convert.ToDateTime("02/02/2002"),
                stPg = "À pagar",
                usuarioHist = "Usuário 2",
                acaoJudicialHist = " - "
            });
            listaHistoricos.Add(new GridHistoricoModel
            {
                idHist = 0,
                dtGeracaoHist = Convert.ToDateTime("03/03/1903"),
                valorHist = Convert.ToDecimal("333,33"),
                descHist = "Descrição 3",
                dtPgHist = Convert.ToDateTime("03/03/2003"),
                stPg = "Pago",
                usuarioHist = "Usuário 3",
                acaoJudicialHist = " - "
            });
        }
    }
}