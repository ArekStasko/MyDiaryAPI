using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Services.Requests;

public record CreateNote
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
}