using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a player snapshot.
/// </summary>
[PublicAPI]
public sealed record Snapshot
{
    /// <summary>The snapshot's unique ID.</summary>
    public int Id { get; init; }

    /// <summary>The parent player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The snapshot's creation date.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The date the snapshot was imported.</summary>
    public DateTime? ImportedAt { get; init; }

    /// <summary>The snapshot's data values.</summary>
    public SnapshotDataValues Data { get; init; } = null!;
}