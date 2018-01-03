
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Sinaf.DAL
{
    public class DaoGenerics<TEntity, J> where TEntity : class where J : DaoDb, new()
    {
        protected static log4net.ILog objLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected IDaoDB objDaoDB = new J();
        /// <summary>
        /// Inclusão de Uma Entidade  
        /// </summary>
        public void Incluir(TEntity entity)
        {
            try
            {
                objDaoDB.getDb().Set<TEntity>().Add(entity);
            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.DaoGenerics(Incluir): " + ex.Message);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Exclusão de Uma Entidade  
        /// </summary>
        public void Excluir(TEntity entity)
        {
            try
            {
                objDaoDB.getDb().Set<TEntity>().Remove(entity);
            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.DaoGenerics(Excluir): " + ex.Message);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Torna permanente as alteraçoes no contexto
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool SaveChanges()
        {
            try
            {
                objDaoDB.getDb().SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.DaoGenerics(SaveChanges): " + ex.Message);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Fecha a conexão
        /// </summary>
        /// <remarks></remarks>
        public static void FecharConexao()
        {
            try
            {
                IDaoDB objDaoDB = new J();
                objDaoDB.closeDb();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar conexão da Área Exclusiva", ex);
            }
        }

        public List<TEntity> ListarTodos()
        {
            try
            {
                return objDaoDB.getDb().Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                objLog.Error("Sinaf.DAL.DaoGenerics(listarTodos): " + ex.Message);
                throw new NotImplementedException();
            }
        }


        public int ContarTodos()
        {
            return objDaoDB.getDb().Set<TEntity>().Count();
        }


        public TEntity Atualizar(TEntity updated, int key)
        {
            if (updated == null)
                return null;

            TEntity existing = objDaoDB.getDb().Set<TEntity>().Find(key);
            if (existing != null)
            {
                objDaoDB.getDb().Entry(existing).CurrentValues.SetValues(updated);
            }
            return existing;
        }

        
        public TEntity RetornarPrimeiro(Expression<Func<TEntity, bool>> match)
        {
            return objDaoDB.getDb().Set<TEntity>().SingleOrDefault(match);
         }


        public List<TEntity> RetornarTodos(Expression<Func<TEntity, bool>> match)
        {
            return objDaoDB.getDb().Set<TEntity>().Where(match).ToList();
        }

        
        public TEntity RetornarPeloId(int id)
        {
            return objDaoDB.getDb().Set<TEntity>().Find(id);
        }
        


        public DbContext getContext()
        {
            return objDaoDB.getDb();
        }
    }
}