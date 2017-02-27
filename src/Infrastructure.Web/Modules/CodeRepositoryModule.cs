using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    // check https://github.com/octokit/octokit.net
    public class CodeRepositoryModule : NancyModule
    {
        public CodeRepositoryModule() : base("/code")
        {
            this.RequiresAuthentication();

            Get["/"] = parameters => "Hello World";
        }
    }
}