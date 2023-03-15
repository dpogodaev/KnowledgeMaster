using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Knowledge box.
/// It is the main entity of the application.
/// </summary>
public class Box : IUniqueEntity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Box"/> class.
    /// </summary>
    /// <param name="name">Name of the knowledge box.</param>
    public Box(string name)
    {
        Name = name;

        Items = new List<BoxItem>();
        AvailableTags = new List<Tag>();
    }

    #region IUniqueEntity

    /// <inheritdoc cref="IUniqueEntity{TPrimaryKey}.Id"/>
    public int Id { get; set; }

    #endregion

    /// <summary>
    /// Box name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Brief description of the appointment.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// List of box items.
    /// </summary>
    public IEnumerable<BoxItem> Items { get; set; }

    /// <summary>
    /// List of available tags.
    /// </summary>
    public IEnumerable<Tag> AvailableTags { get; set; }

    //TODO: project
}