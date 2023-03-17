using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Book review.
/// </summary>
public class Review : IUniqueEntity<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Review"/> class.
    /// </summary>
    /// <param name="starsNumber">Number of stars (from one to five).</param>
    /// <param name="bookId">ID of the <see cref="Book"/> to which this review relates.</param>
    public Review(int starsNumber, Guid bookId)
    {
        BookId = bookId;
        StarsNumber = starsNumber;
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Box ID.
    /// </summary>
    public Guid BookId { get; set; }

    /// <summary>
    /// Number of stars.
    /// </summary>
    public int StarsNumber { get; set; }

    /// <summary>
    /// Comment.
    /// </summary>
    public string? Comment { get; set; }