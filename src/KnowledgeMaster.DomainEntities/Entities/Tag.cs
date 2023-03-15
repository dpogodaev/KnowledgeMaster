using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Box's tag.
/// </summary>
public class Tag : IUniqueEntity<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Tag"/> class.
    /// </summary>
    /// <param name="name">Tag name.</param>
    /// <param name="boxId">ID of the <see cref="Box"/> to which this tag relates.</param>
    public Tag(string name, int boxId)
    {
        Name = name;
        BoxId = boxId;
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Box ID.
    /// </summary>
    public int BoxId { get; set; }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description.
    /// </summary>
    public string? Description { get; set; }
}