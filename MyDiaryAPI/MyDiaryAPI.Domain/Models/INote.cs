namespace MyDiaryAPI.Domain.Models;

public interface INote
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
}