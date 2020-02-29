using KATSU.Feature.Navigation.Models;
using Glass.Mapper.Sc.Maps;

namespace KATSU.Feature.Navigation.ORM
{
    public class LinkItemGlassMapping : SitecoreGlassMap<ILinkItems>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.LinkItem.TemplateId);
                config.Field(f => f.LinkName).FieldName("Name");
                config.Field(f => f.ItemLink).FieldName("Link");
            });
        }
    }
    public class HeaderItemGlassBaseMappings : SitecoreGlassMap<IHeaderGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
            });
        }
    }
 }