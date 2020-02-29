using Glass.Mapper.Sc;
using System.Collections.Generic;
using System.Linq;
using KATSU.Feature.Package.Models;
using KATSU.Feature.Package;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;
using System;
using KATSU.Foundation.Search.Models;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.Data.Items;

namespace KATSU.Feature.Package.Services
{
    public class PackageService : IPackageService
    {
        private readonly IContentRepository _contentRepository;
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;

        public PackageService(IContentRepository contentRepository,
                              IContextRepository contextRepository,
                              ILogRepository logRepository,
                              IRenderingRepository renderingRepository)
        {
            _contentRepository = contentRepository;
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }

        /// <summary>
        ///     **** This method is not required/in use. It is here as an example of how to use the computed search field ****
        ///     Get an item from the index
        /// </summary>
        /// <returns>The first item based on the Search template</returns>
        public IEnumerable<PackageSearchResultItem> GetPackagesSearch(string query)
        {
            // First setup your predicate
            var predicate = PredicateBuilder.True<PackageSearchResultItem>();
            predicate = predicate.And(item => item.Templates.Contains(Constants.Package.TemplateId));
            predicate = predicate.And(item => !item.Name.Equals("__Standard Values"));
            if(!string.IsNullOrEmpty( query))
                predicate = predicate.And(Item => Item.Name.Contains(query));
            // We could set the index manually using the line below (do not use magic strings, sample only)
            // var index = ContentSearchManager.GetIndex($"KATSU_{_contextRepository.GetDatabaseContext()}_index");
            // OR we could automate retrieval of the context index:
            var contextIndex = _contextRepository.GetSearchIndexContext(_contextRepository.GetCurrentItem<Item>());

            using (var context = contextIndex.CreateSearchContext())
            {
                var result = context.GetQueryable<PackageSearchResultItem>().Where(predicate);

                return result;

                // OR we could have populated a Glass model using:
                // injectedSitecoreService.Populate(result);
            }
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
