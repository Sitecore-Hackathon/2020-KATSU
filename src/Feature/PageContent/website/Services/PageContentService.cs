using KATSU.Feature.PageContent.Models;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;

namespace KATSU.Feature.PageContent.Services
{
    public class PageContentService : IPageContentService
    {
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;

        public PageContentService(IContextRepository contextRepository,
            ILogRepository logRepository, IRenderingRepository renderingRepository)
        {
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }

        /// <summary>
        ///     Get an item using the rendering repository
        /// </summary>
        /// <returns>The ImageLink datasource item from the Content API</returns>
        public IImageLink GetImageLinkItem()
        {
            var dataSource = _renderingRepository.GetDataSourceItem<IImageLink>();

            // Basic example of using the wrapped logger
            if (dataSource == null)
                _logRepository.Warn(Logging.Error.DataSourceError);

            return dataSource;
        }

        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;
    }
}