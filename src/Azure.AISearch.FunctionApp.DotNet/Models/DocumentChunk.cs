namespace Azure.AISearch.FunctionApp.Models;

public class DocumentChunk
{
    public string? Id { get; set; }
    public string? Content { get; set; }
    public IReadOnlyList<float>? ContentVector { get; set; }
    public string? SourceDocumentId { get; set; }
    public string? SourceDocumentTitle { get; set; }
    public string? SourceDocumentFilePath { get; set; }
    // mjh
    public string? SourceDocumentDataSource { get; set; }
    public string? SourceDocumentDataSet { get; set; }
    public string? SourceDocumentSourceUrl { get; set; }
    public string? SourceDocumentAuthor { get; set; }
    public string? SourceDocumentType { get; set; }
    public DateTimeOffset? SourceDocumentPublishDate { get; set; }

}