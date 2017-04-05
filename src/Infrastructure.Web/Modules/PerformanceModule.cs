using Domain.Logging;
using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    public class PerformanceModule : NancyModule
    {
        public PerformanceModule(ILogger logger) : base("/performance")
        {
            this.RequiresAuthentication();

            Get["/"] = parameters => "Hello World";
        }
    }
}
