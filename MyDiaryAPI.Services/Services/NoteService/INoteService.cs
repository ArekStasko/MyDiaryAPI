using MyDiaryAPI.Domain.Models;
using MyDiaryAPI.Services.Requests;

namespace MyDiaryAPI.Services.Services.NoteService;

public interface INoteService
{
    public Task<bool> Create(CreateNote note);
    public Task<bool> Update(UpdateNote note);
    public Task<List<INote>> Get();
    public Task<INote> GetById(int id);
    public Task<INote> GetRandom();
}