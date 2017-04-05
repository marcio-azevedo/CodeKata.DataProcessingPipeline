# Data Processing Pipeline #
A code kata to exemplify the use of [Onion Architecture structure](https://www.infoq.com/news/2014/10/ddd-onion-architecture).

### The Problem ###

You have a system that integrates with 3rd-party systems (through APIs) and from an User perspective he can 
change data on their system / application and should be updated also on yours. This requires background 
synchronization to ensure that data is up to date in both systems (assuming that 3rd-party system API allows 
that). You can easily build services to do that but you want it to be (horizontally) scalable in terms of 
processing capacity, ensuring the minimal complexity needed in your code base (keep in mind that you can 
integrate hundreds or even thousands of systems).
So, assuming that we have an [Onion Architecture structure](https://www.infoq.com/news/2014/10/ddd-onion-architecture) 
approach on our application, we should expect "only" to have a new client consumer per new 3rd-party system, 
that will translate the data into our Domain and then just use our Application layer to import / update 
data. Because you depend on 3rd-party systems API to sync it might be a good thing to have health and 
performance monitoring, to allow checking:
- if 3rd-party APIs are up or down;
- if you have problems on any of your data processing pipeline infrastructure components;
- detailed errors that occur while processing data.

### The Vision ###
Provide an easy-to-setup data processing pipeline that addresses the problem, enables horizontal scaling 
and offers additional tools (web) for integration, healthcheck and performance monitoring, being decoupled 
from actual dependencies at the same time.

### How to contribute? ###
Please check [Up for Grabs](https://github.com/marcio-azevedo/CodeKata.DataProcessingPipeline/projects/1) 
and start contributing!

Frameworks / Tools used:
* [NancyFx](http://nancyfx.org/) - "_...lightweight, low-ceremony, framework for building HTTP based services on .NET and Mono._"
* [NUnit](https://www.nunit.org/) - unit-testing framework for .NET (to enable integration with Visual Studio, make sure the [plugin](https://github.com/nunit/docs/wiki/Visual-Studio-Test-Adapter) is installed).
* [Moq](https://github.com/Moq/moq4) - mocking framework for .NET.
* [NLog](http://nlog-project.org/) - NLog is a free logging platform for .NET
* [AutoMoq](https://github.com/darrencauthon/AutoMoq) - an "auto-mocking" container that creates objects for you.
* [FluentMigrator](https://github.com/schambers/fluentmigrator) - a migration framework for .NET.
* [StructureMap](http://structuremap.github.io/) - IoC/DI container for .NET.
* [NHibernate](http://nhibernate.info/) - open source object-relational mapper for the .NET framework.
* [AutoMapper](http://automapper.org/) - a convention-based object-object mapper.
* [BenchmarkDotNet](http://benchmarkdotnet.org/) - .NET library for benchmarking.
* [Nancy.Swagger](https://github.com/yahehe/Nancy.Swagger) - Nancy Swagger plugin (alternative to [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) for ASP.NET Web API).
 
