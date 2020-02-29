using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KATSU.Feature.Package.ViewModels
{
    public class PackageViewModel
    {
        public string Id { get; set; }
        public string PackageName { get; set; }
        public string PackageIdentifier { get; set; }
        public string PackageFile { get; set; }
        public string Documentation { get; set; }
        public bool IsExperienceEditor { get; set; }
        public string PackageTitle { get; set; }
        public string PackageSummary { get; set; }
        public string PackageId { get; set; }
    }
}
