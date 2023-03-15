using KnowledgeMaster.DomainEntities.Interfaces;

namespace KnowledgeMaster.DomainEntities.Entities;

/// <summary>
/// The answer to the question posed.
/// </summary>
public class Answer : IUniqueEntity<long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Answer"/> class.
    /// </summary>
    /// <param name="questionId">ID of the <see cref="Question"/> to which the answer is given.</param>
    public Answer(long questionId)
    {
        QuestionId = questionId;

        Items = new List<AnswerItem>();
    }

    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Question ID.
    /// </summary>
    public long QuestionId { get; set; }

    /// <summary>
    /// Title or short name.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Answer items.
    /// </summary>
    public IEnumerable<AnswerItem> Items { get; set; }
}