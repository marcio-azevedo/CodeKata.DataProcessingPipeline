# Release Audit Tool #
A code kata to exemplify the use of [Onion Architecture structure](https://www.infoq.com/news/2014/10/ddd-onion-architecture).

Frameworks used:
* [NancyFx](http://nancyfx.org/) - [How to use NancyFx with DotNet Core](https://www.hanselman.com/blog/ExploringAMinimalWebAPIWithNETCoreAndNancyFX.aspx)


### The Problem ###
A team adopted a specfic workflow to guide the status of their User Stories (US) in each Sprint (ex: ToDo, Developing, Reviewing, Testing, Accepted, Done). 
Each time an US gets _Done_ is ready to Release, and, because the team uses a [Gitflow](https://www.atlassian.com/git/tutorials/comparing-workflows#gitflow-workflow) approach 
(with [feature branches](http://nvie.com/posts/a-successful-git-branching-model/)), the code (related to the US) should be merged into _develop_ branch.

The release to production typically occurs every week, so, by that time, the team needs to ensure that:
- all finished US (status = Done) are merged into develop branch;
- all Pull Requests (PR) related to that US are closed and merged;
- US should be _tagged_ with the version of the release;
- all HandOver (HO) notes, if any, should be added to the Release log;
- all changes regarding the application that need manual intervention or oversee (like settings, configurations, database schema updates, ...) should be verified in the UAT and Live environments;
- an internal email with the release notes should announce all teams of the next release, and include the details of the release (time, executors, etc).

These are just some of the constant and manual work needed to be done before each release that depending of each case (and tools) can be somehow complex and permissive to errors.
If, for example, the team uses 4 different tools for: Scrum board (User Story's information and status), Code repositories, Deploy Automation and Wiki, the ammount of work increases, as 
well as the risk of making mistakes.

### The Vision ###
Create a tool that addresses the problems enumered above, to allow verifying all the information in a centralized tool to audit all the 
mentioned processes and, if possible, even automation.