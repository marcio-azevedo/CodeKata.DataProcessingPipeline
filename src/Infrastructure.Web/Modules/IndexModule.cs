using Nancy;

namespace Infrastructure.Web.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get("/", args => "Hello World, it's Nancy on .NET Core");
        }
    }
}