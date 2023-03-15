using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Link to the book.
/// </summary>
public class BookLink : IUniqueEntity<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BookLink"/> class.
    /// </summary>
    /// <param name="bookId">ID of the linked <see cref="Book"/>.</param>
    /// <param name="pageNumber">Book page number.</param>
    public BookLink(Guid bookId, int pageNumber)
    {
        BookId = bookId;
        PageNumber = pageNumber;
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Book.
    /// </summary>
    public Guid BookId { get; set; }

    /// <summary>
    /// Page number.
    /// </summary>
    public int PageNumber { get; set; }
}