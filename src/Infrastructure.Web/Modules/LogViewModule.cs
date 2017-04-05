using Domain.Logging;
using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    public class LogViewModule : NancyModule
    {
        public LogViewModule(ILogger logger) : base("/logview")
        {
            this.RequiresAuthentication();

            Get["/"] = parameters => "Hello World";
        }
    }
}