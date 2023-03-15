using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Person.
/// </summary>
public class Person : IUniqueEntity<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="name">Name of the person.</param>
    public Person(string name)
    {
        Name = name;

        Books = new List<Book>();
        Publications = new List<Publication>();
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Name. 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Year of birth.
    /// </summary>
    public int? BirthYear { get; set; }

    /// <summary>
    /// Brief biography.
    /// </summary>
    public string? Biography { get; set; }

    /// <summary>
    /// List of books.
    /// </summary>
    public IEnumerable<Book> Books { get; set; }

    /// <summary>
    /// List of publications.
    /// </summary>
    public IEnumerable<Publication> Publications { get; set; }
}