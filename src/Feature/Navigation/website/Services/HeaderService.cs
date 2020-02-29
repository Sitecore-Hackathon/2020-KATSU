using KATSU.Feature.Navigation.Models;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;
using static KATSU.Feature.Navigation.Constants;

namespace KATSU.Feature.Navigation.Services
{
    public class HeaderService : IHeaderService
    {
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;
        public HeaderService(IContextRepository contextRepository,
            ILogRepository logRepository, IRenderingRepository renderingRepository)
        {
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }
        /// <summary>
        ///     Get an item using the rendering repository
        /// </summary>
        /// <returns>The Header datasource item from the Content API</returns>
        public IHeader GetHeaderItems()
        {
            var dataSource = _renderingRepository.GetDataSourceItem<IHeader>();
            // Basic example of using the wrapped logger
            if (dataSource == null)
                _logRepository.Warn(Logging.Error.DataSourceError);
             return dataSource;
        }    
        
        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;
    }
}