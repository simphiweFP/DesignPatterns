using System.Data;
using System.Drawing;
using DesignsPattern.Creatinal.AbstractFactory;
using DesignsPattern.Creatinal.FactoryMethod;
using DesignsPattern.Creatinal.Builder;
using DesignsPattern.Creatinal.Prototype;
using DesignsPattern.Creatinal.Singleton;
using DesignsPattern.Utils.Display;
using Spectre.Console;
using Rule = Spectre.Console.Rule;
using Color = Spectre.Console.Color;
using DesignsPattern.Structural.Adapter;

MainTitle();

// Loading
AnsiConsole.Status()
    .Start("Loading...", ctx =>
    {
        Thread.Sleep(1500);

        ctx.Status("Sim Learning");
        ctx.Spinner(Spinner.Known.Star);
        ctx.SpinnerStyle(Style.Parse("green"));

        AnsiConsole.MarkupLine("Loading...");
        Thread.Sleep(2000);
    });

var exit = false;

while (!exit)
{
    Console.Clear();

    MainTitle();

    // Design Pattern rule
    var designpatternRule = new Rule("[red]typical solutions to common problems[/]");
    designpatternRule.Justification = Justify.Center;
    AnsiConsole.Write(designpatternRule);

    var choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Please choose pattern to run:")
            .PageSize(10)
            .AddChoices(new[] {
                "Creational Pattern", "Structural Pattern", "Behavioral Pattern", "Exit"
            }));

    switch (choice)
    {
        
        case "Creational Pattern":
            HandleCreationalPattern();
            break;
        case "Structural Pattern":
            HandleStructuralPattern();
            break;
        case "Behavioral Pattern":
            HandleStructuralPattern();
            break;
        case "Exit":
            exit = true;
            break;
        default:
            AnsiConsole.Markup("[red]Invalid option, please try again.[/]");
            break;
    }
}

void HandleCreationalPattern()
{
    var creationalExit = false;
    while (!creationalExit)
    {
        Console.Clear();

        MainTitle();

        // Decorator rule
        var creationalRule = new Rule("[yellow]Creational[/]");
        creationalRule.Justification = Justify.Center;
        AnsiConsole.Write(creationalRule);

        var creationalChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose an option:")
                .PageSize(10)
                .AddChoices(new[] {
                "Factory Method", "Abstract Factory", "Builder", "Prototype", "Singleton", "Decorator", "Exit"
                }));

        switch (creationalChoice)
        {
            case "Factory Method":
                RunFactoryMethod();
                break;
            case "Abstract Factory":
                RunAbstractFactory();
                break;
            case "Builder":
                RunBuilderFactory();
                break;
            case "Prototype":
                RunPrototypeFactory();
                break;
            case "Singleton":
                RunSingletonFactory();
                break;
            case "Exit":
                creationalExit = true;
                break;
            default:
                AnsiConsole.Markup("[red]Invalid option, please try again.[/]");
                break;
        }
    }
}

void HandleStructuralPattern()
{
    var structuralExit = false;
    while (!structuralExit)
    {
        Console.Clear();

        MainTitle();

        // Structural rule
        var structuralRule = new Rule("[blue]Structural[/]");
        structuralRule.Justification = Justify.Center;
        AnsiConsole.Write(structuralRule);

        var structuralChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose an option:")
                .PageSize(10)
                .AddChoices(new[] {
                 "Adapter", "Bridge", "Composite", "Decorator", "Facade", "Proxy", "Back"
                }));

        switch (structuralChoice)
        {
            case "Adapter":
                RunAdapter();
                break;
            case "Bridge":
                //RunBridge();
                break;
            case "Composite":
                //RunComposite();
                break;
            case "Decorator":
                //RunDecorator();
                break;
            case "Facade":
                //RunFacade();
                break;
            case "Proxy":
                //RunProxy();
                break;
            case "Back":
                structuralExit = true;
                break;
            default:
                AnsiConsole.Markup("[red]Invalid option, please try again.[/]");
                break;
        }
    }
}

void RunFactoryMethod()
{
    var runFactoryMethodExample = new FactoryMethod(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var policyType = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose type of insurance policy:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Health", "Life", "Vehicle", "Back"
                }));
        if (!string.IsNullOrEmpty(policyType))
        {
            if (policyType.ToLower() == "back")
            {
                exit = true;
                break;
            }
            runFactoryMethodExample.Run(policyType);
        }
    }
}

void RunAbstractFactory()
{
    var abstractFactory = new AbstractFactory(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose type of insurance policy:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Individual", "Corporate", "Back"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "back")
            {
                exit = true;
                break;
            }
            abstractFactory.Run(option);
        }
    }
}

void RunBuilderFactory()
{
    var builder = new Builder(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose type of insurance policy:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Comprehensive", "Basic", "Back"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "back")
            {
                exit = true;
                break;
            }
            builder.Run(option);
        }
    }
}

void RunPrototypeFactory()
{
    var prototype = new Prototype(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose option:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Start", "Back"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "back")
            {
                exit = true;
                break;
            }
            prototype.Run();
        }
    }
}

void RunSingletonFactory()
{
    var singleton = new Singleton(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose option:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Start", "Back"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "back")
            {
                exit = true;
                break;
            }
            singleton.Run();
        }
    }
}
void RunAdapter()
{
    var adapter = new Adapter(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose option:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Search Person Details", "Back"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "back")
            {
                exit = true;
                break;
            }
            adapter.Run(option);
        }
    }
}

AnsiConsole.Markup("[green]See you soon. Goodbye![/]");

void MainTitle()
{
    AnsiConsole.Write(
        new FigletText("Design Patterns")
            .Centered()
            .Color(Color.Cyan1));
}
