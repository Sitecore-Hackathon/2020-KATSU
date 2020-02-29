using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using KATSU.Foundation.Enumeration.Models;

namespace KATSU.Foundation.Enumeration
{
    public class SitecoreVersionMappings : SitecoreGlassMap<ISitecoreVersion>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.SitecoreVersion.TemplateId);
                config.Field(f => f.Version).FieldName("Sitecore Version Name");
            });
        }
    }
}
