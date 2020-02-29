using KATSU.Foundation.Search.Models;
using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KATSU.Feature.Package.Models
{
    public class PackageSearchResultItem : BaseSearchResultItem
    {
        [IndexField("package_name")]
        public string PackageName { get; set; }

        [IndexField("Summary")]
        public string Summary { get; set; }
    }
}
