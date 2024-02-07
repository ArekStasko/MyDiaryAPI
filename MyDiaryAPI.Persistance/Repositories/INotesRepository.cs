using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Persistance.Repositories;

public interface INotesRepository
{
    public Task<bool> Update();
    public Task<bool> Create();
    public Task<INote> Get(int Id);
    public Task<List<INote>> Get();
}