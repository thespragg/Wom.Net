namespace Wom.Net.Services.Players.Entities;


/// <summary>
/// Represents a player's archive with associated player information.
/// </summary>
public sealed record PlayerArchiveWithPlayer : PlayerArchive
{
    /// <summary>The player associated with the archive.</summary>
    public Player Player { get; init; }
}