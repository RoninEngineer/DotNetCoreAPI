using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Domain.Dto.Tables
{
    public class IntegrationData : TableEntity
    {

		public IntegrationData(string description, string functionInvocationId)
		{
			this.PartitionKey = description;
			this.RowKey = functionInvocationId;
		}

		public bool? Active { get; set; }

		public string Type { get; set; }

		public string Description { get; set; }

		public int? SequenceId { get; set; }

	}
}
