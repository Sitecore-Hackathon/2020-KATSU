using Sitecore.ExperienceForms.Data;
using Sitecore.ExperienceForms.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sitecore;

namespace KATSU.Feature.Package.Providers
{
    public class PhysicalFileStorageProvider : IFileStorageProvider
    {
        public void Cleanup(TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }

        public void CommitFiles(IEnumerable<Guid> fileIds)
        {
            throw new NotImplementedException();
        }

        public void DeleteFiles(IEnumerable<Guid> fileIds)
        {
            throw new NotImplementedException();
        }

        public StoredFile GetFile(Guid fileId)
        {
            var filePaths = Directory.GetFiles(@"C:\SitecoreFiles\", "fileId.*");

            return new StoredFile()
            {
                FileInfo = new StoredFileInfo()
                {
                    FileId = fileId,
                    FileName = filePaths.FirstOrDefault()
                }
            };
        }

        public Guid StoreFile(Stream file, string fileName)
        {
            // Store files on desk
            var fileId = Guid.NewGuid();
            var info = new DirectoryInfo(@"C:\SitecoreFiles");
            if (!info.Exists)
            {
                info.Create();
            }

            var fileNameWithExtension = fileId + Path.GetExtension(fileName);
            var path = Path.Combine(@"C:\SitecoreFiles", fileNameWithExtension);
            using (var outputFileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(outputFileStream);
            }

            return fileId;
        }
    }
}