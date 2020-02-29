using Glass.Mapper.Sc.Maps;
using KATSU.Feature.Package.Models;

namespace KATSU.Feature.Package.ORM
{
    public class GlassMappings : SitecoreGlassMap<IPackage>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.Package.TemplateId);
                config.Field(f => f.PackageName).FieldName("Package Name");
                config.Field(f => f.PackageIdentifier).FieldName("Package Identifier");
                config.Field(f => f.PackageFile).FieldName("Package File");
                config.Field(f => f.Documentation).FieldName("Documentation");
                config.Field(f => f.Contributors).FieldName("Contributor");
                config.Field(f => f.SitecoreVersion).FieldName("Compatible Versions");
                config.Field(f => f.Summary).FieldName("Summary");

            });
        }
    }

    public class GlassBaseMappings : SitecoreGlassMap<IPackageGlassBase>
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
