using Nancy;

namespace Infrastructure.Web.Modules
{
    public class ReleasesModule : NancyModule
    {
        public ReleasesModule() : base("/releases")
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}