namespace KnowledgeMaster.DomainEntities.Interfaces;

/// <summary>
/// Unique entity.
/// </summary>
/// <typeparam name="TPrimaryKey">Type of primary key.</typeparam>
public interface IUniqueEntity<TPrimaryKey>
{
    /// <summary>
    /// Unique identifier (primary key).
    /// </summary>
    public TPrimaryKey Id { get; set; }
}