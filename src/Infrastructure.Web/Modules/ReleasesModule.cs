using Domain.Logging;
using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    // check https://github.com/NancyFx/Nancy/wiki/Exploring-the-nancy-module
    public class ReleasesModule : NancyModule
    {
        public ReleasesModule(ILogger logger) : base("/releases")
        {
            this.RequiresAuthentication();

            logger.Debug("Get Releases");

            Get["/"] = parameters => "Hello World";
        }
    }
}