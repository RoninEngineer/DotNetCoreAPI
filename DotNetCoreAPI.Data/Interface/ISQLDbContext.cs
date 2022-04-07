using System.Data;

namespace DotNetCoreAPI.Data.Interface
{
    public interface ISQLDbContext
    {
        IDbConnection GetDbConnection();
    }
}
