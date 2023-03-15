namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Item of the answer to the question.
/// </summary>
public abstract class AnswerItem : IndexedItem
{
    /// <summary>
    /// Answer ID.
    /// </summary>
    public long AnswerId { get; set; }

    /// <summary>
    /// Link to the book.
    /// </summary>
    public BookLink? BookLink { get; set; }

    /// <summary>
    /// Link to the publication.
    /// </summary>
    public Publication? Publication { get; set; }

    /// <summary>
    /// Link to the discussion.
    /// </summary>
    public Discussion? Discussion { get; set; }
}