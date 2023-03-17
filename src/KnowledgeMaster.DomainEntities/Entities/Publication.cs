using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Publication.
/// </summary>
public class Publication : IUniqueEntity<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Publication"/> class.
    /// </summary>
    /// <param name="title">Title of the publication.</param>
    /// <param name="url">The URL of the publication.</param>
    public Publication(string title, string url)
    {
        Title = title;
        Url = url;

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
    /// URL.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Text.
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Authors.
    /// </summary>
    public IEnumerable<Person> Authors { get; set; }
}