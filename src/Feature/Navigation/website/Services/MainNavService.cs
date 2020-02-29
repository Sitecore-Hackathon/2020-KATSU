using KATSU.Feature.Navigation.Models;
using KATSU.Foundation.Content.Repositories;
using KATSU.Foundation.Logging.Repositories;
using System.Collections.Generic;
using System.Linq;
using static KATSU.Feature.Navigation.Constants;

namespace KATSU.Feature.Navigation.Services
{
    public class NavService : INavService
    {
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;
        public NavService(IContextRepository contextRepository,
            ILogRepository logRepository, IRenderingRepository renderingRepository)
        {
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }

        /// <summary>
        ///     Get an item using the rendering repository
        /// </summary>
        /// <returns>The Nav datasource item from the Content API</returns>
        public List<ILinkItems> GetNavItems()
        {
            var dataSource = _renderingRepository.GetDataSourceItem<IMenu>();
            // Basic example of using the wrapped logger
            if (dataSource == null)
                _logRepository.Warn(Logging.Error.DataSourceError);
             return dataSource?.MenuItems?.ToList();
        }

        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;
    }
}