using System;

namespace KATSU.Feature.Package
{
    /// <summary>
    /// https://staticreadonly.com/2019/02/06/structures-vs-static-classes-for-sitecore-template-references/
    /// </summary>
    public static class Constants
    {
        public static class Package
        {
            public static readonly Guid TemplateId = new Guid("{E356ADF4-96CC-43AD-B1E3-BF07C32F1259}");
        }

        public static class Logging
        {
            public static class Error
            {
                public const string DataSourceError = "The package does not exists.";
            }
        }

        public static class MediatorCodes
        {
            public static class PackageSearchResponse
            {
                public const string DataSourceError = "HeroMediator.CreateHeroViewModel.DataSourceError";
                public const string ViewModelError = "HeroMediator.CreateHeroViewModel.ViewModelError";
                public const string Ok = "HeroMediator.CreateHeroViewModel.Ok";
            }
        }
    }

}
