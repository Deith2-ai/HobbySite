using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Fluent;

namespace Hobby.Common
{
    public static class Config
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string GetConfig(string key)
        {

            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Info, ex.ToString() , ex);
                return "";
            }
        }

        public static string LoginUrl => GetConfig("LoginUrl");

    }
}
