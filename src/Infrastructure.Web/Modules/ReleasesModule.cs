using Nancy;

namespace Infrastructure.Web.Modules
{
    // check https://github.com/NancyFx/Nancy/wiki/Exploring-the-nancy-module
    public class ReleasesModule : NancyModule
    {
        public ReleasesModule() : base("/releases")
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}