using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace MrktProduto.Application
{
    public class AzureBlobStorage
    {
        private readonly IConfiguration configuration;

        public AzureBlobStorage(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public async Task<string> UploadFile(string fileName, Stream buffer, string directory = "")
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(this.configuration["BlobStorageConnection"]);
            BlobContainerClient container = null;

            if (string.IsNullOrWhiteSpace(directory) == false)
            {
                container = blobServiceClient.GetBlobContainerClient($"imagens/{directory}");
                await container.UploadBlobAsync(fileName, buffer);
                return $"{this.configuration["BlobStorageBasePath"]}/imagens/{directory}/{fileName}";
            }

            container = blobServiceClient.GetBlobContainerClient($"imagens");
            await container.UploadBlobAsync(fileName, buffer);

            return $"{this.configuration["BlobStorageBasePath"]}/imagens/{fileName}";

        }
    }
}
