using KnowledgeMaster.DomainEntities.Enums;
using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Book.
/// </summary>
public class Book : IUniqueEntity<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Book"/> class.
    /// </summary>
    /// <param name="title">Title of the book.</param>
    /// <param name="language">The language of the book's publication.</param>
    public Book(string title, LanguageType language)
    {
        Title = title;
        Language = language;

        Authors = new List<Person>();
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Publication date.
    /// </summary>
    public DateTime? PublicationDate { get; set; }

    /// <summary>
    /// List of authors.
    /// </summary>
    public IEnumerable<Person> Authors { get; set; }

    /// <summary>
    /// Language.
    /// </summary>
    public LanguageType Language { get; set; }

    /// <summary>
    /// Number of pages.
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// Publication number.
    /// </summary>
    public int? Edition { get; set; }

    /// <summary>
    /// Reviews.
    /// </summary>
    public ICollection<Review> Reviews { get; set; }
}