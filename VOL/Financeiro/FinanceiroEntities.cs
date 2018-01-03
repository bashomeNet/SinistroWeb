using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.VOL.Financeiro
{
    public partial class FinanceiroEntities
    {
        public FinanceiroEntities(string stringConnection) : base(stringConnection)
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }
    }
}
