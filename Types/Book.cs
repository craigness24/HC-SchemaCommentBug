namespace SchemaCommentBug.Types;

/// <summary>
/// Book comment
/// </summary>
public record Book
{
    /// <summary>
    /// Title comment
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// Author comment
    /// </summary>
    public required Author Author { get; init; }
}