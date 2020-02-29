using Glass.Mapper.Sc.Fields;

namespace PSGN.Feature.PageContent.ViewModels
{
    public class ImageLinkViewModel
    {
        public Link Link { get; set; }
        public Image Image { get; set; }
        public string CssClass { get; set; }
        public bool IsExperienceEditor { get; set; }
    }
}