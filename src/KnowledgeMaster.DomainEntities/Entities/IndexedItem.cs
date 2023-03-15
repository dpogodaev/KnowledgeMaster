namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Indexed item.
/// </summary>
public abstract class IndexedItem
{
    /// <summary>
    /// Sequence number.
    /// </summary>
    public int Index { get; set; }
}