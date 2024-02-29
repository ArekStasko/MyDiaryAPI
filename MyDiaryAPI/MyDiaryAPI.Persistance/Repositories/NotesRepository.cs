using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Persistance.Repositories;

public class NotesRepository : INotesRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<NotesRepository> _logger;

    public NotesRepository(DataContext context, IMapper mapper, ILogger<NotesRepository> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }
    
    public async Task<bool> Update(INote note)
    {
        try
        {
            var noteToUpdate = await _context.Notes.SingleOrDefaultAsync(n => n.Id == note.Id);

            if (noteToUpdate == null)
            {
                _logger.LogError("There is no Note with {id} Id", note.Id);
                return false;
            }

            if (noteToUpdate.Content != note.Content) noteToUpdate.Content = note.Content;
            if (noteToUpdate.Title != note.Title) noteToUpdate.Title = note.Title;
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Update method in Notes Repository has failed while processing");
            return false;
        }
    }

    public async Task<bool> Create(INote note)
    {
        try
        {
            await _context.Notes.AddAsync((Note)note);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Create method in Notes Repository has failed while processing");
            return false;
        }
    }

    public async Task<INote> Get(int Id)
    {
        try
        {
            var note = await _context.Notes.SingleOrDefaultAsync(note => note.Id == Id);
            if (note == null) throw new NullReferenceException("There is no Note with provided Id");
            return note;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Get by Id method in Notes Repository has failed while processing");
            throw;
        }
    }

    public List<INote> Get()
    {
        try
        {
            return _context.Notes.ToList<INote>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Get method in Notes Repository has failed while processing");
            throw;
        }
    }
}