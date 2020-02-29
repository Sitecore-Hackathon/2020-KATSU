using Glass.Mapper.Sc.Fields;

namespace KATSU.Feature.PageContent.Models
{
    public interface ILinkItem : ILinkItemGlassBase
    {
        string LinkName { get; set; }
        Link Link { get; set; }
        Image Image { get; set; }
    }
}