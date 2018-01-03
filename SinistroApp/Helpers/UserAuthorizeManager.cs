using Sinaf.VOL.Sies;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinistroApp.Helpers
{
    public struct UserAuthorizeKeys
    {
        public const string PreAviso = "PreAviso";
        public const string AvisoSinistro = "AvisoSinistro";
        public const string Indenizacao = "Indenizacao";
        public const string DespesaSinistro = "DespesaSinistro";
        public const string LiberarIndenizacao = "LiberarIndenizacao";
        public const string LiberarDespesa = "LiberarDespesa";
        public const string CrudPessoa = "Pessoa";
    }

    public struct UserAuthorizeMap
    {
        public const string Home = "Home/";
        public const string Home_Index = "Home/Index";
        public const string PreAviso = "PreAviso/PreAviso";
        public const string ListaPreAviso = "PreAviso/ListaPreAvisos";
        public const string ListaEmpresas = "OrgaoProdutor/RecuperarEmpresa";
        public const string ListaSucursais = "OrgaoProdutor/RecuperarSucursalId";
        public const string ListaSituacoesPreAviso = "PreAviso/RecuperarSituacoesPreAviso";
    }

    public  class UserAuthorizeManager
    {
        public Boolean CheckUserPermission(string key)
        {
            if(SessionManager.CheckSession(SessionKeys.Permissoes) == true) {

                List<PR_ValidarPermissaoMenu_Result> listPermissoes
                    = (List<PR_ValidarPermissaoMenu_Result>)SessionManager.ReturnSessionObject(SessionKeys.Permissoes);
               
                switch (key)
                {
                    case UserAuthorizeMap.Home:
                    case UserAuthorizeMap.Home_Index:
                    case UserAuthorizeMap.ListaEmpresas:
                    case UserAuthorizeMap.ListaSucursais:
                    case UserAuthorizeMap.ListaSituacoesPreAviso:
                        return true;
                    case UserAuthorizeMap.PreAviso:
                    case UserAuthorizeMap.ListaPreAviso:
                        return listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.AvisoSinistro) > 0;
                }
            }

            
            return false;
        }

        public List<ItemMenuModel> getPermissionList(List<PR_ValidarPermissaoMenu_Result> listPermissoes)
        {
            
            List<ItemMenuModel> listMenu = new List<ItemMenuModel>();
            
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.PreAviso) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Pré Aviso", Action = "PreAviso", Controller = "PreAviso", Id = "1" });
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.AvisoSinistro) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Aviso Sinistro", Action = "AvisoSinistro", Controller = "AvisoSinistro", Id = "2" });
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.Indenizacao) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Indenização", Action = "Indenizacao", Controller = "Indenizacao", Id = "3" });
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.DespesaSinistro) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Despesa Sinistro", Action = "DespesaSinistro", Controller = "DespesaSinistro", Id = "4" });
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.LiberarIndenizacao) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Liberar Indenização", Action = "LiberarIndenizacao", Controller = "LiberarIndenizacao", Id = "5" });
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.LiberarDespesa) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Liberar Despesa", Action = "LiberarDespesa", Controller = "LiberarDespesa", Id = "6" });
            if (listPermissoes.Count(obj => obj.cdprosis.Trim() == UserAuthorizeKeys.CrudPessoa) > 0)
                listMenu.Add(new ItemMenuModel { Texto = "Crud Pessoa", Action = "Pessoa", Controller = "Pessoa", Id = "7" });

            return listMenu;
        }
       

    }
}