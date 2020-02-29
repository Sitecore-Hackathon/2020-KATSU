using System;

namespace KATSU.Foundation.Enumeration
{
    /// <summary>
    /// https://staticreadonly.com/2019/02/06/structures-vs-static-classes-for-sitecore-template-references/
    /// </summary>
    public static class Constants
    {
        public static class Person
        {
            public static readonly Guid TemplateId = new Guid("{6AC42B9D-8D23-4B4A-A4EC-602A2A6B76C0}");
        }
        public static class SitecoreVersion
        {
            public static readonly Guid TemplateId = new Guid("{3E633134-BB87-4DC7-99CD-032761C67375}");
        }
    }

}
