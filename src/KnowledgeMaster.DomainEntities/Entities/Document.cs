using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Folder's document.
/// </summary>
public class Document : FolderItem, IUniqueEntity<long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Document"/> class.
    /// </summary>
    /// <param name="title">Document title.</param>
    /// <param name="folderId">ID of the <see cref="Folder"/> where the document is located.</param>
    public Document(string title, int folderId)
    {
        Title = title;
        FolderId = folderId;

        Items = new List<DocumentItem>();
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// List of items.
    /// </summary>
    public IEnumerable<DocumentItem> Items { get; set; }
}