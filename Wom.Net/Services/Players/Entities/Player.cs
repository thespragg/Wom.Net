using System.Text.Json.Serialization;
using JetBrains.Annotations;
using Wom.Net.Services.Players.Enums;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a player.
/// </summary>
[PublicAPI]
public sealed record Player
{
    /// <summary>The player's unique ID.</summary>
    public int Id { get; init; }

    /// <summary>The player's username (lowercase, 1-12 characters).</summary>
    public required string Username { get; init; }

    /// <summary>The player's display name (1-12 characters, supports capitalization).</summary>
    public required string DisplayName { get; init; }

    /// <summary>The player's account type.</summary>
    public PlayerType Type { get; init; } = PlayerType.Unknown;

    /// <summary>The player's account build.</summary>
    public PlayerBuild Build { get; init; } = PlayerBuild.Main;

    /// <summary>The player's country of origin.</summary>
    public Country? Country { get; init; }

    /// <summary>The player's account status.</summary>
    public PlayerStatus Status { get; init; } = PlayerStatus.Active;

    /// <summary>The player's patronage status (Patreon subscription).</summary>
    public bool Patron { get; init; }

    /// <summary>The player's overall experience.</summary>
    public long Exp { get; init; }

    /// <summary>The player's Efficient Hours Played (EHP).</summary>
    public float Ehp { get; init; }

    /// <summary>The player's Efficient Hours Bossed (EHB).</summary>
    public float Ehb { get; init; }

    /// <summary>The player's Time to Max (all 99s) in hours.</summary>
    public float Ttm { get; init; }

    /// <summary>The player's Time to 200m All in hours.</summary>
    public float Ttm200M { get; init; }

    /// <summary>The player's registration date.</summary>
    public DateTime RegisteredAt { get; init; }

    /// <summary>The player's last successful update date.</summary>
    public DateTime? UpdatedAt { get; init; }

    /// <summary>The player's last change date (e.g., gained exp, kills).</summary>
    public DateTime? LastChangedAt { get; init; }

    /// <summary>The date of the last CML history import.</summary>
    public DateTime? LastImportedAt { get; init; }
}