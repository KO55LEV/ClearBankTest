using System.Configuration;

namespace ClearBank.DeveloperTest.Configuration
{
    class AppConfig : IAppConfig
    {
        public string GetValueByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
