using Glass.Mapper.Sc.Fields;

namespace KATSU.Feature.PageContent.Models
{
    public interface IImageLink : IImageLinkGlassBase
    {
        Link Link { get; set; }
        Image Image { get; set; }
        string CssClass { get; set; }
    }
}