using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.DAL.Sinistro
{
    public class PreAvisoDetalheDao : DaoGenerics<PreAvisoDetalhe, DaoDBSinistro>
    {

        public List<PreAvisoDetalhe> RecuperarPorPreAviso(int cd_preavi)
        {
            try
            {
                return DaoDBSinistro.getDbSinistro.Set<PreAvisoDetalhe>().Where(c => c.cd_preavi == cd_preavi).ToList();
            }
            catch (Exception ex)
            {
                //objLog.Error(typeof(PreAvisoDao) +": " + ex.Message);
            }
            return null;
        }
    }
}
