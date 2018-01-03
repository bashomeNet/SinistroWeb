using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.VOL
{
    public class Config
    {

        #region funções e métodos privados

        private static object GetAppSettings(string pChave)
        {
            return ConfigurationManager.AppSettings.Get(pChave);
        }

        #endregion

        #region funções e métodos públicos

        public static string SiesConnectionString()
        {
            return GetAppSettings("SiesConnectionString").ToString();
        }

        public static string SiesConnectionStringMetadata()
        {
            return GetAppSettings("SiesConnectionStringMetadata").ToString();
        }

        public static string SinistroConnectionString()
        {
            return GetAppSettings("SinistroConnectionString").ToString();
        }

        public static string SinistroConnectionStringMetadata()
        {
            return GetAppSettings("SinistroConnectionStringMetadata").ToString();
        }

        public static string FinanceiroConnectionString()
        {
            return GetAppSettings("FinanceiroConnectionString").ToString();
        }

        public static string FinanceiroConnectionStringMetadata()
        {
            return GetAppSettings("FinanceiroConnectionStringMetadata").ToString();
        }

        public static string ConnectionStringProvider()
        {
            return GetAppSettings("ConnectionStringProvider").ToString();
        }


        public static string IdSistema()
        {
            return GetAppSettings("IdSistema").ToString();
        }
        #endregion

    }
}
