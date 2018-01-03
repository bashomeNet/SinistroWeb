using Sinaf.DAL.Sies;
using Sinaf.VOL.Sies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class UsuarioBlo
    {
        public Usuario VerificarDadosLogin(string login, string senha)
        {
            PR_Login_Result r = new UsuarioDao().VerificarDadosLogin(login, senha);

            if (r == null) return null;

            Usuario u = new Usuario();
            u.cdusuari = r.cdusuari;
            u.nmusuari = r.nmusuari;
            u.cdnivalc = r.cdnivalc;
            return u;
        }

        public List<PR_ValidarPermissaoMenu_Result> RetornaListaIdsPermissoes(string idSistema, string login)
        {
            List<PR_ValidarPermissaoMenu_Result> listaIdMenuTelaPermitidos = new UsuarioDao().RetornaListaIdsPermissoes(idSistema, login).ToList();
            return listaIdMenuTelaPermitidos;
        }


        public Boolean ValidarPermissao(string idSistema, string login, string idEvento)
        {
            PR_ValidaAlcada_Result retorno = new UsuarioDao().ValidarPermissaoFuncao(login, idSistema, idEvento);
            if (retorno != null) return true;
            return false;
        }

        public Boolean ValidarPermissaoFuncoesTelasPermitidas(string idSistema, string login, string idEvento, string idFuncao)
        {
            PR_ValidaAlcada_Result retorno = new UsuarioDao().ValidarPermissaoFuncao(login, idSistema, idEvento);
            if (retorno != null)
            {
                if (retorno.innaoaut.Equals("S"))
                {
                    return false;
                }
                else
                {
                    switch (idFuncao)
                    {
                        case "Consultar":
                            if (retorno.inaprova.Equals("S")
                                || retorno.inaprova.Equals("S")
                                || retorno.inatuali.Equals("S")
                                || retorno.inexclui.Equals("S")
                                || retorno.inefetiv.Equals("S")
                                || retorno.inconsul.Equals("S"))
                                return true;
                            break;
                        case "Incluir":
                        case "Atualiza":
                            if (retorno.inatuali.Equals("S"))
                                return true;
                            break;
                        case "Excluir":
                            if (retorno.inexclui.Equals("S"))
                                return true;
                            break;
                        case "Aprovar":
                            if (retorno.inaprova.Equals("S"))
                                return true;
                            break;
                        case "Efetivar":
                            if (retorno.inefetiv.Equals("S"))
                                return true;
                            break;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
