using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class CmbOperacaoContext
    {
        public List<CmbOperacaoModel> listaOperacoes = new List<CmbOperacaoModel>();

        public CmbOperacaoContext()
        {
            listaOperacoes.Add(new CmbOperacaoModel
            {
                codOperacao = 1,
                nmOperacao = "Operação 1"
            });
            listaOperacoes.Add(new CmbOperacaoModel
            {
                codOperacao = 2,
                nmOperacao = "Operação 2"
            });
            listaOperacoes.Add(new CmbOperacaoModel
            {
                codOperacao = 3,
                nmOperacao = "Operação 3"
            });
        }
    }
}