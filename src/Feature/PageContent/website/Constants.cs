using System;

namespace KATSU.Feature.PageContent
{
    /// <summary>
    /// https://staticreadonly.com/2019/02/06/structures-vs-static-classes-for-sitecore-template-references/
    /// </summary>
    public static class Constants
    {
        public static class ImageLink
        {
            public static readonly Guid TemplateId = new Guid("{4650F391-19D7-4744-98A4-C0A12607ED5A}");
        }

        public static class RichTextEditor
        {
            public static readonly Guid TemplateId = new Guid("{59F4EC96-9C80-41CF-AA4B-D01C1D91B659}");
        }
    }

    public static class Logging
    {
        public static class Error
        {
            public const string DataSourceError = "The ImageLink datasource was empty";
        }
    }

    public static class MediatorCodes
    {
        public static class ImageLinkResponse
        {
            public const string DataSourceError = "ImageLinkMediator.CreateImageLinkViewModel.DataSourceError";
            public const string ViewModelError = "ImageLinkMediator.CreateImageLinkViewModel.ViewModelError";
            public const string Ok = "ImageLinkMediator.CreateImageLinkViewModel.Ok";
        }
    }
}