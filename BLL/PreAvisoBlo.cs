using Sinaf.DAL.Sies;
using Sinaf.DAL.Sinistro;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.IO;
using System.Linq;
using System.Text;
using Sinaf.VOL;
using Sinaf.VOL.Sies;
using Sinaf.VOL.Sinistro;
using Sinaf.VOL.DTOs;
using System.Reflection;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Sinaf.BLL
{
    public class PreAvisoBlo
    {
        List<PreAvisoDetalhe> objLstPreAvisoDetalhe = null;
        PreAvisoHistoricoBlo preAvisoHistoricoBlo = null;
        VOL.Sinistro.PreAviso objPreAviso = null;
       public Sinaf.VOL.Sinistro.PreAviso buscar(int id)
        {
            return new PreAvisoDao().RecuperarPorIdentificador(id);
        }
        public List<Sinaf.VOL.Sinistro.PreAviso> ListarTodos()
        {
            return new PreAvisoDao().ListarTodos();
        }

        public void Incluir(Sinaf.VOL.Sinistro.PreAviso preAviso)
        {
            PreAvisoDao preAvisoDao = new PreAvisoDao();
            preAvisoDao.Incluir(preAviso);
            preAvisoDao.SaveChanges();
        }

        public bool IncluirRecebimento(Sinaf.VOL.DTOs.PreAviso _preAviso, string strJson)
        {

            PropertyInfo[] propriedades = typeof(Sinaf.VOL.DTOs.PreAviso).GetProperties();
            objLstPreAvisoDetalhe = new List<PreAvisoDetalhe>();//Lista para adicionar os PreAvisoDetalhe salvos para o PreAviso

            using (var dbContextTransaction = new DAL.Sinistro.PreAvisoDao().getContext().Database.BeginTransaction())
            {
                try
                {
                    objPreAviso = new VOL.Sinistro.PreAviso();
                    objPreAviso.cd_orgpdr = _preAviso.Empresa;
                    objPreAviso.tp_orgpdr = Convert.ToInt16(_preAviso.Sucursal);
                    objPreAviso.cd_ori = _preAviso.Cod_Autorizacao;
                    objPreAviso.cd_sit = 1;

                    PreAvisoBlo bloPreAviso = new PreAvisoBlo();
                    bloPreAviso.Incluir(objPreAviso);

                    if (objPreAviso.cd_preavi > 0)
                    {
                        preAvisoHistoricoBlo = new PreAvisoHistoricoBlo();
                        PreAvisoHistorico objHist = new PreAvisoHistorico();
                        objHist.cd_preavi = objPreAviso.cd_preavi;
                        objHist.cd_usu = "Ampsoft";
                        objHist.dt_icl = DateTime.Now;
                        objHist.tp_mov = 1;//Recebimento Sistema Origem

                        preAvisoHistoricoBlo.Incluir(objHist);

                        if(objHist.cd_preavihis > 0)
                        {
                            PreAvisoHistoricoJsonBlo preAvisoHistoricoJsonBlo = new PreAvisoHistoricoJsonBlo();
                            PreAvisoHistoricoJson preAvisoHistJson = new PreAvisoHistoricoJson();
                            preAvisoHistJson.cd_preavihis = objHist.cd_preavihis;
                            preAvisoHistJson.ds_Json = strJson;

                            preAvisoHistoricoJsonBlo.Incluir(preAvisoHistJson);

                            PreAvisoDetalheBlo preAvisoDetalheBlo = new PreAvisoDetalheBlo();

                            PreAvisoCampoBlo preAvisoCampoBlo = new PreAvisoCampoBlo();
                            PreAvisoCampo objPreAvisoCampo = new PreAvisoCampo();

                            // Percorre a lista, obtendo o nome de cada uma das propriedades
                            foreach (PropertyInfo objP in propriedades)
                            {
                                PreAvisoDetalhe objDetalhe = new PreAvisoDetalhe();
                                // Obtém o nome da propriedade...

                                objPreAvisoCampo = preAvisoCampoBlo.Recuperar(objP.Name);

                                if (objPreAvisoCampo != null)
                                {
                                    objDetalhe.cd_preavi = objPreAviso.cd_preavi;
                                    objDetalhe.cd_cam = objPreAvisoCampo.cd_cam;
                                    objDetalhe.st_cri = 1;
                                    objDetalhe.ds_msg = null;

                                    object valorCampo = _preAviso.GetType().GetProperty(objP.Name).GetValue(_preAviso, null);

                                    if (valorCampo.GetType().Name.Contains("Object[]"))
                                    {
                                        foreach (Object item in (Object[])valorCampo)
                                        {
                                            objDetalhe.ds_val = item.ToString();
                                            preAvisoDetalheBlo.Incluir(objDetalhe);
                                            objLstPreAvisoDetalhe.Add(objDetalhe);
                                        }
                                    }
                                    else
                                    {
                                        objDetalhe.ds_val = valorCampo.ToString();
                                        preAvisoDetalheBlo.Incluir(objDetalhe);
                                        objLstPreAvisoDetalhe.Add(objDetalhe);
                                    }

                                }
                                else
                                {
                                    //Colocar um tratamento caso a descrição nao seja encontrada na tabela TB_PreAvisoCampo

                                }
                               
                            }

                        }


                    }

                    dbContextTransaction.Commit();
                    return true;
                }
                catch(Exception ex)
                {
                    dbContextTransaction.Rollback();
                    return false;
                    
                }
            }
        }

        public void GravarImportacaoAceita()
        {
            try
            {
                if(objPreAviso != null)
                {
                    preAvisoHistoricoBlo = new PreAvisoHistoricoBlo();
                    PreAvisoHistorico objHist = new PreAvisoHistorico();

                    objHist.cd_preavi = objPreAviso.cd_preavi;
                    objHist.cd_usu = "Ampsoft";
                    objHist.dt_icl = DateTime.Now;
                    objHist.tp_mov = 2;

                    preAvisoHistoricoBlo.Incluir(objHist);


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ValidaDadosObrigatorios(ICollection<ValidationResult> validationResults)
        {
            PreAvisoDetalheBlo preAvisoDetalheBlo = new PreAvisoDetalheBlo();
            
            preAvisoHistoricoBlo = new PreAvisoHistoricoBlo();
            PreAvisoHistorico objHist_Rejeicao = new PreAvisoHistorico(); // logar na TB_PreAvisoHistorico o tp_mov=3 (Importação Rejeitada - Dados Invalidos)

            foreach (ValidationResult item in validationResults)
            {
                string[] strObjeto = new string[1];
                strObjeto = (string[])item.MemberNames;

                if (objLstPreAvisoDetalhe.Count > 0)
                {
                    foreach (PreAvisoDetalhe obj in objLstPreAvisoDetalhe)
                    {
                        if (obj.TB_PreAvisoCampo.nm_cam == strObjeto[0].ToString())
                        {

                            obj.st_cri = 2;
                            obj.ds_msg = item.ErrorMessage.ToString();
                            preAvisoDetalheBlo.Alterar(obj);
                            break;
                        }

                    }

                }

            }

            objHist_Rejeicao.cd_preavi = objLstPreAvisoDetalhe[0].cd_preavi;
            objHist_Rejeicao.cd_usu = "Ampsoft";
            objHist_Rejeicao.dt_icl = DateTime.Now;
            objHist_Rejeicao.tp_mov = 3;

            preAvisoHistoricoBlo.Incluir(objHist_Rejeicao);

        }
      
    }
}