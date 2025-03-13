using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Enums;


/// <summary>
/// Represents the build or specialization of a player account.
/// </summary>
[PublicAPI]
public enum PlayerBuild
{
    /// <summary>Main account build.</summary>
    Main,
    /// <summary>Free-to-play account build.</summary>
    F2P,
    /// <summary>Level 3 account build.</summary>
    Lvl3,
    /// <summary>Zerker account build.</summary>
    Zerker,
    /// <summary>Defense level 1 account build.</summary>
    Def1,
    /// <summary>10 Hitpoints account build.</summary>
    Hp10,
    /// <summary>Free-to-play level 3 account build.</summary>
    F2pLvl3
}