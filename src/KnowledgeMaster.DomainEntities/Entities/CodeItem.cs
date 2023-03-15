using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Code item of the answer.
/// </summary>
public class CodeItem : AnswerItem, IUniqueEntity<long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CodeItem"/> class.
    /// </summary>
    /// <param name="content">Code snippet.</param>
    /// <param name="answerId">ID of the <see cref="Answer"/> that the code is associated with.</param>
    public CodeItem(string content, long answerId)
    {
        Content = content;
        AnswerId = answerId;
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Code snippet.
    /// </summary>
    public string Content { get; set; }
}