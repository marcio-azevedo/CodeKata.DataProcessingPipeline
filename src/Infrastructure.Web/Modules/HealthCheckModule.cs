using Domain.Logging;
using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    public class HealthCheckModule : NancyModule
    {
        public HealthCheckModule(ILogger logger) : base("/healthcheck")
        {
            this.RequiresAuthentication();

            Get["/"] = parameters => "Hello World";
        }
    }
}