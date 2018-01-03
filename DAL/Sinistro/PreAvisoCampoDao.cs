using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.DAL.Sinistro
{
    public class PreAvisoCampoDao : DaoGenerics<PreAvisoCampo, DaoDBSinistro>
    {
        public PreAvisoCampo RecuperarPorDescricao(string strNmCam)
        {
            try
            {
                return DaoDBSinistro.getDbSinistro.Set<PreAvisoCampo>().FirstOrDefault(e => e.nm_cam.Equals(strNmCam));
            }
            catch (Exception ex)
            {
                //objLog.Error(typeof(PreAvisoDao) +": " + ex.Message);
            }
            return null;
        }

    }
}
