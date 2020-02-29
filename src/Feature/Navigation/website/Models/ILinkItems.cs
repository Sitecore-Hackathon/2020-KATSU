using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.Models
{
    public interface ILinkItems : IHeaderGlassBase
    {
        string LinkName { get; set; }

        Link ItemLink { get; set; }

        Image Image { get; set; }

        [SitecoreChildren(InferType = true)]
        IEnumerable<ILinkItems> SubMenuItems { get; set; }
    }
}