namespace SchemaCommentBug.Types;

[QueryType]
public static class Query
{
    /// <summary>
    /// Get one book
    /// </summary>
    /// <returns>Book</returns>
    public static Book GetBook() => new()
    {
        Title = "C# in depth.",
        Author = new Author("Jon Skeet")
    };
}

[ExtendObjectType<Book>]
public class BookExtensions
{
    /// <summary>
    /// Uppercased author name
    /// </summary>
    /// <param name="book"></param>
    /// <returns></returns>
    [GraphQLName("author")]
    public string UppercaseAuthor([Parent] Book book) => book.Author.Name.ToUpper();
}