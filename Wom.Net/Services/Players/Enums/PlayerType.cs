using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Enums;

/// <summary>
/// Represents the type of player account.
/// </summary>
[PublicAPI]
public enum PlayerType
{
    /// <summary>Unknown player type.</summary>
    Unknown,
    /// <summary>Regular player account.</summary>
    Regular,
    /// <summary>Ironman player account.</summary>
    Ironman,
    /// <summary>Hardcore player account.</summary>
    Hardcore,
    /// <summary>Ultimate player account.</summary>
    Ultimate
}