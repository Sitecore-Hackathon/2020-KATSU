using Glass.Mapper.Sc.Maps;
using PSGN.Feature.PageContent.Models;

namespace PSGN.Feature.PageContent.ORM
{
    public class IlinkGlassMappings : SitecoreGlassMap<ILinkItem>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.ImageLink.TemplateId);
                config.Field(f => f.LinkName).FieldName("Name");
                config.Field(f => f.Image).FieldName("Image");
                config.Field(f => f.Link).FieldName("Link");
            });
        }
    }

    public class IlinkGlassBaseMappings : SitecoreGlassMap<ILinkItemGlassBase>
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
