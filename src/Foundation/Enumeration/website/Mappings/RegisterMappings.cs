using Glass.Mapper.Sc.Pipelines.AddMaps;
using KATSU.Foundation.ORM.Extensions;

namespace KATSU.Foundation.Enumeration.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("KATSU.Foundation.Enumeration");
        }
    }
}
