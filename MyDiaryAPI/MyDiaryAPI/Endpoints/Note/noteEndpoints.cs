using MyDiaryAPI.Services.Requests;
using MyDiaryAPI.Services.Responses;
using MyDiaryAPI.Services.Services.NoteService;

namespace MyDiaryAPI.Endpoints.Note;

public static class noteEndpoints
{
    public static void AddNoteEndpoints(this WebApplication app)
    {
        app.MapGet("/get", (INoteService noteService) =>
        {
            var result = noteService.Get();
            return result;
        });

        app.MapGet("/get/{id:int}", async (int id, INoteService noteService) =>
        {
            var result = await noteService.GetById(id);
            return result;
        });

        app.MapGet("/get-random", (INoteService noteService) =>
        {
            var result = noteService.GetRandom();
            return result;
        });

        app.MapPost("/", async (CreateNote createNote, INoteService noteService) =>
        {
            var result = await noteService.Create(createNote);
            return new BaseResponse(){IsSuccess = result};
        });

        app.MapPut("/", async (UpdateNote updateNote, INoteService noteService) => {
            var result = await noteService.Update(updateNote);
            return new BaseResponse(){IsSuccess = result};
        });
    }
}