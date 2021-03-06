using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;
using KATSU.Foundation.Enumeration.Models;

namespace KATSU.Feature.Package.Models
{
    public interface IPackage : IPackageGlassBase
    {
        string PackageName { get; set; }
        string PackageIdentifier { get; set; }
        File PackageFile { get; set; }
        string Documentation { get; set; }
        string Summary { get; set; }
        IEnumerable<ISitecoreVersion> SitecoreVersion { get; set; }
        IEnumerable<IPerson> Contributors { get; set; }
    }
}
