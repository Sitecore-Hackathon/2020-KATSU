using KATSU.Feature.Navigation.Models;
using System.Collections.Generic;

namespace KATSU.Feature.Navigation.Services
{
    public interface INavService
    {
        List<ILinkItems> GetNavItems();       

        bool IsExperienceEditor { get; }
    }
}