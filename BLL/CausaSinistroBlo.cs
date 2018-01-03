using Sinaf.DAL.Sinistro;
using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class CausaSinistroBlo
    {
        public CausaSinistro RecuperarCausaSinistro(int cdcausa)
        {
            return new CausaSinistroDao().RecuperarPorIdentificador(cdcausa);
        }
    }
}
