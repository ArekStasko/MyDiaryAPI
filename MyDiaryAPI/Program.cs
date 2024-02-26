using MyDiaryAPI.Domain;
using MyDiaryAPI.Endpoints.Note;
using MyDiaryAPI.Persistance;
using MyDiaryAPI.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataContext();
builder.Services.AddRepositories();
builder.Services.AddRequestAutoMapperProfile();
builder.Services.AddAutomapperProfile();
builder.Services.AddServices();

var logger = new LoggerConfiguration()
    .ReadFrom
    .Configuration(builder.Configuration)
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

var app = builder.Build();
app.AddNoteEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Migrate();
app.Run();