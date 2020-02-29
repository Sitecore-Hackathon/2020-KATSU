using PSGN.Foundation.ORM.Models;

namespace PSGN.Feature.PageContent.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface IRichTextEditorGlassBase : IGlassBase
    {
    }
}