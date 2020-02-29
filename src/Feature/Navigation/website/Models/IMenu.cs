using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.Models
{
    public interface IMenu : IMenuGlassBase
    {
        [SitecoreChildren(InferType = true)]
        IEnumerable<ILinkItems> MenuItems { get; set; }
    }
}