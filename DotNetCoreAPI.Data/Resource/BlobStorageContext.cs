using Azure.Storage.Blobs;
using DotNetCoreAPI.Common.Interface;
using System;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Data.Resource
{
    public class BlobStorageContext
    {
        private readonly IAppSettingsService _appSettings;

        public BlobStorageContext(IAppSettingsService appSettings)
        {
            _appSettings = appSettings;
        }
        public async Task<BlobContainerClient> GetBlobContainerClient(string container)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_appSettings.StorageConnectionString);
            

            // Create the container and return a container client object
            BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(container);

            return containerClient;
        }

        


        
    }
}
