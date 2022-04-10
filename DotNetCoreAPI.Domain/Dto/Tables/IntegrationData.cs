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

		public IntegrationData(string IntegrationType, string Description)
		{
			this.PartitionKey = IntegrationType;
			this.RowKey = Description;
		}

		public bool? Active { get; set; }

		public int? SequenceId { get; set; }

	}
}
