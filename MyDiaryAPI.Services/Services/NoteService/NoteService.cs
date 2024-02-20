using AutoMapper;
using Microsoft.Extensions.Logging;
using MyDiaryAPI.Domain.Models;
using MyDiaryAPI.Persistance.Repositories;
using MyDiaryAPI.Services.Requests;

namespace MyDiaryAPI.Services.Services.NoteService;

public class NoteService : INoteService
{
    private readonly INotesRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<INoteService> _logger;
    static Random rnd = new Random();
    public NoteService(INotesRepository repository)
    {
        repository = _repository;
    }
    public async Task<bool> Create(CreateNote Note)
    {
        try
        {
            var noteToUpdate = _mapper.Map<CreateNote, INote>(Note);
            var result = await _repository.Create(noteToUpdate);
            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Create method in Notes Service has failed while processing");
            return false;
        }
    }

    public async Task<bool> Update(UpdateNote Note)
    {
        try
        {
            var noteToUpdate = _mapper.Map<UpdateNote, INote>(Note);
            var result = await _repository.Update(noteToUpdate);
            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Update method in Notes Service has failed while processing");
            return false;
        }
    }

    public List<INote> Get()
    {
        try
        {
            var notes = _repository.Get();
            return notes;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Get method in Notes Service has failed while processing");
            throw;
        }
    }

    public Task<INote> GetById(int id)
    {
        try
        {
            var note = _repository.Get(id);
            return note;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Get by Id method in Notes Service has failed while processing");
            throw;
        }
    }

    public INote GetRandom()
    {
        try
        {
            var notes = _repository.Get();
            int r = rnd.Next(notes.Count);
            return notes[r];
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Get random Note method in Notes Service has failed while processing");
            throw;
        }
    }

}