using Microsoft.EntityFrameworkCore;
using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Persistance;

public class DataContext : DbContext
{
    public DataContext(){}

    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
    public virtual DbSet<Note> Notes { get; set; }
}