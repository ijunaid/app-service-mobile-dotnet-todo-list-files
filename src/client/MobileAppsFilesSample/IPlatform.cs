﻿using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.Files;
using Microsoft.WindowsAzure.MobileServices.Files.Metadata;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace MobileAppsFilesSample
{
    public interface IPlatform
    {
        Task <string> GetTodoFilesPathAsync();

        Task<IMobileServiceFileDataSource> GetFileDataSource(MobileServiceFileMetadata metadata);

        Task<string> TakePhotoAsync(object context);

        Task DownloadFileAsync<T>(IMobileServiceSyncTable<T> table, MobileServiceFile file);
    }
}
