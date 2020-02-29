using Glass.Mapper.Sc.Fields;
using KATSU.Feature.Navigation.ViewModels;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.Models
{
    public interface IHeader : IHeaderGlassBase
    {
        IEnumerable<ILanguageItems> Language { get; set; }
        string Copyrights { get; set; }
        IEnumerable<ILinkItems> HeaderItems { get; set; }
        IEnumerable<ILinkItems> FooterItems { get; set; } 

    }
}