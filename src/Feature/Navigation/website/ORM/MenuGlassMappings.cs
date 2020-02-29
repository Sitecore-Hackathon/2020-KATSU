using Glass.Mapper.Sc.Maps;
using KATSU.Feature.Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KATSU.Feature.Navigation.ORM
{
    public class MenuGlassMappings : SitecoreGlassMap<IMenu>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.Menu.TemplateId);
            });
        }
    }
    public class MenuGlassBaseMappings : SitecoreGlassMap<IMenuGlassBase>
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