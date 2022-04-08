using Azure.Data.Tables;
using DotNetCoreAPI.Data.Interface;
using System;
using System.Collections.Generic;
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
