

using System.Web;
using System;
using Sinaf.VOL.Sies;
using Sinaf.VOL;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;

namespace Sinaf.DAL
{
    public class DaoDBSies : DaoDb, IDaoDB
    {
        private const string DATACONTEXT_ITEMS_KEY_SIES = "LinqUtilDataContextKeySies";

        private static SiesEntities InternalDataContextSies
        {
            get { return (SiesEntities)HttpContext.Current.Items[DATACONTEXT_ITEMS_KEY_SIES]; }
            set { HttpContext.Current.Items[DATACONTEXT_ITEMS_KEY_SIES] = value; }
        }


        static internal SiesEntities getDbSies
        {
            get
            {
                // If the context is missing, create a new one
                if (InternalDataContextSies == null)
                {
                    EntityConnectionStringBuilder connStrBuild = new EntityConnectionStringBuilder();

                    connStrBuild.Metadata = Config.SiesConnectionStringMetadata();
                    connStrBuild.Provider = Config.ConnectionStringProvider();
                    connStrBuild.ProviderConnectionString = Config.SiesConnectionString();

                    InternalDataContextSies = new SiesEntities(connStrBuild.ToString());
                }

                if (InternalDataContextSies.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    InternalDataContextSies.Database.Connection.Open();
                }

                return InternalDataContextSies;
            }
        }

        static internal void closeDbSies()
        {
            try
            {
                if (InternalDataContextSies != null && InternalDataContextSies.Database.Connection.State != System.Data.ConnectionState.Closed)
                {
                    InternalDataContextSies.Database.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao fechar conexao", ex);
            }

        }

        static internal void DisposeDbSies()
        {
            try
            {
                InternalDataContextSies = null;
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao matar a conexao", ex);
            }

        }

        new public DbContext getDb()
        {
            return DaoDBSies.getDbSies;
        }

        new public void closeDb()
        {
            DaoDBSies.closeDbSies();
        }
    }
}
