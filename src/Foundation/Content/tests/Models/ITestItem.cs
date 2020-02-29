using KATSU.Foundation.ORM.Models;

namespace KATSU.Foundation.Content.Tests.Models
{
    public interface ITestItem : IGlassBase
    {
        string Title { get; set; }
    }
}
