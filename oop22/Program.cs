using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
public interface IGreetingService
{
    void Greet(string name);
}
public class GreetingService : IGreetingService
{
    public void Greet(string name)
    {
        Console.WriteLine($"Привіт, {name}!");
    }
}
public class App : IHostedService
{
    private readonly IGreetingService _greetingService;

    public App(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.Write("Введіть ім’я: ");
        var name = Console.ReadLine();
        _greetingService.Greet(name);
        return Task.CompletedTask;
    }
    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Програма завершила роботу.");
        return Task.CompletedTask;
    }
}
class Program
{
    static async Task Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IGreetingService, GreetingService>();
                services.AddHostedService<App>();
            })
            .Build();

        await host.RunAsync();
    }
}
