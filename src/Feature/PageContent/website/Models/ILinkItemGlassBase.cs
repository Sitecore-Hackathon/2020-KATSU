using KATSU.Foundation.ORM.Models;

namespace KATSU.Feature.PageContent.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface ILinkItemGlassBase : IGlassBase
    {
    }
}