namespace MyDiaryAPI.Domain.DTO;

public record NoteDto
{
    public string Title { get; set; }
    public string Content { get; set; }
}