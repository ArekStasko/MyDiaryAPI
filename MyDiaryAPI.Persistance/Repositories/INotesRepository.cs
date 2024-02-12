using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Persistance.Repositories;

public interface INotesRepository
{
    public Task<bool> Update(INote note);
    public Task<bool> Create(INote note);
    public Task<INote> Get(int Id);
    public List<INote> Get();
}