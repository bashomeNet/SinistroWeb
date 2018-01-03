using Sinaf.DAL.Sinistro;
using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class PreAvisoDetalheBlo
    {
        public List<PreAvisoDetalhe> RecuperarPorPreAviso(int cdpreavi)
        {
            return new PreAvisoDetalheDao().RecuperarPorPreAviso(cdpreavi);
        }

        public void Incluir(PreAvisoDetalhe preAvisoDetalhe)
        {
            PreAvisoDetalheDao preAvisoDetalheDao = new PreAvisoDetalheDao();
            preAvisoDetalheDao.Incluir(preAvisoDetalhe);
            preAvisoDetalheDao.SaveChanges();
        }

        public void Alterar(PreAvisoDetalhe preAvisoDetalhe)
        {
            PreAvisoDetalheDao preAvisoDetalheDao = new PreAvisoDetalheDao();
            preAvisoDetalheDao.Atualizar(preAvisoDetalhe, preAvisoDetalhe.cd_preavidtl);

        }

       
    }
}
