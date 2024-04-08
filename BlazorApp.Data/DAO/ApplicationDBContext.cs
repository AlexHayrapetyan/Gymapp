using Microsoft.EntityFrameworkCore;
using BlazorApp.Data.Entities;



namespace BlazorApp.Data.DAO;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }

    public DbSet<Exercice> Exercices { get; set; }
}

