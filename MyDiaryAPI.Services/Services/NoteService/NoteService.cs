using MyDiaryAPI.Domain.Models;
using MyDiaryAPI.Persistance.Repositories;
using MyDiaryAPI.Services.Requests;

namespace MyDiaryAPI.Services.Services.NoteService;

public class NoteService : INoteService
{
    private INotesRepository _repository;
    public NoteService(INotesRepository repository)
    {
        repository = _repository;
    }
    public Task<bool> Create(CreateNote Note)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task<bool> Update(UpdateNote Note)
    {
        try
        {
            //var result = _repository.
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task<List<INote>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<INote> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<INote> GetRandom()
    {
        throw new NotImplementedException();
    }
}