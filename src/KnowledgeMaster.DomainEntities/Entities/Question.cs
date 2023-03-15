using KnowledgeMaster.DomainEntities.Enums;
using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// Statement of the question.
/// </summary>
public class Question : DocumentItem, IUniqueEntity<long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Question"/> class.
    /// </summary>
    /// <param name="statement">Statement of the question.</param>
    /// <param name="usageType">Question usage type.</param>
    /// <param name="documentId">ID of the <see cref="Document"/> to which this question relates.</param>
    public Question(string statement, UsageType usageType, long documentId)
    {
        Statement = statement;
        UsageType = usageType;
        DocumentId = documentId;

        Tags = new List<Tag>();
        Answers = new List<Answer>();
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Statement.
    /// </summary>
    public string Statement { get; set; }

    /// <summary>
    /// Usage type.
    /// </summary>
    public UsageType UsageType { get; set; }

    /// <summary>
    /// List of answers.
    /// </summary>
    public IEnumerable<Answer> Answers { get; set; }

    /// <summary>
    /// A list of related tags.
    /// </summary>
    public IEnumerable<Tag> Tags { get; set; }
}