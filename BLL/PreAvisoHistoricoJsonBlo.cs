using Sinaf.DAL.Sinistro;
using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class PreAvisoHistoricoJsonBlo
    {
        public void Incluir(PreAvisoHistoricoJson preAvisoHistorico)
        {
            PreAvisoHistoricoJsonDao preAvisoHistoricoJsonDao = new PreAvisoHistoricoJsonDao();
            preAvisoHistoricoJsonDao.Incluir(preAvisoHistorico);
            preAvisoHistoricoJsonDao.SaveChanges();
        }
    }
}
