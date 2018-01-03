using Sinaf.VOL.Sies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.DAL.Sies
{
    public class UsuarioDao : DaoGenerics<Usuario, DaoDBSinistro>
    {
        public PR_Login_Result VerificarDadosLogin(string login, string Senha)
        {
            try
            {
                return DaoDBSies.getDbSies.PR_Login(login, Senha).FirstOrDefault();

            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.Sies(VerificarDadosLogin): " + ex.Message);
                throw ex;
            }
        }

        public List<PR_ValidarPermissaoMenu_Result> RetornaListaIdsPermissoes(string idSistema, string login)
        {
            try
            {
                return DaoDBSies.getDbSies.PR_ValidarPermissaoMenu(idSistema, login).ToList();

            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.Sies(ValidarPermissaoMenu): " + ex.Message);
                throw ex;
            }
        }


        public PR_ValidaAlcada_Result ValidarPermissaoFuncao(string idSistema, string login, string idEvento)
        {
            try
            {
                return DaoDBSies.getDbSies.PR_ValidaAlcada(login, idSistema, idEvento).FirstOrDefault();
            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.Sies(ValidarPermissaoRequisito): " + ex.Message);
                throw ex;
            }
        }
    }
}
