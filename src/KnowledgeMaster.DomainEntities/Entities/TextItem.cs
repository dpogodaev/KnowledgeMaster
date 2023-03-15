using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Text item of the answer.
/// </summary>
public class TextItem : AnswerItem, IUniqueEntity<long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TextItem"/> class.
    /// </summary>
    /// <param name="content">Text content.</param>
    /// <param name="answerId">ID of the <see cref="Answer"/> that the text is associated with.</param>
    public TextItem(string content, long answerId)
    {
        Content = content;
        AnswerId = answerId;
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Content.
    /// </summary>
    public string Content { get; set; }
}