using Glass.Mapper.Sc.Maps;
using KATSU.Feature.Navigation.Models;

namespace KATSU.Feature.Navigation.ORM
{
    public class LanguageItemGlassMapping : SitecoreGlassMap<ILanguageItems>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.LanguageItemItem.TemplateId);
                config.Field(f => f.Iso).FieldName("Iso");
                config.Field(f => f.RegionalIsoCode).FieldName("Regional Iso Code");
                config.Field(f => f.LanguageIdentifier).FieldName("Language Identifier");
            });
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
}