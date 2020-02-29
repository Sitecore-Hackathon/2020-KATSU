using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using KATSU.Foundation.Enumeration.Models;
using KATSU.Foundation.ORM.Models;

namespace KATSU.Foundation.Enumeration
{
    public class PersonMapping : SitecoreGlassMap<IPerson>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.Person.TemplateId);
            });
        }
    }
}
