using Glass.Mapper.Sc.Pipelines.AddMaps;
using PSGN.Foundation.ORM.Extensions;

namespace PSGN.Feature.PageContent.ORM
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("PSGN.Feature.PageContent");
        }
    }
}
