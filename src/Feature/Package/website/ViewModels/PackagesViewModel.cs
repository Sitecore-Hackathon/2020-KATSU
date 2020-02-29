using System.Collections.Generic;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace KATSU.Feature.Package.ViewModels
{
    public class PackagesViewModel
    {
        public IEnumerable<PackageViewModel> Packages { get; set; }
        public bool IsExperienceEditor { get; set; }
    }

}
