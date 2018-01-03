using Sinaf.VOL.Sinistro;
using Sinaf.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using log4net;

namespace Sinaf.DAL.Sinistro
{   
    public class PreAvisoDao : DaoGenerics<PreAviso, DaoDBSinistro>
    {
        //private static readonly ILog objLog = LogManager.GetLogger(typeof(PreAvisoDao));
        public PreAviso RecuperarPorIdentificador(int idPreAviso)
        {
            try
            {
                return DaoDBSinistro.getDbSinistro.Set<PreAviso>().FirstOrDefault(e => e.cd_preavi == idPreAviso);
            }
            catch (Exception ex)
            {
                //objLog.Error(typeof(PreAvisoDao) +": " + ex.Message);
            }
            return null;
        }


    }
}