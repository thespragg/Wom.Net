using Wom.Net.Contracts;
using Wom.Net.Services.Players;

namespace Wom.Net;

internal class WiseOldManService(HttpClient httpClient) : IWiseOldManService
{
    public IPlayersService Players { get; } = new PlayersService(httpClient);
}