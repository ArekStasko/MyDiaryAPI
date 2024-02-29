using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Services.Requests;

public record UpdateNote
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
};