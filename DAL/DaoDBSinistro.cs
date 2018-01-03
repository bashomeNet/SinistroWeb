using System.Web;
using System;
using Sinaf.VOL.Sinistro;
using Sinaf.VOL;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;

namespace Sinaf.DAL
{
    public class DaoDBSinistro : DaoDb, IDaoDB
    {
        private const string DATACONTEXT_ITEMS_KEY_SINISTRO = "LinqUtilDataContextKeySinistro";

        private static SinistroEntities InternalDataContextSinistro
        {
            get { return (SinistroEntities)HttpContext.Current.Items[DATACONTEXT_ITEMS_KEY_SINISTRO]; }
            set { HttpContext.Current.Items[DATACONTEXT_ITEMS_KEY_SINISTRO] = value; }
        }


        static internal SinistroEntities getDbSinistro
        {
            get
            {
                // If the context is missing, create a new one
                if (InternalDataContextSinistro == null)
                {
                    EntityConnectionStringBuilder connStrBuild = new EntityConnectionStringBuilder();

                    connStrBuild.Metadata = Config.SinistroConnectionStringMetadata();
                    connStrBuild.Provider = Config.ConnectionStringProvider();
                    connStrBuild.ProviderConnectionString = Config.SinistroConnectionString();

                    InternalDataContextSinistro = new SinistroEntities(connStrBuild.ToString());
                }

                if (InternalDataContextSinistro.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    InternalDataContextSinistro.Database.Connection.Open();
                }

                return InternalDataContextSinistro;
            }
        }

        static internal void closeDbSinistro()
        {
            try
            {
                if (InternalDataContextSinistro != null && InternalDataContextSinistro.Database.Connection.State != System.Data.ConnectionState.Closed)
                {
                    InternalDataContextSinistro.Database.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao fechar conexao", ex);
            }

        }

        static internal void DisposeDbSinistro()
        {
            try
            {
                InternalDataContextSinistro = null;
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao matar a conexao", ex);
            }

        }

        new public DbContext getDb()
        {
            return DaoDBSinistro.getDbSinistro;
        }

        new public void closeDb()
        {
            DaoDBSinistro.closeDbSinistro();
        }
    }
}