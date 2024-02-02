using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Services.Requests;

public record UpdateNote
{
    public INote Note { get; set; }
};