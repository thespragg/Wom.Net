using JetBrains.Annotations;
using Wom.Net.Services.NameChanges.Enums;

namespace Wom.Net.Services.NameChanges.Entities;

/// <summary>
/// Represents a name change request for a player.
/// </summary>
[PublicAPI]
public sealed record NameChange
{
    /// <summary>The name change's unique ID.</summary>
    public int Id { get; init; }

    /// <summary>The name change's parent player ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The player's "previous" username.</summary>
    public string OldName { get; init; } = null!;

    /// <summary>The player's "new" username.</summary>
    public string NewName { get; init; } = null!;

    /// <summary>The name change's status.</summary>
    public NameChangeStatus Status { get; init; }

    /// <summary>The name change's reason to have been denied or skipped during auto-review.</summary>
    public ReviewContext? ReviewContext { get; init; }

    /// <summary>The date at which the name change has been approved/denied.</summary>
    public DateTime? ResolvedAt { get; init; }

    /// <summary>The date at which the name change was last modified.</summary>
    public DateTime UpdatedAt { get; init; }

    /// <summary>The date at which the name change was submitted.</summary>
    public DateTime CreatedAt { get; init; }
}