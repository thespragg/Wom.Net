using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Wom.Net.Configuration;

namespace Wom.Net.Extensions;

[PublicAPI]
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWiseOldMan(
        this IServiceCollection services,
        Action<WiseOldManConfiguration>? configure = default
    )
    {
        var config = new WiseOldManConfiguration();
        configure?.Invoke(config);

        services.AddHttpClient<IWiseOldManService, WiseOldManService>(client =>
            {
                client.BaseAddress = new Uri("https://api.wiseoldman.net/v2/");
                
                if (!string.IsNullOrEmpty(config.ApiKey)) 
                    client.DefaultRequestHeaders.Add("x-api-key", config.ApiKey);
                
                if (!string.IsNullOrEmpty(config.DiscordUsername))
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(config.DiscordUsername);
            })
            .AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(1, _ => TimeSpan.FromSeconds(2)));

        return services;
    }
}