using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Models
{
    public class GridCoberturasContext
    {
        public List<GridCoberturaModel> listaCoberturas = new List<GridCoberturaModel>();

        public GridCoberturasContext()
        {
            listaCoberturas.Add(new GridCoberturaModel
            {
                idCob = 0,
                dscCob = "Cobertura 1",
                vlIsCob = "111,11",
                estIndenizacaoCob = "Estimativa 1",
                ramoCob = "Ramo 1",
                dtIniVigCob = Convert.ToDateTime("01/01/0001"),
                dtFimVigCob = Convert.ToDateTime("01/02/0001")
            });
            listaCoberturas.Add(new GridCoberturaModel
            {
                idCob = 1,
                dscCob = "Cobertura 2",
                vlIsCob = "222,22",
                estIndenizacaoCob = "",
                ramoCob = "Ramo 2",
                dtIniVigCob = Convert.ToDateTime("02/02/0002"),
                dtFimVigCob = Convert.ToDateTime("02/03/0002")
            });
            listaCoberturas.Add(new GridCoberturaModel
            {
                idCob = 2,
                dscCob = "Cobertura 3",
                vlIsCob = "333,33",
                estIndenizacaoCob = "Estimativa 3",
                ramoCob = "Ramo 3",
                dtIniVigCob = Convert.ToDateTime("03/03/0003"),
                dtFimVigCob = Convert.ToDateTime("03/04/0003")
            });
        }

        public void CriaCobertura(GridCoberturaModel coberturaModelo)
        {
            listaCoberturas.Add(coberturaModelo);
        }

        //public void AtualizaUsuario(CoberturaModel coberturaModelo)
        //{
        //    foreach (CoberturaModel usuario in listaUsuarios)
        //    {
        //        if (usuario.email == coberturaModelo.email)
        //        {
        //            listaUsuarios.Remove(usuario);
        //            listaUsuarios.Add(coberturaModelo);
        //            break;
        //        }
        //    }
        //}

        //public CoberturaModel GetUsuario(string Email)
        //{
        //    CoberturaModel _usuarioModel = null;

        //    foreach (CoberturaModel _usuario in listaUsuarios)
        //        if (_usuario.email == Email)
        //            _usuarioModel = _usuario;

        //    return _usuarioModel;
        //}

        //public void DeletarUsuario(String Email)
        //{
        //    foreach (UsuarioModel _usuario in listaUsuarios)
        //    {
        //        if (_usuario.email == Email)
        //        {
        //            listaUsuarios.Remove(_usuario);

        //            break;
        //        }
        //    }
        //}
    }
}