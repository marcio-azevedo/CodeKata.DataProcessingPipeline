using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    // check https://github.com/NancyFx/Nancy/wiki/Exploring-the-nancy-module
    public class ReleasesModule : NancyModule
    {
        public ReleasesModule() : base("/releases")
        {
            this.RequiresAuthentication();

            Get["/"] = parameters => "Hello World";
        }
    }
}