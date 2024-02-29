namespace MyDiaryAPI.Domain.Models;

public record Note : INote
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
}