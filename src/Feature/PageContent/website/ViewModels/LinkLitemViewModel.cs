using Glass.Mapper.Sc.Fields;

namespace KATSU.Feature.PageContent.ViewModels
{
    public class LinkItemViewModel
    {
        public Link Link { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public bool IsExperienceEditor { get; set; }
    }
}