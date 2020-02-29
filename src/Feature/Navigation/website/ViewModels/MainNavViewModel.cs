using KATSU.Feature.Navigation.Models;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.ViewModels
{
    public class NavViewModel
    {
        public virtual IEnumerable<ILinkItems> MenuItems { get; set; }

        public bool IsExperienceEditor { get; set; }
    }
}