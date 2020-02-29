using Glass.Mapper.Sc.Pipelines.AddMaps;
using KATSU.Foundation.ORM.Extensions;

namespace KATSU.Feature.Package.ORM
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("KATSU.Feature.Package");
        }
    }
}
