using JetBrains.Annotations;
using Wom.Net.Contracts;

namespace Wom.Net;

[PublicAPI]
public interface IWiseOldManService
{
    IPlayersService Players { get; } 
}