using Nancy;

namespace Infrastructure.Web.Modules
{
    // check https://github.com/octokit/octokit.net
    public class CodeRepositoryModule : NancyModule
    {
        public CodeRepositoryModule() : base("/code")
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}