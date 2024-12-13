namespace Azure.AISearch.WebApp.Models;

public class Document
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? FilePath { get; set; }
    // mjh
    public string? DataSource { get; set; }
    public string? DataSet { get; set; }
    public string? SourceUrl { get; set; }
    public string? Author { get; set; }
    public string? Type { get; set; }
    public DateTimeOffset? PublishDate { get; set; }
}