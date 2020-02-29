using KATSU.Feature.Navigation.Models;

namespace KATSU.Feature.Navigation.Services
{
    public interface IHeaderService
    {
        IHeader GetHeaderItems();       
        bool IsExperienceEditor { get; }
    }
}