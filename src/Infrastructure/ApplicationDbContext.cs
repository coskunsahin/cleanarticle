using Microsoft.EntityFrameworkCore;
using Domain.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    public DbSet<TodoItem> Todos => Set<TodoItem>();
}
