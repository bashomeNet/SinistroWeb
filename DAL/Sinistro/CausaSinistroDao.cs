using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.DAL.Sinistro
{
    public class CausaSinistroDao : DaoGenerics<CausaSinistro, DaoDBSinistro>
    {
        public CausaSinistro RecuperarPorIdentificador(int cdcausa)
        {
            try
            {
                return DaoDBSinistro.getDbSinistro.Set<CausaSinistro>().FirstOrDefault(e => e.cdcausa == cdcausa);
            }
            catch (Exception ex)
            {
                throw ex;
                //objLog.Error(typeof(PreAvisoDao) + ": " + ex.Message);
            }

        }

    }
}
