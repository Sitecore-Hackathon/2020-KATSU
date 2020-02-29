using System.Collections.Generic;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace KATSU.Feature.Hero.ViewModels
{
    public class HeroViewModel
    {
        public HtmlString HeroTitle { get; set; }
        public IEnumerable<Image> HeroImages { get; set; }
        public bool IsExperienceEditor { get; set; }
    }
}
