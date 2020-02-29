using KATSU.Foundation.ORM.Models;

namespace KATSU.Feature.Package.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface IPackageGlassBase : IGlassBase
    {
    }
}
