using Glass.Mapper.Sc.Fields;

namespace PSGN.Feature.PageContent.Models
{
    public interface IAlert
    {
        Image Image { get; set; }
        string Message { get; set; }
        string ActionTitle { get; set; }
        Link ActionUrl { get; set; }
    }
}