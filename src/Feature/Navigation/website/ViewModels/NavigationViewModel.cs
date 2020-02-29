using Glass.Mapper.Sc.Configuration.Attributes;
using KATSU.Feature.Navigation.Models;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.ViewModels
{
    public class HeaderViewModel
    {
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<ILanguageItems> Language { get; set; }
        public string Copyrights { get; set; }
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<ILinkItems> HeaderItems { get; set; }
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<ILinkItems> FooterItems { get; set; } 
        public bool IsExperienceEditor { get; set; }
    }
  }