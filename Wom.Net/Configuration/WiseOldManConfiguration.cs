using JetBrains.Annotations;

namespace Wom.Net.Configuration;

[PublicAPI]
public class WiseOldManConfiguration
{
    public string? ApiKey { get; set; }
    public string? DiscordUsername { get; set; }
}