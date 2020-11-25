using Renci.SshNet;
using System;
using System.IO;

namespace SftpDownloadApi.Service
{
    public class SftpDownloadService
    {
        public string DownloadFile()
        {
            var downloadConfigs = new SftpConfiguration();
            try
            {
                using (SftpClient sftp = new SftpClient(downloadConfigs.Host, downloadConfigs.UserName, downloadConfigs.Password))
                {
                    sftp.Connect();
                    // logger.LogDebug($"Connected to host {downloadConfigs.Host} file using Sftp");

                    using (Stream fileStream = File.OpenWrite(Path.Combine(downloadConfigs.localFilePath, downloadConfigs.fileName)))
                    {
                        sftp.DownloadFile(Path.Combine(downloadConfigs.RemoteFileLocation, downloadConfigs.fileName), fileStream);
                    }

                    sftp.Disconnect();
                    //logger.LogDebug($"Download successful for file {downloadConfigs.fileName} using Sftp to local location {downloadConfigs.localFilePath}");
                }
                return string.Empty;
                   
            }
            catch (Exception e)
            {

            }
            return string.Empty;
        }
        
    }
}
