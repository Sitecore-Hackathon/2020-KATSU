using System;

namespace KATSU.Feature.Navigation
{
    public static class Constants
    {
        public static class Header
        {
            public static readonly Guid TemplateId = new Guid("{95474280-0D96-430A-B110-397EBAA2692E}");
        }

        public static class Menu
        {
            public static readonly Guid TemplateId = new Guid("{9CE63D6E-6CD8-4A5C-9E7B-1C5C39C1E24F}");
        }

        public static class LinkItem
        {
            public static readonly Guid TemplateId = new Guid("{FDE20385-48DD-499D-B757-A3F0140305DC}");
        }
        public static class LanguageItemItem
        {
            public static readonly Guid TemplateId = new Guid("{9C18F052-1FCF-468A-A225-DDFEC37EC48E}");
        }
        public static class Logging
        {
            public static class Error
            {
                public const string DataSourceError = "The Navigation datasource was empty";
                public const string DataHeaderSourceError = "The Header datasource was empty";
            }
        }
        public static class MediatorCodes
        {
            public static class NavigationResponse
            {
                public const string DataSourceError = "NavigationMediator.CreateNavigationViewModel.DataSourceError";
                public const string ViewModelError = "NavigationMediator.CreateNavigationViewModel.ViewModelError";
                public const string Ok = "NavigationMediator.CreateNavigationViewModel.Ok";
            }

            public static class HeaderResponse
            {
                public const string DataSourceError = "HeaderMediator.CreateHeaderViewModel.DataSourceError";
                public const string ViewModelError = "HeaderMediator.CreateHeaderViewModel.DataHeaderSourceError";
                public const string Ok = "HeaderMediator.CreateHeaderViewModel.Ok";
            }

            public static class NavResponse
            {
                public const string DataSourceError = "NavMediator.CreateNavViewModel.DataSourceError";
                public const string ViewModelError = "NavMediator.CreateNavViewModel.DataHeaderSourceError";
                public const string Ok = "NavMediator.CreateNavViewModel.Ok";
            }
        }
    }
}