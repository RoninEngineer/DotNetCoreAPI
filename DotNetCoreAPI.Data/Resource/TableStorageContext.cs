using Azure;
using Azure.Data.Tables;
using DotNetCoreAPI.Data.Interface;
using DotNetCoreAPI.Domain.Dto.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreAPI.Data.Resource
{
    public class TableStorageContext : ITableStorageContext
    {
        private readonly TableClient _tableClient;
        public TableStorageContext(TableClient tableClient)
        {
            _tableClient = tableClient;
        }

        
    }
}
