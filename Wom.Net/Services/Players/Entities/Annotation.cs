using Wom.Net.Services.Players.Enums;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents a player annotation.
/// </summary>
public sealed record Annotation
{
    /// <summary>The annotation's unique ID.</summary>
    public int Id { get; init; }

    /// <summary>The parent player's ID.</summary>
    public int PlayerId { get; init; }

    /// <summary>The annotation's creation date.</summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>The type of annotation.</summary>
    public PlayerAnnotation AnnotationType { get; init; }
}
