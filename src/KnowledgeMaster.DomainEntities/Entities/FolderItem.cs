namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Folder item.
/// </summary>
public abstract class FolderItem : IndexedItem
{
    /// <summary>
    /// Folder ID.
    /// </summary>
    public int FolderId { get; set; }
}