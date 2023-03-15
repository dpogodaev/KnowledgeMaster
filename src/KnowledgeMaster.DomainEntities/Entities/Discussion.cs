using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Discussion with persons.
/// </summary>
public class Discussion : IUniqueEntity<Guid>
{
    public Discussion(string title)
    {
        Title = title;
        Panelists = new List<Person>();
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
    /// Panelists.
    /// </summary>
    public IEnumerable<Person> Panelists { get; set; }
}