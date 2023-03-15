namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Knowledge box item.
/// </summary>
public abstract class BoxItem : IndexedItem
{
    /// <summary>
    /// Box ID.
    /// </summary>
    public int BoxId { get; set; }
}