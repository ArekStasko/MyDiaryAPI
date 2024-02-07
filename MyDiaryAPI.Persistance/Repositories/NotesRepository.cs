using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Persistance.Repositories;

public class NotesRepository : INotesRepository
{
    public Task<bool> Update()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Create()
    {
        throw new NotImplementedException();
    }

    public Task<INote> Get(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<INote>> Get()
    {
        throw new NotImplementedException();
    }
}