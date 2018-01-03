using Sinaf.DAL.Sinistro;
using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class PreAvisoCampoBlo
    {
        public PreAvisoCampo Recuperar(string strNmCam)
        {
            return new PreAvisoCampoDao().RecuperarPorDescricao(strNmCam);
        }
    }
}
