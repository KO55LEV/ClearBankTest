using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearBank.DeveloperTest.Configuration;
using ClearBank.DeveloperTest.Factories;
using FakeItEasy;
using Xunit;


namespace ClearBank.DeveloperTest.Tests
{
    public class AccountDataStoreFactoryTests
    {

        [Fact]
        public void IsBackupFactoryReturned()
        {
            var mockAppConfig = A.Fake<IAppConfig>();

            A.CallTo(() => mockAppConfig.GetValueByKey("DataStoreType")).Returns("Backup");

            var mockAccountDataStoreFactory = new AccountDataStoreFactory(mockAppConfig);

            Assert.True(mockAccountDataStoreFactory != null);

            var mockAccountDataStore = mockAccountDataStoreFactory.GetAccountDataStore();

            Assert.True(mockAccountDataStore != null);

            Assert.Equal("BackupAccountDataStore", mockAccountDataStore.GetType().Name);

        }

        [Fact]
        public void IsDefaultFactoryReturned()
        {
            var mockAppConfig = A.Fake<IAppConfig>();

            A.CallTo(() => mockAppConfig.GetValueByKey("DataStoreType")).Returns("Live");

            var mockAccountDataStoreFactory = new AccountDataStoreFactory(mockAppConfig);

            Assert.True(mockAccountDataStoreFactory != null);

            var mockAccountDataStore = mockAccountDataStoreFactory.GetAccountDataStore();

            Assert.True(mockAccountDataStore != null);

            Assert.Equal("AccountDataStore", mockAccountDataStore.GetType().Name);

        }

    }
}