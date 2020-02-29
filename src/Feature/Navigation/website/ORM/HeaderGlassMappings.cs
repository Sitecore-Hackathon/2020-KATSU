using KATSU.Feature.Navigation.Models;
using Glass.Mapper.Sc.Maps;

namespace KATSU.Feature.Navigation.ORM
{
    public class HeaderGlassMappings : SitecoreGlassMap<IHeader>
    {
        public override void Configure()
        {
            Map(config =>
            {                
                config.AutoMap();
                config.TemplateId(Constants.Header.TemplateId);
                config.Field(f => f.Language).FieldName("Language");
                config.Field(f => f.Copyrights).FieldName("Copyrights");               
                config.Field(f => f.HeaderItems).FieldName("Header Items");
                config.Field(f => f.FooterItems).FieldName("Footer Items");
            });           
        }
    }
    public class HeaderGlassBaseMappings : SitecoreGlassMap<IHeaderGlassBase>
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