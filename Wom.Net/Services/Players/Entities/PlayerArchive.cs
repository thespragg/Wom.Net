using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a player's archive information.
/// </summary>
[PublicAPI]
public record PlayerArchive
{
    /// <summary>The parent player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The player's previous username before archival.</summary>
    public string PreviousUsername { get; init; } = null!;

    /// <summary>The player's placeholder username after archival.</summary>
    public string ArchiveUsername { get; init; } = null!;

    /// <summary>The player's new username after restoration.</summary>
    public string? RestoredUsername { get; init; }

    /// <summary>The archive's creation date.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The archive's restoration date.</summary>
    public DateTime? RestoredAt { get; init; }
}
