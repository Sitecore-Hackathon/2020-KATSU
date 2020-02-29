using Glass.Mapper.Sc;
using KATSU.Feature.Package.Models;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;
using System;

namespace KATSU.Feature.Package.Services
{
    public class PackageService : IPackageService
    {
        private readonly IContentRepository _contentRepository;
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;

        public PackageService(IContentRepository contentRepository,
                              IContextRepository contextRepository,
                              ILogRepository logRepository)
        {
            _contentRepository = contentRepository;
            _contextRepository = contextRepository;
            _logRepository = logRepository;
        }

        public IPackage GetPackage(string packageId)
        {
            if (string.IsNullOrEmpty(packageId)) return null;

            var dataSource = _contentRepository.GetItem<IPackage>(new GetItemByIdOptions
            {
                Id = new Guid(packageId)
            });

            if (dataSource != null) return dataSource;
            _logRepository.Warn(Constants.Logging.Error.DataSourceError);

            return null;
        }

        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;
    }
}
