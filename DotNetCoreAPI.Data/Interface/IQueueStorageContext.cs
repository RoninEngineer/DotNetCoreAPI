using System.Threading.Tasks;

namespace DotNetCoreAPI.Data.Interface
{
    public interface IQueueStorageContext
    {
        Task QueueMessage<T>(string queueName, T message);
        Task<int> GetApproximateMessageCount(string queueName);
    }
}
