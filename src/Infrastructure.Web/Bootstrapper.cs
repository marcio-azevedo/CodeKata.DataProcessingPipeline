using System;
using Domain.Logging;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Infrastructure.Web
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected readonly ILogger Logger;

        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper
        
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            pipelines.OnError.AddItemToEndOfPipeline(OnError);

            // ToDo: https://github.com/NancyFx/Nancy/wiki/Authentication-overview
            //pipelines.BeforeRequest.AddItemToStartOfPipeline(ValidateAuthentication);
        }

        // https://github.com/NancyFx/Nancy/wiki/Authentication-overview
        //private Task<Response> ValidateAuthentication(NancyContext context, CancellationToken token)
        //{
        //    var response = new HtmlResponse(HttpStatusCode.Unauthorized);
        //    //var username = context.Request.Headers;

        //    return new Task<Response>(() => response);
        //}

        private dynamic OnError(NancyContext nancyContext, Exception exception)
        {
            // https://github.com/NancyFx/Nancy/wiki/The-Application-Before%2C-After-and-OnError-pipelines
            Logger.Fatal($"Error on method: {nancyContext.Request.Method}");
            Logger.Fatal(exception);

            return null;
        }
    }
}