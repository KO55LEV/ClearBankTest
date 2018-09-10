using ClearBank.DeveloperTest.Configuration;
using ClearBank.DeveloperTest.Data;

namespace ClearBank.DeveloperTest.Factories
{
    public class AccountDataStoreFactory : IAccountDataStoreFactory
    {
        private readonly IAppConfig _appConfig;

        public AccountDataStoreFactory(IAppConfig appConfig)
        {
            _appConfig = appConfig;
        }

        public virtual IAccountDataStore GetAccountDataStore()
        {
            IAccountDataStore accountDataStore = null;

            var dataStoreType = _appConfig.GetValueByKey("DataStoreType");

            switch (dataStoreType)
            {
                case "Backup":
                {
                    accountDataStore = new BackupAccountDataStore();
                    break;
                }
                default:
                {
                    accountDataStore = new AccountDataStore();
                    break;
                }
            }

            return accountDataStore;
        }
    }
}
