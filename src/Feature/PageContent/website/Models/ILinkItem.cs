using Glass.Mapper.Sc.Fields;

namespace PSGN.Feature.PageContent.Models
{
    public interface ILinkItem : ILinkItemGlassBase
    {
        string LinkName { get; set; }
        Link Link { get; set; }
        Image Image { get; set; }
    }
}