using Nancy;

namespace Infrastructure.Web.Modules
{
    public class BacklogModule : NancyModule
    {
        public BacklogModule() : base("/backlog")
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}

/*
    https://basecone.atlassian.net/rest/api/latest/search?jql=project=Backlog
    https://developer.atlassian.com/jiradev/jira-apis/jira-rest-apis/jira-rest-api-tutorials

    https://docs.atlassian.com/jira/REST/cloud/
    https://bitbucket.org/farmas/atlassian.net-sdk/wiki/Home
 
*/
