# Template-TheAutomaTom.CleanArch.Net8.ASP
A project template for creating an ASP.NET Core application with the G# Clean Architecture implementation and standard utilities already wired up.

## Work in progress

It seems like a lot of stuff has been deprecated since the documentation I was following came out.  Last errors I ran into is: 

```
Z:\Template-TheAutomaTom.CleanArch.Net8.ASP\Source>dotnet new TheAutomaTomCleanArchNet8ASP -o Z:\Template-TheAutomaTom.CleanArch.Net8.ASP\Out\ExampleDeployment
Could not find the template package containing template 'TheAutomaTom.CleanArch.Net8.ASP'
Could not find the template package containing template 'TheAutomaTom.CleanArch.Net8.ASP'
Sequence contains more than one matching element
   at System.Linq.ThrowHelper.ThrowMoreThanOneMatchException()
   at System.Linq.Enumerable.TryGetSingle[TSource](IEnumerable`1 source, Func`2 predicate, Boolean& found)
   at System.Linq.Enumerable.Single[TSource](IEnumerable`1 source, Func`2 predicate)
   at Microsoft.TemplateEngine.Edge.Settings.TemplatePackageManager.GetTemplatePackageAsync(ITemplateInfo template, CancellationToken cancellationToken)
   at Microsoft.TemplateEngine.Cli.CliTemplateInfo.GetManagedTemplatePackageAsync(TemplatePackageManager templatePackageManager, CancellationToken cancellationToken)
   at Microsoft.TemplateEngine.Cli.TemplateInvoker.InvokeTemplateAsync(TemplateCommandArgs templateArgs, CancellationToken cancellationToken)
   at Microsoft.TemplateEngine.Cli.Commands.TemplateCommand.InvokeAsync(ParseResult parseResult, CancellationToken cancellationToken)
   at Microsoft.TemplateEngine.Cli.Commands.InstantiateCommand.HandleTemplateInstantiationAsync(InstantiateCommandArgs args, IEngineEnvironmentSettings environmentSettings, TemplatePackageManager templatePackageManager, TemplateGroup templateGroup, CancellationToken cancellationToken)
   at Microsoft.TemplateEngine.Cli.Commands.InstantiateCommand.ExecuteIntAsync(InstantiateCommandArgs instantiateArgs, IEngineEnvironmentSettings environmentSettings, TemplatePackageManager templatePackageManager, ParseResult parseResult, CancellationToken cancellationToken)
   at Microsoft.TemplateEngine.Cli.Commands.BaseCommand`1.CommandAction.InvokeAsync(ParseResult parseResult, CancellationToken cancellationToken)

For details on the exit code, refer to https://aka.ms/templating-exit-codes#70

Z:\Template-TheAutomaTom.CleanArch.Net8.ASP\Source>
```

Maybe they made Solution Templates mandatory?  I'll have to get back to it when I have more time.  For now, Notepad++ rename feature can get me by.


### Helpful commands
- Pack a new nuget from `Source` directory
    
    `
    nuget.exe pack .\TheAutomaTom.CleanArch.Net8.ASP.nuspec -OutputDirectory .\nupkg
    `
- Install the nuget from local to be able to deploy the template

    `
    dotnet new install Z:\Template-TheAutomaTom.CleanArch.Net8.ASP\Source\nupkg\TheAutomaTom.CleanArch.Net8.ASP.nuspec.0.0.1.nupkg
    `
        
- Deploy a new instance of the template

    `
    dotnet new TheAutomaTomCleanArchNet8ASP -o Z:\Template-TheAutomaTom.CleanArch.Net8.ASP\Out\ExampleDeployment
    `