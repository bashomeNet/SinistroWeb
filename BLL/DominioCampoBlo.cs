using Sinaf.DAL.Sies;
using Sinaf.VOL.Sies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class DominioCampoBlo
    {
        public List<DominioCampo> RetornarSituacoesPreAviso()
        {
            Expression<Func<DominioCampo, bool>> FiltarSituacoesPreAviso(){
                return obj => (obj.nm_cam == "cd_sit");
            }
            return new DominioCampoDao().RetornarTodos(FiltarSituacoesPreAviso());
        }
    }
}
