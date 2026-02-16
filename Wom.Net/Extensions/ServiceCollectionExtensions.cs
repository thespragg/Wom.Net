using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Wom.Net.Configuration;
using Wom.Net.Handlers;

namespace Wom.Net.Extensions;

[PublicAPI]
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWiseOldMan(
        this IServiceCollection services,
        Action<WiseOldManConfiguration>? configure = null
    )
    {
        var config = new WiseOldManConfiguration();
        configure?.Invoke(config);

        var maxRequestsPerMinute = string.IsNullOrEmpty(config.ApiKey) ? 20 : 100;
        services.AddSingleton(sp => new RateLimitingHandler(maxRequestsPerMinute, sp.GetRequiredService<ILoggerFactory>().CreateLogger<RateLimitingHandler>()));

        services.AddHttpClient<IWiseOldManService, WiseOldManService>((sp, client) =>
            {
                var logger = sp.GetRequiredService<ILogger<WiseOldManService>>();
                client.BaseAddress = new Uri("https://api.wiseoldman.net/v2/");

                if (!string.IsNullOrEmpty(config.ApiKey))
                    client.DefaultRequestHeaders.Add("x-api-key", config.ApiKey);

                if (!string.IsNullOrEmpty(config.DiscordUsername))
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(config.DiscordUsername);
            })
            .AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(1, _ => TimeSpan.FromSeconds(2)))
            .AddHttpMessageHandler(sp => sp.GetRequiredService<RateLimitingHandler>());

        return services;
    }
}