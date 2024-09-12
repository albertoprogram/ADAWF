using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAWF.Utilities
{
    internal class ConfigurationHelper
    {
        #region GetConfiguration
        internal static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
        #endregion

        #region GetConnectionString
        internal static string GetConnectionString(string connectionName)
        {
            var config = GetConfiguration();
            return config.GetConnectionString(connectionName);
        }
        #endregion
    }
}
