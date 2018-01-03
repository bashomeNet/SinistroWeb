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
    public class OrgaoProdutorBlo
    {

        public List<OrgaoProdutor> RetornarEmpresas()
        {
            Expression<Func<OrgaoProdutor, bool>> FiltarEmpresasAtivas(){
                return obj => (obj.tporgprt == 0) && (obj.storgprt == 1);
            }
            return new OrgaoProdutorDao().RetornarTodos(FiltarEmpresasAtivas());
        }
        

        public List<OrgaoProdutor> RetornarSucursaisPorIdEmpresa(int? idEmpresa)
        {
            Expression<Func<OrgaoProdutor, bool>> FiltarSucursaisAtivasPorIdEmpresa(int? _idEmpresa)
            {
                return obj => (obj.tporgprt == 2) && (obj.storgprt == 1) && (obj.cdorgprtvin == _idEmpresa);
            }
            return new OrgaoProdutorDao().RetornarTodos(FiltarSucursaisAtivasPorIdEmpresa(idEmpresa));
        }
    }
}
