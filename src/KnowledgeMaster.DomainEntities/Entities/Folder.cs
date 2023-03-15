using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Box's folder.
/// </summary>
public class Folder : BoxItem, IUniqueEntity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Folder"/> class.
    /// </summary>
    /// <param name="name">Folder name.</param>
    /// <param name="boxId">ID of the <see cref="Box"/> where the folder is located.</param>
    public Folder(string name, int boxId)
    {
        Name = name;
        BoxId = boxId;

        Items = new List<FolderItem>();
        NestedFolders = new List<Folder>();
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Brief description of the appointment.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Folder items. 
    /// </summary>
    public IEnumerable<FolderItem> Items { get; set; }

    /// <summary>
    /// Parent folder ID.
    /// </summary>
    public int? ParentFolderId { get; set; }

    /// <summary>
    /// Nested folders.
    /// </summary>
    public IEnumerable<Folder> NestedFolders { get; set; }
}