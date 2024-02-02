using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Services.Requests;

public record CreateNote
{
    public INote Note { get; set; }
}