using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreAPI.Common.Interface
{
    public interface IAppSettingsService
    {
        string DBConnectionString { get; }
        string StorageConnectionString { get; }
    }
}
