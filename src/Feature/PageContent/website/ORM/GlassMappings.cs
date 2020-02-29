using Glass.Mapper.Sc.Maps;
using KATSU.Feature.PageContent.Models;

namespace KATSU.Feature.PageContent.ORM
{
    public class GlassMappings : SitecoreGlassMap<IImageLink>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.ImageLink.TemplateId);
                config.Field(f => f.Link).FieldName("Link");
                config.Field(f => f.Image).FieldName("Image");
                config.Field(f => f.CssClass).FieldName("Css Class");
            });
        }
    }

    public class GlassBaseMappings : SitecoreGlassMap<IImageLinkGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
            });
        }
    }

    public class RichTextEditorGlassBaseMappings : SitecoreGlassMap<IRichTextEditorGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
            });
        }
    }

    public class RichTextEditorGlassMappings : SitecoreGlassMap<IRichTextEditor>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.RichTextEditor.TemplateId);
            });
        }
    }

}
