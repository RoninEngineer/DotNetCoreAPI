using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using DotNetCoreAPI.Common.Interface;
using DotNetCoreAPI.Data.Interface;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Data.Resource
{
    public class QueueStorageContext : IQueueStorageContext
    {
        private readonly IAppSettingsService _appSettings;
        public QueueStorageContext(IAppSettingsService appSettings)
        {
            _appSettings = appSettings;
        }

        private QueueClient GetQueueClient(string queueName)
        {
            QueueClient queueClient = new QueueClient(_appSettings.StorageConnectionString, queueName);
            return queueClient;
        }

        public async Task QueueMessage<T>(string queueName, T message)
        {
            await AddMessageToQueue(queueName, JsonConvert.SerializeObject(message, new JsonSerializerSettings() { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
        }

        public async Task<int> GetApproximateMessageCount(string queueName)
        {
            var queueClient = GetQueueClient(queueName);
            QueueProperties properties = await queueClient.GetPropertiesAsync();
            return properties.ApproximateMessagesCount;
        }

        private async Task AddMessageToQueue(string queueName, string message)
        {
            var queueClient = GetQueueClient(queueName);
            await queueClient.CreateIfNotExistsAsync();
            await queueClient.SendMessageAsync(message);
        }


    }
}
