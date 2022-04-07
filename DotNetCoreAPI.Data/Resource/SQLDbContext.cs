using DotNetCoreAPI.Common.Interface;
using DotNetCoreAPI.Data.Interface;
using System.Data;
using System.Data.SqlClient;

namespace DotNetCoreAPI.Data.Resource
{
    public class SQLDbContext : ISQLDbContext
    {
        private readonly IAppSettingsService _appSettings;
        public SQLDbContext(IAppSettingsService appSettings)
        {
            _appSettings = appSettings;
        }

        public IDbConnection GetDbConnection()
        {
            IDbConnection dbConn = new SqlConnection(_appSettings.DBConnectionString);

            return dbConn;
        }
    }
}
