using Microsoft.Extensions.Logging;
using Wom.Net.Contracts;
using Wom.Net.Services.Players;

namespace Wom.Net;

internal class WiseOldManService(HttpClient httpClient, ILoggerFactory loggerFactory) : IWiseOldManService
{
    public IPlayersService Players { get; } = new PlayersService(httpClient, loggerFactory.CreateLogger<PlayersService>());
}