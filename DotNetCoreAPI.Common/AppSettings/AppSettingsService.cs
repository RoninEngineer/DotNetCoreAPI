using DotNetCoreAPI.Common.Consts;
using DotNetCoreAPI.Common.Interface;
using System;

namespace DotNetCoreAPI.Common.AppSettings
{
    public class AppServiceSettings : IAppSettingsService
    {
        public string DBConnectionString => Environment.GetEnvironmentVariable(AppSettingsKey.DBConnectionstring);
        public string StorageConnectionString => Environment.GetEnvironmentVariable(AppSettingsKey.StorageConnectionString);
    }
}
